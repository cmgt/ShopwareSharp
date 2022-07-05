using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace ShopwareSharp.AdminApi
{
    public class BaseCRUDApi<T> : BaseApi
    {
        protected string endPoint;

        protected BaseCRUDApi(ILogger logger, HttpClient httpClient,
            JsonSerializerOptionsProvider jsonSerializerOptionsProvider,
            TokenProvider<ApiKeyToken>? apiKeyProvider = default,
            TokenProvider<ContextKeyToken>? contextKeyProvider = default,
            TokenProvider<OAuthToken>? oauthTokenProvider = default) : base(logger, httpClient,
            jsonSerializerOptionsProvider, apiKeyProvider, contextKeyProvider, oauthTokenProvider)
        {
            endPoint = $"/{typeof(T).Name.ToLowerInvariant()}";
        }

        /// <summary>
        /// Create a new Product resources Available since: 6.0.0.0
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="response">Data format for response. Empty if none is provided. (optional)</param>
        /// <param name="createRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="Response{T}"/>&gt;</returns>
        public async Task<Response<T>?> CreateAsync(string? response = null, Request<T>? createRequest = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<Response<T>?> result = await CreateWithHttpInfoAsync(response, createRequest, requestOptions, cancellationToken).ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Create a new Product resources Available since: 6.0.0.0
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="response">Data format for response. Empty if none is provided. (optional)</param>
        /// <param name="createRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="Response{T}"/>&gt;</returns>
        public async Task<Response<T>?> CreateOrDefaultAsync(string? response = null, Request<T>? createRequest = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<Response<T>?>? result = null;
            try 
            {
                result = await CreateWithHttpInfoAsync(response, createRequest, requestOptions, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return result is {IsSuccessStatusCode: true}
                ? result.Content
                : null;
        }

        /// <summary>
        /// Create a new Product resources Available since: 6.0.0.0
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="response">Data format for response. Empty if none is provided. (optional)</param>
        /// <param name="createProductRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="Response{T}"/></returns>
        public Task<ApiResponse<Response<T>?>> CreateWithHttpInfoAsync(string? response = null,
            Request<T>? createProductRequest = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null)
        {
            var queryPath = endPoint;
            var parseQueryString = System.Web.HttpUtility.ParseQueryString(string.Empty);
            if (response != null)
                parseQueryString["_response"] = Uri.EscapeDataString(response);

            var query = parseQueryString.ToString();

            return ExecuteRequest<Response<T>?>(queryPath, query, HttpMethod.Post, createProductRequest, requestOptions,
                cancellationToken);
        }

        /// <summary>
        /// Delete a Product resource Available since: 6.0.0.0
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifier for the product</param>
        /// <param name="response">Data format for response. Empty if none is provided. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="object"/>&gt;</returns>
        public async Task<object?> DeleteAsync(string id, string? response = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<object?> result = await DeleteWithHttpInfoAsync(id, response, requestOptions, cancellationToken).ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Delete a Product resource Available since: 6.0.0.0
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifier for the product</param>
        /// <param name="response">Data format for response. Empty if none is provided. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="object"/>&gt;</returns>
        public async Task<object?> DeleteOrDefaultAsync(string id, string? response = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<object?>? result = null;
            try 
            {
                result = await DeleteWithHttpInfoAsync(id, response, requestOptions, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return result is {IsSuccessStatusCode: true}
                ? result.Content
                : null;
        }

        /// <summary>
        /// Delete a Product resource Available since: 6.0.0.0
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifier for the product</param>
        /// <param name="response">Data format for response. Empty if none is provided. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="object"/></returns>
        public Task<ApiResponse<object?>> DeleteWithHttpInfoAsync(string id, string? response = null,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (id == null)
                throw new ArgumentNullException(nameof(id));

#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'

            var queryPath = $"{endPoint}/{id}";
            var parseQueryString = System.Web.HttpUtility.ParseQueryString(string.Empty);
            if (response != null)
                parseQueryString["_response"] = Uri.EscapeDataString(response);

            var query = parseQueryString.ToString();

            return ExecuteRequest<object?>(queryPath, query, HttpMethod.Delete, default, requestOptions,
                cancellationToken);
        }

        /// <summary>
        /// Detailed information about a Product resource Available since: 6.0.0.0
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifier for the product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="Response{T}"/>&gt;</returns>
        public async Task<Response<T>?> GetAsync(string id, RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<Response<T>?> result = await GetWithHttpInfoAsync(id, requestOptions, cancellationToken).ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Detailed information about a Product resource Available since: 6.0.0.0
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifier for the product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="Response{T}"/>&gt;</returns>
        public async Task<Response<T>?> GetOrDefaultAsync(string id, RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<Response<T>?>? result = null;
            try 
            {
                result = await GetWithHttpInfoAsync(id, requestOptions, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return result is {IsSuccessStatusCode: true}
                ? result.Content
                : null;
        }

        /// <summary>
        /// Detailed information about a Product resource Available since: 6.0.0.0
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifier for the product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="Response{T}"/></returns>
        public Task<ApiResponse<Response<T>?>> GetWithHttpInfoAsync(string id,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (id == null)
                throw new ArgumentNullException(nameof(id));

#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'

            var queryPath = $"{endPoint}/{id}";

            return ExecuteRequest<Response<T>?>(queryPath, default, HttpMethod.Get, default, requestOptions,
                cancellationToken);
        }

        /// <summary>
        /// List with basic information of Product resources Available since: 6.0.0.0
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Max amount of resources to be returned in a page (optional)</param>
        /// <param name="page">The page to be returned (optional)</param>
        /// <param name="query">Encoded SwagQL in JSON (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ResponseList{T}"/>&gt;</returns>
        public async Task<ResponseList<T>?> GetListAsync(int? limit = null, int? page = null, string? query = null, RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<ResponseList<T>?> result = await GetListWithHttpInfoAsync(limit, page, query, requestOptions, cancellationToken).ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// List with basic information of Product resources Available since: 6.0.0.0
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Max amount of resources to be returned in a page (optional)</param>
        /// <param name="page">The page to be returned (optional)</param>
        /// <param name="query">Encoded SwagQL in JSON (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ResponseList{T}"/>&gt;</returns>
        public async Task<ResponseList<T>?> GetListOrDefaultAsync(int? limit = null, int? page = null,
            string? query = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<ResponseList<T>?>? result = null;
            try
            {
                result = await GetListWithHttpInfoAsync(limit, page, query, requestOptions, cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return result is {IsSuccessStatusCode: true}
                ? result.Content
                : null;
        }

        /// <summary>
        /// List with basic information of Product resources Available since: 6.0.0.0
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Max amount of resources to be returned in a page (optional)</param>
        /// <param name="page">The page to be returned (optional)</param>
        /// <param name="query">Encoded SwagQL in JSON (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="ResponseList{T}"/></returns>
        public Task<ApiResponse<ResponseList<T>?>> GetListWithHttpInfoAsync(int? limit = null, int? page = null, string? query = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null)
        {
            var queryPath = endPoint;

            System.Collections.Specialized.NameValueCollection parseQueryString = System.Web.HttpUtility.ParseQueryString(string.Empty);
            if (limit != null)
                parseQueryString["limit"] = Uri.EscapeDataString(limit.ToString()!);

            if (page != null)
                parseQueryString["page"] = Uri.EscapeDataString(page.ToString()!);

            if (query != null)
                parseQueryString["query"] = Uri.EscapeDataString(query.ToString()!);

            var queryValue = parseQueryString.ToString();

            return ExecuteRequest<ResponseList<T>?>(queryPath, queryValue, HttpMethod.Get, default, requestOptions,
                cancellationToken);
        }

        /// <summary>
        /// Partially update information about a Product resource Available since: 6.0.0.0
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifier for the product</param>
        /// <param name="response">Data format for response. Empty if none is provided. (optional)</param>
        /// <param name="updateRequest">Partially update information about a Product resource. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="Response{T}"/>&gt;</returns>
        public async Task<Response<T>?> UpdateAsync(string id, string? response = null, Request<T>? updateRequest = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<Response<T>?> result = await UpdateWithHttpInfoAsync(id, response, updateRequest, requestOptions, cancellationToken).ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Partially update information about a Product resource Available since: 6.0.0.0
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifier for the product</param>
        /// <param name="response">Data format for response. Empty if none is provided. (optional)</param>
        /// <param name="createProductRequest">Partially update information about a Product resource. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="Response{T}"/>&gt;</returns>
        public async Task<Response<T>?> UpdateOrDefaultAsync(string id, string? response = null, Request<T>? createProductRequest = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<Response<T>?>? result = null;
            try 
            {
                result = await UpdateWithHttpInfoAsync(id, response, createProductRequest, requestOptions, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return result is {IsSuccessStatusCode: true}
                ? result.Content
                : null;
        }

        /// <summary>
        /// Partially update information about a Product resource Available since: 6.0.0.0
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifier for the product</param>
        /// <param name="response">Data format for response. Empty if none is provided. (optional)</param>
        /// <param name="createProductRequest">Partially update information about a Product resource. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="Response{T}"/></returns>
        public Task<ApiResponse<Response<T>?>> UpdateWithHttpInfoAsync(string id, string? response = null, Request<T>? createProductRequest = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (id == null)
                throw new ArgumentNullException(nameof(id));

#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'

            var queryPath = $"{endPoint}/{id}";

            System.Collections.Specialized.NameValueCollection parseQueryString = System.Web.HttpUtility.ParseQueryString(string.Empty);
            if (response != null)
                parseQueryString["_response"] = Uri.EscapeDataString(response.ToString()!);

            var query = parseQueryString.ToString();

            return ExecuteRequest<Response<T>?>(queryPath, query, HttpMethod.Patch, createProductRequest, requestOptions,
                cancellationToken);
        } 
    }
}
