# FeeWise.Model.ExternalPayment
A payment that was made outside of the FeeWise platform.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ArtifactId** | **Guid** | The artifact (Invoice, TrustDeposit, ...) the payment is in relation to. | 
**ArtifactType** | **ArtifactType** |  | 
**Amount** | **string** | The amount of the external payment | 
**PaymentType** | **string** | Freeform description of the type (eg visa, amex, cash, bank transfer) | [optional] 
**ExternalId** | **string** | An ID, external to FeeWise, to identify the payment | [optional] 
**Details** | **string** | Freeform description of the payment (eg \&quot;Paid in person with cash - receipt GB-6832\&quot; ) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

