# ShopwareSharp.Model.CartAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the cart - for example &#x60;guest-cart&#x60; | [optional] 
**Token** | **string** | Context token identifying the cart and the user session | [optional] 
**Price** | [**CartAllOfPrice**](CartAllOfPrice.md) |  | [optional] 
**LineItems** | [**List&lt;LineItem&gt;**](LineItem.md) | All items within the cart | [optional] 
**Errors** | [**List&lt;CartAllOfErrors&gt;**](CartAllOfErrors.md) | A list of all cart errors, such as insufficient stocks, invalid addresses or vouchers. | [optional] 
**Transactions** | [**List&lt;CartAllOfTransactions&gt;**](CartAllOfTransactions.md) | A list of all payment transactions associated with the current cart. | [optional] 
**Modified** | **bool** |  | [optional] 
**CustomerComment** | **string** | A comment that can be added to the cart. | [optional] 
**AffiliateCode** | **string** | An affiliate tracking code | [optional] 
**CampaignCode** | **string** | A campaign tracking code | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

