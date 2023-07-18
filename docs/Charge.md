# FeeWise.Model.Charge
A Charge is created to request payment. Either the settlement_account_type or the settlement_account_id must be provided but not both. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChargeId** | **Guid** | This is the uuid of the charge. This will be used for a &#39;GET&#39; of the charge and in webhooks about this charge. NB: this is generated and must not be supplied when creating an charge.  | [optional] 
**FirmId** | **Guid** | The firm the charge is being created for. | [optional] 
**Matter** | [**Matter**](Matter.md) |  | [optional] 
**Debtor** | [**Debtor**](Debtor.md) |  | [optional] 
**ExternalId** | **string** | This is the id supplied by the channel partner / PMS and can be used for filtering charges. This should be unique for the PMS but this is not enforced. | [optional] 
**ExternalReference** | **string** | This a reference supplied by the channel partner / PMS and can be used for filtering charges. | [optional] 
**Amount** | **string** | The total amount the charge is for. | 
**AmountDue** | **string** | The total amount outstanding on this charge. | [optional] 
**Currency** | **Currency** |  | [optional] 
**DueDate** | **DateTime** |  | [optional] 
**SettlementAccountType** | **AccountType** |  | [optional] 
**SettlementAccountId** | **Guid** | The id of the account the charge should be paid to. NB: if both the settlement_account_type and settlement_account_id are specified, it is a bad request.  | [optional] 
**Notes** | **List&lt;string&gt;** | Any notes relevant to the charge. | [optional] 
**PaymentMethodsOverride** | [**List&lt;PaymentMethod&gt;**](PaymentMethod.md) |  | [optional] 
**Description** | **string** | Description of the charge. | [optional] 
**StorePaymentMethods** | [**List&lt;PaymentMethod&gt;**](PaymentMethod.md) | Choose which payment methods to save when the customer pays a charge. | [optional] 
**SurchargeChoiceOverride** | **SurchargeChoice** |  | [optional] 
**PaymentUri** | **string** | The URI to pay the charge. | [optional] 
**Metadata** | **Dictionary&lt;string, string&gt;** | Set of key value pairs that you can attach to an object. Useful for storing additional information about the object in a structured format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

