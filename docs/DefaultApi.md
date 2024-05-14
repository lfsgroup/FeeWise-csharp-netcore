# FeeWise.Api.DefaultApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteFirmBankAccount**](DefaultApi.md#deletefirmbankaccount) | **DELETE** /api/v3/partner/firms/{firm_id}/accounts/{account_id} | Delete a bank account |

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

            var apiInstance = new DefaultApi(config);
            var firmId = "firmId_example";  // Guid | 
            var accountId = "accountId_example";  // Guid | 

            try
            {
                // Delete a bank account
                apiInstance.DeleteFirmBankAccount(firmId, accountId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteFirmBankAccount: " + e.Message);
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
    Debug.Print("Exception when calling DefaultApi.DeleteFirmBankAccountWithHttpInfo: " + e.Message);
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

