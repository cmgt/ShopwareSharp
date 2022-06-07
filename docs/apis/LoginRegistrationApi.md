# ShopwareSharp.Api.LoginRegistrationApi

All URIs are relative to *http://localhost/store-api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCustomerGroupRegistrationInfo**](LoginRegistrationApi.md#getcustomergroupregistrationinfo) | **GET** /customer-group-registration/config/{customerGroupId} | Fetch registration settings for customer group |
| [**LoginCustomer**](LoginRegistrationApi.md#logincustomer) | **POST** /account/login | Log in a customer |
| [**LogoutCustomer**](LoginRegistrationApi.md#logoutcustomer) | **POST** /account/logout | Log out a customer |
| [**Register**](LoginRegistrationApi.md#register) | **POST** /account/register | Register a customer |
| [**RegisterConfirm**](LoginRegistrationApi.md#registerconfirm) | **POST** /account/register-confirm | Confirm a customer registration |

<a name="getcustomergroupregistrationinfo"></a>
# **GetCustomerGroupRegistrationInfo**
> CustomerGroup GetCustomerGroupRegistrationInfo (string customerGroupId, string contentType, string accept)

Fetch registration settings for customer group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class GetCustomerGroupRegistrationInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new LoginRegistrationApi(config);
            var customerGroupId = "customerGroupId_example";  // string | Customer group id
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")

            try
            {
                // Fetch registration settings for customer group
                CustomerGroup result = apiInstance.GetCustomerGroupRegistrationInfo(customerGroupId, contentType, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoginRegistrationApi.GetCustomerGroupRegistrationInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomerGroupRegistrationInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch registration settings for customer group
    ApiResponse<CustomerGroup> response = apiInstance.GetCustomerGroupRegistrationInfoWithHttpInfo(customerGroupId, contentType, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoginRegistrationApi.GetCustomerGroupRegistrationInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customerGroupId** | **string** | Customer group id |  |
| **contentType** | **string** | Content type of the request | [default to &quot;application/json&quot;] |
| **accept** | **string** | Accepted response content types | [default to &quot;application/json&quot;] |

### Return type

[**CustomerGroup**](CustomerGroup.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the customer group including registration settings. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="logincustomer"></a>
# **LoginCustomer**
> ContextTokenResponse LoginCustomer (LoginCustomerRequest loginCustomerRequest, string contentType, string accept)

Log in a customer

Logs in customers given their credentials.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class LoginCustomerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new LoginRegistrationApi(config);
            var loginCustomerRequest = new LoginCustomerRequest(); // LoginCustomerRequest | 
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")

            try
            {
                // Log in a customer
                ContextTokenResponse result = apiInstance.LoginCustomer(loginCustomerRequest, contentType, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoginRegistrationApi.LoginCustomer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoginCustomerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Log in a customer
    ApiResponse<ContextTokenResponse> response = apiInstance.LoginCustomerWithHttpInfo(loginCustomerRequest, contentType, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoginRegistrationApi.LoginCustomerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loginCustomerRequest** | [**LoginCustomerRequest**](LoginCustomerRequest.md) |  |  |
| **contentType** | **string** | Content type of the request | [default to &quot;application/json&quot;] |
| **accept** | **string** | Accepted response content types | [default to &quot;application/json&quot;] |

### Return type

[**ContextTokenResponse**](ContextTokenResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful login returns a context token which is associated with the logged in user. Use that as your &#x60;sw-context-token&#x60; header for subsequent requests. |  -  |
| **401** | If credentials are incorrect an error is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="logoutcustomer"></a>
# **LogoutCustomer**
> ContextTokenResponse LogoutCustomer (string contentType, string accept)

Log out a customer

Logs out a customer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class LogoutCustomerExample
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

            var apiInstance = new LoginRegistrationApi(config);
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")

            try
            {
                // Log out a customer
                ContextTokenResponse result = apiInstance.LogoutCustomer(contentType, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoginRegistrationApi.LogoutCustomer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogoutCustomerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Log out a customer
    ApiResponse<ContextTokenResponse> response = apiInstance.LogoutCustomerWithHttpInfo(contentType, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoginRegistrationApi.LogoutCustomerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** | Content type of the request | [default to &quot;application/json&quot;] |
| **accept** | **string** | Accepted response content types | [default to &quot;application/json&quot;] |

### Return type

[**ContextTokenResponse**](ContextTokenResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey), [ContextToken](../README.md#ContextToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful logout returns a context token for the anonymous user. Use that as your &#x60;sw-context-token&#x60; header for subsequent requests. |  -  |
| **403** | If the user is not logged in, a 403 error is returned. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="register"></a>
# **Register**
> Customer Register (RegisterRequest registerRequest, string contentType, string accept)

Register a customer

Registers a customer. Used both for normal customers and guest customers.  See the Guide \"Register a customer\" for more information on customer registration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class RegisterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new LoginRegistrationApi(config);
            var registerRequest = new RegisterRequest(); // RegisterRequest | 
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")

            try
            {
                // Register a customer
                Customer result = apiInstance.Register(registerRequest, contentType, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoginRegistrationApi.Register: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RegisterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Register a customer
    ApiResponse<Customer> response = apiInstance.RegisterWithHttpInfo(registerRequest, contentType, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoginRegistrationApi.RegisterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **registerRequest** | [**RegisterRequest**](RegisterRequest.md) |  |  |
| **contentType** | **string** | Content type of the request | [default to &quot;application/json&quot;] |
| **accept** | **string** | Accepted response content types | [default to &quot;application/json&quot;] |

### Return type

[**Customer**](Customer.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="registerconfirm"></a>
# **RegisterConfirm**
> void RegisterConfirm (RegisterConfirmRequest registerConfirmRequest, string contentType, string accept)

Confirm a customer registration

Confirms a customer registration when double opt-in is activated.  Learn more about double opt-in registration in our guide \"Register a customer\".

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class RegisterConfirmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new LoginRegistrationApi(config);
            var registerConfirmRequest = new RegisterConfirmRequest(); // RegisterConfirmRequest | 
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")

            try
            {
                // Confirm a customer registration
                apiInstance.RegisterConfirm(registerConfirmRequest, contentType, accept);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoginRegistrationApi.RegisterConfirm: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RegisterConfirmWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Confirm a customer registration
    apiInstance.RegisterConfirmWithHttpInfo(registerConfirmRequest, contentType, accept);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoginRegistrationApi.RegisterConfirmWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **registerConfirmRequest** | [**RegisterConfirmRequest**](RegisterConfirmRequest.md) |  |  |
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
| **200** | Returns the logged in customer. The customer is automatically logged in with the &#x60;sw-context-token&#x60; header provided, which can be reused for subsequent requests. |  -  |
| **404** | No hash provided |  -  |
| **412** | The customer has already been confirmed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

