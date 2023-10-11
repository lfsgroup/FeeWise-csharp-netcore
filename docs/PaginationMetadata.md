# FeeWise.Model.PaginationMetadata
Metadata about the pagination of a list of objects. Returned in the response body of any paginated list. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestedPage** | **int** | The requested page number | [optional] 
**RequestedPageSize** | **int** | Records per page. | [optional] 
**RequestedFromDate** | **DateTime** | The requested from date | [optional] 
**RequestedToDate** | **DateTime** | The requested to date | [optional] 
**RequestedSortBy** | **string** | Field that the records were requested to be sorted by. | [optional] 
**RequestedStatusFilter** | **List&lt;string&gt;** | Status that the records were requested to be filtered with. | [optional] 
**RequestedAccountIdFilter** | **List&lt;Guid&gt;** | Account IDs that the results were filtered with | [optional] 
**RequestedSortOrder** | **string** | Order the records are sorted by, using the sort_by property | [optional] [default to RequestedSortOrderEnum.Asc]
**CurrentPageStartIndex** | **int** | Index of the first record on the current page.  E.g. To render- Items 1-10, on page 1, 11-20 on page 2, etc.  | [optional] 
**CurrentPageEndIndex** | **int** | Index of the last record on the current page.  E.g. To render- Items 1-10, on page 1, 11-20 on page 2, etc.  | [optional] 
**TotalRecords** | **int** | Total number of records returned. | [optional] 
**TotalPages** | **int** | Total number of pages returned. TODO | [optional] 
**FirstPage** | **int** | Number of the first page. TODO | [optional] 
**LastPage** | **int** | Number of the last page. TODO | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

