# ShopwareSharp.Model.OrderLineItem
Added since version: 6.0.0.0

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**VersionId** | **string** |  | [optional] 
**OrderId** | **string** |  | 
**OrderVersionId** | **string** |  | [optional] 
**ProductId** | **string** |  | [optional] 
**ProductVersionId** | **string** |  | [optional] 
**ParentId** | **string** |  | [optional] 
**ParentVersionId** | **string** |  | [optional] 
**CoverId** | **string** |  | [optional] 
**Identifier** | **string** |  | 
**ReferencedId** | **string** |  | [optional] 
**Quantity** | **long** |  | 
**Label** | **string** |  | 
**Payload** | **Object** |  | [optional] 
**Good** | **bool** |  | [optional] 
**Removable** | **bool** |  | [optional] 
**Stackable** | **bool** |  | [optional] 
**Position** | **long** |  | 
**PriceDefinition** | **Object** |  | [optional] 
**UnitPrice** | **float** |  | [optional] 
**TotalPrice** | **float** |  | [optional] 
**Description** | **string** |  | [optional] 
**Type** | **string** |  | [optional] 
**CustomFields** | **Object** |  | [optional] 
**CreatedAt** | **DateTime** |  | [readonly] 
**UpdatedAt** | **DateTime** |  | [optional] [readonly] 
**Cover** | [**Media**](Media.md) |  | [optional] 
**OrderDeliveryPositions** | [**OrderDeliveryPosition**](OrderDeliveryPosition.md) |  | [optional] 
**Parent** | [**OrderLineItem**](OrderLineItem.md) |  | [optional] 
**Children** | [**OrderLineItem**](OrderLineItem.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

