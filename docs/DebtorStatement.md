# FeeWise.Model.DebtorStatement

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirmId** | **Guid** | The firm the artifact (invoice, trust deposit etc...) is raised for. | 
**Debtor** | [**Debtor**](Debtor.md) |  | 
**Matters** | [**List&lt;MatterSummary&gt;**](MatterSummary.md) |  | [optional] 
**PaymentUrl** | **string** | The URI to get the client payment instructions for this debtor statement | [optional] 
**PdfUrl** | **string** | The URI to get the client payment instructions for this matter statement. The url will be embedded into PDF invoices and will always resolve to the &#x60;complex&#x60; (detailed) matter statement payment view   | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

