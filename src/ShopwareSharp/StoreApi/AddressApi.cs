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
using ShopwareSharp;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace StoreApi
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAddressApi : IApi
    {
        /// <summary>
        /// Create a new address for a customer
        /// </summary>
        /// <remarks>
        /// Creates a new address for a customer.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerAddress"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;CustomerAddress?&gt;&gt;</returns>
        Task<ApiResponse<CustomerAddress?>> CreateCustomerAddressWithHttpInfoAsync(
            CustomerAddress? customerAddress = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Create a new address for a customer
        /// </summary>
        /// <remarks>
        /// Creates a new address for a customer.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerAddress"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;CustomerAddress&gt;</returns>
        Task<CustomerAddress?> CreateCustomerAddressAsync(CustomerAddress? customerAddress = null,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Create a new address for a customer
        /// </summary>
        /// <remarks>
        /// Creates a new address for a customer.
        /// </remarks>
        /// <param name="customerAddress"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;CustomerAddress?&gt;</returns>
        Task<CustomerAddress?> CreateCustomerAddressOrDefaultAsync(CustomerAddress? customerAddress = null,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null);


        /// <summary>
        /// Change a customer&#39;s default billing address
        /// </summary>
        /// <remarks>
        /// Updates the default (preselected) billing addresses of a customer.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">Address ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;object?&gt;&gt;</returns>
        Task<ApiResponse<object?>> DefaultBillingAddressWithHttpInfoAsync(string addressId,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Change a customer&#39;s default billing address
        /// </summary>
        /// <remarks>
        /// Updates the default (preselected) billing addresses of a customer.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">Address ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;object&gt;</returns>
        Task<object?> DefaultBillingAddressAsync(string addressId, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Change a customer&#39;s default billing address
        /// </summary>
        /// <remarks>
        /// Updates the default (preselected) billing addresses of a customer.
        /// </remarks>
        /// <param name="addressId">Address ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;object?&gt;</returns>
        Task<object?> DefaultBillingAddressOrDefaultAsync(string addressId, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);


        /// <summary>
        /// Change a customer&#39;s default shipping address
        /// </summary>
        /// <remarks>
        /// Updates the default (preselected) shipping addresses of a customer.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">Address ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;object?&gt;&gt;</returns>
        Task<ApiResponse<object?>> DefaultShippingAddressWithHttpInfoAsync(string addressId,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Change a customer&#39;s default shipping address
        /// </summary>
        /// <remarks>
        /// Updates the default (preselected) shipping addresses of a customer.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">Address ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;object&gt;</returns>
        Task<object?> DefaultShippingAddressAsync(string addressId, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Change a customer&#39;s default shipping address
        /// </summary>
        /// <remarks>
        /// Updates the default (preselected) shipping addresses of a customer.
        /// </remarks>
        /// <param name="addressId">Address ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;object?&gt;</returns>
        Task<object?> DefaultShippingAddressOrDefaultAsync(string addressId, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);


        /// <summary>
        /// Delete an address of a customer
        /// </summary>
        /// <remarks>
        /// Delete an address of customer.  Only addresses which are not set as default addresses for shipping or billing can be deleted. You can check the current default addresses of your customer using the profile information endpoint and change them using the default address endpoint.       **A customer must have at least one address (which can be used for shipping and billing).**  An automatic fallback is not applied.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">ID of the address to be deleted.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;object?&gt;&gt;</returns>
        Task<ApiResponse<object?>> DeleteCustomerAddressWithHttpInfoAsync(string addressId,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Delete an address of a customer
        /// </summary>
        /// <remarks>
        /// Delete an address of customer.  Only addresses which are not set as default addresses for shipping or billing can be deleted. You can check the current default addresses of your customer using the profile information endpoint and change them using the default address endpoint.       **A customer must have at least one address (which can be used for shipping and billing).**  An automatic fallback is not applied.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">ID of the address to be deleted.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;object&gt;</returns>
        Task<object?> DeleteCustomerAddressAsync(string addressId, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Delete an address of a customer
        /// </summary>
        /// <remarks>
        /// Delete an address of customer.  Only addresses which are not set as default addresses for shipping or billing can be deleted. You can check the current default addresses of your customer using the profile information endpoint and change them using the default address endpoint.       **A customer must have at least one address (which can be used for shipping and billing).**  An automatic fallback is not applied.
        /// </remarks>
        /// <param name="addressId">ID of the address to be deleted.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;object?&gt;</returns>
        Task<object?> DeleteCustomerAddressOrDefaultAsync(string addressId, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);


        /// <summary>
        /// Fetch addresses of a customer
        /// </summary>
        /// <remarks>
        /// Lists all addresses of the current customer and allows filtering them based on a criteria.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="readCustomerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;List&lt;CustomerAddress&gt;?&gt;&gt;</returns>
        Task<ApiResponse<List<CustomerAddress>?>> ListAddressWithHttpInfoAsync(
            ReadCustomerRequest? readCustomerRequest = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Fetch addresses of a customer
        /// </summary>
        /// <remarks>
        /// Lists all addresses of the current customer and allows filtering them based on a criteria.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="readCustomerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;List&lt;CustomerAddress&gt;&gt;</returns>
        Task<List<CustomerAddress>?> ListAddressAsync(ReadCustomerRequest? readCustomerRequest = null,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Fetch addresses of a customer
        /// </summary>
        /// <remarks>
        /// Lists all addresses of the current customer and allows filtering them based on a criteria.
        /// </remarks>
        /// <param name="readCustomerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;List&lt;CustomerAddress&gt;?&gt;</returns>
        Task<List<CustomerAddress>?> ListAddressOrDefaultAsync(ReadCustomerRequest? readCustomerRequest = null,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null);


        /// <summary>
        /// Modify an address of a customer
        /// </summary>
        /// <remarks>
        /// Modifies an existing address of a customer.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">Address ID</param>
        /// <param name="customerAddress"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;CustomerAddress?&gt;&gt;</returns>
        Task<ApiResponse<CustomerAddress?>> UpdateCustomerAddressWithHttpInfoAsync(string addressId,
            CustomerAddress? customerAddress = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Modify an address of a customer
        /// </summary>
        /// <remarks>
        /// Modifies an existing address of a customer.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">Address ID</param>
        /// <param name="customerAddress"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;CustomerAddress&gt;</returns>
        Task<CustomerAddress?> UpdateCustomerAddressAsync(string addressId, CustomerAddress? customerAddress = null,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Modify an address of a customer
        /// </summary>
        /// <remarks>
        /// Modifies an existing address of a customer.
        /// </remarks>
        /// <param name="addressId">Address ID</param>
        /// <param name="customerAddress"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;CustomerAddress?&gt;</returns>
        Task<CustomerAddress?> UpdateCustomerAddressOrDefaultAsync(string addressId,
            CustomerAddress? customerAddress = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AddressApi : BaseApi, IAddressApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AddressApi(ILogger<AddressApi> logger, HttpClient httpClient,
            JsonSerializerOptionsProvider jsonSerializerOptionsProvider,
            TokenProvider<ApiKeyToken> apiKeyProvider, TokenProvider<ContextKeyToken> contextKeyProvider) : base(logger,
            httpClient, jsonSerializerOptionsProvider, apiKeyProvider, contextKeyProvider)
        {
        }

        /// <summary>
        /// Create a new address for a customer Creates a new address for a customer.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerAddress"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="CustomerAddress"/>&gt;</returns>
        public async Task<CustomerAddress?> CreateCustomerAddressAsync(CustomerAddress? customerAddress = null,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<CustomerAddress?> result =
                await CreateCustomerAddressWithHttpInfoAsync(customerAddress, requestOptions, cancellationToken)
                    .ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Create a new address for a customer Creates a new address for a customer.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="customerAddress"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="CustomerAddress"/>&gt;</returns>
        public async Task<CustomerAddress?> CreateCustomerAddressOrDefaultAsync(CustomerAddress? customerAddress = null,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<CustomerAddress?>? result = null;
            try
            {
                result = await CreateCustomerAddressWithHttpInfoAsync(customerAddress, requestOptions,
                    cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return result != null && result.IsSuccessStatusCode
                ? result.Content
                : null;
        }

        /// <summary>
        /// Create a new address for a customer Creates a new address for a customer.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerAddress"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="CustomerAddress"/></returns>
        public Task<ApiResponse<CustomerAddress?>> CreateCustomerAddressWithHttpInfoAsync(
            CustomerAddress? customerAddress = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null)
        {
            const string queryPath = "/account/address";

            return ExecuteRequest<CustomerAddress?>(queryPath, default, HttpMethod.Post, customerAddress,
                requestOptions, cancellationToken);
        }

        /// <summary>
        /// Change a customer&#39;s default billing address Updates the default (preselected) billing addresses of a customer.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">Address ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="object"/>&gt;</returns>
        public async Task<object?> DefaultBillingAddressAsync(string addressId,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<object?> result =
                await DefaultBillingAddressWithHttpInfoAsync(addressId, requestOptions, cancellationToken)
                    .ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Change a customer&#39;s default billing address Updates the default (preselected) billing addresses of a customer.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">Address ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="object"/>&gt;</returns>
        public async Task<object?> DefaultBillingAddressOrDefaultAsync(string addressId,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<object?>? result = null;
            try
            {
                result = await DefaultBillingAddressWithHttpInfoAsync(addressId, requestOptions, cancellationToken)
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
        /// Change a customer&#39;s default billing address Updates the default (preselected) billing addresses of a customer.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">Address ID</param>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="object"/></returns>
        public Task<ApiResponse<object?>> DefaultBillingAddressWithHttpInfoAsync(string addressId,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
            if (addressId == null)
                throw new ArgumentNullException(nameof(addressId));

            var queryPath = $"/account/address/default-billing/{addressId}";

            return ExecuteRequest<object?>(queryPath, default, HttpMethod.Patch, default, requestOptions,
                cancellationToken);
        }

        /// <summary>
        /// Change a customer&#39;s default shipping address Updates the default (preselected) shipping addresses of a customer.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">Address ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="object"/>&gt;</returns>
        public async Task<object?> DefaultShippingAddressAsync(string addressId,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<object?> result =
                await DefaultShippingAddressWithHttpInfoAsync(addressId, requestOptions, cancellationToken)
                    .ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Change a customer&#39;s default shipping address Updates the default (preselected) shipping addresses of a customer.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">Address ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="object"/>&gt;</returns>
        public async Task<object?> DefaultShippingAddressOrDefaultAsync(string addressId,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<object?>? result = null;
            try
            {
                result = await DefaultShippingAddressWithHttpInfoAsync(addressId, requestOptions, cancellationToken)
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
        /// Change a customer&#39;s default shipping address Updates the default (preselected) shipping addresses of a customer.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">Address ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="object"/></returns>
        public Task<ApiResponse<object?>> DefaultShippingAddressWithHttpInfoAsync(string addressId,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
            if (addressId == null)
                throw new ArgumentNullException(nameof(addressId));

            var queryPath = $"/account/address/default-shipping/{addressId}";

            return ExecuteRequest<object?>(queryPath, default, HttpMethod.Patch, default, requestOptions,
                cancellationToken);
        }

        /// <summary>
        /// Delete an address of a customer Delete an address of customer.  Only addresses which are not set as default addresses for shipping or billing can be deleted. You can check the current default addresses of your customer using the profile information endpoint and change them using the default address endpoint.       **A customer must have at least one address (which can be used for shipping and billing).**  An automatic fallback is not applied.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">ID of the address to be deleted.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="object"/>&gt;</returns>
        public async Task<object?> DeleteCustomerAddressAsync(string addressId,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<object?> result =
                await DeleteCustomerAddressWithHttpInfoAsync(addressId, requestOptions, cancellationToken)
                    .ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Delete an address of a customer Delete an address of customer.  Only addresses which are not set as default addresses for shipping or billing can be deleted. You can check the current default addresses of your customer using the profile information endpoint and change them using the default address endpoint.       **A customer must have at least one address (which can be used for shipping and billing).**  An automatic fallback is not applied.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">ID of the address to be deleted.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="object"/>&gt;</returns>
        public async Task<object?> DeleteCustomerAddressOrDefaultAsync(string addressId,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<object?>? result = null;
            try
            {
                result = await DeleteCustomerAddressWithHttpInfoAsync(addressId, requestOptions, cancellationToken)
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
        /// Delete an address of a customer Delete an address of customer.  Only addresses which are not set as default addresses for shipping or billing can be deleted. You can check the current default addresses of your customer using the profile information endpoint and change them using the default address endpoint.       **A customer must have at least one address (which can be used for shipping and billing).**  An automatic fallback is not applied.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">ID of the address to be deleted.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="object"/></returns>
        public Task<ApiResponse<object?>> DeleteCustomerAddressWithHttpInfoAsync(string addressId,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
            if (addressId == null)
                throw new ArgumentNullException(nameof(addressId));

            var queryPath = $"/account/address/{addressId}";

            return ExecuteRequest<object?>(queryPath, default, HttpMethod.Delete, default, requestOptions,
                cancellationToken);
        }

        /// <summary>
        /// Fetch addresses of a customer Lists all addresses of the current customer and allows filtering them based on a criteria.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="readCustomerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="List&lt;CustomerAddress&gt;"/>&gt;</returns>
        public async Task<List<CustomerAddress>?> ListAddressAsync(ReadCustomerRequest? readCustomerRequest = null,
            RequestOptions? requestOptions = default, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<List<CustomerAddress>?> result =
                await ListAddressWithHttpInfoAsync(readCustomerRequest, requestOptions, cancellationToken)
                    .ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Fetch addresses of a customer Lists all addresses of the current customer and allows filtering them based on a criteria.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="readCustomerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="List&lt;CustomerAddress&gt;"/>&gt;</returns>
        public async Task<List<CustomerAddress>?> ListAddressOrDefaultAsync(
            ReadCustomerRequest? readCustomerRequest = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<List<CustomerAddress>?>? result = null;
            try
            {
                result = await ListAddressWithHttpInfoAsync(readCustomerRequest, requestOptions, cancellationToken)
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
        /// Fetch addresses of a customer Lists all addresses of the current customer and allows filtering them based on a criteria.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="readCustomerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="List&lt;CustomerAddress&gt;"/></returns>
        public Task<ApiResponse<List<CustomerAddress>?>> ListAddressWithHttpInfoAsync(
            ReadCustomerRequest? readCustomerRequest = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null)
        {
            const string queryPath = "/account/list-address";

            return ExecuteRequest<List<CustomerAddress>?>(queryPath, default, HttpMethod.Post, readCustomerRequest,
                requestOptions, cancellationToken);
        }

        /// <summary>
        /// Modify an address of a customer Modifies an existing address of a customer.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">Address ID</param>
        /// <param name="customerAddress"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="CustomerAddress"/>&gt;</returns>
        public async Task<CustomerAddress?> UpdateCustomerAddressAsync(string addressId,
            CustomerAddress? customerAddress = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<CustomerAddress?> result =
                await UpdateCustomerAddressWithHttpInfoAsync(addressId, customerAddress, requestOptions,
                    cancellationToken).ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Modify an address of a customer Modifies an existing address of a customer.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">Address ID</param>
        /// <param name="customerAddress"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="CustomerAddress"/>&gt;</returns>
        public async Task<CustomerAddress?> UpdateCustomerAddressOrDefaultAsync(string addressId,
            CustomerAddress? customerAddress = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<CustomerAddress?>? result = null;
            try
            {
                result = await UpdateCustomerAddressWithHttpInfoAsync(addressId, customerAddress, requestOptions,
                    cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return result != null && result.IsSuccessStatusCode
                ? result.Content
                : null;
        }

        /// <summary>
        /// Modify an address of a customer Modifies an existing address of a customer.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">Address ID</param>
        /// <param name="customerAddress"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="CustomerAddress"/></returns>
        public Task<ApiResponse<CustomerAddress?>> UpdateCustomerAddressWithHttpInfoAsync(string addressId,
            CustomerAddress? customerAddress = null, RequestOptions? requestOptions = default,
            System.Threading.CancellationToken? cancellationToken = null)
        {
            if (addressId == null)
                throw new ArgumentNullException(nameof(addressId));

            var queryPath = "/account/address/{addressId}";

            return ExecuteRequest<CustomerAddress?>(queryPath, default, HttpMethod.Patch, customerAddress,
                requestOptions, cancellationToken);
        }
    }
}
