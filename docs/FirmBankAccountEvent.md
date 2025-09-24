# FeeWise.Model.FirmBankAccountEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirmId** | **Guid** |  | [optional] 
**AccountId** | **Guid** |  | [optional] 
**AccountType** | **AccountType** |  | 
**AccountName** | **string** |  | 
**AccountHolderType** | **string** |  | 
**AccountNumber** | **string** |  | 
**BranchCode** | **string** |  | 
**Address** | **string** |  | [optional] 
**Alias** | **string** |  | [optional] 
**Bank** | **string** |  | [optional] 
**CountryCode** | **string** | Two-letter ISO code representing the country the bank account is located in. | 
**LastUpdatedAt** | **DateTime** |  | [optional] 
**Status** | **string** | The status of the bank account. Pending - awaiting validation, Valid - successfully validated, Invalid - bank account number validation failed. | [optional] 
**Metadata** | **Dictionary&lt;string, string&gt;** | Set of key value pairs attached to the object when it was created. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

