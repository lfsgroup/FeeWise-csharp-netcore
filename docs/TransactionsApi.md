# FeeWise.Api.TransactionsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetFirmTransactions**](TransactionsApi.md#getfirmtransactions) | **GET** /api/v3/partner/firms/{firm_id}/transactions |  |

<a name="getfirmtransactions"></a>
# **GetFirmTransactions**
> TransactionsResponse GetFirmTransactions (Guid firmId, DateTime? from = null, DateTime? to = null, int? page = null, int? pageSize = null, string sortBy = null, string order = null, List<string> statusFilter = null, List<Guid> accountIdFilter = null)



Search for transactions for a channel partner..         Filters supplied in the query params must *all* be met. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class GetFirmTransactionsExample
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

            var apiInstance = new TransactionsApi(config);
            var firmId = "firmId_example";  // Guid | 
            var from = 2023-09-20T00:00:00.000Z;  // DateTime? | Return transactions since this timestamp. If not supplied, \"from\" defaults to the last 7 days\".  (optional) 
            var to = 2023-09-20T00:00:00.000Z;  // DateTime? | Return payments created before timestamp. If not supplied, \"to\" defaults to now.  (optional) 
            var page = 1;  // int? | Pagination - Page number to return  (optional)  (default to 1)
            var pageSize = 20;  // int? | Pagination - Transactions per page  (optional)  (default to 20)
            var sortBy = "account_id";  // string | Field to sort by, from the transaction model (optional)  (default to payment_date)
            var order = "asc";  // string | Sorting order (asc or desc). Default is desc  (optional)  (default to desc)
            var statusFilter = new List<string>(); // List<string> | Filter by status nb: Example usage, comma separated, in query... /transactions?status_filter=Paid,Initialised  (optional) 
            var accountIdFilter = new List<Guid>(); // List<Guid> | Filter by account id nb: Example usage, comma separated, in query... /transactions?account_id=57d43c4e-f18d-40ae-9511-2aeafbf68def,b7dc7851-5cc4-41d5-8174-f00ad916f76b  (optional) 

            try
            {
                TransactionsResponse result = apiInstance.GetFirmTransactions(firmId, from, to, page, pageSize, sortBy, order, statusFilter, accountIdFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetFirmTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFirmTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TransactionsResponse> response = apiInstance.GetFirmTransactionsWithHttpInfo(firmId, from, to, page, pageSize, sortBy, order, statusFilter, accountIdFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.GetFirmTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** |  |  |
| **from** | **DateTime?** | Return transactions since this timestamp. If not supplied, \&quot;from\&quot; defaults to the last 7 days\&quot;.  | [optional]  |
| **to** | **DateTime?** | Return payments created before timestamp. If not supplied, \&quot;to\&quot; defaults to now.  | [optional]  |
| **page** | **int?** | Pagination - Page number to return  | [optional] [default to 1] |
| **pageSize** | **int?** | Pagination - Transactions per page  | [optional] [default to 20] |
| **sortBy** | **string** | Field to sort by, from the transaction model | [optional] [default to payment_date] |
| **order** | **string** | Sorting order (asc or desc). Default is desc  | [optional] [default to desc] |
| **statusFilter** | [**List&lt;string&gt;**](string.md) | Filter by status nb: Example usage, comma separated, in query... /transactions?status_filter&#x3D;Paid,Initialised  | [optional]  |
| **accountIdFilter** | [**List&lt;Guid&gt;**](Guid.md) | Filter by account id nb: Example usage, comma separated, in query... /transactions?account_id&#x3D;57d43c4e-f18d-40ae-9511-2aeafbf68def,b7dc7851-5cc4-41d5-8174-f00ad916f76b  | [optional]  |

### Return type

[**TransactionsResponse**](TransactionsResponse.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of transactions for the firm |  -  |
| **400** | Incompatible search parameters supplied |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

