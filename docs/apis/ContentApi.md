# ShopwareSharp.Api.ContentApi

All URIs are relative to *http://localhost/store-api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReadCms**](ContentApi.md#readcms) | **POST** /cms/{id} | Fetch and resolve a CMS page |
| [**ReadLandingPage**](ContentApi.md#readlandingpage) | **POST** /landing-page/{landingPageId} | Fetch a landing page with the resolved CMS page |
| [**SendContactMail**](ContentApi.md#sendcontactmail) | **POST** /contact-form | Submit a contact form message |

<a name="readcms"></a>
# **ReadCms**
> CmsPage ReadCms (string id, string contentType, string accept, ReadCmsRequest? readCmsRequest = null)

Fetch and resolve a CMS page

Loads a content management page by its identifier and resolve the slot data. This could be media files, product listing and so on.  **Important notice**  The criteria passed with this route also affects the listing, if there is one within the cms page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class ReadCmsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new ContentApi(config);
            var id = "id_example";  // string | Identifier of the CMS page to be resolved
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")
            var readCmsRequest = new ReadCmsRequest?(); // ReadCmsRequest? |  (optional) 

            try
            {
                // Fetch and resolve a CMS page
                CmsPage result = apiInstance.ReadCms(id, contentType, accept, readCmsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentApi.ReadCms: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadCmsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch and resolve a CMS page
    ApiResponse<CmsPage> response = apiInstance.ReadCmsWithHttpInfo(id, contentType, accept, readCmsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentApi.ReadCmsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the CMS page to be resolved |  |
| **contentType** | **string** | Content type of the request | [default to &quot;application/json&quot;] |
| **accept** | **string** | Accepted response content types | [default to &quot;application/json&quot;] |
| **readCmsRequest** | [**ReadCmsRequest?**](ReadCmsRequest?.md) |  | [optional]  |

### Return type

[**CmsPage**](CmsPage.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/vnd.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The loaded cms page |  -  |
| **404** | Not Found |  -  |

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

            var apiInstance = new ContentApi(config);
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
                Debug.Print("Exception when calling ContentApi.ReadLandingPage: " + e.Message);
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
    Debug.Print("Exception when calling ContentApi.ReadLandingPageWithHttpInfo: " + e.Message);
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

<a name="sendcontactmail"></a>
# **SendContactMail**
> void SendContactMail (SendContactMailRequest sendContactMailRequest, string contentType, string accept)

Submit a contact form message

Used for submitting contact forms. Be aware that there can be more required fields, depending on the system settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class SendContactMailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new ContentApi(config);
            var sendContactMailRequest = new SendContactMailRequest(); // SendContactMailRequest | 
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")

            try
            {
                // Submit a contact form message
                apiInstance.SendContactMail(sendContactMailRequest, contentType, accept);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentApi.SendContactMail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendContactMailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Submit a contact form message
    apiInstance.SendContactMailWithHttpInfo(sendContactMailRequest, contentType, accept);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContentApi.SendContactMailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sendContactMailRequest** | [**SendContactMailRequest**](SendContactMailRequest.md) |  |  |
| **contentType** | **string** | Content type of the request | [default to &quot;application/json&quot;] |
| **accept** | **string** | Accepted response content types | [default to &quot;application/json&quot;] |

### Return type

void (empty response body)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Message sent successful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

