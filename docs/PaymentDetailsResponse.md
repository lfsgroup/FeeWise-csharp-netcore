# FeeWise.Model.PaymentDetailsResponse
A single payment footer, including all of its representations.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MatterId** | **string** | Echoes the matter_id from the request, if provided. | [optional] 
**DebtorId** | **string** | Echoes the debtor_id from the request, if provided. | [optional] 
**InvoiceId** | **string** | Echoes the invoice_id from the request, if provided. | [optional] 
**TrustDepositId** | **string** | Echoes the trust_deposit_id from the request, if provided. | [optional] 
**PaymentDetailsType** | **PaymentDetailType** |  | 
**PaymentUrl** | **string** | The full URL the customer visits to pay. | 
**QrCodeSvg** | **byte[]** | Base64-encoded SVG markup for the QR code encoding the payment_url. | 
**Html** | **byte[]** | Base64-encoded HTML rendering of the payment footer. | 
**Error** | **string** | Only set if the artifact has an error retrieving. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

