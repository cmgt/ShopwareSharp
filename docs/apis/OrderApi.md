# ShopwareSharp.Api.OrderApi

All URIs are relative to *http://localhost/store-api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelOrder**](OrderApi.md#cancelorder) | **POST** /order/state/cancel | Cancel an order |
| [**CreateOrder**](OrderApi.md#createorder) | **POST** /checkout/order | Create an order from a cart |
| [**OrderSetPayment**](OrderApi.md#ordersetpayment) | **POST** /order/payment | Update the payment method of an order |
| [**ReadOrder**](OrderApi.md#readorder) | **POST** /order | Fetch a list of orders |

<a name="cancelorder"></a>
# **CancelOrder**
> StateMachineState CancelOrder (CancelOrderRequest cancelOrderRequest, string contentType, string accept)

Cancel an order

Cancels an order. The order state will be set to 'cancelled'.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class CancelOrderExample
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

            var apiInstance = new OrderApi(config);
            var cancelOrderRequest = new CancelOrderRequest(); // CancelOrderRequest | 
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")

            try
            {
                // Cancel an order
                StateMachineState result = apiInstance.CancelOrder(cancelOrderRequest, contentType, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.CancelOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel an order
    ApiResponse<StateMachineState> response = apiInstance.CancelOrderWithHttpInfo(cancelOrderRequest, contentType, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.CancelOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cancelOrderRequest** | [**CancelOrderRequest**](CancelOrderRequest.md) |  |  |
| **contentType** | **string** | Content type of the request | [default to &quot;application/json&quot;] |
| **accept** | **string** | Accepted response content types | [default to &quot;application/json&quot;] |

### Return type

[**StateMachineState**](StateMachineState.md)

### Authorization

[ApiKey](../README.md#ApiKey), [ContextToken](../README.md#ContextToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the state of the state machine  example: More information about the state machine can be found in the corresponding guide: [Using the state machine](https://developer.shopware.com/docs/guides/plugins/plugins/checkout/order/using-the-state-machine) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="createorder"></a>
# **CreateOrder**
> Order CreateOrder (string contentType, string accept, CreateOrderRequest? createOrderRequest = null)

Create an order from a cart

Creates a new order from the current cart and deletes the cart.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class CreateOrderExample
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

            var apiInstance = new OrderApi(config);
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")
            var createOrderRequest = new CreateOrderRequest?(); // CreateOrderRequest? |  (optional) 

            try
            {
                // Create an order from a cart
                Order result = apiInstance.CreateOrder(contentType, accept, createOrderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.CreateOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an order from a cart
    ApiResponse<Order> response = apiInstance.CreateOrderWithHttpInfo(contentType, accept, createOrderRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.CreateOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** | Content type of the request | [default to &quot;application/json&quot;] |
| **accept** | **string** | Accepted response content types | [default to &quot;application/json&quot;] |
| **createOrderRequest** | [**CreateOrderRequest?**](CreateOrderRequest?.md) |  | [optional]  |

### Return type

[**Order**](Order.md)

### Authorization

[ApiKey](../README.md#ApiKey), [ContextToken](../README.md#ContextToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="ordersetpayment"></a>
# **OrderSetPayment**
> SuccessResponse OrderSetPayment (OrderSetPaymentRequest orderSetPaymentRequest, string contentType, string accept)

Update the payment method of an order

Changes the payment method of a specific order. You can use the /order route to find out if the payment method of an order can be changed - take a look at the `paymentChangeable`- array in the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class OrderSetPaymentExample
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

            var apiInstance = new OrderApi(config);
            var orderSetPaymentRequest = new OrderSetPaymentRequest(); // OrderSetPaymentRequest | 
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")

            try
            {
                // Update the payment method of an order
                SuccessResponse result = apiInstance.OrderSetPayment(orderSetPaymentRequest, contentType, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderSetPayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderSetPaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the payment method of an order
    ApiResponse<SuccessResponse> response = apiInstance.OrderSetPaymentWithHttpInfo(orderSetPaymentRequest, contentType, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderSetPaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderSetPaymentRequest** | [**OrderSetPaymentRequest**](OrderSetPaymentRequest.md) |  |  |
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
| **200** | Successfully updated the payment method of the order. |  -  |

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

            var apiInstance = new OrderApi(config);
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
                Debug.Print("Exception when calling OrderApi.ReadOrder: " + e.Message);
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
    Debug.Print("Exception when calling OrderApi.ReadOrderWithHttpInfo: " + e.Message);
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

