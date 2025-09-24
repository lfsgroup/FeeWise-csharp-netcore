# FeeWise.Model.PaymentDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentId** | **Guid** |  | [optional] 
**ArtifactId** | **Guid** |  | [optional] 
**SessionId** | **Guid** |  | [optional] 
**Amount** | **string** |  | [optional] 
**Subtotal** | **string** |  | [optional] 
**Date** | **DateTime** |  | [optional] 
**CustomerFeeAmount** | **string** |  | [optional] 
**CustomerFeePricing** | **string** | the pricing of the customer fee e.g. 2.9% + $0.2 | [optional] 
**PaymentMethod** | **PaymentMethod** |  | [optional] 
**PayerDetails** | [**Payer**](Payer.md) |  | [optional] 
**CardDetails** | [**CardPayment**](CardPayment.md) |  | [optional] 
**DirectDebitDetails** | [**DebitPayment**](DebitPayment.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

