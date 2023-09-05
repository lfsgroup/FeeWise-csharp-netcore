# FeeWise.Api.PayoutsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetChannelPartnerPayouts**](PayoutsApi.md#getchannelpartnerpayouts) | **GET** /api/v3/partner/payouts | Get payouts for the channel partner |
| [**GetFirmPayouts**](PayoutsApi.md#getfirmpayouts) | **GET** /api/v3/partner/payouts/firms/{firm_id} | Get payouts for the specified firm |

<a name="getchannelpartnerpayouts"></a>
# **GetChannelPartnerPayouts**
> Payouts GetChannelPartnerPayouts (DateTime? since = null)

Get payouts for the channel partner

Get list of payouts for the channel partner since the provided timestamp.  If not supplied, payouts for the last 24 hours are returned. The channel partner is derived from the PartnerAuth security context 

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
            var since = 2022-07-29T15:33:00Z;  // DateTime? | Return payouts since this timestamp.  If not supplied, payouts for the last 24 hours are returned.  (optional) 

            try
            {
                // Get payouts for the channel partner
                Payouts result = apiInstance.GetChannelPartnerPayouts(since);
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
    // Get payouts for the channel partner
    ApiResponse<Payouts> response = apiInstance.GetChannelPartnerPayoutsWithHttpInfo(since);
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
| **since** | **DateTime?** | Return payouts since this timestamp.  If not supplied, payouts for the last 24 hours are returned.  | [optional]  |

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

<a name="getfirmpayouts"></a>
# **GetFirmPayouts**
> Payouts GetFirmPayouts (Guid firmId, DateTime? since = null)

Get payouts for the specified firm

Get list of payouts for the specified firm.  If the since parameter is not supplied, payouts for the last 24 hours are returned. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class GetFirmPayoutsExample
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
            var firmId = "firmId_example";  // Guid | ID of the firm whose payouts are to be retrieved 
            var since = 2022-07-29T15:33:00Z;  // DateTime? | Return payouts, for the given channel partner / firm, sent since this timestamp.  If not supplied, payouts for the last 24 hours are returned.  (optional) 

            try
            {
                // Get payouts for the specified firm
                Payouts result = apiInstance.GetFirmPayouts(firmId, since);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PayoutsApi.GetFirmPayouts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFirmPayoutsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get payouts for the specified firm
    ApiResponse<Payouts> response = apiInstance.GetFirmPayoutsWithHttpInfo(firmId, since);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PayoutsApi.GetFirmPayoutsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** | ID of the firm whose payouts are to be retrieved  |  |
| **since** | **DateTime?** | Return payouts, for the given channel partner / firm, sent since this timestamp.  If not supplied, payouts for the last 24 hours are returned.  | [optional]  |

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

