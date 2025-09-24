# FeeWise.Api.AuthApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RetrieveFirmAPIKey**](AuthApi.md#retrievefirmapikey) | **POST** /api/v3/partner/firms/{firm_id}/auth | Retrieve the details of a firm&#39;s API key |

<a name="retrievefirmapikey"></a>
# **RetrieveFirmAPIKey**
> FirmAuthResponse RetrieveFirmAPIKey (Guid firmId)

Retrieve the details of a firm's API key

A firm specific api key can be used to make requests to the FeeWise API. If no key exists, a new key will be created. nb As the endpoint is idempotent, POST is used. (i.e. subsequent invocations will result in the same value)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class RetrieveFirmAPIKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: PartnerAuth
            config.AddApiKey("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new AuthApi(config);
            var firmId = "firmId_example";  // Guid | 

            try
            {
                // Retrieve the details of a firm's API key
                FirmAuthResponse result = apiInstance.RetrieveFirmAPIKey(firmId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.RetrieveFirmAPIKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveFirmAPIKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the details of a firm's API key
    ApiResponse<FirmAuthResponse> response = apiInstance.RetrieveFirmAPIKeyWithHttpInfo(firmId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.RetrieveFirmAPIKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firmId** | **Guid** |  |  |

### Return type

[**FirmAuthResponse**](FirmAuthResponse.md)

### Authorization

[PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Key retrieved |  -  |
| **401** | Unauthorized - invalid partner credentials |  -  |
| **404** | Firm not found |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

