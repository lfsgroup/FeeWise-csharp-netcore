# FeeWise.Api.BankAccountApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetFirmBankAccountByID**](BankAccountApi.md#getfirmbankaccountbyid) | **GET** /api/v3/partner/firms/{firm_id}/accounts/{account_id} | Get a bank account by ID. |
| [**GetFirmBankAccounts**](BankAccountApi.md#getfirmbankaccounts) | **GET** /api/v3/partner/firms/{firm_id}/accounts | List all firms bank account&#39;s. |
| [**SetFirmsDefaultBankAccount**](BankAccountApi.md#setfirmsdefaultbankaccount) | **POST** /api/v3/partner/firms/{firm_id}/accounts/{account_id}/default | Set firms default bank account. |

<a name="getfirmbankaccountbyid"></a>
# **GetFirmBankAccountByID**
> BankAccount GetFirmBankAccountByID (Guid firmId, Guid accountId)

Get a bank account by ID.

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

            var apiInstance = new BankAccountApi(config);
            var firmId = "firmId_example";  // Guid | 
            var accountId = "accountId_example";  // Guid | 

            try
            {
                // Get a bank account by ID.
                BankAccount result = apiInstance.GetFirmBankAccountByID(firmId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BankAccountApi.GetFirmBankAccountByID: " + e.Message);
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
    // Get a bank account by ID.
    ApiResponse<BankAccount> response = apiInstance.GetFirmBankAccountByIDWithHttpInfo(firmId, accountId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BankAccountApi.GetFirmBankAccountByIDWithHttpInfo: " + e.Message);
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

            var apiInstance = new BankAccountApi(config);
            var firmId = "firmId_example";  // Guid | 

            try
            {
                // List all firms bank account's.
                BankAccountsResponse result = apiInstance.GetFirmBankAccounts(firmId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BankAccountApi.GetFirmBankAccounts: " + e.Message);
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
    Debug.Print("Exception when calling BankAccountApi.GetFirmBankAccountsWithHttpInfo: " + e.Message);
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

            var apiInstance = new BankAccountApi(config);
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
                Debug.Print("Exception when calling BankAccountApi.SetFirmsDefaultBankAccount: " + e.Message);
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
    Debug.Print("Exception when calling BankAccountApi.SetFirmsDefaultBankAccountWithHttpInfo: " + e.Message);
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

