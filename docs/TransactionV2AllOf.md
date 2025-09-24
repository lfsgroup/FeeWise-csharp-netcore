# FeeWise.Model.TransactionV2AllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionUri** | **string** | A direct URL to view this transaction in the FeeWise dashboard.  Integration note: When embedding this link in your Practice Management System (PMS),   prefix it with your magic link URL to maintain authentication context. Refer to the \&quot;Magic Links\&quot; documentation section for implementation details.  | [optional] 
**FundingType** | **string** | The funding type for card payments e.g Credit, Debit | [optional] 
**Surcharged** | **bool** | Indicates if the transaction was surcharged | [optional] 
**SurchargedAmount** | **string** | Surcharge amount the customer paid for this transaction | [optional] 
**Refundable** | **bool** | Indicates if this transaction can be refunded | [optional] 
**Refund** | [**Refund**](Refund.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

