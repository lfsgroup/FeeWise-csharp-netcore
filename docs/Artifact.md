# FeeWise.Model.Artifact
An Artifact can be an Invoice or a Trust Deposit. An Artifact is created to request payment. One of settlement_account_type or settlement_account_id must be specified but not both. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ArtifactId** | **Guid** | This is the uuid of the artifact. This will be used for and &#39;GET&#39; of the artifact and in webhooks about this artifact NB this is generated and must not be supplied when creating an artifact.  | [optional] 
**ArtifactType** | **ArtifactType** |  | 
**ExternalId** | **string** | This is the id supplied by the channel partner / PMS and can be used for filtering artifacts. This should be unique for the PMS but this is not enforced. | 
**ExternalReference** | **string** | This a reference supplied by the channel partner / PMS and can be used for filtering artifacts. | [optional] 
**Amount** | **string** | The total amount the artifact is for. | 
**AmountDue** | **string** | The total amount outstanding on this artifact. | [optional] 
**Currency** | **Currency** |  | [optional] 
**DueDate** | **DateTime** |  | [optional] 
**SettlementAccountType** | **AccountType** |  | [optional] 
**SettlementAccountId** | **Guid** | The id of the account the artifact settlement should be paid to.  NB, if both the settlement_account_type and settlement_account_id are specified, it is a bad request  | [optional] 
**LineItems** | [**List&lt;LineItem&gt;**](LineItem.md) |  | [optional] 
**Notes** | **List&lt;string&gt;** | Freeform notes on the artifact | [optional] 
**Payments** | [**List&lt;Payment&gt;**](Payment.md) | List of payments made against this artifact | [optional] 
**PaymentMethodsOverride** | [**List&lt;PaymentMethod&gt;**](PaymentMethod.md) |  | [optional] 
**SurchargeChoiceOverride** | **SurchargeChoice** |  | [optional] 
**Description** | **string** | Freeform text for API user. | [optional] 
**Status** | **string** | The status of the artifact | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

