using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace ShopwareSharp.Client
{
    public abstract class BaseApi
    {
        protected JsonSerializerOptions jsonSerializerOptions;

        /// <summary>
        /// An event to track the health of the server. 
        /// If you store these event args, be sure to purge old event args to prevent a memory leak.
        /// </summary>
        public event ClientUtils.EventHandler<ApiResponseEventArgs>? ApiResponded;

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyToken"/>
        /// </summary>
        public TokenProvider<ApiKeyToken>? ApiKeyProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="ContextKeyToken"/>
        /// </summary>
        public TokenProvider<ContextKeyToken>? ContextKeyProvider { get; set; }

        /// <summary>
        /// A token provider of type <see cref="OauthTokenProvider"/>
        /// </summary>
        public TokenProvider<OAuthToken>? OauthTokenProvider { get; }

        protected BaseApi(ILogger logger, HttpClient httpClient,
            JsonSerializerOptionsProvider jsonSerializerOptionsProvider,
            TokenProvider<ApiKeyToken>? apiKeyProvider = default,
            TokenProvider<ContextKeyToken>? contextKeyProvider = default,
            TokenProvider<OAuthToken>? oauthTokenProvider = default)
        {
            jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            Logger = logger;
            HttpClient = httpClient;
            ApiKeyProvider = apiKeyProvider;
            ContextKeyProvider = contextKeyProvider;
            OauthTokenProvider = oauthTokenProvider;
        }

        protected async Task<ApiResponse<T>> ExecuteRequest<T>(string queryPath, string? query, HttpMethod? httpMethod,
            object? content, RequestOptions? requestOptions, CancellationToken? cancellationToken)
        {
            try
            {
                using var request = new HttpRequestMessage();
                var url = requestOptions?.Host ?? HttpClient.BaseAddress!;

                UriBuilder uriBuilder = new UriBuilder
                {
                    Host = url.Host,
                    Scheme = url.Scheme,
                    Path = url.AbsolutePath == "/" ? queryPath : url.AbsolutePath + queryPath,
                    Query = query
                };

                if (content != default)
                {
                    request.Content = content is System.IO.Stream stream
                        ? request.Content = new StreamContent(stream)
                        : request.Content = JsonContent.Create(content, options: jsonSerializerOptions);
                }

                if (ApiKeyProvider != default)
                {
                    var apiKey = await ApiKeyProvider.GetAsync(cancellationToken).ConfigureAwait(false);
                    apiKey.UseInHeader(request, "sw-access-key");
                }

                if (ContextKeyProvider != default)
                {
                    var contextKey = await ContextKeyProvider.GetAsync(cancellationToken).ConfigureAwait(false);
                    contextKey.UseInHeader(request, "sw-context-token");
                }

                if (OauthTokenProvider != default)
                {
                    var oAuthToken = await OauthTokenProvider.GetAsync(cancellationToken).ConfigureAwait(false);
                    oAuthToken.UseInHeader(request);
                }

                request.PrepareRequestOptions(requestOptions);

                request.RequestUri = uriBuilder.Uri;
                string[] accepts = new string[]
                {
                    "application/json"
                };

                string? accept = ClientUtils.SelectHeaderAccept(accepts);

                if (accept != null)
                    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(accept));

                request.Method = httpMethod ?? HttpMethod.Post;

                using var responseMessage = await HttpClient
                    .SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

                DateTime requestedAt = DateTime.UtcNow;

                string responseContent = await responseMessage.Content
                    .ReadAsStringAsync(cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

                if (ApiResponded != null)
                {
                    try
                    {
                        ApiResponded.Invoke(this,
                            new ApiResponseEventArgs(requestedAt, DateTime.UtcNow, responseMessage.StatusCode,
                                queryPath));
                    }
                    catch (Exception e)
                    {
                        Logger.LogError(e, "An error occured while invoking ApiResponded.");
                    }
                }

                ApiResponse<T> apiResponse = new ApiResponse<T>(responseMessage, responseContent);

                if (apiResponse.IsSuccessStatusCode)
                    apiResponse.Content =
                        JsonSerializer.Deserialize<T>(apiResponse.RawContent, jsonSerializerOptions);

                return apiResponse;
            }
            catch (Exception e)
            {
                Logger.LogError(e, "An error occured while sending the request to the server.");
                throw;
            }
        }
    }
}
