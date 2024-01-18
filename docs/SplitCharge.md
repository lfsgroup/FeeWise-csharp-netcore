# FeeWise.Model.SplitCharge
A Split Charge enables a single payment to be distributed among multiple firm bank accounts. nb: Either the settlement_account_type or the settlement_account_id must be provided in each charge but not both. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SplitChargeId** | **Guid** | This is the uuid of the charge. This will be used for a &#39;GET&#39; of the split charge and in webhooks about this split charge. NB: this is generated and must NOT be supplied when creating a split charge.  | [optional] 
**FirmId** | **Guid** | The firm the charge is being created for. | [optional] 
**Amount** | **string** | The total amount the split charge is for. This amount should match the total for each charge being split. | [optional] 
**Matter** | [**Matter**](Matter.md) |  | [optional] 
**Debtor** | [**Debtor**](Debtor.md) |  | [optional] 
**Charges** | [**List&lt;Charge&gt;**](Charge.md) |  | [optional] 
**Description** | **string** | Description of the split charge. | [optional] 
**PaymentUri** | **string** | The URI to allow the end user to pay the split charges. | [optional] 
**Metadata** | **Dictionary&lt;string, string&gt;** | Set of key value pairs that you can attach to an object. Useful for storing additional information about the object in a structured format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

