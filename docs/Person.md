# FeeWise.Model.Person

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PersonId** | **Guid** |  | [optional] 
**FirstName** | **string** |  | 
**MiddleName** | **string** |  | [optional] 
**LastName** | **string** |  | 
**Title** | **string** |  | 
**Phone** | **string** |  | [optional] 
**NationalId** | **string** | This field may be required to be populated, depending on the region.  For the US , this is the social security number, and is required. For CA, this is the social insurance number.  | [optional] 
**Email** | **string** |  | 
**Address** | [**Address**](Address.md) |  | 
**DateOfBirth** | **DateTime** |  | 
**IsExecutive** | **bool** | Indicates if the individual bears substantial responsibility for controlling, managing, or directing the organization. | 
**IsRepresentative** | **bool** | Representative refers to the designated primary representative of the account, authorized by the business to provide both personal information about themselves and general details about the account. It is essential to note that there can only be one representative assigned to the account at any given time, and during the account creation, this role is typically assigned to the individual responsible for opening the account. | 
**IsDirector** | **bool** | Indicates if the individual is a director of the organization. Directors are typically members of the governing board of the company. | [optional] 
**OwnershipPercentage** | **string** | The percent owned of firm&#39;s legal entity owned by the person. | [optional] 
**SsnLast4** | **string** | The last four digits of the person&#39;s Social Security number, US only | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

