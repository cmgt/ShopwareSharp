# ShopwareSharp.Model.Order
Added since version: 6.0.0.0

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BillingAddressId** | **string** |  | 
**CurrencyId** | **string** |  | 
**LanguageId** | **string** |  | 
**SalesChannelId** | **string** |  | 
**OrderDateTime** | **DateTime** |  | 
**CurrencyFactor** | **float** |  | 
**CreatedAt** | **DateTime** |  | [readonly] 
**Id** | **string** |  | [optional] 
**VersionId** | **string** |  | [optional] 
**OrderNumber** | **string** |  | [optional] 
**BillingAddressVersionId** | **string** |  | [optional] 
**OrderDate** | **string** |  | [optional] [readonly] 
**Price** | [**OrderPrice**](OrderPrice.md) |  | [optional] 
**AmountTotal** | **float** |  | [optional] [readonly] 
**AmountNet** | **float** |  | [optional] [readonly] 
**PositionPrice** | **float** |  | [optional] [readonly] 
**TaxStatus** | **string** |  | [optional] [readonly] 
**ShippingCosts** | [**OrderShippingCosts**](OrderShippingCosts.md) |  | [optional] 
**ShippingTotal** | **float** |  | [optional] [readonly] 
**DeepLinkCode** | **string** |  | [optional] 
**AffiliateCode** | **string** |  | [optional] 
**CampaignCode** | **string** |  | [optional] 
**CustomerComment** | **string** |  | [optional] 
**CustomFields** | **Object** |  | [optional] 
**CreatedById** | **string** |  | [optional] 
**UpdatedById** | **string** |  | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] [readonly] 
**StateMachineState** | [**StateMachineState**](StateMachineState.md) |  | [optional] 
**OrderCustomer** | [**OrderCustomer**](OrderCustomer.md) |  | [optional] 
**Currency** | [**Currency**](Currency.md) |  | [optional] 
**Language** | [**Language**](Language.md) |  | [optional] 
**Addresses** | [**OrderAddress**](OrderAddress.md) |  | [optional] 
**BillingAddress** | [**OrderAddress**](OrderAddress.md) |  | [optional] 
**Deliveries** | [**OrderDelivery**](OrderDelivery.md) |  | [optional] 
**LineItems** | [**OrderLineItem**](OrderLineItem.md) |  | [optional] 
**Transactions** | [**OrderTransaction**](OrderTransaction.md) |  | [optional] 
**Documents** | [**Document**](Document.md) |  | [optional] 
**Tags** | [**Tag**](Tag.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

