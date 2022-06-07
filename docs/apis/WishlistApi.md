# ShopwareSharp.Api.WishlistApi

All URIs are relative to *http://localhost/store-api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddProductOnWishlist**](WishlistApi.md#addproductonwishlist) | **POST** /customer/wishlist/add/{productId} | Add a product to a wishlist |
| [**DeleteProductOnWishlist**](WishlistApi.md#deleteproductonwishlist) | **DELETE** /customer/wishlist/delete/{productId} | Remove a product from a wishlist |
| [**MergeProductOnWishlist**](WishlistApi.md#mergeproductonwishlist) | **POST** /customer/wishlist/merge | Create a wishlist for a customer |
| [**ReadCustomerWishlist**](WishlistApi.md#readcustomerwishlist) | **POST** /customer/wishlist | Fetch a wishlist |

<a name="addproductonwishlist"></a>
# **AddProductOnWishlist**
> SuccessResponse AddProductOnWishlist (string productId, string contentType, string accept)

Add a product to a wishlist

Adds a product to a customers wishlist.  **Important constraints**  * Anonymous (not logged-in) customers can not have wishlists. * The wishlist feature has to be activated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class AddProductOnWishlistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");
            // Configure API key authorization: ContextToken
            config.AddApiKey("sw-context-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-context-token", "Bearer");

            var apiInstance = new WishlistApi(config);
            var productId = "productId_example";  // string | Identifier of the product to be added.
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")

            try
            {
                // Add a product to a wishlist
                SuccessResponse result = apiInstance.AddProductOnWishlist(productId, contentType, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WishlistApi.AddProductOnWishlist: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddProductOnWishlistWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a product to a wishlist
    ApiResponse<SuccessResponse> response = apiInstance.AddProductOnWishlistWithHttpInfo(productId, contentType, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WishlistApi.AddProductOnWishlistWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | Identifier of the product to be added. |  |
| **contentType** | **string** | Content type of the request | [default to &quot;application/json&quot;] |
| **accept** | **string** | Accepted response content types | [default to &quot;application/json&quot;] |

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey), [ContextToken](../README.md#ContextToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a success response. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="deleteproductonwishlist"></a>
# **DeleteProductOnWishlist**
> SuccessResponse DeleteProductOnWishlist (string productId, string contentType, string accept)

Remove a product from a wishlist

Removes a product from a customer's wishlist.  **Important constraints**  * Anonymous (not logged-in) customers can not have wishlists. * The wishlist feature has to be activated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class DeleteProductOnWishlistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");
            // Configure API key authorization: ContextToken
            config.AddApiKey("sw-context-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-context-token", "Bearer");

            var apiInstance = new WishlistApi(config);
            var productId = "productId_example";  // string | The identifier of the product to be removed from the wishlist.
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")

            try
            {
                // Remove a product from a wishlist
                SuccessResponse result = apiInstance.DeleteProductOnWishlist(productId, contentType, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WishlistApi.DeleteProductOnWishlist: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteProductOnWishlistWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a product from a wishlist
    ApiResponse<SuccessResponse> response = apiInstance.DeleteProductOnWishlistWithHttpInfo(productId, contentType, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WishlistApi.DeleteProductOnWishlistWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | The identifier of the product to be removed from the wishlist. |  |
| **contentType** | **string** | Content type of the request | [default to &quot;application/json&quot;] |
| **accept** | **string** | Accepted response content types | [default to &quot;application/json&quot;] |

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey), [ContextToken](../README.md#ContextToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a success response indicating a successful removal. |  -  |
| **404** | The removal of the product failed. Probably because the product could not be found on the wishlist. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="mergeproductonwishlist"></a>
# **MergeProductOnWishlist**
> SuccessResponse MergeProductOnWishlist (MergeProductOnWishlistRequest mergeProductOnWishlistRequest, string contentType, string accept)

Create a wishlist for a customer

Create a new wishlist for a logged in customer or extend the existing wishlist given a set of products.  **Important constraints**  * Anonymous (not logged-in) customers can not have wishlists. * A customer can only have a single wishlist. * The wishlist feature has to be activated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class MergeProductOnWishlistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");
            // Configure API key authorization: ContextToken
            config.AddApiKey("sw-context-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-context-token", "Bearer");

            var apiInstance = new WishlistApi(config);
            var mergeProductOnWishlistRequest = new MergeProductOnWishlistRequest(); // MergeProductOnWishlistRequest | 
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")

            try
            {
                // Create a wishlist for a customer
                SuccessResponse result = apiInstance.MergeProductOnWishlist(mergeProductOnWishlistRequest, contentType, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WishlistApi.MergeProductOnWishlist: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MergeProductOnWishlistWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a wishlist for a customer
    ApiResponse<SuccessResponse> response = apiInstance.MergeProductOnWishlistWithHttpInfo(mergeProductOnWishlistRequest, contentType, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WishlistApi.MergeProductOnWishlistWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mergeProductOnWishlistRequest** | [**MergeProductOnWishlistRequest**](MergeProductOnWishlistRequest.md) |  |  |
| **contentType** | **string** | Content type of the request | [default to &quot;application/json&quot;] |
| **accept** | **string** | Accepted response content types | [default to &quot;application/json&quot;] |

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey), [ContextToken](../README.md#ContextToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a success response. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="readcustomerwishlist"></a>
# **ReadCustomerWishlist**
> WishlistLoadRouteResponse ReadCustomerWishlist (string contentType, string accept, ReadCustomerRequest? readCustomerRequest = null)

Fetch a wishlist

Fetch a customer's wishlist. Products on the wishlist can be filtered using a criteria object.  **Important constraints**  * Anonymous (not logged-in) customers can not have wishlists. * The wishlist feature has to be activated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class ReadCustomerWishlistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");
            // Configure API key authorization: ContextToken
            config.AddApiKey("sw-context-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-context-token", "Bearer");

            var apiInstance = new WishlistApi(config);
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")
            var readCustomerRequest = new ReadCustomerRequest?(); // ReadCustomerRequest? |  (optional) 

            try
            {
                // Fetch a wishlist
                WishlistLoadRouteResponse result = apiInstance.ReadCustomerWishlist(contentType, accept, readCustomerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WishlistApi.ReadCustomerWishlist: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadCustomerWishlistWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch a wishlist
    ApiResponse<WishlistLoadRouteResponse> response = apiInstance.ReadCustomerWishlistWithHttpInfo(contentType, accept, readCustomerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WishlistApi.ReadCustomerWishlistWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** | Content type of the request | [default to &quot;application/json&quot;] |
| **accept** | **string** | Accepted response content types | [default to &quot;application/json&quot;] |
| **readCustomerRequest** | [**ReadCustomerRequest?**](ReadCustomerRequest?.md) |  | [optional]  |

### Return type

[**WishlistLoadRouteResponse**](WishlistLoadRouteResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey), [ContextToken](../README.md#ContextToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

