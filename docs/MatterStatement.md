# FeeWise.Model.MatterStatement

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Matter** | [**Matter**](Matter.md) |  | 
**FirmId** | **Guid** | The firm the invoice is raised for. | 
**Debtor** | [**Debtor**](Debtor.md) |  | 
**Artifacts** | [**List&lt;Artifact&gt;**](Artifact.md) |  | 
**PaymentUrl** | **string** | The URI to get the client payment instructions for this matter statement | 
**PdfUrl** | **string** | The URI to get the client payment instructions for this matter statement. The url will be embedded into PDF invoices and will always resolve to the &#x60;complex&#x60; (detailed) matter statement payment view   | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

