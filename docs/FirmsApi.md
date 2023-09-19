# FeeWise.Api.FirmsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostFirmBrandingColour**](FirmsApi.md#postfirmbrandingcolour) | **POST** /api/v3/partner/firms/{firm_id}/branding/colour |  |

<a name="postfirmbrandingcolour"></a>
# **PostFirmBrandingColour**
> void PostFirmBrandingColour (Guid firmId, PostFirmBrandingColourRequest postFirmBrandingColourRequest = null)



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

            var apiInstance = new FirmsApi(config);
            var firmId = "firmId_example";  // Guid | 
            var postFirmBrandingColourRequest = new PostFirmBrandingColourRequest(); // PostFirmBrandingColourRequest |  (optional) 

            try
            {
                apiInstance.PostFirmBrandingColour(firmId, postFirmBrandingColourRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FirmsApi.PostFirmBrandingColour: " + e.Message);
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
    apiInstance.PostFirmBrandingColourWithHttpInfo(firmId, postFirmBrandingColourRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FirmsApi.PostFirmBrandingColourWithHttpInfo: " + e.Message);
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

