# ShopwareSharp.Model.OrderDelivery
Added since version: 6.0.0.0

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **string** |  | 
**ShippingOrderAddressId** | **string** |  | 
**ShippingMethodId** | **string** |  | 
**StateId** | **string** |  | 
**TrackingCodes** | **List&lt;string&gt;** |  | 
**ShippingDateEarliest** | **DateTime** |  | 
**ShippingDateLatest** | **DateTime** |  | 
**CreatedAt** | **DateTime** |  | [readonly] 
**Id** | **string** |  | [optional] 
**VersionId** | **string** |  | [optional] 
**OrderVersionId** | **string** |  | [optional] 
**ShippingOrderAddressVersionId** | **string** |  | [optional] 
**ShippingCosts** | [**OrderShippingCosts**](OrderShippingCosts.md) |  | [optional] 
**CustomFields** | **Object** |  | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] [readonly] 
**StateMachineState** | [**StateMachineState**](StateMachineState.md) |  | [optional] 
**ShippingOrderAddress** | [**OrderAddress**](OrderAddress.md) |  | [optional] 
**ShippingMethod** | [**ShippingMethod**](ShippingMethod.md) |  | [optional] 
**Positions** | [**OrderDeliveryPosition**](OrderDeliveryPosition.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

