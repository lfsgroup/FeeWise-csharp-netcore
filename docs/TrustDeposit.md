# FeeWise.Model.TrustDeposit
A TrustDeposit is created to request payment into a Trust account 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TrustDepositId** | **Guid** | This is the uuid of the Trust Deposit. This will be used for any &#39;GET&#39; of the Trust Deposit and in webhooks about this Trust Deposit NB this is generated and must not be supplied when creating a Trust Deposit.  | [optional] 
**FirmId** | **Guid** | The firm the trust deposit is raised for. | 
**Matter** | [**Matter**](Matter.md) |  | [optional] 
**Debtor** | [**Debtor**](Debtor.md) |  | [optional] 
**ExternalId** | **string** | This is the id supplied by the channel partner / PMS and can be used for filtering trust deposits. This should be unique for the PMS but this is not enforced. | 
**ExternalReference** | **string** | This a reference supplied by the channel partner / PMS and can be used for filtering trust deposits. | [optional] 
**Amount** | **string** | The total amount the trust deposit is for. | 
**AmountDue** | **string** | The total amount outstanding on this trust deposit. | [optional] 
**Currency** | **Currency** |  | [optional] 
**DueDate** | **DateTime** |  | [optional] 
**LineItems** | [**List&lt;LineItem&gt;**](LineItem.md) |  | [optional] 
**Notes** | **List&lt;string&gt;** | Freeform notes on the trust deposit | [optional] 
**Payments** | [**List&lt;Payment&gt;**](Payment.md) | List of payments made against this trust deposit. | [optional] 
**SettlementAccountId** | **Guid** | The id of the account the trust deposit should be paid to.  If not supplied, the default trust deposit for the firm will be used  | [optional] 
**PaymentMethodsOverride** | [**List&lt;PaymentMethod&gt;**](PaymentMethod.md) |  | [optional] 
**SurchargeChoiceOverride** | **SurchargeChoice** |  | [optional] 
**Description** | **string** | Freeform text for channel partner / PMS. | [optional] 
**PaymentUri** | **string** | The URI to send to customer.    They will follow this link to make a payment.    NB This must not be set when creating an invoice.  | [optional] 
**Status** | **string** | The status of the trust deposit. This must not be set when creating an trust deposit. | [optional] 
**ArtifactSubtype** | **ArtifactSubtype** |  | [optional] 
**CreatedAt** | **DateTime** | The date the partner created the artifact. | [optional] 
**SourceId** | **string** | The source ID that was passed in when creating the artifact. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

