# ShopwareSharp.Api.PaymentShippingApi

All URIs are relative to *http://localhost/store-api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HandlePaymentMethod**](PaymentShippingApi.md#handlepaymentmethod) | **POST** /handle-payment | Initiate a payment for an order |
| [**ReadShippingMethod**](PaymentShippingApi.md#readshippingmethod) | **POST** /shipping-method | Fetch shipping methods |

<a name="handlepaymentmethod"></a>
# **HandlePaymentMethod**
> void HandlePaymentMethod (string contentType, string accept, HandlePaymentMethodRequest handlePaymentMethodRequest)

Initiate a payment for an order

This generic endpoint is should be called to initiate a payment flow after an order has been created. The details of the payment flow can differ depending on the payment integration and might require calling additional operations or the setup of webhooks.  The endpoint internally calls the payment handler of the payment method currently set for the order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class HandlePaymentMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PaymentShippingApi(httpClient, config, httpClientHandler);
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")
            var handlePaymentMethodRequest = new HandlePaymentMethodRequest(); // HandlePaymentMethodRequest | 

            try
            {
                // Initiate a payment for an order
                apiInstance.HandlePaymentMethod(contentType, accept, handlePaymentMethodRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentShippingApi.HandlePaymentMethod: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HandlePaymentMethodWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Initiate a payment for an order
    apiInstance.HandlePaymentMethodWithHttpInfo(contentType, accept, handlePaymentMethodRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentShippingApi.HandlePaymentMethodWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** | Content type of the request | [default to &quot;application/json&quot;] |
| **accept** | **string** | Accepted response content types | [default to &quot;application/json&quot;] |
| **handlePaymentMethodRequest** | [**HandlePaymentMethodRequest**](HandlePaymentMethodRequest.md) |  |  |

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
| **200** | Redirect to external payment provider |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readshippingmethod"></a>
# **ReadShippingMethod**
> ReadShippingMethod200Response ReadShippingMethod (string contentType, string accept, bool? onlyAvailable = null, ReadCustomerRequest? readCustomerRequest = null)

Fetch shipping methods

Perform a filtered search for shipping methods.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
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

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PaymentShippingApi(httpClient, config, httpClientHandler);
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
                Debug.Print("Exception when calling PaymentShippingApi.ReadShippingMethod: " + e.Message);
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
    Debug.Print("Exception when calling PaymentShippingApi.ReadShippingMethodWithHttpInfo: " + e.Message);
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

