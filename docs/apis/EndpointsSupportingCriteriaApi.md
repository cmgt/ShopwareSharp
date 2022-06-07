# ShopwareSharp.Api.EndpointsSupportingCriteriaApi

All URIs are relative to *http://localhost/store-api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ListAddress**](EndpointsSupportingCriteriaApi.md#listaddress) | **POST** /account/list-address | Fetch addresses of a customer |
| [**ReadCategory**](EndpointsSupportingCriteriaApi.md#readcategory) | **POST** /category/{categoryId} | Fetch a single category |
| [**ReadCategoryList**](EndpointsSupportingCriteriaApi.md#readcategorylist) | **POST** /category | Fetch a list of categories |
| [**ReadCountry**](EndpointsSupportingCriteriaApi.md#readcountry) | **POST** /country | Fetch countries |
| [**ReadCurrency**](EndpointsSupportingCriteriaApi.md#readcurrency) | **POST** /currency | Fetch currencies |
| [**ReadCustomer**](EndpointsSupportingCriteriaApi.md#readcustomer) | **POST** /account/customer | Get information about current customer |
| [**ReadCustomerWishlist**](EndpointsSupportingCriteriaApi.md#readcustomerwishlist) | **POST** /customer/wishlist | Fetch a wishlist |
| [**ReadLandingPage**](EndpointsSupportingCriteriaApi.md#readlandingpage) | **POST** /landing-page/{landingPageId} | Fetch a landing page with the resolved CMS page |
| [**ReadLanguages**](EndpointsSupportingCriteriaApi.md#readlanguages) | **POST** /language | Fetch languages |
| [**ReadNavigation**](EndpointsSupportingCriteriaApi.md#readnavigation) | **POST** /navigation/{requestActiveId}/{requestRootId} | Fetch a navigation menu |
| [**ReadOrder**](EndpointsSupportingCriteriaApi.md#readorder) | **POST** /order | Fetch a list of orders |
| [**ReadPaymentMethod**](EndpointsSupportingCriteriaApi.md#readpaymentmethod) | **POST** /payment-method | Loads all available payment methods |
| [**ReadProduct**](EndpointsSupportingCriteriaApi.md#readproduct) | **POST** /product | Fetch a list of products |
| [**ReadProductReviews**](EndpointsSupportingCriteriaApi.md#readproductreviews) | **POST** /product/{productId}/reviews | Fetch product reviews |
| [**ReadSalutation**](EndpointsSupportingCriteriaApi.md#readsalutation) | **POST** /salutation | Fetch salutations |
| [**ReadSeoUrl**](EndpointsSupportingCriteriaApi.md#readseourl) | **POST** /seo-url | Fetch SEO routes |
| [**ReadShippingMethod**](EndpointsSupportingCriteriaApi.md#readshippingmethod) | **POST** /shipping-method | Fetch shipping methods |

<a name="listaddress"></a>
# **ListAddress**
> List&lt;CustomerAddress&gt; ListAddress (string contentType, string accept, ReadCustomerRequest? readCustomerRequest = null)

Fetch addresses of a customer

Lists all addresses of the current customer and allows filtering them based on a criteria.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class ListAddressExample
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

            var apiInstance = new EndpointsSupportingCriteriaApi(config);
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")
            var readCustomerRequest = new ReadCustomerRequest?(); // ReadCustomerRequest? |  (optional) 

            try
            {
                // Fetch addresses of a customer
                List<CustomerAddress> result = apiInstance.ListAddress(contentType, accept, readCustomerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ListAddress: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAddressWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch addresses of a customer
    ApiResponse<List<CustomerAddress>> response = apiInstance.ListAddressWithHttpInfo(contentType, accept, readCustomerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ListAddressWithHttpInfo: " + e.Message);
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

[**List&lt;CustomerAddress&gt;**](CustomerAddress.md)

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

<a name="readcategory"></a>
# **ReadCategory**
> Category ReadCategory (string categoryId, string contentType, string accept, string? slots = null, ReadCategoryRequest? readCategoryRequest = null)

Fetch a single category

This endpoint returns information about the category, as well as a fully resolved (hydrated with mapping values) CMS page, if one is assigned to the category. You can pass slots which should be resolved exclusively.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class ReadCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new EndpointsSupportingCriteriaApi(config);
            var categoryId = "categoryId_example";  // string | Identifier of the category to be fetched
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")
            var slots = "slots_example";  // string? | Resolves only the given slot identifiers. The identifiers have to be seperated by a '|' character (optional) 
            var readCategoryRequest = new ReadCategoryRequest?(); // ReadCategoryRequest? |  (optional) 

            try
            {
                // Fetch a single category
                Category result = apiInstance.ReadCategory(categoryId, contentType, accept, slots, readCategoryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch a single category
    ApiResponse<Category> response = apiInstance.ReadCategoryWithHttpInfo(categoryId, contentType, accept, slots, readCategoryRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryId** | **string** | Identifier of the category to be fetched |  |
| **contentType** | **string** | Content type of the request | [default to &quot;application/json&quot;] |
| **accept** | **string** | Accepted response content types | [default to &quot;application/json&quot;] |
| **slots** | **string?** | Resolves only the given slot identifiers. The identifiers have to be seperated by a &#39;|&#39; character | [optional]  |
| **readCategoryRequest** | [**ReadCategoryRequest?**](ReadCategoryRequest?.md) |  | [optional]  |

### Return type

[**Category**](Category.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The loaded category with cms page |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="readcategorylist"></a>
# **ReadCategoryList**
> ReadCategoryList200Response ReadCategoryList (string contentType, string accept, ReadCustomerRequest? readCustomerRequest = null)

Fetch a list of categories

Perform a filtered search for categories.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class ReadCategoryListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new EndpointsSupportingCriteriaApi(config);
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")
            var readCustomerRequest = new ReadCustomerRequest?(); // ReadCustomerRequest? |  (optional) 

            try
            {
                // Fetch a list of categories
                ReadCategoryList200Response result = apiInstance.ReadCategoryList(contentType, accept, readCustomerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadCategoryList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadCategoryListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch a list of categories
    ApiResponse<ReadCategoryList200Response> response = apiInstance.ReadCategoryListWithHttpInfo(contentType, accept, readCustomerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadCategoryListWithHttpInfo: " + e.Message);
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

[**ReadCategoryList200Response**](ReadCategoryList200Response.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Entity search result containing categories. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="readcountry"></a>
# **ReadCountry**
> ReadCountry200Response ReadCountry (string contentType, string accept, ReadCustomerRequest? readCustomerRequest = null)

Fetch countries

Perform a filtered search for countries

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class ReadCountryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new EndpointsSupportingCriteriaApi(config);
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")
            var readCustomerRequest = new ReadCustomerRequest?(); // ReadCustomerRequest? |  (optional) 

            try
            {
                // Fetch countries
                ReadCountry200Response result = apiInstance.ReadCountry(contentType, accept, readCustomerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadCountry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadCountryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch countries
    ApiResponse<ReadCountry200Response> response = apiInstance.ReadCountryWithHttpInfo(contentType, accept, readCustomerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadCountryWithHttpInfo: " + e.Message);
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

[**ReadCountry200Response**](ReadCountry200Response.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Entity search result containing countries. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="readcurrency"></a>
# **ReadCurrency**
> ReadCurrency200Response ReadCurrency (string contentType, string accept, ReadCustomerRequest? readCustomerRequest = null)

Fetch currencies

Perform a filtered search for currencies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class ReadCurrencyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new EndpointsSupportingCriteriaApi(config);
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")
            var readCustomerRequest = new ReadCustomerRequest?(); // ReadCustomerRequest? |  (optional) 

            try
            {
                // Fetch currencies
                ReadCurrency200Response result = apiInstance.ReadCurrency(contentType, accept, readCustomerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadCurrency: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadCurrencyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch currencies
    ApiResponse<ReadCurrency200Response> response = apiInstance.ReadCurrencyWithHttpInfo(contentType, accept, readCustomerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadCurrencyWithHttpInfo: " + e.Message);
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

[**ReadCurrency200Response**](ReadCurrency200Response.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Entity search result containing currencies. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="readcustomer"></a>
# **ReadCustomer**
> Customer ReadCustomer (string contentType, string accept, ReadCustomerRequest? readCustomerRequest = null)

Get information about current customer

Returns information about the current customer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class ReadCustomerExample
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

            var apiInstance = new EndpointsSupportingCriteriaApi(config);
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")
            var readCustomerRequest = new ReadCustomerRequest?(); // ReadCustomerRequest? |  (optional) 

            try
            {
                // Get information about current customer
                Customer result = apiInstance.ReadCustomer(contentType, accept, readCustomerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadCustomer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadCustomerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get information about current customer
    ApiResponse<Customer> response = apiInstance.ReadCustomerWithHttpInfo(contentType, accept, readCustomerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadCustomerWithHttpInfo: " + e.Message);
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

[**Customer**](Customer.md)

### Authorization

[ApiKey](../README.md#ApiKey), [ContextToken](../README.md#ContextToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the logged in customer, also for guest sessions. Check for the value of &#x60;guest&#x60; field to see whether the customer is a guest. |  -  |

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

            var apiInstance = new EndpointsSupportingCriteriaApi(config);
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
                Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadCustomerWishlist: " + e.Message);
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
    Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadCustomerWishlistWithHttpInfo: " + e.Message);
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

<a name="readlandingpage"></a>
# **ReadLandingPage**
> LandingPage ReadLandingPage (string landingPageId, string contentType, string accept, ReadLandingPageRequest? readLandingPageRequest = null)

Fetch a landing page with the resolved CMS page

Loads a landing page by its identifier and resolves the CMS page.  **Important notice**  The criteria passed with this route also affects the listing, if there is one within the cms page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class ReadLandingPageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new EndpointsSupportingCriteriaApi(config);
            var landingPageId = "landingPageId_example";  // string | Identifier of the landing page.
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")
            var readLandingPageRequest = new ReadLandingPageRequest?(); // ReadLandingPageRequest? |  (optional) 

            try
            {
                // Fetch a landing page with the resolved CMS page
                LandingPage result = apiInstance.ReadLandingPage(landingPageId, contentType, accept, readLandingPageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadLandingPage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadLandingPageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch a landing page with the resolved CMS page
    ApiResponse<LandingPage> response = apiInstance.ReadLandingPageWithHttpInfo(landingPageId, contentType, accept, readLandingPageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadLandingPageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **landingPageId** | **string** | Identifier of the landing page. |  |
| **contentType** | **string** | Content type of the request | [default to &quot;application/json&quot;] |
| **accept** | **string** | Accepted response content types | [default to &quot;application/json&quot;] |
| **readLandingPageRequest** | [**ReadLandingPageRequest?**](ReadLandingPageRequest?.md) |  | [optional]  |

### Return type

[**LandingPage**](LandingPage.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/vnd.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The loaded landing page with cms page |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="readlanguages"></a>
# **ReadLanguages**
> ReadLanguages200Response ReadLanguages (string contentType, string accept, ReadCustomerRequest? readCustomerRequest = null)

Fetch languages

Perform a filtered search for languages.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class ReadLanguagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new EndpointsSupportingCriteriaApi(config);
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")
            var readCustomerRequest = new ReadCustomerRequest?(); // ReadCustomerRequest? |  (optional) 

            try
            {
                // Fetch languages
                ReadLanguages200Response result = apiInstance.ReadLanguages(contentType, accept, readCustomerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadLanguages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadLanguagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch languages
    ApiResponse<ReadLanguages200Response> response = apiInstance.ReadLanguagesWithHttpInfo(contentType, accept, readCustomerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadLanguagesWithHttpInfo: " + e.Message);
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

[**ReadLanguages200Response**](ReadLanguages200Response.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Entity search result containing languages. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="readnavigation"></a>
# **ReadNavigation**
> List&lt;Category&gt; ReadNavigation (string requestActiveId, string requestRootId, ReadNavigationRequest readNavigationRequest, string contentType, string accept, bool? swIncludeSeoUrls = null)

Fetch a navigation menu

This endpoint returns categories that can be used as a page navigation. You can either return them as a tree or as a flat list. You can also control the depth of the tree.      Instead of passing uuids, you can also use one of the following aliases for the activeId and rootId parameters to get the respective navigations of your sales channel.       * main-navigation      * service-navigation      * footer-navigation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class ReadNavigationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new EndpointsSupportingCriteriaApi(config);
            var requestActiveId = "requestActiveId_example";  // string | Identifier of the active category in the navigation tree (if not used, just set to the same as rootId).
            var requestRootId = "requestRootId_example";  // string | Identifier of the root category for your desired navigation tree. You can use it to fetch sub-trees of your navigation tree.
            var readNavigationRequest = new ReadNavigationRequest(); // ReadNavigationRequest | 
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")
            var swIncludeSeoUrls = true;  // bool? | Instructs Shopware to try and resolve SEO URLs for the given navigation item (optional) 

            try
            {
                // Fetch a navigation menu
                List<Category> result = apiInstance.ReadNavigation(requestActiveId, requestRootId, readNavigationRequest, contentType, accept, swIncludeSeoUrls);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadNavigation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadNavigationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch a navigation menu
    ApiResponse<List<Category>> response = apiInstance.ReadNavigationWithHttpInfo(requestActiveId, requestRootId, readNavigationRequest, contentType, accept, swIncludeSeoUrls);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadNavigationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestActiveId** | **string** | Identifier of the active category in the navigation tree (if not used, just set to the same as rootId). |  |
| **requestRootId** | **string** | Identifier of the root category for your desired navigation tree. You can use it to fetch sub-trees of your navigation tree. |  |
| **readNavigationRequest** | [**ReadNavigationRequest**](ReadNavigationRequest.md) |  |  |
| **contentType** | **string** | Content type of the request | [default to &quot;application/json&quot;] |
| **accept** | **string** | Accepted response content types | [default to &quot;application/json&quot;] |
| **swIncludeSeoUrls** | **bool?** | Instructs Shopware to try and resolve SEO URLs for the given navigation item | [optional]  |

### Return type

[**List&lt;Category&gt;**](Category.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All available navigations |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="readorder"></a>
# **ReadOrder**
> OrderRouteResponse ReadOrder (ReadOrderRequest readOrderRequest, string contentType, string accept)

Fetch a list of orders

List orders of a customer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class ReadOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new EndpointsSupportingCriteriaApi(config);
            var readOrderRequest = new ReadOrderRequest(); // ReadOrderRequest | 
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")

            try
            {
                // Fetch a list of orders
                OrderRouteResponse result = apiInstance.ReadOrder(readOrderRequest, contentType, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch a list of orders
    ApiResponse<OrderRouteResponse> response = apiInstance.ReadOrderWithHttpInfo(readOrderRequest, contentType, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **readOrderRequest** | [**ReadOrderRequest**](ReadOrderRequest.md) |  |  |
| **contentType** | **string** | Content type of the request | [default to &quot;application/json&quot;] |
| **accept** | **string** | Accepted response content types | [default to &quot;application/json&quot;] |

### Return type

[**OrderRouteResponse**](OrderRouteResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An array of orders and an indicator if the payment of the order can be changed. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="readpaymentmethod"></a>
# **ReadPaymentMethod**
> ReadPaymentMethod200Response ReadPaymentMethod (ReadPaymentMethodRequest readPaymentMethodRequest, string contentType, string accept)

Loads all available payment methods

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class ReadPaymentMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new EndpointsSupportingCriteriaApi(config);
            var readPaymentMethodRequest = new ReadPaymentMethodRequest(); // ReadPaymentMethodRequest | 
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")

            try
            {
                // Loads all available payment methods
                ReadPaymentMethod200Response result = apiInstance.ReadPaymentMethod(readPaymentMethodRequest, contentType, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadPaymentMethod: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadPaymentMethodWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Loads all available payment methods
    ApiResponse<ReadPaymentMethod200Response> response = apiInstance.ReadPaymentMethodWithHttpInfo(readPaymentMethodRequest, contentType, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadPaymentMethodWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **readPaymentMethodRequest** | [**ReadPaymentMethodRequest**](ReadPaymentMethodRequest.md) |  |  |
| **contentType** | **string** | Content type of the request | [default to &quot;application/json&quot;] |
| **accept** | **string** | Accepted response content types | [default to &quot;application/json&quot;] |

### Return type

[**ReadPaymentMethod200Response**](ReadPaymentMethod200Response.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="readproduct"></a>
# **ReadProduct**
> ReadProduct200Response ReadProduct (string contentType, string accept, ReadCustomerRequest? readCustomerRequest = null)

Fetch a list of products

List products that match the given criteria. For performance ressons a limit should always be set.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class ReadProductExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new EndpointsSupportingCriteriaApi(config);
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")
            var readCustomerRequest = new ReadCustomerRequest?(); // ReadCustomerRequest? |  (optional) 

            try
            {
                // Fetch a list of products
                ReadProduct200Response result = apiInstance.ReadProduct(contentType, accept, readCustomerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch a list of products
    ApiResponse<ReadProduct200Response> response = apiInstance.ReadProductWithHttpInfo(contentType, accept, readCustomerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadProductWithHttpInfo: " + e.Message);
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

[**ReadProduct200Response**](ReadProduct200Response.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Entity search result containing products |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="readproductreviews"></a>
# **ReadProductReviews**
> ReadProductReviews200Response ReadProductReviews (string productId, string contentType, string accept, ReadCustomerRequest? readCustomerRequest = null)

Fetch product reviews

Perform a filtered search for product reviews.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class ReadProductReviewsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new EndpointsSupportingCriteriaApi(config);
            var productId = "productId_example";  // string | Identifier of the product.
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")
            var readCustomerRequest = new ReadCustomerRequest?(); // ReadCustomerRequest? |  (optional) 

            try
            {
                // Fetch product reviews
                ReadProductReviews200Response result = apiInstance.ReadProductReviews(productId, contentType, accept, readCustomerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadProductReviews: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadProductReviewsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch product reviews
    ApiResponse<ReadProductReviews200Response> response = apiInstance.ReadProductReviewsWithHttpInfo(productId, contentType, accept, readCustomerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadProductReviewsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productId** | **string** | Identifier of the product. |  |
| **contentType** | **string** | Content type of the request | [default to &quot;application/json&quot;] |
| **accept** | **string** | Accepted response content types | [default to &quot;application/json&quot;] |
| **readCustomerRequest** | [**ReadCustomerRequest?**](ReadCustomerRequest?.md) |  | [optional]  |

### Return type

[**ReadProductReviews200Response**](ReadProductReviews200Response.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Entity search result containing product reviews |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="readsalutation"></a>
# **ReadSalutation**
> ReadSalutation200Response ReadSalutation (string contentType, string accept, ReadCustomerRequest? readCustomerRequest = null)

Fetch salutations

Perform a filtered search for salutations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class ReadSalutationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new EndpointsSupportingCriteriaApi(config);
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")
            var readCustomerRequest = new ReadCustomerRequest?(); // ReadCustomerRequest? |  (optional) 

            try
            {
                // Fetch salutations
                ReadSalutation200Response result = apiInstance.ReadSalutation(contentType, accept, readCustomerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadSalutation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadSalutationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch salutations
    ApiResponse<ReadSalutation200Response> response = apiInstance.ReadSalutationWithHttpInfo(contentType, accept, readCustomerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadSalutationWithHttpInfo: " + e.Message);
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

[**ReadSalutation200Response**](ReadSalutation200Response.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Entity search result containing salutations. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="readseourl"></a>
# **ReadSeoUrl**
> ReadSeoUrl200Response ReadSeoUrl (string contentType, string accept, ReadCustomerRequest? readCustomerRequest = null)

Fetch SEO routes

Perform a filtered search for seo urls.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class ReadSeoUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new EndpointsSupportingCriteriaApi(config);
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")
            var readCustomerRequest = new ReadCustomerRequest?(); // ReadCustomerRequest? |  (optional) 

            try
            {
                // Fetch SEO routes
                ReadSeoUrl200Response result = apiInstance.ReadSeoUrl(contentType, accept, readCustomerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadSeoUrl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadSeoUrlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch SEO routes
    ApiResponse<ReadSeoUrl200Response> response = apiInstance.ReadSeoUrlWithHttpInfo(contentType, accept, readCustomerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadSeoUrlWithHttpInfo: " + e.Message);
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

[**ReadSeoUrl200Response**](ReadSeoUrl200Response.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/vnd.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Entity search result containing seo urls. |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="readshippingmethod"></a>
# **ReadShippingMethod**
> ReadShippingMethod200Response ReadShippingMethod (string contentType, string accept, bool? onlyAvailable = null, ReadCustomerRequest? readCustomerRequest = null)

Fetch shipping methods

Perform a filtered search for shipping methods.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class ReadShippingMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new EndpointsSupportingCriteriaApi(config);
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")
            var onlyAvailable = true;  // bool? | List only available shipping methods. This filters shipping methods methods which can not be used in the actual context because of their availability rule. (optional) 
            var readCustomerRequest = new ReadCustomerRequest?(); // ReadCustomerRequest? |  (optional) 

            try
            {
                // Fetch shipping methods
                ReadShippingMethod200Response result = apiInstance.ReadShippingMethod(contentType, accept, onlyAvailable, readCustomerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadShippingMethod: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadShippingMethodWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch shipping methods
    ApiResponse<ReadShippingMethod200Response> response = apiInstance.ReadShippingMethodWithHttpInfo(contentType, accept, onlyAvailable, readCustomerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointsSupportingCriteriaApi.ReadShippingMethodWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** | Content type of the request | [default to &quot;application/json&quot;] |
| **accept** | **string** | Accepted response content types | [default to &quot;application/json&quot;] |
| **onlyAvailable** | **bool?** | List only available shipping methods. This filters shipping methods methods which can not be used in the actual context because of their availability rule. | [optional]  |
| **readCustomerRequest** | [**ReadCustomerRequest?**](ReadCustomerRequest?.md) |  | [optional]  |

### Return type

[**ReadShippingMethod200Response**](ReadShippingMethod200Response.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

