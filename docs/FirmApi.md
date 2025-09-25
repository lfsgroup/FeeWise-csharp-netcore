# FeeWise.Api.FirmApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Associate**](FirmApi.md#associate) | **POST** /api/v3/partner/firms/connect/{firm_connect_id}/associate | Associate a firm with an affiliate |
| [**CreateFirm**](FirmApi.md#createfirm) | **POST** /api/v3/partner/firms | Create a new firm |
| [**CreateFirmAccountOwner**](FirmApi.md#createfirmaccountowner) | **POST** /api/v3/partner/firms/{firm_id}/owner | Create Firm Account Owner |
| [**CreateFirmBankAccount**](FirmApi.md#createfirmbankaccount) | **POST** /api/v3/partner/firms/{firm_id}/accounts | Create a bank account |
| [**CreatePaymentToken**](FirmApi.md#createpaymenttoken) | **POST** /api/v3/partner/firms/{firm_id}/payment_token | Create a payment token for a customer. |
| [**DeleteFirmBankAccount**](FirmApi.md#deletefirmbankaccount) | **DELETE** /api/v3/partner/firms/{firm_id}/accounts/{account_id} | Delete a bank account |
| [**DeletePaymentToken**](FirmApi.md#deletepaymenttoken) | **DELETE** /api/v3/partner/firms/{firm_id}/payment_token/{payment_token} | Delete a payment token |
| [**GetFirm**](FirmApi.md#getfirm) | **GET** /api/v3/partner/firms/{firm_id} | Get a firm |
| [**GetFirmBankAccountByID**](FirmApi.md#getfirmbankaccountbyid) | **GET** /api/v3/partner/firms/{firm_id}/accounts/{account_id} | Get a bank account by ID |
| [**GetFirmBankAccounts**](FirmApi.md#getfirmbankaccounts) | **GET** /api/v3/partner/firms/{firm_id}/accounts | List bank accounts |
| [**GetFirmBranding**](FirmApi.md#getfirmbranding) | **GET** /api/v3/partner/firms/{firm_id}/branding | Get firm branding |
| [**GetFirmCustomers**](FirmApi.md#getfirmcustomers) | **GET** /api/v3/partner/firms/{firm_id}/customers | List all the customers for a firm. |
| [**GetFirmDetails**](FirmApi.md#getfirmdetails) | **GET** /api/v3/partner/firms/firm-details | Get firm details |
| [**GetFirmPricing**](FirmApi.md#getfirmpricing) | **GET** /api/v3/partner/firms/{firm_id}/pricing | List the pricing products for a firm and their constraints. |
| [**GetFirms**](FirmApi.md#getfirms) | **GET** /api/v3/partner/firms | Get firms |
| [**GetMagicLink**](FirmApi.md#getmagiclink) | **POST** /api/v3/partner/firms/{firm_id}/magic-link | Create a magic link |
| [**PostFirmBrandingColour**](FirmApi.md#postfirmbrandingcolour) | **POST** /api/v3/partner/firms/{firm_id}/branding/colour | Set firm branding colour for firm dashboard |
| [**PostUpload**](FirmApi.md#postupload) | **POST** /api/v3/partner/firms/{firm_id}/upload | Upload file |
| [**PutSurchargingStatus**](FirmApi.md#putsurchargingstatus) | **PUT** /api/v3/partner/firms/{firm_id}/surcharging/status/{status} | Toggle surcharging status |
| [**SearchChargesByMetadata**](FirmApi.md#searchchargesbymetadata) | **GET** /api/v3/partner/firms/{firm_id}/charges/search | Query metadata to search for Charges, for the given firm |
| [**SetFirmsDefaultBankAccount**](FirmApi.md#setfirmsdefaultbankaccount) | **POST** /api/v3/partner/firms/{firm_id}/accounts/{account_id}/default | Set firms default bank account. |
| [**SyncFirm**](FirmApi.md#syncfirm) | **POST** /api/v3/partner/firms/sync/{connect_id} | Sync a firm by the FeeWise Connect ID |
| [**ToggleFirmProducts**](FirmApi.md#togglefirmproducts) | **POST** /api/v3/partner/firms/{firm_id}/products |  |

<a name="associate"></a>
# **Associate**
> void Associate (string firmConnectId, Guid affiliateId)

Associate a firm with an affiliate

Enables partners to establish an affiliation with FeeWise-registered firms. Partners must obtain the firm's unique FeeWise Connect ID from the firm's dashboard and submit it through this endpoint to create the association. The FeeWise Connect ID can be retrieved by the firm from the settings page.  On association, a `FirmAffiliationCreated` webhook event will be emitted. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class AssociateExample
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
            var firmConnectId = "firmConnectId_example";  // string | 
            var affiliateId = "affiliateId_example";  // Guid | 

            try
            {
                // Associate a firm with an affiliate
                apiInstance.Associate(firmConnectId, affiliateId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FirmApi.Associate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssociateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Associate a firm with an affiliate
    apiInstance.AssociateWithHttpInfo(firmConnectId, affiliateId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FirmApi.AssociateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmConnectId** | **string** |  |  |
| **affiliateId** | **Guid** |  |  |

### Return type

void (empty response body)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Affiliation successfully created |  -  |
| **500** | Server Error |  -  |
| **401** | Access to Firm or Affiliate Unauthorized |  -  |
| **404** | Firm or affiliate not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfirm"></a>
# **CreateFirm**
> FirmDetails CreateFirm (CreateFirm createFirm)

Create a new firm

The createFirm API endpoint facilitates the onboarding of a new firm into the current system. The endpoint allows clients to initiate the onboarding process for their respective firms. Upon a successful http response, the firm's status will be set to \"pending\" in FeeWise. The onboarding process follows a two-step procedure. Initially, the operational team will review the firm's details and perform necessary verifications. Once the firm's information has been validated and approved by the operational team, the firm will be officially onboarded into FeeWise. During the onboarding approval process, a webhook will be triggered for the \"firm.onboarded\" event. The webhook serves as a notification mechanism, enabling integrations and external systems to be updated about the newly onboarded firm. It is important to note that the onboarding process might take some time to complete, as it involves manual verification steps by the operational team. However, clients can track the status of their firm through FeeWise and receive real-time updates through the webhook once the firm onboarding is successfully approved. Please ensure that all necessary information is provided accurately when using this API endpoint to avoid delays in the onboarding process. Additionally, clients should handle the webhook appropriately to capture the \"firm.onboarded\" event and update their internal systems accordingly. Roles must have one and only one representative.  Representative person is an authorised person who represents the firms. The representative must be either an executive or owner. All owners of the firm with greater that 25% must be specified in the roles. 

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

<a name="createfirmaccountowner"></a>
# **CreateFirmAccountOwner**
> void CreateFirmAccountOwner (Guid firmId, CreateFirmAccountOwnerRequest createFirmAccountOwnerRequest)

Create Firm Account Owner

Create a firm account owner, once activated, they can sign into the FeeWise dashboard.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class CreateFirmAccountOwnerExample
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
            var createFirmAccountOwnerRequest = new CreateFirmAccountOwnerRequest(); // CreateFirmAccountOwnerRequest | Firm account owner details

            try
            {
                // Create Firm Account Owner
                apiInstance.CreateFirmAccountOwner(firmId, createFirmAccountOwnerRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FirmApi.CreateFirmAccountOwner: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFirmAccountOwnerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Firm Account Owner
    apiInstance.CreateFirmAccountOwnerWithHttpInfo(firmId, createFirmAccountOwnerRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FirmApi.CreateFirmAccountOwnerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** |  |  |
| **createFirmAccountOwnerRequest** | [**CreateFirmAccountOwnerRequest**](CreateFirmAccountOwnerRequest.md) | Firm account owner details |  |

### Return type

void (empty response body)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successfully created firm account owner |  -  |
| **401** | Unauthorized error |  -  |
| **404** | Firm not found |  -  |
| **409** | Firm User email duplicates existing |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfirmbankaccount"></a>
# **CreateFirmBankAccount**
> BankAccount CreateFirmBankAccount (Guid firmId, BankAccount bankAccount)

Create a bank account

Create an Office or Trust account for a Firm.  If the account doesn't already exist, the new account will be created in `Pending` state. You need to listen for the `firm.bank-account.updated` webhook to know when the account is `Valid` or `Invalid`.  New account validation is subject to [Stripe's validation rules](https://docs.stripe.com/connect/payouts-bank-accounts?bank-account-collection-integration=direct-api&bank-account-collection-method=manual-entry&account-country=US#collecting-external-accounts), which vary by region. Please refer to these rules if the `firm.bank-account.updated` webhook says your account is `Invalid`. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class CreateFirmBankAccountExample
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
            var bankAccount = new BankAccount(); // BankAccount | New account details

            try
            {
                // Create a bank account
                BankAccount result = apiInstance.CreateFirmBankAccount(firmId, bankAccount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FirmApi.CreateFirmBankAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFirmBankAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a bank account
    ApiResponse<BankAccount> response = apiInstance.CreateFirmBankAccountWithHttpInfo(firmId, bankAccount);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FirmApi.CreateFirmBankAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** |  |  |
| **bankAccount** | [**BankAccount**](BankAccount.md) | New account details |  |

### Return type

[**BankAccount**](BankAccount.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Account created |  -  |
| **400** | Bad request |  -  |
| **403** | Forbidden request |  -  |
| **404** | Firm not found |  -  |
| **409** | Firm bank account already exists |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpaymenttoken"></a>
# **CreatePaymentToken**
> PaymentTokenResponse CreatePaymentToken (Guid firmId, PaymentTokenBody paymentTokenBody)

Create a payment token for a customer.

Create a payment token for a customer to capture their payment method details and later use to charge them via the charge and pay endpoint /api/v4/partner/firms/{firm_id}/charges/payment-token/{payment_token}.

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
            var paymentTokenBody = new PaymentTokenBody(); // PaymentTokenBody | Customer and payment method details nb If payment method is not provided, the default will be set to Card. 

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
| **paymentTokenBody** | [**PaymentTokenBody**](PaymentTokenBody.md) | Customer and payment method details nb If payment method is not provided, the default will be set to Card.  |  |

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

<a name="deletefirmbankaccount"></a>
# **DeleteFirmBankAccount**
> void DeleteFirmBankAccount (Guid firmId, Guid accountId)

Delete a bank account

Delete a bank account for a Firm nb: If a bank account is related to an inflight transaction, payout or similar the bank account deletion will fail. Contact FeeWise support to resolve the issue. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class DeleteFirmBankAccountExample
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
                // Delete a bank account
                apiInstance.DeleteFirmBankAccount(firmId, accountId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FirmApi.DeleteFirmBankAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFirmBankAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a bank account
    apiInstance.DeleteFirmBankAccountWithHttpInfo(firmId, accountId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FirmApi.DeleteFirmBankAccountWithHttpInfo: " + e.Message);
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

void (empty response body)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Account deleted |  -  |
| **400** | Bad request |  -  |
| **404** | Firm or account not found |  -  |
| **409** | Account has ongoing artifacts, transactions, etc. |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepaymenttoken"></a>
# **DeletePaymentToken**
> void DeletePaymentToken (Guid firmId, Guid paymentToken)

Delete a payment token

Delete a payment token for given firm

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class DeletePaymentTokenExample
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
            var paymentToken = "paymentToken_example";  // Guid | 

            try
            {
                // Delete a payment token
                apiInstance.DeletePaymentToken(firmId, paymentToken);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FirmApi.DeletePaymentToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePaymentTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a payment token
    apiInstance.DeletePaymentTokenWithHttpInfo(firmId, paymentToken);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FirmApi.DeletePaymentTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** |  |  |
| **paymentToken** | **Guid** |  |  |

### Return type

void (empty response body)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Payment token has been successfully deleted. |  -  |
| **400** | Bad request |  -  |
| **404** | Firm or token not found |  -  |
| **409** | Payment token in use. |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfirm"></a>
# **GetFirm**
> FirmResponse GetFirm (Guid firmId)

Get a firm

Deprecated, prefer /api/v3/partner/firms/firm-details.

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

<a name="getfirmbankaccountbyid"></a>
# **GetFirmBankAccountByID**
> BankAccount GetFirmBankAccountByID (Guid firmId, Guid accountId)

Get a bank account by ID

Get a bank account by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class GetFirmBankAccountByIDExample
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
                // Get a bank account by ID
                BankAccount result = apiInstance.GetFirmBankAccountByID(firmId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FirmApi.GetFirmBankAccountByID: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFirmBankAccountByIDWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a bank account by ID
    ApiResponse<BankAccount> response = apiInstance.GetFirmBankAccountByIDWithHttpInfo(firmId, accountId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FirmApi.GetFirmBankAccountByIDWithHttpInfo: " + e.Message);
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

[**BankAccount**](BankAccount.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return bank account. |  -  |
| **404** | Firm not found |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfirmbankaccounts"></a>
# **GetFirmBankAccounts**
> BankAccountsResponse GetFirmBankAccounts (Guid firmId)

List bank accounts

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
            // Configure API key authorization: FirmApiKey
            config.AddApiKey("X-FIRM-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-FIRM-API-KEY", "Bearer");
            // Configure API key authorization: FirmAuth
            config.AddApiKey("X-FIRM-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-FIRM-ID", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new FirmApi(config);
            var firmId = "firmId_example";  // Guid | 

            try
            {
                // List bank accounts
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
    // List bank accounts
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

[APIAuth](../README.md#APIAuth), [FirmApiKey](../README.md#FirmApiKey), [FirmAuth](../README.md#FirmAuth), [PartnerAuth](../README.md#PartnerAuth)

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

<a name="getfirmbranding"></a>
# **GetFirmBranding**
> GetPartnerBranding200Response GetFirmBranding (Guid firmId)

Get firm branding

Get firm branding. Nb if branding is not set, an empty model will be returned. nb To avoid overwriting the Firms existing brand settings by mistake, this GET endpoint should be used to retrieve the firms current branding PRIOR to using the POST endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class GetFirmBrandingExample
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
                // Get firm branding
                GetPartnerBranding200Response result = apiInstance.GetFirmBranding(firmId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FirmApi.GetFirmBranding: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFirmBrandingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get firm branding
    ApiResponse<GetPartnerBranding200Response> response = apiInstance.GetFirmBrandingWithHttpInfo(firmId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FirmApi.GetFirmBrandingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** |  |  |

### Return type

[**GetPartnerBranding200Response**](GetPartnerBranding200Response.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized request |  -  |
| **500** | Generic Error |  -  |

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

<a name="getfirmdetails"></a>
# **GetFirmDetails**
> FirmDetails GetFirmDetails (Guid? firmId = null, string externalId = null)

Get firm details

Get firm details by Firm ID (UUID) - This is the FeeWise unique ID for a firm OR by External ID (string), the partner's own unique id for a firm. Both will return the same model Firm surcharge settings is defined here. Surcharge price rates can be found as customer variable fee and customer fixed fee per product here: '/api/v3/partner/firms/{firm_id}/pricing'. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class GetFirmDetailsExample
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
            var firmId = "firmId_example";  // Guid? | Firm ID (UUID) (optional) 
            var externalId = "externalId_example";  // string | External ID (string) (optional) 

            try
            {
                // Get firm details
                FirmDetails result = apiInstance.GetFirmDetails(firmId, externalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FirmApi.GetFirmDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFirmDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get firm details
    ApiResponse<FirmDetails> response = apiInstance.GetFirmDetailsWithHttpInfo(firmId, externalId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FirmApi.GetFirmDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid?** | Firm ID (UUID) | [optional]  |
| **externalId** | **string** | External ID (string) | [optional]  |

### Return type

[**FirmDetails**](FirmDetails.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return the Firm. |  -  |
| **400** | Bad request |  -  |
| **404** | Firm not found |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfirmpricing"></a>
# **GetFirmPricing**
> ToggleFirmProducts200Response GetFirmPricing (Guid firmId, string amount = null)

List the pricing products for a firm and their constraints.

Returns an array of pricing products for a specific firm. Surcharge price rates are customer variable fee and customer fixed fee.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class GetFirmPricingExample
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
            var amount = "amount_example";  // string | An example amount.  When supplied, each payment method in the response will contain an `example_amount`, representing the full amount that would be charged including fees, given the amount passed in.  (optional) 

            try
            {
                // List the pricing products for a firm and their constraints.
                ToggleFirmProducts200Response result = apiInstance.GetFirmPricing(firmId, amount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FirmApi.GetFirmPricing: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFirmPricingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the pricing products for a firm and their constraints.
    ApiResponse<ToggleFirmProducts200Response> response = apiInstance.GetFirmPricingWithHttpInfo(firmId, amount);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FirmApi.GetFirmPricingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** |  |  |
| **amount** | **string** | An example amount.  When supplied, each payment method in the response will contain an &#x60;example_amount&#x60;, representing the full amount that would be charged including fees, given the amount passed in.  | [optional]  |

### Return type

[**ToggleFirmProducts200Response**](ToggleFirmProducts200Response.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful response |  -  |
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
            // Configure API key authorization: FirmApiKey
            config.AddApiKey("X-FIRM-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-FIRM-API-KEY", "Bearer");
            // Configure API key authorization: FirmAuth
            config.AddApiKey("X-FIRM-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-FIRM-ID", "Bearer");
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

[APIAuth](../README.md#APIAuth), [FirmApiKey](../README.md#FirmApiKey), [FirmAuth](../README.md#FirmAuth), [PartnerAuth](../README.md#PartnerAuth)

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

<a name="postfirmbrandingcolour"></a>
# **PostFirmBrandingColour**
> void PostFirmBrandingColour (Guid firmId, PostFirmBrandingColourRequest postFirmBrandingColourRequest = null)

Set firm branding colour for firm dashboard

Update firm branding colour

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class PostFirmBrandingColourExample
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
            var postFirmBrandingColourRequest = new PostFirmBrandingColourRequest(); // PostFirmBrandingColourRequest |  (optional) 

            try
            {
                // Set firm branding colour for firm dashboard
                apiInstance.PostFirmBrandingColour(firmId, postFirmBrandingColourRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FirmApi.PostFirmBrandingColour: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostFirmBrandingColourWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set firm branding colour for firm dashboard
    apiInstance.PostFirmBrandingColourWithHttpInfo(firmId, postFirmBrandingColourRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FirmApi.PostFirmBrandingColourWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** |  |  |
| **postFirmBrandingColourRequest** | [**PostFirmBrandingColourRequest**](PostFirmBrandingColourRequest.md) |  | [optional]  |

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
| **204** | Successful Response |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized request |  -  |
| **500** | Generic Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postupload"></a>
# **PostUpload**
> PostUpload200Response PostUpload (Guid firmId, string filePurpose, Guid? personId = null, string documentSide = null, System.IO.Stream fwUploadFile = null)

Upload file

Upload files to FeeWise. nb Content-Type header must be multipart/form-data example  curl -X POST -F \"fwUploadFile=@/path/to/file.png\" \\     http://localhost:8080/api/v3/partner/firms/<firm_id>/upload?file_purpose=identity_document \\       - -header 'X-CHANNEL-PARTNER-ID: <channel partner id>'  \\       - -header 'X-API-KEY: <api key>' \\       - -header \"Content-Type: multipart/form-data\" 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class PostUploadExample
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
            var filePurpose = "business_logo";  // string | Purpose of the uploaded file, must match one of the enum values
            var personId = "personId_example";  // Guid? | person_id is required when the file_purpose is \"identity_document\". The person_id can be retrieved from the firm details endpoint.  (optional) 
            var documentSide = "front";  // string | The side of the \"identity_document\" being uploaded. (optional)  (default to front)
            var fwUploadFile = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                // Upload file
                PostUpload200Response result = apiInstance.PostUpload(firmId, filePurpose, personId, documentSide, fwUploadFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FirmApi.PostUpload: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostUploadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload file
    ApiResponse<PostUpload200Response> response = apiInstance.PostUploadWithHttpInfo(firmId, filePurpose, personId, documentSide, fwUploadFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FirmApi.PostUploadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** |  |  |
| **filePurpose** | **string** | Purpose of the uploaded file, must match one of the enum values |  |
| **personId** | **Guid?** | person_id is required when the file_purpose is \&quot;identity_document\&quot;. The person_id can be retrieved from the firm details endpoint.  | [optional]  |
| **documentSide** | **string** | The side of the \&quot;identity_document\&quot; being uploaded. | [optional] [default to front] |
| **fwUploadFile** | **System.IO.Stream****System.IO.Stream** |  | [optional]  |

### Return type

[**PostUpload200Response**](PostUpload200Response.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized request |  -  |
| **403** | Forbidden request |  -  |
| **500** | Generic Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putsurchargingstatus"></a>
# **PutSurchargingStatus**
> SurchargeSettingsResponse PutSurchargingStatus (Guid firmId, string status, PutSurchargingStatusRequest putSurchargingStatusRequest = null)

Toggle surcharging status

Allows partners to toggle surcharging on or off for a firm. Surcharge pricing values can be found using the endpoint, firms/{firm_id}/pricing 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class PutSurchargingStatusExample
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
            var firmId = "firmId_example";  // Guid | Firm ID (UUID)
            var status = "enable";  // string | enable: The firm would like to enable surcharging disable: The firm would like to disable surcharging ### Region specific rules US environment, there is a 30 day waiting period, for surcharging to be enabled AU environment, surcharging is enabled immediately. * nb: Once surcharging has been enabled a FirmSurchargeStatusChanged webhook will be triggered 
            var putSurchargingStatusRequest = new PutSurchargingStatusRequest(); // PutSurchargingStatusRequest | Optional parameters for surcharging configuration (optional) 

            try
            {
                // Toggle surcharging status
                SurchargeSettingsResponse result = apiInstance.PutSurchargingStatus(firmId, status, putSurchargingStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FirmApi.PutSurchargingStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutSurchargingStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Toggle surcharging status
    ApiResponse<SurchargeSettingsResponse> response = apiInstance.PutSurchargingStatusWithHttpInfo(firmId, status, putSurchargingStatusRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FirmApi.PutSurchargingStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** | Firm ID (UUID) |  |
| **status** | **string** | enable: The firm would like to enable surcharging disable: The firm would like to disable surcharging ### Region specific rules US environment, there is a 30 day waiting period, for surcharging to be enabled AU environment, surcharging is enabled immediately. * nb: Once surcharging has been enabled a FirmSurchargeStatusChanged webhook will be triggered  |  |
| **putSurchargingStatusRequest** | [**PutSurchargingStatusRequest**](PutSurchargingStatusRequest.md) | Optional parameters for surcharging configuration | [optional]  |

### Return type

[**SurchargeSettingsResponse**](SurchargeSettingsResponse.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Toggle success |  -  |
| **400** | Bad request |  -  |
| **404** | Firm not found |  -  |
| **409** | Current surcharging state does not allow disable |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchchargesbymetadata"></a>
# **SearchChargesByMetadata**
> List&lt;ChargeResponse&gt; SearchChargesByMetadata (Guid firmId, MetadataSearch metadataSearch)

Query metadata to search for Charges, for the given firm

Retrieve a firm's charges that are associated with a specific metadata key-value pair

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class SearchChargesByMetadataExample
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
            var metadataSearch = new MetadataSearch(); // MetadataSearch | Metadata search details

            try
            {
                // Query metadata to search for Charges, for the given firm
                List<ChargeResponse> result = apiInstance.SearchChargesByMetadata(firmId, metadataSearch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FirmApi.SearchChargesByMetadata: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchChargesByMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Query metadata to search for Charges, for the given firm
    ApiResponse<List<ChargeResponse>> response = apiInstance.SearchChargesByMetadataWithHttpInfo(firmId, metadataSearch);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FirmApi.SearchChargesByMetadataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** |  |  |
| **metadataSearch** | [**MetadataSearch**](MetadataSearch.md) | Metadata search details |  |

### Return type

[**List&lt;ChargeResponse&gt;**](ChargeResponse.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return the objects that match the metadata key value pairs. |  -  |
| **500** | Error processing |  -  |

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

<a name="togglefirmproducts"></a>
# **ToggleFirmProducts**
> ToggleFirmProducts200Response ToggleFirmProducts (Guid firmId, OptionalProductSettings optionalProductSettings)



Toggle the optional products that are enabled for a firm.  Can be used to enable or disable optional payment types, such as Klarna and Affirm. The products with `Enabled` values will be enabled, products with `Disabled` will be disabled, and omitted products will be ignored. All enabled products for the firm will be returned. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class ToggleFirmProductsExample
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
            var optionalProductSettings = new OptionalProductSettings(); // OptionalProductSettings | An object of optional products that should be enabled for a firm. Only present values will be updated.

            try
            {
                ToggleFirmProducts200Response result = apiInstance.ToggleFirmProducts(firmId, optionalProductSettings);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FirmApi.ToggleFirmProducts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ToggleFirmProductsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ToggleFirmProducts200Response> response = apiInstance.ToggleFirmProductsWithHttpInfo(firmId, optionalProductSettings);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FirmApi.ToggleFirmProductsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** |  |  |
| **optionalProductSettings** | [**OptionalProductSettings**](OptionalProductSettings.md) | An object of optional products that should be enabled for a firm. Only present values will be updated. |  |

### Return type

[**ToggleFirmProducts200Response**](ToggleFirmProducts200Response.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized request |  -  |
| **403** | Forbidden request |  -  |
| **500** | Generic Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

