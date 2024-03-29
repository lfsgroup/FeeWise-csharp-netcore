# FeeWise.Api.DefaultApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostPartnerLogoUpload**](DefaultApi.md#postpartnerlogoupload) | **POST** /api/v3/partner/upload |  |

<a name="postpartnerlogoupload"></a>
# **PostPartnerLogoUpload**
> PostUpload200Response PostPartnerLogoUpload (System.IO.Stream fwUploadFile = null)



Upload a partner logo to FeeWise. This logo will be used wherever FeeWise and the partner have agreed to show a logo in the FeeWise UI. nb Content-Type header must be multipart/form-data example  curl -X POST -F \"fwUploadFile=@/path/to/file.png\" \\     http://localhost:8080/api/v3/partner/upload \\       - -header 'X-CHANNEL-PARTNER-ID: <channel partner id>'                - -header 'X-API-KEY: <api key>' \\       - -header \"Content-Type: multipart/form-data\" 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class PostPartnerLogoUploadExample
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
            var fwUploadFile = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                PostUpload200Response result = apiInstance.PostPartnerLogoUpload(fwUploadFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.PostPartnerLogoUpload: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostPartnerLogoUploadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostUpload200Response> response = apiInstance.PostPartnerLogoUploadWithHttpInfo(fwUploadFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.PostPartnerLogoUploadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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
| **500** | Generic Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

