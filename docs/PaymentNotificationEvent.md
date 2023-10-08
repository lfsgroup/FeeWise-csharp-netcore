# FeeWise.Model.PaymentNotificationEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Artifacts** | [**List&lt;ArtifactReceipt&gt;**](ArtifactReceipt.md) |  | 
**PaymentId** | **Guid** | The payment ID | 
**AmountPaid** | **string** | The amount paid | 
**CardPayment** | [**CardPayment**](CardPayment.md) |  | [optional] 
**DebitPayment** | [**DebitPayment**](DebitPayment.md) |  | [optional] 
**FirmId** | **Guid** | The firm ID | 
**PaymentMethod** | **PaymentMethod** |  | 
**PaymentMethodDetail** | **string** | The payment method detail | [optional] 
**PaymentStatus** | **string** | The status of the payment. Card payments have either a Successful or Failed status. Direct Debit payments can have a Processing, Successful or Failed status. | 
**FailureMessage** | **string** | When the payment_status is Failed this will show the reason for payment failure. E.g. Card does not have sufficient funds. | [optional] 
**Metadata** | **Dictionary&lt;string, string&gt;** | Set of key value pairs attached to the payment object when it was created. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

