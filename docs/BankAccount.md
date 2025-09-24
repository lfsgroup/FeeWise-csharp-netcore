# FeeWise.Model.BankAccount

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **Guid** | The FeeWise ID of the bank account, do not use when creating an account. | [optional] 
**AccountType** | **AccountType** |  | 
**AccountName** | **string** | The name attached to the bank account. | 
**AccountHolderType** | **string** | The type of account holder. | 
**AccountNumber** | **string** | The firm&#39;s bank account number. | 
**BranchCode** | **string** | The bank&#39;s branch code. | 
**Address** | **string** | The bank&#39;s address. | [optional] 
**Alias** | **string** | The name of the account for the Firm, as it will be displayed in the FeeWise firm app. | [optional] 
**Bank** | **string** | Name of the bank | [optional] 
**CountryCode** | **string** | Two-letter ISO code representing the country the bank account is located in. | 
**IsDefault** | **bool** | Will be set to true, if the account is the default for this type (e.g. Office, Trust) | [optional] 
**DefaultAccounts** | **List&lt;BankAccount.DefaultAccountsEnum&gt;** | The account types this account is the default for (eg the account could be the default for both Billing and Office) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

