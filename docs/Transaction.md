# FeeWise.Model.Transaction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentReference** | **Guid** | UUID of the payment intent (in FeeWise). This is the Payment id shown in the payment receipt. | 
**AccountId** | **Guid** | FW ID of the settlement account | [optional] 
**PayoutId** | **Guid** | ID of the payout (if paid out). | [optional] 
**PayoutDate** | **DateTime** | Timestamp when the associated payout was made to the firm from FeeWise. | [optional] 
**Reference** | **string** | The artifact reference. | 
**Debtor** | [**Debtor**](Debtor.md) |  | [optional] 
**MatterReference** | **string** | The name of the matter the payment is made for. | [optional] 
**MatterDescription** | **string** | The description of the matter the payment is made for. | [optional] 
**PaymentDate** | **DateTime** | Timestamp when the payment was made by the client. | 
**CustomerPaymentMethod** | [**CustomerPaymentMethod**](CustomerPaymentMethod.md) |  | [optional] 
**AccountAlias** | **string** | The account alias (name). | 
**AccountType** | **AccountType** |  | 
**Amount** | **string** | Amount paid (received from client gross) | 
**Status** | **TransactionStatus** |  | 
**PayerDetails** | [**Payer**](Payer.md) |  | [optional] 
**ClientReference** | **string** | Only present if the artifact is of type payment link | [optional] 
**Metadata** | **Dictionary&lt;string, string&gt;** | metadata that the partner has attached to the original artifact (charge, invoice, trust deposit, etc) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

