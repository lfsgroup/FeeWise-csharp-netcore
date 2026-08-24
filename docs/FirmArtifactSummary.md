# FeeWise.Model.FirmArtifactSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ArtifactType** | **string** | Lowercase artifact type. | 
**ArtifactId** | **Guid** | The FeeWise ID of the artifact. | 
**ExternalArtifactId** | **string** | The ID of the artifact in the partner&#39;s system. | 
**ArtifactNumber** | **string** | The artifact number in the partner&#39;s system. | 
**MatterId** | **Guid** | The FeeWise ID of the matter. | 
**ExternalMatterId** | **string** | The ID of the matter in the partner&#39;s system. | 
**MatterNumber** | **string** |  | 
**MatterType** | **string** |  | 
**AmountDue** | **string** |  | 
**Date** | **DateTime** | The date of the artifact. | 
**DueDate** | **DateTime** |  | 
**DebtorId** | **Guid** | The FeeWise ID of the debtor. | [optional] 
**DebtorExternalId** | **string** | The ID of the debtor in the partner&#39;s system. | 
**DebtorName** | **string** | The name of the debtor. | [optional] 
**DebtorEmail** | **string** | The email address of the debtor. | [optional] 
**DebtorPhoneNumber** | **string** | The phone number of the debtor. | [optional] 
**LastUpdatedAt** | **DateTime** | The timestamp the artifact was last updated. | [optional] 
**FeewisePaymentReferenceNumber** | **string** | FeeWise-generated payment reference number. | 
**PaymentUrl** | **string** | The payment URL for the artifact. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

