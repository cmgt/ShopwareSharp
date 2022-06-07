# ShopwareSharp.Api.CategoryApi

All URIs are relative to *http://localhost/store-api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReadCategory**](CategoryApi.md#readcategory) | **POST** /category/{categoryId} | Fetch a single category |
| [**ReadCategoryList**](CategoryApi.md#readcategorylist) | **POST** /category | Fetch a list of categories |
| [**ReadNavigation**](CategoryApi.md#readnavigation) | **POST** /navigation/{requestActiveId}/{requestRootId} | Fetch a navigation menu |

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

            var apiInstance = new CategoryApi(config);
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
                Debug.Print("Exception when calling CategoryApi.ReadCategory: " + e.Message);
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
    Debug.Print("Exception when calling CategoryApi.ReadCategoryWithHttpInfo: " + e.Message);
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

            var apiInstance = new CategoryApi(config);
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
                Debug.Print("Exception when calling CategoryApi.ReadCategoryList: " + e.Message);
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
    Debug.Print("Exception when calling CategoryApi.ReadCategoryListWithHttpInfo: " + e.Message);
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

            var apiInstance = new CategoryApi(config);
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
                Debug.Print("Exception when calling CategoryApi.ReadNavigation: " + e.Message);
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
    Debug.Print("Exception when calling CategoryApi.ReadNavigationWithHttpInfo: " + e.Message);
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

