# ShopwareSharp.Api.NewsletterApi

All URIs are relative to *http://localhost/store-api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ConfirmNewsletter**](NewsletterApi.md#confirmnewsletter) | **POST** /newsletter/confirm | Confirm a newsletter registration |
| [**SubscribeToNewsletter**](NewsletterApi.md#subscribetonewsletter) | **POST** /newsletter/subscribe | Create or remove a newsletter subscription |
| [**UnsubscribeToNewsletter**](NewsletterApi.md#unsubscribetonewsletter) | **POST** /newsletter/unsubscribe | Remove a newsletter subscription |

<a name="confirmnewsletter"></a>
# **ConfirmNewsletter**
> void ConfirmNewsletter (ConfirmNewsletterRequest confirmNewsletterRequest, string contentType, string accept)

Confirm a newsletter registration

You have to use the hash from the link sent out via email to confirm the user registration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class ConfirmNewsletterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new NewsletterApi(config);
            var confirmNewsletterRequest = new ConfirmNewsletterRequest(); // ConfirmNewsletterRequest | 
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")

            try
            {
                // Confirm a newsletter registration
                apiInstance.ConfirmNewsletter(confirmNewsletterRequest, contentType, accept);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NewsletterApi.ConfirmNewsletter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConfirmNewsletterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Confirm a newsletter registration
    apiInstance.ConfirmNewsletterWithHttpInfo(confirmNewsletterRequest, contentType, accept);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NewsletterApi.ConfirmNewsletterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **confirmNewsletterRequest** | [**ConfirmNewsletterRequest**](ConfirmNewsletterRequest.md) |  |  |
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
| **200** | The newsletter confirmation was successful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="subscribetonewsletter"></a>
# **SubscribeToNewsletter**
> void SubscribeToNewsletter (SubscribeToNewsletterRequest subscribeToNewsletterRequest, string contentType, string accept)

Create or remove a newsletter subscription

This route is used to create/remove/confirm a newsletter subscription.  The `option` property controls what should happen: * `direct`: The subscription is directly active and does not need a confirmation. * `subscribe`: An email will be send to the provided email addrees containing a link to the /newsletter/confirm route. The subscription is only successful, if the /newsletter/confirm route is called with the generated hashes. * `unsubscribe`: The email address will be removed from the newsletter subscriptions. * `confirmSubscribe`: Confirmes the newsletter subscription for the provided email address.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class SubscribeToNewsletterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new NewsletterApi(config);
            var subscribeToNewsletterRequest = new SubscribeToNewsletterRequest(); // SubscribeToNewsletterRequest | 
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")

            try
            {
                // Create or remove a newsletter subscription
                apiInstance.SubscribeToNewsletter(subscribeToNewsletterRequest, contentType, accept);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NewsletterApi.SubscribeToNewsletter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribeToNewsletterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create or remove a newsletter subscription
    apiInstance.SubscribeToNewsletterWithHttpInfo(subscribeToNewsletterRequest, contentType, accept);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NewsletterApi.SubscribeToNewsletterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscribeToNewsletterRequest** | [**SubscribeToNewsletterRequest**](SubscribeToNewsletterRequest.md) |  |  |
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
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="unsubscribetonewsletter"></a>
# **UnsubscribeToNewsletter**
> void UnsubscribeToNewsletter (UnsubscribeToNewsletterRequest unsubscribeToNewsletterRequest, string contentType, string accept)

Remove a newsletter subscription

Removes a newsletter recipient from the mailing lists.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class UnsubscribeToNewsletterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new NewsletterApi(config);
            var unsubscribeToNewsletterRequest = new UnsubscribeToNewsletterRequest(); // UnsubscribeToNewsletterRequest | 
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")

            try
            {
                // Remove a newsletter subscription
                apiInstance.UnsubscribeToNewsletter(unsubscribeToNewsletterRequest, contentType, accept);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NewsletterApi.UnsubscribeToNewsletter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnsubscribeToNewsletterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a newsletter subscription
    apiInstance.UnsubscribeToNewsletterWithHttpInfo(unsubscribeToNewsletterRequest, contentType, accept);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NewsletterApi.UnsubscribeToNewsletterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **unsubscribeToNewsletterRequest** | [**UnsubscribeToNewsletterRequest**](UnsubscribeToNewsletterRequest.md) |  |  |
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
| **200** | Unsubscribing was successful. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

