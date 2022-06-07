# ShopwareSharp.Api.ProfileApi

All URIs are relative to *http://localhost/store-api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChangeEmail**](ProfileApi.md#changeemail) | **POST** /account/change-email | Change the customer&#39;s email address |
| [**ChangePassword**](ProfileApi.md#changepassword) | **POST** /account/change-password | Change the customer&#39;s password |
| [**ChangePaymentMethod**](ProfileApi.md#changepaymentmethod) | **POST** /account/change-payment-method/{paymentMethodId} | Change the customer&#39;s default payment method |
| [**ChangeProfile**](ProfileApi.md#changeprofile) | **POST** /account/change-profile | Change the customer&#39;s information |
| [**DeleteCustomer**](ProfileApi.md#deletecustomer) | **DELETE** /account/customer | Delete the customer&#39;s profile |
| [**ReadCustomer**](ProfileApi.md#readcustomer) | **POST** /account/customer | Get information about current customer |
| [**RecoveryPassword**](ProfileApi.md#recoverypassword) | **POST** /account/recovery-password-confirm | Reset a password with recovery credentials |
| [**SendRecoveryMail**](ProfileApi.md#sendrecoverymail) | **POST** /account/recovery-password | Send a password recovery mail |

<a name="changeemail"></a>
# **ChangeEmail**
> SuccessResponse ChangeEmail (ChangeEmailRequest changeEmailRequest, string contentType, string accept)

Change the customer's email address

Changes a customer's email address to a new email address, using their current password as a validation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class ChangeEmailExample
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

            var apiInstance = new ProfileApi(config);
            var changeEmailRequest = new ChangeEmailRequest(); // ChangeEmailRequest | 
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")

            try
            {
                // Change the customer's email address
                SuccessResponse result = apiInstance.ChangeEmail(changeEmailRequest, contentType, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.ChangeEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChangeEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change the customer's email address
    ApiResponse<SuccessResponse> response = apiInstance.ChangeEmailWithHttpInfo(changeEmailRequest, contentType, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfileApi.ChangeEmailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **changeEmailRequest** | [**ChangeEmailRequest**](ChangeEmailRequest.md) |  |  |
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
| **200** | Returns a success response indicating a successful update |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="changepassword"></a>
# **ChangePassword**
> SuccessResponse ChangePassword (ChangePasswordRequest changePasswordRequest, string contentType, string accept)

Change the customer's password

Changes a customer's password using their current password as a validation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class ChangePasswordExample
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

            var apiInstance = new ProfileApi(config);
            var changePasswordRequest = new ChangePasswordRequest(); // ChangePasswordRequest | 
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")

            try
            {
                // Change the customer's password
                SuccessResponse result = apiInstance.ChangePassword(changePasswordRequest, contentType, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.ChangePassword: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChangePasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change the customer's password
    ApiResponse<SuccessResponse> response = apiInstance.ChangePasswordWithHttpInfo(changePasswordRequest, contentType, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfileApi.ChangePasswordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **changePasswordRequest** | [**ChangePasswordRequest**](ChangePasswordRequest.md) |  |  |
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
| **200** | Returns a success response indicating a successful update. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="changepaymentmethod"></a>
# **ChangePaymentMethod**
> SuccessResponse ChangePaymentMethod (string paymentMethodId, string contentType, string accept)

Change the customer's default payment method

Changes a customer's default (preselected) payment method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class ChangePaymentMethodExample
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

            var apiInstance = new ProfileApi(config);
            var paymentMethodId = "paymentMethodId_example";  // string | Identifier of the desired default payment method
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")

            try
            {
                // Change the customer's default payment method
                SuccessResponse result = apiInstance.ChangePaymentMethod(paymentMethodId, contentType, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.ChangePaymentMethod: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChangePaymentMethodWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change the customer's default payment method
    ApiResponse<SuccessResponse> response = apiInstance.ChangePaymentMethodWithHttpInfo(paymentMethodId, contentType, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfileApi.ChangePaymentMethodWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **paymentMethodId** | **string** | Identifier of the desired default payment method |  |
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
| **200** | Returns a success response indicating a successful update. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="changeprofile"></a>
# **ChangeProfile**
> SuccessResponse ChangeProfile (ChangeProfileRequest changeProfileRequest, string contentType, string accept)

Change the customer's information

Make changes to a customer's account, like changing their name, salutation or title.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class ChangeProfileExample
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

            var apiInstance = new ProfileApi(config);
            var changeProfileRequest = new ChangeProfileRequest(); // ChangeProfileRequest | 
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")

            try
            {
                // Change the customer's information
                SuccessResponse result = apiInstance.ChangeProfile(changeProfileRequest, contentType, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.ChangeProfile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChangeProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change the customer's information
    ApiResponse<SuccessResponse> response = apiInstance.ChangeProfileWithHttpInfo(changeProfileRequest, contentType, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfileApi.ChangeProfileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **changeProfileRequest** | [**ChangeProfileRequest**](ChangeProfileRequest.md) |  |  |
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
| **200** | Returns a success response indicating a successful update |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="deletecustomer"></a>
# **DeleteCustomer**
> void DeleteCustomer (string contentType, string accept)

Delete the customer's profile

Deletes a customer profile along with their addresses, wishlists and associated data. Created orders and their payment/shipping information (addresses) and reviews are not deleted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class DeleteCustomerExample
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

            var apiInstance = new ProfileApi(config);
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")

            try
            {
                // Delete the customer's profile
                apiInstance.DeleteCustomer(contentType, accept);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.DeleteCustomer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCustomerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete the customer's profile
    apiInstance.DeleteCustomerWithHttpInfo(contentType, accept);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfileApi.DeleteCustomerWithHttpInfo: " + e.Message);
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

void (empty response body)

### Authorization

[ApiKey](../README.md#ApiKey), [ContextToken](../README.md#ContextToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Returns a no content response indicating a successful removal of the customer profile |  -  |

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

            var apiInstance = new ProfileApi(config);
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
                Debug.Print("Exception when calling ProfileApi.ReadCustomer: " + e.Message);
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
    Debug.Print("Exception when calling ProfileApi.ReadCustomerWithHttpInfo: " + e.Message);
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

<a name="recoverypassword"></a>
# **RecoveryPassword**
> SuccessResponse RecoveryPassword (RecoveryPasswordRequest recoveryPasswordRequest, string contentType, string accept)

Reset a password with recovery credentials

This operation is Step 2 of the password reset flow. It is required to conduct Step 1 \"Send a password recovery mail\" in order to obtain the required credentials for this step.  Resets a customer's password using credentials from a password recovery mail as a validation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class RecoveryPasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new ProfileApi(config);
            var recoveryPasswordRequest = new RecoveryPasswordRequest(); // RecoveryPasswordRequest | 
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")

            try
            {
                // Reset a password with recovery credentials
                SuccessResponse result = apiInstance.RecoveryPassword(recoveryPasswordRequest, contentType, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.RecoveryPassword: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RecoveryPasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reset a password with recovery credentials
    ApiResponse<SuccessResponse> response = apiInstance.RecoveryPasswordWithHttpInfo(recoveryPasswordRequest, contentType, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfileApi.RecoveryPasswordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recoveryPasswordRequest** | [**RecoveryPasswordRequest**](RecoveryPasswordRequest.md) |  |  |
| **contentType** | **string** | Content type of the request | [default to &quot;application/json&quot;] |
| **accept** | **string** | Accepted response content types | [default to &quot;application/json&quot;] |

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a success response indicating a successful update. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a name="sendrecoverymail"></a>
# **SendRecoveryMail**
> SuccessResponse SendRecoveryMail (SendRecoveryMailRequest sendRecoveryMailRequest, string contentType, string accept)

Send a password recovery mail

This operation is Step 1 of the password reset flow. Make sure to implement Step 2 \"Reset password with recovery credentials\" in order to allow for the complete flow in your application  Sends a recovery mail containing a link with credentials that allows a customer to reset their password.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class SendRecoveryMailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.AddApiKey("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sw-access-key", "Bearer");

            var apiInstance = new ProfileApi(config);
            var sendRecoveryMailRequest = new SendRecoveryMailRequest(); // SendRecoveryMailRequest | 
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")

            try
            {
                // Send a password recovery mail
                SuccessResponse result = apiInstance.SendRecoveryMail(sendRecoveryMailRequest, contentType, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfileApi.SendRecoveryMail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendRecoveryMailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send a password recovery mail
    ApiResponse<SuccessResponse> response = apiInstance.SendRecoveryMailWithHttpInfo(sendRecoveryMailRequest, contentType, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfileApi.SendRecoveryMailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sendRecoveryMailRequest** | [**SendRecoveryMailRequest**](SendRecoveryMailRequest.md) |  |  |
| **contentType** | **string** | Content type of the request | [default to &quot;application/json&quot;] |
| **accept** | **string** | Accepted response content types | [default to &quot;application/json&quot;] |

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | If email corresponds to an existing customer, a mail will be sent out to that customer containing a link assembled using the following schema:  Returns a success indicating a successful initialisation of the reset flow. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

