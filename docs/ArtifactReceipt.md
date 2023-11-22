# FeeWise.Model.ArtifactReceipt
An artifact (invoice, matter, deposit, etc...), which also contains the payment receipt id

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReceiptId** | **Guid** | The receipt ID | 
**MatterExternalId** | **string** | The external matter ID of the attached matter | [optional] 
**MatterExternalReference** | **string** | The external matter reference of the attached matter | [optional] 
**ArtifactId** | **Guid** | The artifact ID | 
**ArtifactType** | **ArtifactType** |  | 
**ExternalId** | **string** | The external ID | 
**Name** | **string** | The artifact name | 
**Description** | **string** | The artifact description | [optional] 
**AmountPaid** | **string** | The amount paid for the artifact | 
**Account** | [**ArtifactReceiptAccount**](ArtifactReceiptAccount.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

