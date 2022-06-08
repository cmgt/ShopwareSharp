# ShopwareSharp.Model.SendContactMailRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SalutationId** | **string** | Identifier of the salutation. Use &#x60;/api/salutation&#x60; endpoint to fetch possible values. | 
**FirstName** | **string** | Firstname. This field may be required depending on the system settings. | [optional] 
**LastName** | **string** | Lastname. This field may be required depending on the system settings. | [optional] 
**Email** | **string** | Email address | 
**Phone** | **string** | Phone. This field may be required depending on the system settings. | [optional] 
**Subject** | **string** | The subject of the contact form. | 
**Comment** | **string** | The message of the contact form | 
**NavigationId** | **string** | Identifier of the navigation page. Can be used to override the configuration. Take a look at the settings of a category containing a concact form in the administration. | [optional] 
**SlotId** | **string** | Identifier of the cms element | [optional] 
**CmsPageType** | **string** | Type of the content management page | [optional] 
**EntityName** | **string** | Entity name for slot config | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

