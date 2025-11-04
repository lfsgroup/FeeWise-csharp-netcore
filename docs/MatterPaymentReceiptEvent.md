# FeeWise.Model.MatterPaymentReceiptEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Artifacts** | [**List&lt;ArtifactReceipt&gt;**](ArtifactReceipt.md) |  | 
**PaymentId** | **Guid** | The payment ID | 
**AmountPaid** | **string** | The amount paid | 
**PaymentDate** | **DateTime** |  | 
**CardPayment** | [**CardPayment**](CardPayment.md) |  | [optional] 
**DebitPayment** | [**DebitPayment**](DebitPayment.md) |  | [optional] 
**FirmId** | **Guid** | The firm ID | 
**ExternalFirmId** | **string** | The firm ID from the partner&#39;s system | 
**PaymentMethod** | **PaymentMethod** |  | 
**PaymentMethodDetail** | **string** | The payment method detail | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

