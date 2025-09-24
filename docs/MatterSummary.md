# FeeWise.Model.MatterSummary
Contains summarised matter details and any associated artifacts.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MatterId** | **Guid** |  | 
**ExternalId** | **string** | The id of the matter in the PMS. | 
**ExternalReference** | **string** | Freeform reference (normally for the PMS) | [optional] 
**Artifacts** | [**List&lt;Artifact&gt;**](Artifact.md) | List of artifacts associated with the matter, sorted by date asc | [optional] 
**SourceId** | **string** | The source ID that was passed in when creating the matter. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

