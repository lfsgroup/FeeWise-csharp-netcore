# FeeWise.Model.SurchargeSettings
Controls surcharging configuration and availability for a firm  ## Surcharging availability  `SurchargingStatus` `Enabled`:   * `start_date` is in the future, Surcharging will become available on the specified date  * `start_date` is in the past,   Surcharging is immediately available  `SurchargingStatus` `Disabled`, Surcharging is not available (regardless of the `start_date`)   ## Access Information is available in both:   * `FirmSurchargeSettingsEvent` webhooks   * The firm details endpoint (in the `surcharge_settings` field)  ## Webhooks  Any change to the `SurchargingStatus` field will trigger a `FirmSurchargeSettingsEvent` webhook to all subscribers. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SurchargedArtifacts** | [**List&lt;ArtifactType&gt;**](ArtifactType.md) | Specifies which types of artifacts can have surcharges applied | 
**SurchargeTrustPayments** | **bool** | Determines whether Trust payments are subject to surcharging. | 
**StartDate** | **DateTime** | The date and time when surcharging becomes active (when status is Enabled). | [optional] 
**Status** | **SurchargingStatus** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

