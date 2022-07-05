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
using System.Threading;
using ShopwareSharp.Client;
using ShopwareSharp.Model;
using ShopwareSharp.StoreApi;

namespace ShopwareSharp.StoreApi
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICartApi : IApi
    {
        /// <summary>
        /// Add items to the cart
        /// </summary>
        /// <remarks>
        /// This route adds items to the cart. An item can be a product or promotion for example. They are referenced by the &#x60;referencedId&#x60;-parameter.  Example: [Working with the cart - Guide](https://developer.shopware.com/docs/guides/integrations-api/store-api-guide/work-with-the-cart#adding-new-items-to-the-cart)
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartItems"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;Cart?&gt;&gt;</returns>
        Task<ApiResponse<Cart?>> AddLineItemWithHttpInfoAsync(CartItems? cartItems = null,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Add items to the cart
        /// </summary>
        /// <remarks>
        /// This route adds items to the cart. An item can be a product or promotion for example. They are referenced by the &#x60;referencedId&#x60;-parameter.  Example: [Working with the cart - Guide](https://developer.shopware.com/docs/guides/integrations-api/store-api-guide/work-with-the-cart#adding-new-items-to-the-cart)
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartItems"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;Cart&gt;</returns>
        Task<Cart?> AddLineItemAsync(CartItems? cartItems = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Add items to the cart
        /// </summary>
        /// <remarks>
        /// This route adds items to the cart. An item can be a product or promotion for example. They are referenced by the &#x60;referencedId&#x60;-parameter.  Example: [Working with the cart - Guide](https://developer.shopware.com/docs/guides/integrations-api/store-api-guide/work-with-the-cart#adding-new-items-to-the-cart)
        /// </remarks>
        /// <param name="cartItems"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;Cart?&gt;</returns>
        Task<Cart?> AddLineItemOrDefaultAsync(CartItems? cartItems = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);


        /// <summary>
        /// Delete a cart
        /// </summary>
        /// <remarks>
        /// This route deletes the cart of the customer.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;SuccessResponse?&gt;&gt;</returns>
        Task<ApiResponse<SuccessResponse?>> DeleteCartWithHttpInfoAsync(RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Delete a cart
        /// </summary>
        /// <remarks>
        /// This route deletes the cart of the customer.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;SuccessResponse&gt;</returns>
        Task<SuccessResponse?> DeleteCartAsync(RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Delete a cart
        /// </summary>
        /// <remarks>
        /// This route deletes the cart of the customer.
        /// </remarks>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;SuccessResponse?&gt;</returns>
        Task<SuccessResponse?> DeleteCartOrDefaultAsync(RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);


        /// <summary>
        /// Fetch or create a cart
        /// </summary>
        /// <remarks>
        /// Used to fetch the current cart or for creating a new one.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the new cart. This parameter will only be used when creating a new cart. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;Cart?&gt;&gt;</returns>
        Task<ApiResponse<Cart?>> ReadCartWithHttpInfoAsync(string? name = null,
            RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Fetch or create a cart
        /// </summary>
        /// <remarks>
        /// Used to fetch the current cart or for creating a new one.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the new cart. This parameter will only be used when creating a new cart. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;Cart&gt;</returns>
        Task<Cart?> ReadCartAsync(string? name = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Fetch or create a cart
        /// </summary>
        /// <remarks>
        /// Used to fetch the current cart or for creating a new one.
        /// </remarks>
        /// <param name="name">The name of the new cart. This parameter will only be used when creating a new cart. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;Cart?&gt;</returns>
        Task<Cart?> ReadCartOrDefaultAsync(string? name = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);


        /// <summary>
        /// Remove items from the cart
        /// </summary>
        /// <remarks>
        /// This route removes items from the cart and recalculates it.  Example: [Working with the cart - Guide](https://developer.shopware.com/docs/guides/integrations-api/store-api-guide/work-with-the-cart#deleting-items-in-the-cart)
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">A list of product identifiers.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;Cart?&gt;&gt;</returns>
        Task<ApiResponse<Cart?>> RemoveLineItemWithHttpInfoAsync(IEnumerable<string> ids,
            RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Remove items from the cart
        /// </summary>
        /// <remarks>
        /// This route removes items from the cart and recalculates it.  Example: [Working with the cart - Guide](https://developer.shopware.com/docs/guides/integrations-api/store-api-guide/work-with-the-cart#deleting-items-in-the-cart)
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">A list of product identifiers.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;Cart&gt;</returns>
        Task<Cart?> RemoveLineItemAsync(IEnumerable<string> ids, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Remove items from the cart
        /// </summary>
        /// <remarks>
        /// This route removes items from the cart and recalculates it.  Example: [Working with the cart - Guide](https://developer.shopware.com/docs/guides/integrations-api/store-api-guide/work-with-the-cart#deleting-items-in-the-cart)
        /// </remarks>
        /// <param name="ids">A list of product identifiers.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;Cart?&gt;</returns>
        Task<Cart?> RemoveLineItemOrDefaultAsync(IEnumerable<string> ids, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);


        /// <summary>
        /// Update items in the cart
        /// </summary>
        /// <remarks>
        /// This route updates items in the cart. A typical example is updating the quantity of an item.  Example: [Working with the cart - Guide](https://developer.shopware.com/docs/guides/integrations-api/store-api-guide/work-with-the-cart#updating-items-in-the-cart)
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartItems"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;Cart?&gt;&gt;</returns>
        Task<ApiResponse<Cart?>> UpdateLineItemWithHttpInfoAsync(CartItems? cartItems = null,
            RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Update items in the cart
        /// </summary>
        /// <remarks>
        /// This route updates items in the cart. A typical example is updating the quantity of an item.  Example: [Working with the cart - Guide](https://developer.shopware.com/docs/guides/integrations-api/store-api-guide/work-with-the-cart#updating-items-in-the-cart)
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartItems"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;Cart&gt;</returns>
        Task<Cart?> UpdateLineItemAsync(CartItems? cartItems = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Update items in the cart
        /// </summary>
        /// <remarks>
        /// This route updates items in the cart. A typical example is updating the quantity of an item.  Example: [Working with the cart - Guide](https://developer.shopware.com/docs/guides/integrations-api/store-api-guide/work-with-the-cart#updating-items-in-the-cart)
        /// </remarks>
        /// <param name="cartItems"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;Cart?&gt;</returns>
        Task<Cart?> UpdateLineItemOrDefaultAsync(CartItems? cartItems = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CartApi : BaseApi, ICartApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CartApi(ILogger<CartApi> logger, HttpClient httpClient,
            JsonSerializerOptionsProvider jsonSerializerOptionsProvider,
            TokenProvider<ApiKeyToken> apiKeyProvider, TokenProvider<ContextKeyToken> contextKeyProvider) : base(logger,
            httpClient, jsonSerializerOptionsProvider, apiKeyProvider, contextKeyProvider)
        {
        }

        /// <summary>
        /// Add items to the cart This route adds items to the cart. An item can be a product or promotion for example. They are referenced by the &#x60;referencedId&#x60;-parameter.  Example: [Working with the cart - Guide](https://developer.shopware.com/docs/guides/integrations-api/store-api-guide/work-with-the-cart#adding-new-items-to-the-cart)
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartItems"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="Cart"/>&gt;</returns>
        public async Task<Cart?> AddLineItemAsync(CartItems? cartItems = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<Cart?> result = await AddLineItemWithHttpInfoAsync(cartItems, requestOptions, cancellationToken)
                .ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Add items to the cart This route adds items to the cart. An item can be a product or promotion for example. They are referenced by the &#x60;referencedId&#x60;-parameter.  Example: [Working with the cart - Guide](https://developer.shopware.com/docs/guides/integrations-api/store-api-guide/work-with-the-cart#adding-new-items-to-the-cart)
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartItems"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="Cart"/>&gt;</returns>
        public async Task<Cart?> AddLineItemOrDefaultAsync(CartItems? cartItems = null,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<Cart?>? result = null;
            try
            {
                result = await AddLineItemWithHttpInfoAsync(cartItems, requestOptions, cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return result != null && result.IsSuccessStatusCode
                ? result.Content
                : null;
        }

        /// <summary>
        /// Add items to the cart This route adds items to the cart. An item can be a product or promotion for example. They are referenced by the &#x60;referencedId&#x60;-parameter.  Example: [Working with the cart - Guide](https://developer.shopware.com/docs/guides/integrations-api/store-api-guide/work-with-the-cart#adding-new-items-to-the-cart)
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartItems"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="Cart"/></returns>
        public Task<ApiResponse<Cart?>> AddLineItemWithHttpInfoAsync(CartItems? cartItems = null,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
            const string queryPath = "/checkout/cart/line-item";

            return ExecuteRequest<Cart?>(queryPath, default, HttpMethod.Post, cartItems, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Delete a cart This route deletes the cart of the customer.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="SuccessResponse"/>&gt;</returns>
        public async Task<SuccessResponse?> DeleteCartAsync(RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<SuccessResponse?> result =
                await DeleteCartWithHttpInfoAsync(requestOptions, cancellationToken).ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Delete a cart This route deletes the cart of the customer.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="SuccessResponse"/>&gt;</returns>
        public async Task<SuccessResponse?> DeleteCartOrDefaultAsync(RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<SuccessResponse?>? result = null;
            try
            {
                result = await DeleteCartWithHttpInfoAsync(requestOptions, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return result != null && result.IsSuccessStatusCode
                ? result.Content
                : null;
        }

        /// <summary>
        /// Delete a cart This route deletes the cart of the customer.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="SuccessResponse"/></returns>
        public Task<ApiResponse<SuccessResponse?>> DeleteCartWithHttpInfoAsync(
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
            const string queryPath = "/checkout/cart";

            return ExecuteRequest<SuccessResponse?>(queryPath, default, HttpMethod.Delete, default, requestOptions,
                cancellationToken);
        }

        /// <summary>
        /// Fetch or create a cart Used to fetch the current cart or for creating a new one.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the new cart. This parameter will only be used when creating a new cart. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="Cart"/>&gt;</returns>
        public async Task<Cart?> ReadCartAsync(string? name = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<Cart?> result = await ReadCartWithHttpInfoAsync(name, requestOptions, cancellationToken)
                .ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Fetch or create a cart Used to fetch the current cart or for creating a new one.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the new cart. This parameter will only be used when creating a new cart. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="Cart"/>&gt;</returns>
        public async Task<Cart?> ReadCartOrDefaultAsync(string? name = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<Cart?>? result = null;
            try
            {
                result = await ReadCartWithHttpInfoAsync(name, requestOptions, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return result != null && result.IsSuccessStatusCode
                ? result.Content
                : null;
        }

        /// <summary>
        /// Fetch or create a cart Used to fetch the current cart or for creating a new one.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the new cart. This parameter will only be used when creating a new cart. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="Cart"/></returns>
        public Task<ApiResponse<Cart?>> ReadCartWithHttpInfoAsync(string? name = null,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
            const string queryPath = "/checkout/cart";

            System.Collections.Specialized.NameValueCollection parseQueryString =
                System.Web.HttpUtility.ParseQueryString(string.Empty);
            if (name != null)
                parseQueryString["name"] = Uri.EscapeDataString(name.ToString()!);
            var query = parseQueryString.ToString();

            return ExecuteRequest<Cart?>(queryPath, query, HttpMethod.Get, null, requestOptions,
                cancellationToken);
        }

        /// <summary>
        /// Remove items from the cart This route removes items from the cart and recalculates it.  Example: [Working with the cart - Guide](https://developer.shopware.com/docs/guides/integrations-api/store-api-guide/work-with-the-cart#deleting-items-in-the-cart)
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">A list of product identifiers.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="Cart"/>&gt;</returns>
        public async Task<Cart?> RemoveLineItemAsync(IEnumerable<string> ids, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<Cart?> result = await RemoveLineItemWithHttpInfoAsync(ids, requestOptions, cancellationToken)
                .ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Remove items from the cart This route removes items from the cart and recalculates it.  Example: [Working with the cart - Guide](https://developer.shopware.com/docs/guides/integrations-api/store-api-guide/work-with-the-cart#deleting-items-in-the-cart)
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">A list of product identifiers.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="Cart"/>&gt;</returns>
        public async Task<Cart?> RemoveLineItemOrDefaultAsync(IEnumerable<string> ids,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<Cart?>? result = null;
            try
            {
                result = await RemoveLineItemWithHttpInfoAsync(ids, requestOptions, cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return result != null && result.IsSuccessStatusCode
                ? result.Content
                : null;
        }

        /// <summary>
        /// Remove items from the cart This route removes items from the cart and recalculates it.  Example: [Working with the cart - Guide](https://developer.shopware.com/docs/guides/integrations-api/store-api-guide/work-with-the-cart#deleting-items-in-the-cart)
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">A list of product identifiers.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="Cart"/></returns>
        public Task<ApiResponse<Cart?>> RemoveLineItemWithHttpInfoAsync(IEnumerable<string> ids,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (ids == null)
                throw new ArgumentNullException(nameof(ids));

#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'

            const string queryPath = "/checkout/cart/line-item";

            System.Collections.Specialized.NameValueCollection parseQueryString =
                System.Web.HttpUtility.ParseQueryString(string.Empty);
            parseQueryString["ids"] = Uri.EscapeDataString(ids.ToString()!);
            var query = parseQueryString.ToString();

            return ExecuteRequest<Cart?>(queryPath, query, HttpMethod.Delete, default, requestOptions,
                cancellationToken);
        }

        /// <summary>
        /// Update items in the cart This route updates items in the cart. A typical example is updating the quantity of an item.  Example: [Working with the cart - Guide](https://developer.shopware.com/docs/guides/integrations-api/store-api-guide/work-with-the-cart#updating-items-in-the-cart)
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartItems"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="Cart"/>&gt;</returns>
        public async Task<Cart?> UpdateLineItemAsync(CartItems? cartItems = null,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<Cart?> result =
                await UpdateLineItemWithHttpInfoAsync(cartItems, requestOptions, cancellationToken)
                    .ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Update items in the cart This route updates items in the cart. A typical example is updating the quantity of an item.  Example: [Working with the cart - Guide](https://developer.shopware.com/docs/guides/integrations-api/store-api-guide/work-with-the-cart#updating-items-in-the-cart)
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartItems"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="Cart"/>&gt;</returns>
        public async Task<Cart?> UpdateLineItemOrDefaultAsync(CartItems? cartItems = null,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<Cart?>? result = null;
            try
            {
                result = await UpdateLineItemWithHttpInfoAsync(cartItems, requestOptions, cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return result != null && result.IsSuccessStatusCode
                ? result.Content
                : null;
        }

        /// <summary>
        /// Update items in the cart This route updates items in the cart. A typical example is updating the quantity of an item.  Example: [Working with the cart - Guide](https://developer.shopware.com/docs/guides/integrations-api/store-api-guide/work-with-the-cart#updating-items-in-the-cart)
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>


        /// <param name="cartItems"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="Cart"/></returns>
        public Task<ApiResponse<Cart?>> UpdateLineItemWithHttpInfoAsync(CartItems? cartItems = null,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
            const string queryPath = "/checkout/cart/line-item";


            return ExecuteRequest<Cart?>(queryPath, default, HttpMethod.Patch, default, requestOptions,
                cancellationToken);
        }
    }
}