# ShopwareSharp.Model.ChangeProfileRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SalutationId** | **string** | Id of the salutation for the customer account. Fetch options using &#x60;salutation&#x60; endpoint. | 
**Title** | **string** | (Academic) title of the customer | [optional] 
**FirstName** | **string** | Customer first name. Value will be reused for shipping and billing address if not provided explicitly. | 
**LastName** | **string** | Customer last name. Value will be reused for shipping and billing address if not provided explicitly. | 
**Company** | **string** | Company of the customer. Only required when &#x60;accountType&#x60; is &#x60;business&#x60;. | [optional] 
**BirthdayDay** | **int** | Birthday day | [optional] 
**BirthdayMonth** | **int** | Birthday month | [optional] 
**BirthdayYear** | **int** | Birthday year | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

