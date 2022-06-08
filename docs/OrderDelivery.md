# ShopwareSharp.Model.OrderDelivery
Added since version: 6.0.0.0

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**VersionId** | **string** |  | [optional] 
**OrderId** | **string** |  | 
**OrderVersionId** | **string** |  | [optional] 
**ShippingOrderAddressId** | **string** |  | 
**ShippingOrderAddressVersionId** | **string** |  | [optional] 
**ShippingMethodId** | **string** |  | 
**StateId** | **string** |  | 
**TrackingCodes** | **List&lt;string&gt;** |  | 
**ShippingDateEarliest** | **DateTime** |  | 
**ShippingDateLatest** | **DateTime** |  | 
**ShippingCosts** | [**OrderShippingCosts**](OrderShippingCosts.md) |  | [optional] 
**CustomFields** | **Object** |  | [optional] 
**CreatedAt** | **DateTime** |  | [readonly] 
**UpdatedAt** | **DateTime** |  | [optional] [readonly] 
**StateMachineState** | [**StateMachineState**](StateMachineState.md) |  | [optional] 
**ShippingOrderAddress** | [**OrderAddress**](OrderAddress.md) |  | [optional] 
**ShippingMethod** | [**ShippingMethod**](ShippingMethod.md) |  | [optional] 
**Positions** | [**OrderDeliveryPosition**](OrderDeliveryPosition.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

