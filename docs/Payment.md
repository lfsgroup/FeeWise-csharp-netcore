# FeeWise.Model.Payment
Describes a payment coming into the system (client of a firm paying an invoice, trust deposit, ...)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **Guid** | The unique id of this single transaction in the payout. | 
**PaymentId** | **Guid** | The id of the payment. nb A single payment may contain multiple transactions and may not be unique. | 
**PaymentType** | **PaymentMethod** |  | [optional] 
**ArtifactId** | **Guid** | The artifact (Invoice, TrustDeposit, ...) the payment is in relation to. | 
**ArtifactType** | **ArtifactType** |  | 
**ExternalId** | **string** | This is the id of the artifact supplied by the channel partner / PMS. | [optional] 
**ExternalPayment** | [**PaymentExternalPayment**](PaymentExternalPayment.md) |  | [optional] 
**Received** | **string** | The amount received from the client. | [optional] 
**Refunded** | **string** | The amount refunded (back to the client) against this payment. | [optional] 
**PaidOut** | **string** | The total amount paid to the firm for this payment | 
**Currency** | **string** | The currency the payment was made in. | 
**Date** | **DateTime** | When the payment was made. | 
**Metadata** | **Dictionary&lt;string, string&gt;** | metadata that the partner has attached to the original artifact (charge, invoice, trust deposit, etc) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

