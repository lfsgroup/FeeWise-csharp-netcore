# FeeWise.Api.WebhookApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateWebhook**](WebhookApi.md#createwebhook) | **POST** /api/v3/partner/webhooks | Create a webhook |
| [**DeleteWebhook**](WebhookApi.md#deletewebhook) | **DELETE** /api/v3/partner/webhooks/{webhook_id} | Delete Webhook |
| [**GetChannelPartnerEventTopics**](WebhookApi.md#getchannelpartnereventtopics) | **GET** /api/v3/partner/events/topics | Get a list of event topics for the channel partner |
| [**GetChannelPartnerWebhookEvents**](WebhookApi.md#getchannelpartnerwebhookevents) | **GET** /api/v3/partner/events | Get a list of events for the channel partner |
| [**GetWebhooks**](WebhookApi.md#getwebhooks) | **GET** /api/v3/partner/webhooks | Get list of webhooks for the partner |
| [**ReceiveWebhook**](WebhookApi.md#receivewebhook) | **POST** /api/v3/partner/webhook/receiver | Dummy receiver for webhooks. |
| [**UpdateWebhook**](WebhookApi.md#updatewebhook) | **PUT** /api/v3/partner/webhooks | Update a webhook |

<a name="createwebhook"></a>
# **CreateWebhook**
> WebhookResponse CreateWebhook (Webhook webhook)

Create a webhook

Create a webhook

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class CreateWebhookExample
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

            var apiInstance = new WebhookApi(config);
            var webhook = new Webhook(); // Webhook | Webhook details. webhook_id must not be supplied. If it is, the POST will be considered a BadRequest

            try
            {
                // Create a webhook
                WebhookResponse result = apiInstance.CreateWebhook(webhook);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.CreateWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a webhook
    ApiResponse<WebhookResponse> response = apiInstance.CreateWebhookWithHttpInfo(webhook);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.CreateWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhook** | [**Webhook**](Webhook.md) | Webhook details. webhook_id must not be supplied. If it is, the POST will be considered a BadRequest |  |

### Return type

[**WebhookResponse**](WebhookResponse.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/jsopn


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Created Webhook |  -  |
| **409** | A webhook already exists for the partyId with the same url and events. |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletewebhook"></a>
# **DeleteWebhook**
> void DeleteWebhook (Guid webhookId)

Delete Webhook

Delete a webhook by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class DeleteWebhookExample
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

            var apiInstance = new WebhookApi(config);
            var webhookId = "webhookId_example";  // Guid | 

            try
            {
                // Delete Webhook
                apiInstance.DeleteWebhook(webhookId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.DeleteWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Webhook
    apiInstance.DeleteWebhookWithHttpInfo(webhookId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.DeleteWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookId** | **Guid** |  |  |

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
| **204** | Deleted Webhook |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelpartnereventtopics"></a>
# **GetChannelPartnerEventTopics**
> EventTopics GetChannelPartnerEventTopics ()

Get a list of event topics for the channel partner

All currently available event topics for the channel partner are returned.          The channel partner is derived from the PartnerAuth security context 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class GetChannelPartnerEventTopicsExample
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

            var apiInstance = new WebhookApi(config);

            try
            {
                // Get a list of event topics for the channel partner
                EventTopics result = apiInstance.GetChannelPartnerEventTopics();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.GetChannelPartnerEventTopics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChannelPartnerEventTopicsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of event topics for the channel partner
    ApiResponse<EventTopics> response = apiInstance.GetChannelPartnerEventTopicsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.GetChannelPartnerEventTopicsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**EventTopics**](EventTopics.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of currently available event topics |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelpartnerwebhookevents"></a>
# **GetChannelPartnerWebhookEvents**
> Events GetChannelPartnerWebhookEvents (string topic = null, Guid? sinceWebhookEventId = null, DateTime? since = null, WebhookSendStatus? status = null)

Get a list of events for the channel partner

Returns events for the channel partner matching the filter criteria.         The filters supplied in the query params must *all* be met.         The channel partner is derived from the PartnerAuth security context. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class GetChannelPartnerWebhookEventsExample
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

            var apiInstance = new WebhookApi(config);
            var topic = payout.paid;  // string |  (optional) 
            var sinceWebhookEventId = "sinceWebhookEventId_example";  // Guid? | If supplied, all events since this webhook event was sent, are retrieved. The retrieved events are subject to the  other filter params (topic, status).   NB - 'since_webhook_event_id' and 'since' are mutually exclusive. Supplying both results in a BadRequest error.  (optional) 
            var since = 2023-09-01T00:00:00Z;  // DateTime? | Return events sent since this timestamp. If not supplied, events for the last 24 hours are returned.   NB - 'since_webhook_event_id' and 'since' are mutually exclusive. Supplying both results in a BadRequest error.  (optional) 
            var status = (WebhookSendStatus) "sent";  // WebhookSendStatus? | Webhook send status (optional) 

            try
            {
                // Get a list of events for the channel partner
                Events result = apiInstance.GetChannelPartnerWebhookEvents(topic, sinceWebhookEventId, since, status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.GetChannelPartnerWebhookEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChannelPartnerWebhookEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of events for the channel partner
    ApiResponse<Events> response = apiInstance.GetChannelPartnerWebhookEventsWithHttpInfo(topic, sinceWebhookEventId, since, status);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.GetChannelPartnerWebhookEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **topic** | **string** |  | [optional]  |
| **sinceWebhookEventId** | **Guid?** | If supplied, all events since this webhook event was sent, are retrieved. The retrieved events are subject to the  other filter params (topic, status).   NB - &#39;since_webhook_event_id&#39; and &#39;since&#39; are mutually exclusive. Supplying both results in a BadRequest error.  | [optional]  |
| **since** | **DateTime?** | Return events sent since this timestamp. If not supplied, events for the last 24 hours are returned.   NB - &#39;since_webhook_event_id&#39; and &#39;since&#39; are mutually exclusive. Supplying both results in a BadRequest error.  | [optional]  |
| **status** | **WebhookSendStatus?** | Webhook send status | [optional]  |

### Return type

[**Events**](Events.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of matching events |  -  |
| **400** | Incompatible search parameters supplied |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooks"></a>
# **GetWebhooks**
> WebhookList GetWebhooks ()

Get list of webhooks for the partner

Get list of webhooks for the partner

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class GetWebhooksExample
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

            var apiInstance = new WebhookApi(config);

            try
            {
                // Get list of webhooks for the partner
                WebhookList result = apiInstance.GetWebhooks();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.GetWebhooks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWebhooksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get list of webhooks for the partner
    ApiResponse<WebhookList> response = apiInstance.GetWebhooksWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.GetWebhooksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**WebhookList**](WebhookList.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/jsopn


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of webhooks |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="receivewebhook"></a>
# **ReceiveWebhook**
> void ReceiveWebhook (WebhookEvent webhookEvent)

Dummy receiver for webhooks.

This is a webhook receiver. Normally implemented by channel partners to receive webhooks

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class ReceiveWebhookExample
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

            var apiInstance = new WebhookApi(config);
            var webhookEvent = new WebhookEvent(); // WebhookEvent | Webhook event.

            try
            {
                // Dummy receiver for webhooks.
                apiInstance.ReceiveWebhook(webhookEvent);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.ReceiveWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReceiveWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dummy receiver for webhooks.
    apiInstance.ReceiveWebhookWithHttpInfo(webhookEvent);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.ReceiveWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookEvent** | [**WebhookEvent**](WebhookEvent.md) | Webhook event. |  |

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
| **200** | The webhook was received |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewebhook"></a>
# **UpdateWebhook**
> WebhookResponse UpdateWebhook (Webhook webhook)

Update a webhook

Update a webhook

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class UpdateWebhookExample
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

            var apiInstance = new WebhookApi(config);
            var webhook = new Webhook(); // Webhook | Webhook details.

            try
            {
                // Update a webhook
                WebhookResponse result = apiInstance.UpdateWebhook(webhook);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookApi.UpdateWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a webhook
    ApiResponse<WebhookResponse> response = apiInstance.UpdateWebhookWithHttpInfo(webhook);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookApi.UpdateWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhook** | [**Webhook**](Webhook.md) | Webhook details. |  |

### Return type

[**WebhookResponse**](WebhookResponse.md)

### Authorization

[APIAuth](../README.md#APIAuth), [PartnerAuth](../README.md#PartnerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Webhook updated. |  -  |
| **404** | The specified webhook (by webhook_id) not found |  -  |
| **409** | The update causes a conflict with an existing webhook (same partyId, url and events). |  -  |
| **500** | Error processing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

