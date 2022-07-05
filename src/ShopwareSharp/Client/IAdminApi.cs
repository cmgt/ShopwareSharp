using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopwareSharp.AdminApi;
using ShopwareSharp.Model;

namespace ShopwareSharp.Client
{
    public interface IAdminCRUDApi<T>: IApi
    {
        /// <summary>
        /// Create a new Product resources
        /// </summary>
        /// <remarks>
        /// Available since: 6.0.0.0
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="response">Data format for response. Empty if none is provided. (optional)</param>
        /// <param name="createProductRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;Response<T>?&gt;&gt;</returns>
        Task<ApiResponse<Response<T>?>> CreateWithHttpInfoAsync(string? response = null, Request<T>? createProductRequest = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Create a new Product resources
        /// </summary>
        /// <remarks>
        /// Available since: 6.0.0.0
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="response">Data format for response. Empty if none is provided. (optional)</param>
        /// <param name="createProductRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;CreateProduct200Response&gt;</returns>
        Task<Response<T>?> CreateAsync(string? response = null, Request<T>? createProductRequest = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Create a new Product resources
        /// </summary>
        /// <remarks>
        /// Available since: 6.0.0.0
        /// </remarks>
        /// <param name="response">Data format for response. Empty if none is provided. (optional)</param>
        /// <param name="createProductRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;Response<T>?&gt;</returns>
        Task<Response<T>?> CreateOrDefaultAsync(string? response = null, Request<T>? createProductRequest = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        
        /// <summary>
        /// Delete a Product resource
        /// </summary>
        /// <remarks>
        /// Available since: 6.0.0.0
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifier for the product</param>
        /// <param name="response">Data format for response. Empty if none is provided. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;object?&gt;&gt;</returns>
        Task<ApiResponse<object?>> DeleteWithHttpInfoAsync(string id, string? response = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Delete a Product resource
        /// </summary>
        /// <remarks>
        /// Available since: 6.0.0.0
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifier for the product</param>
        /// <param name="response">Data format for response. Empty if none is provided. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;object&gt;</returns>
        Task<object?> DeleteAsync(string id, string? response = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Delete a Product resource
        /// </summary>
        /// <remarks>
        /// Available since: 6.0.0.0
        /// </remarks>
        /// <param name="id">Identifier for the product</param>
        /// <param name="response">Data format for response. Empty if none is provided. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;object?&gt;</returns>
        Task<object?> DeleteOrDefaultAsync(string id, string? response = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        
        /// <summary>
        /// Detailed information about a Product resource
        /// </summary>
        /// <remarks>
        /// Available since: 6.0.0.0
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifier for the product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;Response<T>?&gt;&gt;</returns>
        Task<ApiResponse<Response<T>?>> GetWithHttpInfoAsync(string id, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Detailed information about a Product resource
        /// </summary>
        /// <remarks>
        /// Available since: 6.0.0.0
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifier for the product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;CreateProduct200Response&gt;</returns>
        Task<Response<T>?> GetAsync(string id, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Detailed information about a Product resource
        /// </summary>
        /// <remarks>
        /// Available since: 6.0.0.0
        /// </remarks>
        /// <param name="id">Identifier for the product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;Response<T>?&gt;</returns>
        Task<Response<T>?> GetOrDefaultAsync(string id, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        
        /// <summary>
        /// List with basic information of Product resources
        /// </summary>
        /// <remarks>
        /// Available since: 6.0.0.0
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Max amount of resources to be returned in a page (optional)</param>
        /// <param name="page">The page to be returned (optional)</param>
        /// <param name="query">Encoded SwagQL in JSON (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;GetProductList200Response?&gt;&gt;</returns>
        Task<ApiResponse<ResponseList<T>?>> GetListWithHttpInfoAsync(int? limit = null, int? page = null, string? query = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// List with basic information of Product resources
        /// </summary>
        /// <remarks>
        /// Available since: 6.0.0.0
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Max amount of resources to be returned in a page (optional)</param>
        /// <param name="page">The page to be returned (optional)</param>
        /// <param name="query">Encoded SwagQL in JSON (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;GetProductList200Response&gt;</returns>
        Task<ResponseList<T>?> GetListAsync(int? limit = null, int? page = null, string? query = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// List with basic information of Product resources
        /// </summary>
        /// <remarks>
        /// Available since: 6.0.0.0
        /// </remarks>
        /// <param name="limit">Max amount of resources to be returned in a page (optional)</param>
        /// <param name="page">The page to be returned (optional)</param>
        /// <param name="query">Encoded SwagQL in JSON (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;GetProductList200Response?&gt;</returns>
        Task<ResponseList<T>?> GetListOrDefaultAsync(int? limit = null, int? page = null, string? query = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        
        /// <summary>
        /// Partially update information about a Product resource
        /// </summary>
        /// <remarks>
        /// Available since: 6.0.0.0
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifier for the product</param>
        /// <param name="response">Data format for response. Empty if none is provided. (optional)</param>
        /// <param name="createProductRequest">Partially update information about a Product resource. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;Response<T>?&gt;&gt;</returns>
        Task<ApiResponse<Response<T>?>> UpdateWithHttpInfoAsync(string id, string? response = null, Request<T>? createProductRequest = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Partially update information about a Product resource
        /// </summary>
        /// <remarks>
        /// Available since: 6.0.0.0
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identifier for the product</param>
        /// <param name="response">Data format for response. Empty if none is provided. (optional)</param>
        /// <param name="createProductRequest">Partially update information about a Product resource. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;CreateProduct200Response&gt;</returns>
        Task<Response<T>?> UpdateAsync(string id, string? response = null, Request<T>? createProductRequest = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Partially update information about a Product resource
        /// </summary>
        /// <remarks>
        /// Available since: 6.0.0.0
        /// </remarks>
        /// <param name="id">Identifier for the product</param>
        /// <param name="response">Data format for response. Empty if none is provided. (optional)</param>
        /// <param name="createProductRequest">Partially update information about a Product resource. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;Response<T>?&gt;</returns>
        Task<Response<T>?> UpdateOrDefaultAsync(string id, string? response = null, Request<T>? createProductRequest = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);
    }
}
