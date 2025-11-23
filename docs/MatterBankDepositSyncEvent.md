# FeeWise.Model.MatterBankDepositSyncEvent
For FeeWise specific features, PaymentLinks, PaymentPlan Payments, Card Safe etc... The Channel Partner can elect to allow firms to associate FeeWise specific feature payments with artifacts in their own system. Firm users (e.g. bookkeepers) can then use the FeeWise transactions dashboard to select matters / invoices in the partners systems to associate the payments with. (nb: The Channel partner must provide FeeWise an endpoint to retrieve matters/invoices for the firm; to be be used for the association).     The MatterBankDepositSyncEvent is used to notify the Channel Partner that:   The firm user has used the FeeWise transactions dashboard to associate a matter / invoice in the Channel Partners system with FeeWise specific features. (At this point, the payout has already been made from FeeWise to the firm's bank account) A deposit for this payment can now be made, in the Channel Partners system The event is emitted after a payout has been paid AND all unintegrated payments associated with the payout have been associated with a partner artifact. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PayoutReference** | **string** | The unique reference of the payout. This will appear in the bank account statement the payout was made to. | 
**Date** | **DateTime** | When the payout was made. | 
**PayoutTotal** | **string** | The total paid out to the firm. This is the sum of the transactions paid_out amounts. | 
**Account** | [**BankAccountSummary**](BankAccountSummary.md) |  | 
**FirmId** | **Guid** | The id of the firm the payout was made to. | 
**ExternalFirmId** | **string** | The ID of the firm in the PMS | [optional] 
**Status** | **PayoutStatus** |  | 
**Transactions** | [**List&lt;Payment&gt;**](Payment.md) | A list of the payments that are included in this payout | 
**Metadata** | **Dictionary&lt;string, string&gt;** | Set of key value pairs attached to the object when it was created. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

