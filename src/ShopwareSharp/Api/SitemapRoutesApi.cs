// <auto-generated>
/*
 * Shopware Store API
 *
 * This endpoint reference contains an overview of all endpoints comprising the Shopware Store API
 *
 * The version of the OpenAPI document: 6.4.9999999.9999999-dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace ShopwareSharp.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISitemapRoutesApi : IApi
    {
        /// <summary>
        /// Fetch SEO routes
        /// </summary>
        /// <remarks>
        /// Perform a filtered search for seo urls.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="readCustomerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;ReadSeoUrl200Response?&gt;&gt;</returns>
        Task<ApiResponse<ReadSeoUrl200Response?>> ReadSeoUrlWithHttpInfoAsync(string contentType, string accept, ReadCustomerRequest? readCustomerRequest = null, System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Fetch SEO routes
        /// </summary>
        /// <remarks>
        /// Perform a filtered search for seo urls.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="readCustomerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;ReadSeoUrl200Response&gt;</returns>
        Task<ReadSeoUrl200Response?> ReadSeoUrlAsync(string contentType, string accept, ReadCustomerRequest? readCustomerRequest = null, System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Fetch SEO routes
        /// </summary>
        /// <remarks>
        /// Perform a filtered search for seo urls.
        /// </remarks>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="readCustomerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;ReadSeoUrl200Response?&gt;</returns>
        Task<ReadSeoUrl200Response?> ReadSeoUrlOrDefaultAsync(string contentType, string accept, ReadCustomerRequest? readCustomerRequest = null, System.Threading.CancellationToken? cancellationToken = null);

        
        /// <summary>
        /// Fetch sitemaps
        /// </summary>
        /// <remarks>
        /// Fetches a list of compressed sitemap files, which are often used by search engines.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;List&lt;Sitemap&gt;?&gt;&gt;</returns>
        Task<ApiResponse<List<Sitemap>?>> ReadSitemapWithHttpInfoAsync(string contentType, string accept, System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Fetch sitemaps
        /// </summary>
        /// <remarks>
        /// Fetches a list of compressed sitemap files, which are often used by search engines.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;List&lt;Sitemap&gt;&gt;</returns>
        Task<List<Sitemap>?> ReadSitemapAsync(string contentType, string accept, System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Fetch sitemaps
        /// </summary>
        /// <remarks>
        /// Fetches a list of compressed sitemap files, which are often used by search engines.
        /// </remarks>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;List&lt;Sitemap&gt;?&gt;</returns>
        Task<List<Sitemap>?> ReadSitemapOrDefaultAsync(string contentType, string accept, System.Threading.CancellationToken? cancellationToken = null);

            }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SitemapRoutesApi : ISitemapRoutesApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// An event to track the health of the server. 
        /// If you store these event args, be sure to purge old event args to prevent a memory leak.
        /// </summary>
        public event ClientUtils.EventHandler<ApiResponseEventArgs>? ApiResponded;

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<SitemapRoutesApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SitemapRoutesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SitemapRoutesApi(ILogger<SitemapRoutesApi> logger, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, 
            TokenProvider<ApiKeyToken> apiKeyProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            Logger = logger;
            HttpClient = httpClient;
            ApiKeyProvider = apiKeyProvider;
        }

        /// <summary>
        /// Fetch SEO routes Perform a filtered search for seo urls.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="readCustomerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ReadSeoUrl200Response"/>&gt;</returns>
        public async Task<ReadSeoUrl200Response?> ReadSeoUrlAsync(string contentType, string accept, ReadCustomerRequest? readCustomerRequest = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<ReadSeoUrl200Response?> result = await ReadSeoUrlWithHttpInfoAsync(contentType, accept, readCustomerRequest, cancellationToken).ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Fetch SEO routes Perform a filtered search for seo urls.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="readCustomerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ReadSeoUrl200Response"/>&gt;</returns>
        public async Task<ReadSeoUrl200Response?> ReadSeoUrlOrDefaultAsync(string contentType, string accept, ReadCustomerRequest? readCustomerRequest = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<ReadSeoUrl200Response?>? result = null;
            try 
            {
                result = await ReadSeoUrlWithHttpInfoAsync(contentType, accept, readCustomerRequest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return result != null && result.IsSuccessStatusCode
                ? result.Content
                : null;
        }

        /// <summary>
        /// Fetch SEO routes Perform a filtered search for seo urls.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="readCustomerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="ReadSeoUrl200Response"/></returns>
        public async Task<ApiResponse<ReadSeoUrl200Response?>> ReadSeoUrlWithHttpInfoAsync(string contentType, string accept, ReadCustomerRequest? readCustomerRequest = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            try
            {
                #pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'

                if (contentType == null)
                    throw new ArgumentNullException(nameof(contentType));

                if (accept == null)
                    throw new ArgumentNullException(nameof(accept));

                #pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'

                using (HttpRequestMessage request = new HttpRequestMessage())
                {
                    UriBuilder uriBuilder = new UriBuilder();
                    uriBuilder.Host = HttpClient.BaseAddress!.Host;
                    uriBuilder.Scheme = ClientUtils.SCHEME;
                    uriBuilder.Path = ClientUtils.CONTEXT_PATH + "/seo-url";

                    request.Headers.Add("Content-Type", ClientUtils.ParameterToString(contentType));

                    request.Headers.Add("Accept", ClientUtils.ParameterToString(accept));

                    request.Content = (readCustomerRequest as object) is System.IO.Stream stream
                        ? request.Content = new StreamContent(stream)
                        : request.Content = new StringContent(JsonSerializer.Serialize(readCustomerRequest, _jsonSerializerOptions));

                    List<TokenBase> tokens = new List<TokenBase>();

                    ApiKeyToken apiKey = (ApiKeyToken) await ApiKeyProvider.GetAsync(cancellationToken).ConfigureAwait(false);

                    tokens.Add(apiKey);

                    apiKey.UseInHeader(request, "sw-access-key");

                    request.RequestUri = uriBuilder.Uri;

                    string[] contentTypes = new string[] {
                        "application/json" 
                    };

                    string? contentType = ClientUtils.SelectHeaderContentType(contentTypes);

                    if (contentType != null)
                        request.Content.Headers.Add("ContentType", contentType);

                    string[] accepts = new string[] { 
                        "application/json", 
                        "application/vnd.api+json" 
                    };

                    string? accept = ClientUtils.SelectHeaderAccept(accepts);

                    if (accept != null)
                        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(accept));
                    
                    request.Method = HttpMethod.Post;

                    using (HttpResponseMessage responseMessage = await HttpClient.SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false))
                    {
                        DateTime requestedAt = DateTime.UtcNow;

                        string responseContent = await responseMessage.Content.ReadAsStringAsync(cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

                        if (ApiResponded != null)
                        {
                            try
                            {
                                ApiResponded.Invoke(this, new ApiResponseEventArgs(requestedAt, DateTime.UtcNow, responseMessage.StatusCode, "/seo-url"));
                            }
                            catch(Exception e)
                            {
                                Logger.LogError(e, "An error occured while invoking ApiResponded.");
                            }
                        }

                        ApiResponse<ReadSeoUrl200Response?> apiResponse = new ApiResponse<ReadSeoUrl200Response?>(responseMessage, responseContent);

                        if (apiResponse.IsSuccessStatusCode)
                            apiResponse.Content = JsonSerializer.Deserialize<ReadSeoUrl200Response>(apiResponse.RawContent, _jsonSerializerOptions);
                        else if (apiResponse.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase token in tokens)
                                token.BeginRateLimit();

                        return apiResponse;
                    }
                }
            }
            catch(Exception e)
            {
                Logger.LogError(e, "An error occured while sending the request to the server.");
                throw;
            }
        }

        /// <summary>
        /// Fetch sitemaps Fetches a list of compressed sitemap files, which are often used by search engines.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="List&lt;Sitemap&gt;"/>&gt;</returns>
        public async Task<List<Sitemap>?> ReadSitemapAsync(string contentType, string accept, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<List<Sitemap>?> result = await ReadSitemapWithHttpInfoAsync(contentType, accept, cancellationToken).ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Fetch sitemaps Fetches a list of compressed sitemap files, which are often used by search engines.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="List&lt;Sitemap&gt;"/>&gt;</returns>
        public async Task<List<Sitemap>?> ReadSitemapOrDefaultAsync(string contentType, string accept, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<List<Sitemap>?>? result = null;
            try 
            {
                result = await ReadSitemapWithHttpInfoAsync(contentType, accept, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return result != null && result.IsSuccessStatusCode
                ? result.Content
                : null;
        }

        /// <summary>
        /// Fetch sitemaps Fetches a list of compressed sitemap files, which are often used by search engines.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="List&lt;Sitemap&gt;"/></returns>
        public async Task<ApiResponse<List<Sitemap>?>> ReadSitemapWithHttpInfoAsync(string contentType, string accept, System.Threading.CancellationToken? cancellationToken = null)
        {
            try
            {
                #pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'

                if (contentType == null)
                    throw new ArgumentNullException(nameof(contentType));

                if (accept == null)
                    throw new ArgumentNullException(nameof(accept));

                #pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'

                using (HttpRequestMessage request = new HttpRequestMessage())
                {
                    UriBuilder uriBuilder = new UriBuilder();
                    uriBuilder.Host = HttpClient.BaseAddress!.Host;
                    uriBuilder.Scheme = ClientUtils.SCHEME;
                    uriBuilder.Path = ClientUtils.CONTEXT_PATH + "/sitemap";

                    request.Headers.Add("Content-Type", ClientUtils.ParameterToString(contentType));

                    request.Headers.Add("Accept", ClientUtils.ParameterToString(accept));

                    List<TokenBase> tokens = new List<TokenBase>();

                    ApiKeyToken apiKey = (ApiKeyToken) await ApiKeyProvider.GetAsync(cancellationToken).ConfigureAwait(false);

                    tokens.Add(apiKey);

                    apiKey.UseInHeader(request, "sw-access-key");

                    request.RequestUri = uriBuilder.Uri;

                    string[] accepts = new string[] { 
                        "application/json" 
                    };

                    string? accept = ClientUtils.SelectHeaderAccept(accepts);

                    if (accept != null)
                        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(accept));
                    
                    request.Method = HttpMethod.Get;

                    using (HttpResponseMessage responseMessage = await HttpClient.SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false))
                    {
                        DateTime requestedAt = DateTime.UtcNow;

                        string responseContent = await responseMessage.Content.ReadAsStringAsync(cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

                        if (ApiResponded != null)
                        {
                            try
                            {
                                ApiResponded.Invoke(this, new ApiResponseEventArgs(requestedAt, DateTime.UtcNow, responseMessage.StatusCode, "/sitemap"));
                            }
                            catch(Exception e)
                            {
                                Logger.LogError(e, "An error occured while invoking ApiResponded.");
                            }
                        }

                        ApiResponse<List<Sitemap>?> apiResponse = new ApiResponse<List<Sitemap>?>(responseMessage, responseContent);

                        if (apiResponse.IsSuccessStatusCode)
                            apiResponse.Content = JsonSerializer.Deserialize<List<Sitemap>>(apiResponse.RawContent, _jsonSerializerOptions);
                        else if (apiResponse.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase token in tokens)
                                token.BeginRateLimit();

                        return apiResponse;
                    }
                }
            }
            catch(Exception e)
            {
                Logger.LogError(e, "An error occured while sending the request to the server.");
                throw;
            }
        }    }
}
