# FeeWise.Api.PayoutsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetChannelPartnerPayouts**](PayoutsApi.md#getchannelpartnerpayouts) | **GET** /api/v3/partner/payouts | Search for payouts for the channel partner |

<a name="getchannelpartnerpayouts"></a>
# **GetChannelPartnerPayouts**
> Payouts GetChannelPartnerPayouts (Guid? payoutId = null, GetChannelPartnerPayoutsAccountParameter account = null, Guid? firmId = null, Guid? sincePayoutId = null, DateTime? since = null)

Search for payouts for the channel partner

Search for payouts for a channel partner..         The filters supplied in the query params must *all* be met.         The channel partner is derived from the PartnerAuth security context. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class GetChannelPartnerPayoutsExample
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

            var apiInstance = new PayoutsApi(config);
            var payoutId = "payoutId_example";  // Guid? | Get a specific payout. If this is specified, other query params should not be specified  and will result in a BadRequest if the are.  (optional) 
            var account = new GetChannelPartnerPayoutsAccountParameter(); // GetChannelPartnerPayoutsAccountParameter | Get payouts going to a specific account.  (optional) 
            var firmId = "firmId_example";  // Guid? | Get payouts going to a specific firm  (optional) 
            var sincePayoutId = "sincePayoutId_example";  // Guid? | If supplied, all payouts since this payout was sent, are retrieved. The retrieved payouts are subject to the  other filter params (firm_id, settlement_account_id).   NB - 'since_payout_id' and 'since' are mutually exclusive. Supplying both results in a BadRequest error.  (optional) 
            var since = 2022-07-29T15:33:00;  // DateTime? | Return payouts sent since this timestamp. If not supplied, payouts for the last 24 hours are returned.   NB - 'since_payout_id' and 'since' are mutually exclusive. Supplying both results in a BadRequest error.  (optional) 

            try
            {
                // Search for payouts for the channel partner
                Payouts result = apiInstance.GetChannelPartnerPayouts(payoutId, account, firmId, sincePayoutId, since);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PayoutsApi.GetChannelPartnerPayouts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChannelPartnerPayoutsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for payouts for the channel partner
    ApiResponse<Payouts> response = apiInstance.GetChannelPartnerPayoutsWithHttpInfo(payoutId, account, firmId, sincePayoutId, since);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PayoutsApi.GetChannelPartnerPayoutsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **payoutId** | **Guid?** | Get a specific payout. If this is specified, other query params should not be specified  and will result in a BadRequest if the are.  | [optional]  |
| **account** | [**GetChannelPartnerPayoutsAccountParameter**](GetChannelPartnerPayoutsAccountParameter.md) | Get payouts going to a specific account.  | [optional]  |
| **firmId** | **Guid?** | Get payouts going to a specific firm  | [optional]  |
| **sincePayoutId** | **Guid?** | If supplied, all payouts since this payout was sent, are retrieved. The retrieved payouts are subject to the  other filter params (firm_id, settlement_account_id).   NB - &#39;since_payout_id&#39; and &#39;since&#39; are mutually exclusive. Supplying both results in a BadRequest error.  | [optional]  |
| **since** | **DateTime?** | Return payouts sent since this timestamp. If not supplied, payouts for the last 24 hours are returned.   NB - &#39;since_payout_id&#39; and &#39;since&#39; are mutually exclusive. Supplying both results in a BadRequest error.  | [optional]  |

### Return type

[**Payouts**](Payouts.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of matching Payouts |  -  |
| **400** | Incompatible search parameters supplied |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

