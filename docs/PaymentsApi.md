# FeeWise.Api.PaymentsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AdjustInvoiceAmount**](PaymentsApi.md#adjustinvoiceamount) | **POST** /api/v3/partner/invoices/{invoice_id}/adjust-amount | Adjust an invoice. |
| [**AdjustTrustDepositAmount**](PaymentsApi.md#adjusttrustdepositamount) | **POST** /api/v3/partner/trust-deposits/{trust_deposit_id}/adjust-amount | Adjust an trust deposit. |
| [**CreateCharge**](PaymentsApi.md#createcharge) | **POST** /api/v3/partner/firms/{firm_id}/charges | Create a Charge |
| [**CreateChargeAndPayWithCustomerPaymentToken**](PaymentsApi.md#createchargeandpaywithcustomerpaymenttoken) | **POST** /api/v3/partner/firms/{firm_id}/charges/payment_token/{payment_token} | DEPRECATED - Use /api/v4/partner/firms/{firm_id}/charges/payment-token/{payment_token} endpoint instead |
| [**CreateChargePayment**](PaymentsApi.md#createchargepayment) | **POST** /api/v4/partner/firms/{firm_id}/charges/payment-token/{payment_token} | Create Charge, and pay directly. |
| [**CreateInvoice**](PaymentsApi.md#createinvoice) | **POST** /api/v3/partner/invoices | Create an Invoice |
| [**CreateMatter**](PaymentsApi.md#creatematter) | **POST** /api/v3/partner/matters | Create a matter |
| [**CreateSplitCharge**](PaymentsApi.md#createsplitcharge) | **POST** /api/v3/partner/firms/{firm_id}/charges/split | Create split charges, each charge is distributed to its own settlement account. |
| [**CreateTrustDeposit**](PaymentsApi.md#createtrustdeposit) | **POST** /api/v3/partner/trust-deposits | Create a Trust Deposit |
| [**GetChannelPartnerPayments**](PaymentsApi.md#getchannelpartnerpayments) | **GET** /api/v3/partner/payments | DEPRECATED use /transactions - Search for payments for the channel partner |
| [**GetDebtorMatterStatement**](PaymentsApi.md#getdebtormatterstatement) | **GET** /api/v3/partner/statements/debtors/{debtor_id}/matters/{matter_id} | Get a matter debtor statement |
| [**GetDebtorStatement**](PaymentsApi.md#getdebtorstatement) | **GET** /api/v3/partner/statements/debtors/{debtor_id} | Get a debtor statement |
| [**GetInvoiceByExternalId**](PaymentsApi.md#getinvoicebyexternalid) | **GET** /api/v3/partner/invoices/firm/{firm_id}/{external_id} | Get invoice by external_id |
| [**GetInvoiceById**](PaymentsApi.md#getinvoicebyid) | **GET** /api/v3/partner/invoices/{invoice_id} | Get a specified invoice by id. |
| [**GetMatterStatement**](PaymentsApi.md#getmatterstatement) | **GET** /api/v3/partner/statements/matters/{matter_id} | Get a matter statement |
| [**GetRefundDetails**](PaymentsApi.md#getrefunddetails) | **GET** /api/v3/partner/firms/{firm_id}/payments/refund/details | Get Refund Details |
| [**GetTrustDepositByExternalId**](PaymentsApi.md#gettrustdepositbyexternalid) | **GET** /api/v3/partner/trust-deposits/firm/{firm_id}/{external_id} | Get Trust Deposit by external_id |
| [**GetTrustDepositById**](PaymentsApi.md#gettrustdepositbyid) | **GET** /api/v3/partner/trust-deposits/{trust_deposit_id} | Get a Trust Deposit by id. |
| [**PostConfirmChargePayment**](PaymentsApi.md#postconfirmchargepayment) | **POST** /api/v3/partner/firms/{firm_id}/charges/{charge_id}/payments/{payment_id}/confirm | Confirm a pending charge payment. |
| [**RecordExternalPayment**](PaymentsApi.md#recordexternalpayment) | **POST** /api/v3/partner/payments/external | Record external payment. |
| [**UpdateArtifactAccount**](PaymentsApi.md#updateartifactaccount) | **POST** /api/v3/partner/firms/{firm_id}/artifacts/settlement-account/{settlement_account_id}/replace | Update the settlement account for unpaid artifacts. |
| [**UpdateArtifactRedirectURL**](PaymentsApi.md#updateartifactredirecturl) | **PATCH** /api/v3/partner/firms/{firm_id}/artifacts/{artifact_id}/update-redirect | Update the payment redirect URL for an artifact |

<a name="adjustinvoiceamount"></a>
# **AdjustInvoiceAmount**
> InvoiceResponse AdjustInvoiceAmount (Guid invoiceId, AdjustInvoiceAmountRequest adjustInvoiceAmountRequest)

Adjust an invoice.

Adjust the invoice amount after the invoice has been created.  If an adjustment is for an invoice outside of FeeWise, it should be adjusted using this endpoint. If the invoice has no payments, the total amount will be updated to the adjustment amount.  If a payment has already been made to the existing invoice, the adjustment request will fail. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class AdjustInvoiceAmountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: APIAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var invoiceId = "invoiceId_example";  // Guid | 
            var adjustInvoiceAmountRequest = new AdjustInvoiceAmountRequest(); // AdjustInvoiceAmountRequest | 

            try
            {
                // Adjust an invoice.
                InvoiceResponse result = apiInstance.AdjustInvoiceAmount(invoiceId, adjustInvoiceAmountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.AdjustInvoiceAmount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdjustInvoiceAmountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adjust an invoice.
    ApiResponse<InvoiceResponse> response = apiInstance.AdjustInvoiceAmountWithHttpInfo(invoiceId, adjustInvoiceAmountRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.AdjustInvoiceAmountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **invoiceId** | **Guid** |  |  |
| **adjustInvoiceAmountRequest** | [**AdjustInvoiceAmountRequest**](AdjustInvoiceAmountRequest.md) |  |  |

### Return type

[**InvoiceResponse**](InvoiceResponse.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The adjustment was recorded |  -  |
| **400** | Bad request |  -  |
| **404** | Requested invoice not found |  -  |
| **409** | Requested invoice is not in the correct state |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adjusttrustdepositamount"></a>
# **AdjustTrustDepositAmount**
> TrustDepositResponse AdjustTrustDepositAmount (Guid trustDepositId, AdjustTrustDepositAmountRequest adjustTrustDepositAmountRequest)

Adjust an trust deposit.

Adjust the trust deposit amount after the trust deposit has been created.  If an adjustment is for an trust deposit outside of FeeWise, it should be adjusted using this endpoint. If the trust deposit has no payments, the total amount will be updated to the adjustment amount.  If a payment has already been made to the existing trust deposit, the adjustment request will fail. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class AdjustTrustDepositAmountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: APIAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var trustDepositId = "trustDepositId_example";  // Guid | 
            var adjustTrustDepositAmountRequest = new AdjustTrustDepositAmountRequest(); // AdjustTrustDepositAmountRequest | 

            try
            {
                // Adjust an trust deposit.
                TrustDepositResponse result = apiInstance.AdjustTrustDepositAmount(trustDepositId, adjustTrustDepositAmountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.AdjustTrustDepositAmount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdjustTrustDepositAmountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adjust an trust deposit.
    ApiResponse<TrustDepositResponse> response = apiInstance.AdjustTrustDepositAmountWithHttpInfo(trustDepositId, adjustTrustDepositAmountRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.AdjustTrustDepositAmountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trustDepositId** | **Guid** |  |  |
| **adjustTrustDepositAmountRequest** | [**AdjustTrustDepositAmountRequest**](AdjustTrustDepositAmountRequest.md) |  |  |

### Return type

[**TrustDepositResponse**](TrustDepositResponse.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The adjustment was recorded |  -  |
| **400** | Bad request |  -  |
| **404** | Requested trust deposit not found |  -  |
| **409** | Requested trust deposit is not in the correct state |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcharge"></a>
# **CreateCharge**
> ChargeResponse CreateCharge (Guid firmId, Charge charge)

Create a Charge

Create a charge for a firm. The firm can then send the returned URI to their customer, for payment. NB the fields `charge_id`, and `payment_uri` must NOT be supplied. If supplied, BadResponse will be returned.   These are populated once the charge has been created and will be available in the response. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class CreateChargeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: APIAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var firmId = "firmId_example";  // Guid | 
            var charge = new Charge(); // Charge | Charge details

            try
            {
                // Create a Charge
                ChargeResponse result = apiInstance.CreateCharge(firmId, charge);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.CreateCharge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateChargeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Charge
    ApiResponse<ChargeResponse> response = apiInstance.CreateChargeWithHttpInfo(firmId, charge);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.CreateChargeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** |  |  |
| **charge** | [**Charge**](Charge.md) | Charge details |  |

### Return type

[**ChargeResponse**](ChargeResponse.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Created Charge |  -  |
| **400** | Bad request, do not include charge_id or payment_uri in the request. |  -  |
| **404** | Firm or Settlement Account could not be found. |  -  |
| **409** | Invalid settlement account. |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createchargeandpaywithcustomerpaymenttoken"></a>
# **CreateChargeAndPayWithCustomerPaymentToken**
> ChargeAndPayResponse CreateChargeAndPayWithCustomerPaymentToken (Guid paymentToken, Guid firmId, Charge charge)

DEPRECATED - Use /api/v4/partner/firms/{firm_id}/charges/payment-token/{payment_token} endpoint instead

Create a charge (and pay for it) for a firm, using an existing customer payment token.  A list of customer payment tokens can be retrieved from the `/customers` endpoint.  NB the fields `charge_id`, and `payment_uri` must NOT be supplied. If supplied, BadResponse will be returned.   These are populated once the charge has been created and will be available in the response. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class CreateChargeAndPayWithCustomerPaymentTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: APIAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var paymentToken = "paymentToken_example";  // Guid | 
            var firmId = "firmId_example";  // Guid | 
            var charge = new Charge(); // Charge | Charge details, using an existing customer payment token

            try
            {
                // DEPRECATED - Use /api/v4/partner/firms/{firm_id}/charges/payment-token/{payment_token} endpoint instead
                ChargeAndPayResponse result = apiInstance.CreateChargeAndPayWithCustomerPaymentToken(paymentToken, firmId, charge);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.CreateChargeAndPayWithCustomerPaymentToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateChargeAndPayWithCustomerPaymentTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DEPRECATED - Use /api/v4/partner/firms/{firm_id}/charges/payment-token/{payment_token} endpoint instead
    ApiResponse<ChargeAndPayResponse> response = apiInstance.CreateChargeAndPayWithCustomerPaymentTokenWithHttpInfo(paymentToken, firmId, charge);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.CreateChargeAndPayWithCustomerPaymentTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **paymentToken** | **Guid** |  |  |
| **firmId** | **Guid** |  |  |
| **charge** | [**Charge**](Charge.md) | Charge details, using an existing customer payment token |  |

### Return type

[**ChargeAndPayResponse**](ChargeAndPayResponse.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Charge created and paid |  -  |
| **400** | Bad request, do not include charge_id or payment_uri in the request. |  -  |
| **404** | Firm or Settlement Account could not be found. |  -  |
| **409** | Charge was unsuccessful and the payment failed to process. |  -  |
| **500** | Error processing charge |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createchargepayment"></a>
# **CreateChargePayment**
> ChargePaymentDetails CreateChargePayment (Guid paymentToken, Guid firmId, CreateChargePaymentRequest createChargePaymentRequest)

Create Charge, and pay directly.

Create a charge (and pay for it) for a firm, using an existing customer payment token.  A list of customer payment tokens can be retrieved from the `/customers` endpoint.  NB the fields `charge_id`, and `payment_uri` must NOT be supplied. If supplied, BadResponse will be returned.   These are populated once the charge has been created and will be available in the response. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class CreateChargePaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: APIAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var paymentToken = "paymentToken_example";  // Guid | 
            var firmId = "firmId_example";  // Guid | 
            var createChargePaymentRequest = new CreateChargePaymentRequest(); // CreateChargePaymentRequest | Charge details, using an existing customer payment token

            try
            {
                // Create Charge, and pay directly.
                ChargePaymentDetails result = apiInstance.CreateChargePayment(paymentToken, firmId, createChargePaymentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.CreateChargePayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateChargePaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Charge, and pay directly.
    ApiResponse<ChargePaymentDetails> response = apiInstance.CreateChargePaymentWithHttpInfo(paymentToken, firmId, createChargePaymentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.CreateChargePaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **paymentToken** | **Guid** |  |  |
| **firmId** | **Guid** |  |  |
| **createChargePaymentRequest** | [**CreateChargePaymentRequest**](CreateChargePaymentRequest.md) | Charge details, using an existing customer payment token |  |

### Return type

[**ChargePaymentDetails**](ChargePaymentDetails.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Charge created and paid |  -  |
| **400** | Bad request, do not include charge_id or payment_uri in the request. |  -  |
| **402** | Payment requires a review |  -  |
| **404** | Firm or Settlement Account could not be found. |  -  |
| **409** | Charge was unsuccessful and the payment failed to process. |  -  |
| **500** | Error processing charge |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createinvoice"></a>
# **CreateInvoice**
> InvoiceResponse CreateInvoice (Invoice invoice, string sourceId = null)

Create an Invoice

Create an invoice for a firm.   NB the fields `invoice_id`, `payment_uri` and `status` must NOT be supplied. If supplied, BadResponse will be returned.   These are populated once the invoice has been created and will be available in the response. The external_id is a unique field, if the same external_id is provided, the matching invoice will be updated instead. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class CreateInvoiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: FirmAuth
            config.AddApiKey("X-FIRM-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-FIRM-ID", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var invoice = new Invoice(); // Invoice | Invoice details
            var sourceId = "sourceId_example";  // string |  (optional) 

            try
            {
                // Create an Invoice
                InvoiceResponse result = apiInstance.CreateInvoice(invoice, sourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.CreateInvoice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateInvoiceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an Invoice
    ApiResponse<InvoiceResponse> response = apiInstance.CreateInvoiceWithHttpInfo(invoice, sourceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.CreateInvoiceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **invoice** | [**Invoice**](Invoice.md) | Invoice details |  |
| **sourceId** | **string** |  | [optional]  |

### Return type

[**InvoiceResponse**](InvoiceResponse.md)

### Authorization

[FirmAuth](../README.md#FirmAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Created Invoice |  -  |
| **409** | Invalid settlement account. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creatematter"></a>
# **CreateMatter**
> MatterResponse CreateMatter (string sourceId = null, MatterRequest matterRequest = null)

Create a matter

Create a matter, with all matter information, debtor details and artifacts, invoice or trust deposit. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class CreateMatterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: APIAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var sourceId = "sourceId_example";  // string |  (optional) 
            var matterRequest = new MatterRequest(); // MatterRequest |  (optional) 

            try
            {
                // Create a matter
                MatterResponse result = apiInstance.CreateMatter(sourceId, matterRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.CreateMatter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateMatterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a matter
    ApiResponse<MatterResponse> response = apiInstance.CreateMatterWithHttpInfo(sourceId, matterRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.CreateMatterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** |  | [optional]  |
| **matterRequest** | [**MatterRequest**](MatterRequest.md) |  | [optional]  |

### Return type

[**MatterResponse**](MatterResponse.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Matter was created |  -  |
| **409** | Invalid settlement account. |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsplitcharge"></a>
# **CreateSplitCharge**
> SplitChargesResponse CreateSplitCharge (Guid firmId, SplitCharge splitCharge)

Create split charges, each charge is distributed to its own settlement account.

Create multiple charges for a firm, that can be paid in a single payment. NB the fields `charge_id`, and `payment_uri` must NOT be supplied. If supplied, BadResponse will be returned.   These are populated once the split charge has been created and will be available in the response. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class CreateSplitChargeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: APIAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var firmId = "firmId_example";  // Guid | 
            var splitCharge = new SplitCharge(); // SplitCharge | Split Charge details

            try
            {
                // Create split charges, each charge is distributed to its own settlement account.
                SplitChargesResponse result = apiInstance.CreateSplitCharge(firmId, splitCharge);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.CreateSplitCharge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSplitChargeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create split charges, each charge is distributed to its own settlement account.
    ApiResponse<SplitChargesResponse> response = apiInstance.CreateSplitChargeWithHttpInfo(firmId, splitCharge);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.CreateSplitChargeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** |  |  |
| **splitCharge** | [**SplitCharge**](SplitCharge.md) | Split Charge details |  |

### Return type

[**SplitChargesResponse**](SplitChargesResponse.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Created Split Charge |  -  |
| **400** | Bad request, do not include split_charge_id or payment_uri in the request. |  -  |
| **404** | Firm or Settlement Account could not be found. |  -  |
| **409** | Invalid settlement account. |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtrustdeposit"></a>
# **CreateTrustDeposit**
> TrustDepositResponse CreateTrustDeposit (TrustDeposit trustDeposit, string sourceId = null)

Create a Trust Deposit

Create a trust deposit for a channel partner.   NB the fields trust_deposit_id, payment_uri and status must NOT be supplied. If supplied, BadResponse will be returned.   These are populated once the trust deposit has been created and will be available in the response. The external_id is a unique field, if the same external_id is provided, the matching trust deposit will be updated instead. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class CreateTrustDepositExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: APIAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var trustDeposit = new TrustDeposit(); // TrustDeposit | Trust deposit details
            var sourceId = "sourceId_example";  // string |  (optional) 

            try
            {
                // Create a Trust Deposit
                TrustDepositResponse result = apiInstance.CreateTrustDeposit(trustDeposit, sourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.CreateTrustDeposit: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTrustDepositWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Trust Deposit
    ApiResponse<TrustDepositResponse> response = apiInstance.CreateTrustDepositWithHttpInfo(trustDeposit, sourceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.CreateTrustDepositWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trustDeposit** | [**TrustDeposit**](TrustDeposit.md) | Trust deposit details |  |
| **sourceId** | **string** |  | [optional]  |

### Return type

[**TrustDepositResponse**](TrustDepositResponse.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Created Trust Deposit |  -  |
| **409** | Invalid settlement account. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelpartnerpayments"></a>
# **GetChannelPartnerPayments**
> Payments GetChannelPartnerPayments (Guid? paymentId = null, Guid? artifactId = null, Guid? firmId = null, DateTime? since = null)

DEPRECATED use /transactions - Search for payments for the channel partner

Search for payments for a channel partner..         The filters supplied in the query params must *all* be met.         The channel partner is derived from the PartnerAuth security context. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class GetChannelPartnerPaymentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: APIAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var paymentId = "paymentId_example";  // Guid? | Get a specific payment. If this is specified, other query params should not be specified  and will result in a BadRequest if the are.  (optional) 
            var artifactId = "artifactId_example";  // Guid? | Get payments only for the specified artifact (Invoice/Trust Desposit)  (optional) 
            var firmId = "firmId_example";  // Guid? | Get payments going to a specific firm  (optional) 
            var since = 2022-07-29T15:33:00;  // DateTime? | Return payments sent since this timestamp. If not supplied, payments for the last 24 hours are returned.  (optional) 

            try
            {
                // DEPRECATED use /transactions - Search for payments for the channel partner
                Payments result = apiInstance.GetChannelPartnerPayments(paymentId, artifactId, firmId, since);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetChannelPartnerPayments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChannelPartnerPaymentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DEPRECATED use /transactions - Search for payments for the channel partner
    ApiResponse<Payments> response = apiInstance.GetChannelPartnerPaymentsWithHttpInfo(paymentId, artifactId, firmId, since);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.GetChannelPartnerPaymentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **paymentId** | **Guid?** | Get a specific payment. If this is specified, other query params should not be specified  and will result in a BadRequest if the are.  | [optional]  |
| **artifactId** | **Guid?** | Get payments only for the specified artifact (Invoice/Trust Desposit)  | [optional]  |
| **firmId** | **Guid?** | Get payments going to a specific firm  | [optional]  |
| **since** | **DateTime?** | Return payments sent since this timestamp. If not supplied, payments for the last 24 hours are returned.  | [optional]  |

### Return type

[**Payments**](Payments.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of matching payments |  -  |
| **400** | Incompatible search parameters supplied |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdebtormatterstatement"></a>
# **GetDebtorMatterStatement**
> MatterStatement GetDebtorMatterStatement (Guid debtorId, Guid matterId, string sourceId = null, Guid? refArtifactId = null, int? to = null, int? from = null)

Get a matter debtor statement

Get a matter statement that is payable by the client via the returned URL.   Note: `to` and `from` are not yet implemented. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class GetDebtorMatterStatementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: APIAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var debtorId = "debtorId_example";  // Guid | 
            var matterId = "matterId_example";  // Guid | 
            var sourceId = "sourceId_example";  // string |  (optional) 
            var refArtifactId = "refArtifactId_example";  // Guid? | Optional referring artifact id.  If provided, details of the originating artifact, e.g. invoice or trust deposit, may be displayed on the payment pages.   (optional) 
            var to = 56;  // int? |  (optional) 
            var from = 56;  // int? |  (optional) 

            try
            {
                // Get a matter debtor statement
                MatterStatement result = apiInstance.GetDebtorMatterStatement(debtorId, matterId, sourceId, refArtifactId, to, from);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetDebtorMatterStatement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDebtorMatterStatementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a matter debtor statement
    ApiResponse<MatterStatement> response = apiInstance.GetDebtorMatterStatementWithHttpInfo(debtorId, matterId, sourceId, refArtifactId, to, from);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.GetDebtorMatterStatementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **debtorId** | **Guid** |  |  |
| **matterId** | **Guid** |  |  |
| **sourceId** | **string** |  | [optional]  |
| **refArtifactId** | **Guid?** | Optional referring artifact id.  If provided, details of the originating artifact, e.g. invoice or trust deposit, may be displayed on the payment pages.   | [optional]  |
| **to** | **int?** |  | [optional]  |
| **from** | **int?** |  | [optional]  |

### Return type

[**MatterStatement**](MatterStatement.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Matter Statement was returned |  -  |
| **400** | Incompatible filters provided. Must provide at least a matter_id. |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdebtorstatement"></a>
# **GetDebtorStatement**
> DebtorStatement GetDebtorStatement (Guid debtorId)

Get a debtor statement

Get a debtor statement that is payable by the client via the returned URL. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class GetDebtorStatementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: APIAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var debtorId = "debtorId_example";  // Guid | 

            try
            {
                // Get a debtor statement
                DebtorStatement result = apiInstance.GetDebtorStatement(debtorId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetDebtorStatement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDebtorStatementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a debtor statement
    ApiResponse<DebtorStatement> response = apiInstance.GetDebtorStatementWithHttpInfo(debtorId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.GetDebtorStatementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **debtorId** | **Guid** |  |  |

### Return type

[**DebtorStatement**](DebtorStatement.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Debtor Statement was returned |  -  |
| **400** | Bad request. |  -  |
| **403** | Forbidden request. |  -  |
| **404** | Debtor not found. |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoicebyexternalid"></a>
# **GetInvoiceByExternalId**
> InvoiceResponse GetInvoiceByExternalId (Guid firmId, string externalId)

Get invoice by external_id

Get an invoice for a firm by the external_id.  NB During artifact (e.g. Invoice or Trust Deposit) creation, FeeWise channel partners can create an artifact  with a unique id (external_id) that is meaningful for their system). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class GetInvoiceByExternalIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: APIAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var firmId = "firmId_example";  // Guid | 
            var externalId = "externalId_example";  // string | 

            try
            {
                // Get invoice by external_id
                InvoiceResponse result = apiInstance.GetInvoiceByExternalId(firmId, externalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetInvoiceByExternalId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInvoiceByExternalIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get invoice by external_id
    ApiResponse<InvoiceResponse> response = apiInstance.GetInvoiceByExternalIdWithHttpInfo(firmId, externalId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.GetInvoiceByExternalIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** |  |  |
| **externalId** | **string** |  |  |

### Return type

[**InvoiceResponse**](InvoiceResponse.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Found the requested invoice |  -  |
| **400** | Bad request |  -  |
| **404** | Requested invoice not found |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoicebyid"></a>
# **GetInvoiceById**
> InvoiceResponse GetInvoiceById (Guid invoiceId)

Get a specified invoice by id.

Get a specified invoice by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class GetInvoiceByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: FirmAuth
            config.AddApiKey("X-FIRM-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-FIRM-ID", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var invoiceId = "invoiceId_example";  // Guid | 

            try
            {
                // Get a specified invoice by id.
                InvoiceResponse result = apiInstance.GetInvoiceById(invoiceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetInvoiceById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInvoiceByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a specified invoice by id.
    ApiResponse<InvoiceResponse> response = apiInstance.GetInvoiceByIdWithHttpInfo(invoiceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.GetInvoiceByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **invoiceId** | **Guid** |  |  |

### Return type

[**InvoiceResponse**](InvoiceResponse.md)

### Authorization

[FirmAuth](../README.md#FirmAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Found the requested invoice |  -  |
| **400** | Bad request |  -  |
| **404** | Requested invoice not found |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmatterstatement"></a>
# **GetMatterStatement**
> MatterStatement GetMatterStatement (Guid matterId, int? to = null, int? from = null)

Get a matter statement

Get a matter statement that is payable by the client via the returned URL.   Note: `to` and `from` are not yet implemented. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class GetMatterStatementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: APIAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var matterId = "matterId_example";  // Guid | 
            var to = 56;  // int? |  (optional) 
            var from = 56;  // int? |  (optional) 

            try
            {
                // Get a matter statement
                MatterStatement result = apiInstance.GetMatterStatement(matterId, to, from);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetMatterStatement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMatterStatementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a matter statement
    ApiResponse<MatterStatement> response = apiInstance.GetMatterStatementWithHttpInfo(matterId, to, from);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.GetMatterStatementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **matterId** | **Guid** |  |  |
| **to** | **int?** |  | [optional]  |
| **from** | **int?** |  | [optional]  |

### Return type

[**MatterStatement**](MatterStatement.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Matter Statement was returned |  -  |
| **400** | Incompatible filters provided. Must provide at least a matter_id. |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrefunddetails"></a>
# **GetRefundDetails**
> RefundResponse GetRefundDetails (Guid firmId, Guid paymentId, Guid artifactId)

Get Refund Details

Get refund details by Payment ID (UUID) and Artifact ID (UUID).  Both values can be found in the /transactions and /payouts responses. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class GetRefundDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: FirmAuth
            config.AddApiKey("X-FIRM-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-FIRM-ID", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var firmId = "firmId_example";  // Guid | The ID of the firm
            var paymentId = "paymentId_example";  // Guid | Payment ID (UUID)
            var artifactId = "artifactId_example";  // Guid | Artifact ID (UUID)

            try
            {
                // Get Refund Details
                RefundResponse result = apiInstance.GetRefundDetails(firmId, paymentId, artifactId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetRefundDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRefundDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Refund Details
    ApiResponse<RefundResponse> response = apiInstance.GetRefundDetailsWithHttpInfo(firmId, paymentId, artifactId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.GetRefundDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** | The ID of the firm |  |
| **paymentId** | **Guid** | Payment ID (UUID) |  |
| **artifactId** | **Guid** | Artifact ID (UUID) |  |

### Return type

[**RefundResponse**](RefundResponse.md)

### Authorization

[FirmAuth](../README.md#FirmAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the refund, by the given ID pairing. |  -  |
| **400** | Bad request |  -  |
| **404** | Refund not found |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettrustdepositbyexternalid"></a>
# **GetTrustDepositByExternalId**
> TrustDepositResponse GetTrustDepositByExternalId (Guid firmId, string externalId)

Get Trust Deposit by external_id

Get a trust deposit for a firm by the external_id. NB During artifact (e.g. Invoice or Trust Deposit) creation, FeeWise channel partners can create an artifact with a unique id (external_id) that is meaningful for their system). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class GetTrustDepositByExternalIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: APIAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var firmId = "firmId_example";  // Guid | 
            var externalId = "externalId_example";  // string | 

            try
            {
                // Get Trust Deposit by external_id
                TrustDepositResponse result = apiInstance.GetTrustDepositByExternalId(firmId, externalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetTrustDepositByExternalId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTrustDepositByExternalIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Trust Deposit by external_id
    ApiResponse<TrustDepositResponse> response = apiInstance.GetTrustDepositByExternalIdWithHttpInfo(firmId, externalId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.GetTrustDepositByExternalIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** |  |  |
| **externalId** | **string** |  |  |

### Return type

[**TrustDepositResponse**](TrustDepositResponse.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Found the requested trust deposit |  -  |
| **400** | Bad request |  -  |
| **404** | Requested trust deposit not found |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettrustdepositbyid"></a>
# **GetTrustDepositById**
> TrustDepositResponse GetTrustDepositById (Guid trustDepositId)

Get a Trust Deposit by id.

Get a Trust Deposit by the specified trust_deposit_id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class GetTrustDepositByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: APIAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var trustDepositId = "trustDepositId_example";  // Guid | 

            try
            {
                // Get a Trust Deposit by id.
                TrustDepositResponse result = apiInstance.GetTrustDepositById(trustDepositId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetTrustDepositById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTrustDepositByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a Trust Deposit by id.
    ApiResponse<TrustDepositResponse> response = apiInstance.GetTrustDepositByIdWithHttpInfo(trustDepositId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.GetTrustDepositByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trustDepositId** | **Guid** |  |  |

### Return type

[**TrustDepositResponse**](TrustDepositResponse.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Found the requested Trust Deposit |  -  |
| **400** | Bad request |  -  |
| **404** | Requested Trust Deposit not found |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postconfirmchargepayment"></a>
# **PostConfirmChargePayment**
> ChargePaymentDetails PostConfirmChargePayment (Guid firmId, Guid chargeId, Guid paymentId, PostConfirmChargePaymentRequest postConfirmChargePaymentRequest = null)

Confirm a pending charge payment.

confirm the payment of a pending charge using the provided charge_id and payment_id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class PostConfirmChargePaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: APIAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var firmId = "firmId_example";  // Guid | 
            var chargeId = "chargeId_example";  // Guid | 
            var paymentId = "paymentId_example";  // Guid | 
            var postConfirmChargePaymentRequest = new PostConfirmChargePaymentRequest(); // PostConfirmChargePaymentRequest | POST Body contains optional Metadata and Debtor info to apply to the charge. Warning, will replace the charge's existing metadata. Debtor external_id can not be updated at this point in the flow and will be ignored. (optional) 

            try
            {
                // Confirm a pending charge payment.
                ChargePaymentDetails result = apiInstance.PostConfirmChargePayment(firmId, chargeId, paymentId, postConfirmChargePaymentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.PostConfirmChargePayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostConfirmChargePaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Confirm a pending charge payment.
    ApiResponse<ChargePaymentDetails> response = apiInstance.PostConfirmChargePaymentWithHttpInfo(firmId, chargeId, paymentId, postConfirmChargePaymentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.PostConfirmChargePaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** |  |  |
| **chargeId** | **Guid** |  |  |
| **paymentId** | **Guid** |  |  |
| **postConfirmChargePaymentRequest** | [**PostConfirmChargePaymentRequest**](PostConfirmChargePaymentRequest.md) | POST Body contains optional Metadata and Debtor info to apply to the charge. Warning, will replace the charge&#39;s existing metadata. Debtor external_id can not be updated at this point in the flow and will be ignored. | [optional]  |

### Return type

[**ChargePaymentDetails**](ChargePaymentDetails.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful response |  -  |
| **400** | Bad request |  -  |
| **403** | Firm is unable to transact |  -  |
| **404** | Firm, charge or payment not found |  -  |
| **409** | Charge has already been paid or payment is out of sync |  -  |
| **500** | generic server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recordexternalpayment"></a>
# **RecordExternalPayment**
> ExternalPaymentResponse RecordExternalPayment (ExternalPayment externalPayment)

Record external payment.

If a payment is made towards an artifact (invoice, trust deposit) outside of FeeWise, it should be recorded using this endpoint. This will be recorded as a payment against the artifact and change the amount_due. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class RecordExternalPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: APIAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var externalPayment = new ExternalPayment(); // ExternalPayment | External payment details.

            try
            {
                // Record external payment.
                ExternalPaymentResponse result = apiInstance.RecordExternalPayment(externalPayment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.RecordExternalPayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RecordExternalPaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Record external payment.
    ApiResponse<ExternalPaymentResponse> response = apiInstance.RecordExternalPaymentWithHttpInfo(externalPayment);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.RecordExternalPaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **externalPayment** | [**ExternalPayment**](ExternalPayment.md) | External payment details. |  |

### Return type

[**ExternalPaymentResponse**](ExternalPaymentResponse.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The payment was recorded |  -  |
| **404** | Artifact not found |  -  |
| **409** | External payment already exists |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateartifactaccount"></a>
# **UpdateArtifactAccount**
> UpdatedCount UpdateArtifactAccount (Guid firmId, Guid settlementAccountId, UpdateArtifactAccountRequest updateArtifactAccountRequest)

Update the settlement account for unpaid artifacts.

Swaps the settlement account id on all artifacts with the given artifact type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class UpdateArtifactAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: APIAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var firmId = "firmId_example";  // Guid | 
            var settlementAccountId = "settlementAccountId_example";  // Guid | 
            var updateArtifactAccountRequest = new UpdateArtifactAccountRequest(); // UpdateArtifactAccountRequest | Contains the type of the artifact and the ID of the account the artifacts should be paid to.

            try
            {
                // Update the settlement account for unpaid artifacts.
                UpdatedCount result = apiInstance.UpdateArtifactAccount(firmId, settlementAccountId, updateArtifactAccountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.UpdateArtifactAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateArtifactAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the settlement account for unpaid artifacts.
    ApiResponse<UpdatedCount> response = apiInstance.UpdateArtifactAccountWithHttpInfo(firmId, settlementAccountId, updateArtifactAccountRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.UpdateArtifactAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** |  |  |
| **settlementAccountId** | **Guid** |  |  |
| **updateArtifactAccountRequest** | [**UpdateArtifactAccountRequest**](UpdateArtifactAccountRequest.md) | Contains the type of the artifact and the ID of the account the artifacts should be paid to. |  |

### Return type

[**UpdatedCount**](UpdatedCount.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully updated the artifacts. |  -  |
| **400** | Bad request |  -  |
| **404** | Firm not found |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateartifactredirecturl"></a>
# **UpdateArtifactRedirectURL**
> ArtifactResponse UpdateArtifactRedirectURL (Guid artifactId, Guid firmId)

Update the payment redirect URL for an artifact

Update the optional URL the payer will be redirected to after payment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class UpdateArtifactRedirectURLExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: FirmAuth
            config.AddApiKey("X-FIRM-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-FIRM-ID", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var artifactId = "artifactId_example";  // Guid | 
            var firmId = "firmId_example";  // Guid | 

            try
            {
                // Update the payment redirect URL for an artifact
                ArtifactResponse result = apiInstance.UpdateArtifactRedirectURL(artifactId, firmId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.UpdateArtifactRedirectURL: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateArtifactRedirectURLWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the payment redirect URL for an artifact
    ApiResponse<ArtifactResponse> response = apiInstance.UpdateArtifactRedirectURLWithHttpInfo(artifactId, firmId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.UpdateArtifactRedirectURLWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **artifactId** | **Guid** |  |  |
| **firmId** | **Guid** |  |  |

### Return type

[**ArtifactResponse**](ArtifactResponse.md)

### Authorization

[FirmAuth](../README.md#FirmAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated the redirect URL for the requested artifact |  -  |
| **400** | Bad request |  -  |
| **404** | Requested artifact not found |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

