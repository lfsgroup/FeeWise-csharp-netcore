# FeeWise.Model.CreateChargePaymentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Charge** | [**Charge**](Charge.md) |  | 
**ReviewPayment** | **bool** | When set to true, the endpoint will always return a &#39;402 - Payment requires a review&#39; error response, this can be used to enforce a 2-step payment. When set to false or not present, the &#39;402&#39; will only be returned if there is a surcharge greater than $0 for the payment. | [optional] 
**SessionId** | **Guid** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

