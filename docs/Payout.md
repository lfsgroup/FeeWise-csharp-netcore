# FeeWise.Model.Payout
Describes a payout made by the system to a channel partner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PayoutReference** | **string** | The unique reference of the payout. This will appear in the bank account statement the payout was made to. | 
**Date** | **DateTime** | When the payout was made. | 
**PayoutTotal** | **string** | The total paid out to the firm. This is the sum of the transactions paid_out amounts. | 
**Account** | [**PayoutAccount**](PayoutAccount.md) |  | 
**FirmId** | **Guid** | The id of the firm the payout was made to. | 
**Transactions** | [**List&lt;Payment&gt;**](Payment.md) | A list of the payments that are included in this payout | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

