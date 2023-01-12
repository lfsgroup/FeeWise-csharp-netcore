# FeeWise.Model.Statement
Parameters for generating a statement of account. The statement of account will include Invoices and Trust Deposits that match the provided information

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirmId** | **Guid** | The FeeWise Firm ID. | 
**ExternalMatterId** | **string** | The ID of a matter from the calling system. See external_id field in &#39;#/components/schemas/Matter&#39; | [optional] 
**ExternalDebtorId** | **string** | The ID of a debtor from the calling system. See external_id field in &#39;#/components/schemas/Debtor&#39; | 
**EndDate** | **DateTime** | an optional end date for retrieving Invoices or Trust Deposits. Will retrieve anything created on or before this date. | [optional] 
**StartDate** | **DateTime** | an optional start date for retrieving Invoices or Trust Deposits. Will retrieve anything created on or after this date. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

