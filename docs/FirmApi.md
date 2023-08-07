# FeeWise.Api.FirmApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateFirm**](FirmApi.md#createfirm) | **POST** /api/v3/partner/firms | Create a new firm |
| [**CreatePaymentToken**](FirmApi.md#createpaymenttoken) | **POST** /api/v3/partner/firms/{firm_id}/payment_token | Create a payment token for a customer. |
| [**GetFirm**](FirmApi.md#getfirm) | **GET** /api/v3/partner/firms/{firm_id} | Get a firm |
| [**GetFirmBankAccounts**](FirmApi.md#getfirmbankaccounts) | **GET** /api/v3/partner/firms/{firm_id}/accounts | List all firms bank account&#39;s. |
| [**GetFirmCustomers**](FirmApi.md#getfirmcustomers) | **GET** /api/v3/partner/firms/{firm_id}/customers | List all the customers for a firm. |
| [**GetFirms**](FirmApi.md#getfirms) | **GET** /api/v3/partner/firms | Get firms |
| [**GetMagicLink**](FirmApi.md#getmagiclink) | **POST** /api/v3/partner/firms/{firm_id}/magic-link | Create a magic link |
| [**SetFirmsDefaultBankAccount**](FirmApi.md#setfirmsdefaultbankaccount) | **POST** /api/v3/partner/firms/{firm_id}/accounts/{account_id}/default | Set firms default bank account. |
| [**SyncFirm**](FirmApi.md#syncfirm) | **POST** /api/v3/partner/firms/sync/{connect_id} | Sync a firm by the FeeWise Connect ID |

<a name="createfirm"></a>
# **CreateFirm**
> FirmDetails CreateFirm (CreateFirm createFirm)

Create a new firm

The createFirm API endpoint facilitates the onboarding of a new firm into the current system. The endpoint allows clients to initiate the onboarding process for their respective firms. Upon a successful http response, the firm's status will be set to \"pending\" in FeeWise. The onboarding process follows a two-step procedure. Initially, the operational team will review the firm's details and perform necessary verifications. Once the firm's information has been validated and approved by the operational team, the firm will be officially onboarded into FeeWise. During the onboarding approval process, a webhook will be triggered for the \"firm.onboarded\" event. The webhook serves as a notification mechanism, enabling integrations and external systems to be updated about the newly onboarded firm. It is important to note that the onboarding process might take some time to complete, as it involves manual verification steps by the operational team. However, clients can track the status of their firm through FeeWise and receive real-time updates through the webhook once the firm onboarding is successfully approved. Please ensure that all necessary information is provided accurately when using this API endpoint to avoid delays in the onboarding process. Additionally, clients should handle the webhook appropriately to capture the \"firm.onboarded\" event and update their internal systems accordingly. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class CreateFirmExample
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

            var apiInstance = new FirmApi(config);
            var createFirm = new CreateFirm(); // CreateFirm | Firm Details

            try
            {
                // Create a new firm
                FirmDetails result = apiInstance.CreateFirm(createFirm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FirmApi.CreateFirm: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFirmWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new firm
    ApiResponse<FirmDetails> response = apiInstance.CreateFirmWithHttpInfo(createFirm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FirmApi.CreateFirmWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createFirm** | [**CreateFirm**](CreateFirm.md) | Firm Details |  |

### Return type

[**FirmDetails**](FirmDetails.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Firm successfully created |  -  |
| **400** | Bad JSON request or request contains an invalid uuid |  -  |
| **404** | Channel Partner Not Found |  -  |
| **409** | External ID is not unique or a Bank Account is invalid |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpaymenttoken"></a>
# **CreatePaymentToken**
> PaymentTokenResponse CreatePaymentToken (Guid firmId, PaymentTokenBody paymentTokenBody)

Create a payment token for a customer.

Create a payment token for a customer to capture their payment method details and later use to charge them via the charge and pay endpoint /api/v3/partner/charges/pay/payment_token/{payment_token}.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class CreatePaymentTokenExample
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

            var apiInstance = new FirmApi(config);
            var firmId = "firmId_example";  // Guid | 
            var paymentTokenBody = new PaymentTokenBody(); // PaymentTokenBody | Customer details

            try
            {
                // Create a payment token for a customer.
                PaymentTokenResponse result = apiInstance.CreatePaymentToken(firmId, paymentTokenBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FirmApi.CreatePaymentToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePaymentTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a payment token for a customer.
    ApiResponse<PaymentTokenResponse> response = apiInstance.CreatePaymentTokenWithHttpInfo(firmId, paymentTokenBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FirmApi.CreatePaymentTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** |  |  |
| **paymentTokenBody** | [**PaymentTokenBody**](PaymentTokenBody.md) | Customer details |  |

### Return type

[**PaymentTokenResponse**](PaymentTokenResponse.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return the customer and payment token. |  -  |
| **404** | Firm not found |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfirm"></a>
# **GetFirm**
> FirmResponse GetFirm (Guid firmId)

Get a firm

Get a firm by the firm's ID.  The firm will have the current sync status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class GetFirmExample
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

            var apiInstance = new FirmApi(config);
            var firmId = "firmId_example";  // Guid | 

            try
            {
                // Get a firm
                FirmResponse result = apiInstance.GetFirm(firmId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FirmApi.GetFirm: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFirmWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a firm
    ApiResponse<FirmResponse> response = apiInstance.GetFirmWithHttpInfo(firmId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FirmApi.GetFirmWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** |  |  |

### Return type

[**FirmResponse**](FirmResponse.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return the Firm. |  -  |
| **404** | Firm not found |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfirmbankaccounts"></a>
# **GetFirmBankAccounts**
> BankAccountsResponse GetFirmBankAccounts (Guid firmId)

List all firms bank account's.

Return all bank accounts linked to a firm.  If no accounts are linked an empty array is returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class GetFirmBankAccountsExample
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

            var apiInstance = new FirmApi(config);
            var firmId = "firmId_example";  // Guid | 

            try
            {
                // List all firms bank account's.
                BankAccountsResponse result = apiInstance.GetFirmBankAccounts(firmId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FirmApi.GetFirmBankAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFirmBankAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all firms bank account's.
    ApiResponse<BankAccountsResponse> response = apiInstance.GetFirmBankAccountsWithHttpInfo(firmId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FirmApi.GetFirmBankAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** |  |  |

### Return type

[**BankAccountsResponse**](BankAccountsResponse.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return the list of bank accounts. |  -  |
| **404** | Firm not found |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfirmcustomers"></a>
# **GetFirmCustomers**
> CustomersResponse GetFirmCustomers (Guid firmId)

List all the customers for a firm.

Return an array of all customers with their saved payment methods. If no customers, an empty array is returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class GetFirmCustomersExample
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

            var apiInstance = new FirmApi(config);
            var firmId = "firmId_example";  // Guid | 

            try
            {
                // List all the customers for a firm.
                CustomersResponse result = apiInstance.GetFirmCustomers(firmId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FirmApi.GetFirmCustomers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFirmCustomersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all the customers for a firm.
    ApiResponse<CustomersResponse> response = apiInstance.GetFirmCustomersWithHttpInfo(firmId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FirmApi.GetFirmCustomersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** |  |  |

### Return type

[**CustomersResponse**](CustomersResponse.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return the list of customers. |  -  |
| **404** | Firm not found |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfirms"></a>
# **GetFirms**
> FirmsResponse GetFirms ()

Get firms

get all firms for current channel partner

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class GetFirmsExample
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

            var apiInstance = new FirmApi(config);

            try
            {
                // Get firms
                FirmsResponse result = apiInstance.GetFirms();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FirmApi.GetFirms: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFirmsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get firms
    ApiResponse<FirmsResponse> response = apiInstance.GetFirmsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FirmApi.GetFirmsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**FirmsResponse**](FirmsResponse.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Firms have been retrieved |  -  |
| **404** | Channel Partner Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmagiclink"></a>
# **GetMagicLink**
> GetMagicLink200Response GetMagicLink (Guid firmId, string destinationUrl = null)

Create a magic link

Create a magic link that, on click, redirects to a defined URL within the dashboard. Defaults to homepage 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class GetMagicLinkExample
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

            var apiInstance = new FirmApi(config);
            var firmId = "firmId_example";  // Guid | 
            var destinationUrl = "destinationUrl_example";  // string |  (optional) 

            try
            {
                // Create a magic link
                GetMagicLink200Response result = apiInstance.GetMagicLink(firmId, destinationUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FirmApi.GetMagicLink: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMagicLinkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a magic link
    ApiResponse<GetMagicLink200Response> response = apiInstance.GetMagicLinkWithHttpInfo(firmId, destinationUrl);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FirmApi.GetMagicLinkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** |  |  |
| **destinationUrl** | **string** |  | [optional]  |

### Return type

[**GetMagicLink200Response**](GetMagicLink200Response.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Magic sign in link for a firm |  -  |
| **500** | Server Error |  -  |
| **401** | Access to Firm Unauthorized |  -  |
| **404** | Firm not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setfirmsdefaultbankaccount"></a>
# **SetFirmsDefaultBankAccount**
> BankAccountResponse SetFirmsDefaultBankAccount (Guid firmId, Guid accountId)

Set firms default bank account.

Set the given account as the default bank account (Trust or Office). The account type will determine if the bank account becomes the default office or trust account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class SetFirmsDefaultBankAccountExample
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

            var apiInstance = new FirmApi(config);
            var firmId = "firmId_example";  // Guid | 
            var accountId = "accountId_example";  // Guid | 

            try
            {
                // Set firms default bank account.
                BankAccountResponse result = apiInstance.SetFirmsDefaultBankAccount(firmId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FirmApi.SetFirmsDefaultBankAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetFirmsDefaultBankAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set firms default bank account.
    ApiResponse<BankAccountResponse> response = apiInstance.SetFirmsDefaultBankAccountWithHttpInfo(firmId, accountId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FirmApi.SetFirmsDefaultBankAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** |  |  |
| **accountId** | **Guid** |  |  |

### Return type

[**BankAccountResponse**](BankAccountResponse.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The default bank account was successfully set.  The bank account object is returned. |  -  |
| **404** | Bank Account not found |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="syncfirm"></a>
# **SyncFirm**
> FirmResponse SyncFirm (string connectId)

Sync a firm by the FeeWise Connect ID

Given a FeeWise Connect ID return a the firm's ID and status.  The firm ID can be used for future requests.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class SyncFirmExample
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

            var apiInstance = new FirmApi(config);
            var connectId = "connectId_example";  // string | 

            try
            {
                // Sync a firm by the FeeWise Connect ID
                FirmResponse result = apiInstance.SyncFirm(connectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FirmApi.SyncFirm: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SyncFirmWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sync a firm by the FeeWise Connect ID
    ApiResponse<FirmResponse> response = apiInstance.SyncFirmWithHttpInfo(connectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FirmApi.SyncFirmWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **connectId** | **string** |  |  |

### Return type

[**FirmResponse**](FirmResponse.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return the Firm ID and status. |  -  |
| **404** | Firm not found |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

