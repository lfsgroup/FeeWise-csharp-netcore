# FeeWise.Api.PaymentsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AdjustInvoiceAmount**](PaymentsApi.md#adjustinvoiceamount) | **POST** /api/v3/partner/invoices/{invoice_id}/adjust-amount | Adjust an invoice. |
| [**AdjustTrustDepositAmount**](PaymentsApi.md#adjusttrustdepositamount) | **POST** /api/v3/partner/trust-deposits/{trust_deposit_id}/adjust-amount | Adjust an trust deposit. |
| [**CreateInvoice**](PaymentsApi.md#createinvoice) | **POST** /api/v3/partner/invoices | Create an Invoice |
| [**CreateStatement**](PaymentsApi.md#createstatement) | **POST** /api/v3/partner/statements |  |
| [**CreateTrustDeposit**](PaymentsApi.md#createtrustdeposit) | **POST** /api/v3/partner/trust-deposits | Create a Trust Deposit |
| [**GetChannelPartnerPayments**](PaymentsApi.md#getchannelpartnerpayments) | **GET** /api/v3/partner/payments | Search for payments for the channel partner |
| [**GetInvoiceByExternalId**](PaymentsApi.md#getinvoicebyexternalid) | **GET** /api/v3/partner/invoices/firm/{firm_id}/{external_id} | Get invoice by external_id |
| [**GetInvoiceById**](PaymentsApi.md#getinvoicebyid) | **GET** /api/v3/partner/invoices/{invoice_id} | Get a specified invoice by id. |
| [**GetTrustDepositByExternalId**](PaymentsApi.md#gettrustdepositbyexternalid) | **GET** /api/v3/partner/trust-deposits/firm/{firm_id}/{external_id} | Get Trust Deposit by external_id |
| [**GetTrustDepositById**](PaymentsApi.md#gettrustdepositbyid) | **GET** /api/v3/partner/trust-deposits/{trust_deposit_id} | Get a Trust Deposit by id. |
| [**RecordExternalPayment**](PaymentsApi.md#recordexternalpayment) | **POST** /api/v3/partner/payments/external | Record external payment. |

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

<a name="createinvoice"></a>
# **CreateInvoice**
> InvoiceResponse CreateInvoice (Invoice invoice)

Create an Invoice

Create an invoice for a channel partner.   NB the fields `invoice_id`, `payment_uri` and `status` must NOT be supplied. If supplied, BadResponse will be returned.   These are populated once the invoice has been created and will be available in the response. The external_id is a unique field, if the same external_id is provided, the matching invoice will be updated instead. 

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
            // Configure API key authorization: APIAuth
            config.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-KEY", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var invoice = new Invoice(); // Invoice | Invoice details

            try
            {
                // Create an Invoice
                InvoiceResponse result = apiInstance.CreateInvoice(invoice);
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
    ApiResponse<InvoiceResponse> response = apiInstance.CreateInvoiceWithHttpInfo(invoice);
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
| **200** | Created Invoice |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createstatement"></a>
# **CreateStatement**
> StatementResponse CreateStatement (Statement statement = null)



Creates a statement of account, filtered by a debtor ID and an optional matter ID, payable by the client via the returned URL  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class CreateStatementExample
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
            var statement = new Statement(); // Statement |  (optional) 

            try
            {
                StatementResponse result = apiInstance.CreateStatement(statement);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.CreateStatement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateStatementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<StatementResponse> response = apiInstance.CreateStatementWithHttpInfo(statement);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.CreateStatementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **statement** | [**Statement**](Statement.md) |  | [optional]  |

### Return type

[**StatementResponse**](StatementResponse.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Statement was created |  -  |
| **400** | Incompatible filters provided. Must provide at least a matter_id or a debtor_id |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtrustdeposit"></a>
# **CreateTrustDeposit**
> TrustDepositResponse CreateTrustDeposit (TrustDeposit trustDeposit)

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

            try
            {
                // Create a Trust Deposit
                TrustDepositResponse result = apiInstance.CreateTrustDeposit(trustDeposit);
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
    ApiResponse<TrustDepositResponse> response = apiInstance.CreateTrustDepositWithHttpInfo(trustDeposit);
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelpartnerpayments"></a>
# **GetChannelPartnerPayments**
> Payments GetChannelPartnerPayments (Guid? paymentId = null, Guid? artifactId = null, Guid? firmId = null, DateTime? since = null)

Search for payments for the channel partner

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
                // Search for payments for the channel partner
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
    // Search for payments for the channel partner
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

<a name="recordexternalpayment"></a>
# **RecordExternalPayment**
> void RecordExternalPayment (ExternalPayment externalPayment)

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
                apiInstance.RecordExternalPayment(externalPayment);
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
    apiInstance.RecordExternalPaymentWithHttpInfo(externalPayment);
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

void (empty response body)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The payment was recorded |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

