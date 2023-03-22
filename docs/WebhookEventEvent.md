# FeeWise.Model.WebhookEventEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvoiceId** | **Guid** | This is the uuid of the invoice. This will be used for and &#39;GET&#39; of the invoice and in webhooks about this invoice NB this is generated and must not be supplied when creating an invoice.  | [optional] 
**FirmId** | **Guid** | The id of the firm the payout was made to. | 
**Matter** | [**Matter**](Matter.md) |  | [optional] 
**Debtor** | [**Debtor**](Debtor.md) |  | [optional] 
**ExternalId** | **string** | This is the id of the artifact supplied by the channel partner / PMS. | 
**ExternalReference** | **string** | This a reference supplied by the channel partner / PMS and can be used for filtering trust deposits. | [optional] 
**Amount** | **string** | The total amount the trust deposit is for. | 
**AmountDue** | **string** | The total amount outstanding on this trust deposit. | [optional] 
**Currency** | **string** | The currency the payment was made in. | 
**DueDate** | **DateTime** |  | [optional] 
**SettlementAccountType** | **AccountType** |  | [optional] 
**SettlementAccountId** | **Guid** | The id of the account the trust deposit should be paid to.  If not supplied, the default trust deposit for the firm will be used  | [optional] 
**LineItems** | [**List&lt;LineItem&gt;**](LineItem.md) |  | [optional] 
**Notes** | **List&lt;string&gt;** | Freeform notes on the trust deposit | [optional] 
**Payments** | [**List&lt;Payment&gt;**](Payment.md) | List of payments made against this trust deposit. | [optional] 
**PaymentMethodsOverride** | [**List&lt;PaymentMethod&gt;**](PaymentMethod.md) |  | [optional] 
**SurchargeChoiceOverride** | **SurchargeChoice** |  | [optional] 
**Description** | **string** | Freeform text for channel partner / PMS. | [optional] 
**PaymentUri** | **string** | The URI to send to customer.    They will follow this link to make a payment.    NB This must not be set when creating an invoice.  | [optional] 
**Status** | **PayoutStatus** |  | 
**TrustDepositId** | **Guid** | This is the uuid of the Trust Deposit. This will be used for any &#39;GET&#39; of the Trust Deposit and in webhooks about this Trust Deposit NB this is generated and must not be supplied when creating a Trust Deposit.  | [optional] 
**TransactionId** | **Guid** | The unique id of this single transaction in the payout. | 
**PaymentId** | **Guid** | The id of the payment. nb A single payment may contain multiple transactions and may not be unique. | 
**PaymentType** | **PaymentMethod** |  | [optional] 
**ArtifactId** | **Guid** | The artifact (Invoice, TrustDeposit, ...) the payment is in relation to. | 
**ArtifactType** | **ArtifactType** |  | 
**ExternalPayment** | [**PaymentExternalPayment**](PaymentExternalPayment.md) |  | [optional] 
**Received** | **string** | The amount received from the client. | [optional] 
**Refunded** | **string** | The amount refunded (back to the client) against this payment. | [optional] 
**PaidOut** | **string** | The total amount paid to the firm for this payment | 
**Date** | **DateTime** | When the payout was made. | 
**PayoutReference** | **string** | The unique reference of the payout. This will appear in the bank account statement the payout was made to. | 
**PayoutTotal** | **string** | The total paid out to the firm. This is the sum of the transactions paid_out amounts. | 
**Account** | [**PayoutAccount**](PayoutAccount.md) |  | 
**Transactions** | [**List&lt;Payment&gt;**](Payment.md) | A list of the payments that are included in this payout | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

