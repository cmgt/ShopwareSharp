# ShopwareSharp.Model.RegisterRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** | Email of the customer. Has to be unique, unless &#x60;guest&#x60; is &#x60;true&#x60; | 
**Password** | **string** | Password for the customer. Required, unless &#x60;guest&#x60; is &#x60;true&#x60; | 
**SalutationId** | **string** | Id of the salutation for the customer account. Fetch options using &#x60;salutation&#x60; endpoint. | 
**FirstName** | **string** | Customer first name. Value will be reused for shipping and billing address if not provided explicitly. | 
**LastName** | **string** | Customer last name. Value will be reused for shipping and billing address if not provided explicitly. | 
**AcceptedDataProtection** | **bool** | Flag indicating accepted data protection | 
**StorefrontUrl** | **string** | URL of the storefront for that registration. Used in confirmation emails. Has to be one of the configured domains of the sales channel. | 
**BillingAddress** | [**CustomerAddress**](CustomerAddress.md) |  | 
**ShippingAddress** | [**CustomerAddress**](CustomerAddress.md) |  | [optional] 
**AccountType** | **string** | Account type of the customer which can be either &#x60;private&#x60; or &#x60;business&#x60;. | [optional] [default to "private"]
**Guest** | **bool** | If set, will create a guest customer. Guest customers can re-use an email address and don&#39;t need a password. | [optional] [default to false]
**BirthdayDay** | **int** | Birthday day | [optional] 
**BirthdayMonth** | **int** | Birthday month | [optional] 
**BirthdayYear** | **int** | Birthday year | [optional] 
**Title** | **string** | (Academic) title of the customer | [optional] 
**AffiliateCode** | **string** | Field can be used to store an affiliate tracking code | [optional] 
**CampaignCode** | **string** | Field can be used to store a campaign tracking code | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

