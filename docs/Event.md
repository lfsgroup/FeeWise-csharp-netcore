# FeeWise.Model.Event

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebhookEventId** | **Guid** |  | 
**ExternalId** | **string** | The id of the firm the webhook was related to. | 
**Topic** | **string** | The topic of the event. | 
**Status** | **WebhookSendStatus** |  | 
**Payload** | **Dictionary&lt;string, Object&gt;** | The webhooks payload and metadata about how and when the data was sent. | 
**SentAt** | **DateTime** | The timestamp the webhook send was attempted. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

