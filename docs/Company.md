# FeeWise.Model.Company

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirmId** | **Guid** | Create the company details for a firm. NB the field &#x60;firm_id&#x60;, must NOT be supplied during &#x60;create&#x60;. If supplied, BadResponse will be returned. The firm_id is used by FeeWise to refer to a firm. It is populated once the firm has been created and will be available in the response. (or any GET Firm requests) See external_id  | [optional] 
**ExternalId** | **string** | Allows callers to use their own system id, for the firm. external_id will always be returned in any responses, where a FeeWise Firm is returned. | [optional] 
**LegalName** | **string** |  | 
**LegalIdentifier** | **string** | The identification number given to a company when it is registered or incorporated, if distinct from the identification number used for filing taxes. | [optional] 
**LegalStructure** | **string** | This is a US specific required field. | 
**TaxId** | **string** | The business ID number of the company, as appropriate for the company’s country. Employer ID Number in US, Business Number in CA, Company House Registration Number in UK and Australian Business Number in AU. | 
**TradingName** | **string** |  | 
**Website** | **string** |  | 
**SupportEmail** | **string** |  | [optional] 
**SupportNumber** | **string** |  | [optional] 
**ContactEmail** | **string** |  | 
**ContactNumber** | **string** |  | 
**BillingEmail** | **string** |  | 
**BillingNumber** | **string** |  | [optional] 
**Status** | **FirmOnboardingStatus** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

