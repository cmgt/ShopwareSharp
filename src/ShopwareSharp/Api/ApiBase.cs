using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using ShopwareSharp.Client;

namespace ShopwareSharp.Api
{
    public abstract class ApiBase
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
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="ContextKeyToken"/>
        /// </summary>
        public TokenProvider<ContextKeyToken> ContextKeyProvider { get; set; }

        protected ApiBase(ILogger logger, HttpClient httpClient,
            JsonSerializerOptionsProvider jsonSerializerOptionsProvider,
            TokenProvider<ApiKeyToken> apiKeyProvider, TokenProvider<ContextKeyToken> contextKeyProvider)
        {
            jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            Logger = logger;
            HttpClient = httpClient;
            ApiKeyProvider = apiKeyProvider;
            ContextKeyProvider = contextKeyProvider;
        }

        protected async Task<ApiResponse<T>> ExecuteRequest<T>(string queryPath, string? query, HttpMethod? httpMethod,
            object? content,
            RequestOptions? requestOptions, CancellationToken? cancellationToken)
        {
            try
            {
                using var request = new HttpRequestMessage();
                UriBuilder uriBuilder = new UriBuilder();
                uriBuilder.Host = requestOptions?.Host?.Host ?? HttpClient.BaseAddress!.Host;
                uriBuilder.Scheme = HttpClient.BaseAddress!.Scheme;
                uriBuilder.Path = ClientUtils.CONTEXT_PATH + queryPath;
                uriBuilder.Query = query;

                request.Content = content is System.IO.Stream stream
                    ? request.Content = new StreamContent(stream)
                    : request.Content =
                        new StringContent(JsonSerializer.Serialize(content, jsonSerializerOptions));

                var apiKey = await ApiKeyProvider.GetAsync(cancellationToken).ConfigureAwait(false);
                apiKey.UseInHeader(request, "sw-access-key");

                var contextKey = await ContextKeyProvider.GetAsync(cancellationToken).ConfigureAwait(false);
                contextKey.UseInHeader(request, "sw-context-token");

                request.PrepareRequestOptions(requestOptions);

                request.RequestUri = uriBuilder.Uri;
                string[] contentTypes = new string[]
                {
                    "application/json"
                };

                string? contentType = ClientUtils.SelectHeaderContentType(contentTypes);

                if (contentType != null)
                    request.Content.Headers.Add("ContentType", contentType);

                string[] accepts = new string[]
                {
                    "application/json"
                };

                string? accept = ClientUtils.SelectHeaderAccept(accepts);

                if (accept != null)
                    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(accept));

                request.Method = httpMethod;

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
