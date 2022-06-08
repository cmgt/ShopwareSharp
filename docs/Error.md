# ShopwareSharp.Model.Error

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for this particular occurrence of the problem. | [optional] 
**Links** | [**Dictionary&lt;string, Link&gt;**](Link.md) |  | [optional] 
**Status** | **string** | The HTTP status code applicable to this problem, expressed as a string value. | [optional] 
**Code** | **string** | An application-specific error code, expressed as a string value. | [optional] 
**Title** | **string** | A short, human-readable summary of the problem. It **SHOULD NOT** change from occurrence to occurrence of the problem, except for purposes of localization. | [optional] 
**Detail** | **string** | A human-readable explanation specific to this occurrence of the problem. | [optional] 
**Source** | [**ErrorSource**](ErrorSource.md) |  | [optional] 
**Meta** | **Dictionary&lt;string, Object&gt;** | Non-standard meta-information that can not be represented as an attribute or relationship. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

