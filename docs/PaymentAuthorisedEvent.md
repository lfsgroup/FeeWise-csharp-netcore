# FeeWise.Model.PaymentAuthorisedEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Artifacts** | [**List&lt;ArtifactReceipt&gt;**](ArtifactReceipt.md) |  | 
**PaymentId** | **Guid** | The payment ID | 
**AmountPaid** | **string** | The amount paid | 
**CardPayment** | [**CardPayment**](CardPayment.md) |  | [optional] 
**DebitPayment** | [**DebitPayment**](DebitPayment.md) |  | [optional] 
**FirmId** | **Guid** | The firm ID | 
**ExternalFirmId** | **string** | The firm ID from the partner&#39;s system | [optional] 
**SettlementAccountExternalId** | **Guid** | The id of the account the artifact settlement should be paid to, in the partner&#39;s system..  NB, This property is only for the partners reference, only the settlement_account_id property will be used by FeeWise  | [optional] 
**PaymentDate** | **DateTime** | The date the payment was made | [optional] 
**PayerName** | **string** | The name of the payer | [optional] 
**PaymentMethod** | **PaymentMethod** |  | 
**PaymentMethodDetail** | **string** | The payment method detail | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

