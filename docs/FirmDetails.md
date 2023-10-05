# FeeWise.Model.FirmDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Company** | [**Company**](Company.md) |  | 
**Address** | [**Address**](Address.md) |  | 
**Accounts** | [**List&lt;BankAccount&gt;**](BankAccount.md) |  | 
**Roles** | [**List&lt;Person&gt;**](Person.md) | Must have one and only one representative.  Representative person is an authorised person who represents the firms. The representative must be either an executive or owner. All owners of the firm with greater that 25% must be specified.  | [optional] 
**TermsOfService** | [**TermsOfService**](TermsOfService.md) |  | [optional] 
**Metadata** | **Dictionary&lt;string, string&gt;** | Set of key value pairs attached to the firm object when it was created. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

