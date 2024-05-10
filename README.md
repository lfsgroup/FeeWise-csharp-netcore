# FeeWise - the C# library for the FeeWise Partner API

API for partners

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 0.0.117
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;
```
<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FeeWise.Api;
using FeeWise.Client;
using FeeWise.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: APIAuth
            config.ApiKey.Add("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("X-API-KEY", "Bearer");
            // Configure API key authorization: PartnerAuth
            config.ApiKey.Add("X-CHANNEL-PARTNER-ID", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("X-CHANNEL-PARTNER-ID", "Bearer");

            var apiInstance = new APIKeyApi(config);
            var apiKeyRotation = new ApiKeyRotation(); // ApiKeyRotation |  (optional) 

            try
            {
                // Rotate API Key
                ApiKeyResponse result = apiInstance.RotateApiKey(apiKeyRotation);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling APIKeyApi.RotateApiKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*APIKeyApi* | [**RotateApiKey**](docs/APIKeyApi.md#rotateapikey) | **POST** /api/v3/partner/rotatekey | Rotate API Key
*AccountsApi* | [**CreateFirmBankAccount**](docs/AccountsApi.md#createfirmbankaccount) | **POST** /api/v3/partner/firms/{firm_id}/accounts | Create an account
*BankAccountApi* | [**GetFirmBankAccountByID**](docs/BankAccountApi.md#getfirmbankaccountbyid) | **GET** /api/v3/partner/firms/{firm_id}/accounts/{account_id} | Get a bank account by ID.
*BankAccountApi* | [**GetFirmBankAccounts**](docs/BankAccountApi.md#getfirmbankaccounts) | **GET** /api/v3/partner/firms/{firm_id}/accounts | List all firms bank account's.
*BankAccountApi* | [**SetFirmsDefaultBankAccount**](docs/BankAccountApi.md#setfirmsdefaultbankaccount) | **POST** /api/v3/partner/firms/{firm_id}/accounts/{account_id}/default | Set firms default bank account.
*FirmApi* | [**CreateFirm**](docs/FirmApi.md#createfirm) | **POST** /api/v3/partner/firms | Create a new firm
*FirmApi* | [**CreateFirmAccountOwner**](docs/FirmApi.md#createfirmaccountowner) | **POST** /api/v3/partner/firms/{firm_id}/owner | Create Firm Account Owner
*FirmApi* | [**CreatePaymentToken**](docs/FirmApi.md#createpaymenttoken) | **POST** /api/v3/partner/firms/{firm_id}/payment_token | Create a payment token for a customer.
*FirmApi* | [**DeletePaymentToken**](docs/FirmApi.md#deletepaymenttoken) | **DELETE** /api/v3/partner/firms/{firm_id}/payment_token/{payment_token} | Delete a payment token.
*FirmApi* | [**GetFirm**](docs/FirmApi.md#getfirm) | **GET** /api/v3/partner/firms/{firm_id} | Get a firm
*FirmApi* | [**GetFirmBankAccountByID**](docs/FirmApi.md#getfirmbankaccountbyid) | **GET** /api/v3/partner/firms/{firm_id}/accounts/{account_id} | Get a bank account by ID.
*FirmApi* | [**GetFirmBankAccounts**](docs/FirmApi.md#getfirmbankaccounts) | **GET** /api/v3/partner/firms/{firm_id}/accounts | List all firms bank account's.
*FirmApi* | [**GetFirmCustomers**](docs/FirmApi.md#getfirmcustomers) | **GET** /api/v3/partner/firms/{firm_id}/customers | List all the customers for a firm.
*FirmApi* | [**GetFirmDetails**](docs/FirmApi.md#getfirmdetails) | **GET** /api/v3/partner/firms/firm-details | Get firm details
*FirmApi* | [**GetFirms**](docs/FirmApi.md#getfirms) | **GET** /api/v3/partner/firms | Get firms
*FirmApi* | [**GetMagicLink**](docs/FirmApi.md#getmagiclink) | **POST** /api/v3/partner/firms/{firm_id}/magic-link | Create a magic link
*FirmApi* | [**PostFirmBrandingColour**](docs/FirmApi.md#postfirmbrandingcolour) | **POST** /api/v3/partner/firms/{firm_id}/branding/colour | Set firm branding colour for firm dashboard
*FirmApi* | [**PostUpload**](docs/FirmApi.md#postupload) | **POST** /api/v3/partner/firms/{firm_id}/upload | Upload file
*FirmApi* | [**SearchChargesByMetadata**](docs/FirmApi.md#searchchargesbymetadata) | **GET** /api/v3/partner/firms/{firm_id}/charges/search | Query metadata to search for Charges, for the given firm
*FirmApi* | [**SetFirmsDefaultBankAccount**](docs/FirmApi.md#setfirmsdefaultbankaccount) | **POST** /api/v3/partner/firms/{firm_id}/accounts/{account_id}/default | Set firms default bank account.
*FirmApi* | [**SyncFirm**](docs/FirmApi.md#syncfirm) | **POST** /api/v3/partner/firms/sync/{connect_id} | Sync a firm by the FeeWise Connect ID
*PartnerApi* | [**GetPartnerBranding**](docs/PartnerApi.md#getpartnerbranding) | **GET** /api/v3/partner/branding | Get partner branding
*PartnerApi* | [**PostPartnerLogoUpload**](docs/PartnerApi.md#postpartnerlogoupload) | **POST** /api/v3/partner/upload | Upload partner logo
*PaymentsApi* | [**AdjustInvoiceAmount**](docs/PaymentsApi.md#adjustinvoiceamount) | **POST** /api/v3/partner/invoices/{invoice_id}/adjust-amount | Adjust an invoice.
*PaymentsApi* | [**AdjustTrustDepositAmount**](docs/PaymentsApi.md#adjusttrustdepositamount) | **POST** /api/v3/partner/trust-deposits/{trust_deposit_id}/adjust-amount | Adjust an trust deposit.
*PaymentsApi* | [**CreateCharge**](docs/PaymentsApi.md#createcharge) | **POST** /api/v3/partner/firms/{firm_id}/charges | Create a Charge
*PaymentsApi* | [**CreateChargeAndPayWithCustomerPaymentToken**](docs/PaymentsApi.md#createchargeandpaywithcustomerpaymenttoken) | **POST** /api/v3/partner/firms/{firm_id}/charges/payment_token/{payment_token} | Create Charge, and pay directly.
*PaymentsApi* | [**CreateInvoice**](docs/PaymentsApi.md#createinvoice) | **POST** /api/v3/partner/invoices | Create an Invoice
*PaymentsApi* | [**CreateMatter**](docs/PaymentsApi.md#creatematter) | **POST** /api/v3/partner/matters | Create a matter
*PaymentsApi* | [**CreateSplitCharge**](docs/PaymentsApi.md#createsplitcharge) | **POST** /api/v3/partner/firms/{firm_id}/charges/split | Create split charges, each charge is distributed to its own settlement account.
*PaymentsApi* | [**CreateTrustDeposit**](docs/PaymentsApi.md#createtrustdeposit) | **POST** /api/v3/partner/trust-deposits | Create a Trust Deposit
*PaymentsApi* | [**GetChannelPartnerPayments**](docs/PaymentsApi.md#getchannelpartnerpayments) | **GET** /api/v3/partner/payments | DEPRECATED use /transactions - Search for payments for the channel partner
*PaymentsApi* | [**GetDebtorMatterStatement**](docs/PaymentsApi.md#getdebtormatterstatement) | **GET** /api/v3/partner/statements/debtors/{debtor_id}/matters/{matter_id} | Get a matter debtor statement
*PaymentsApi* | [**GetInvoiceByExternalId**](docs/PaymentsApi.md#getinvoicebyexternalid) | **GET** /api/v3/partner/invoices/firm/{firm_id}/{external_id} | Get invoice by external_id
*PaymentsApi* | [**GetInvoiceById**](docs/PaymentsApi.md#getinvoicebyid) | **GET** /api/v3/partner/invoices/{invoice_id} | Get a specified invoice by id.
*PaymentsApi* | [**GetMatterStatement**](docs/PaymentsApi.md#getmatterstatement) | **GET** /api/v3/partner/statements/matters/{matter_id} | Get a matter statement
*PaymentsApi* | [**GetTrustDepositByExternalId**](docs/PaymentsApi.md#gettrustdepositbyexternalid) | **GET** /api/v3/partner/trust-deposits/firm/{firm_id}/{external_id} | Get Trust Deposit by external_id
*PaymentsApi* | [**GetTrustDepositById**](docs/PaymentsApi.md#gettrustdepositbyid) | **GET** /api/v3/partner/trust-deposits/{trust_deposit_id} | Get a Trust Deposit by id.
*PaymentsApi* | [**RecordExternalPayment**](docs/PaymentsApi.md#recordexternalpayment) | **POST** /api/v3/partner/payments/external | Record external payment.
*PayoutsApi* | [**GetChannelPartnerPayouts**](docs/PayoutsApi.md#getchannelpartnerpayouts) | **GET** /api/v3/partner/payouts | Get payouts for the channel partner
*PayoutsApi* | [**GetFirmPayouts**](docs/PayoutsApi.md#getfirmpayouts) | **GET** /api/v3/partner/payouts/firms/{firm_id} | Get payouts for the specified firm
*PayoutsApi* | [**GetPayoutsForFirm**](docs/PayoutsApi.md#getpayoutsforfirm) | **GET** /api/v3/partner/firms/{firm_id}/payouts | 
*TransactionsApi* | [**GetFirmTransactions**](docs/TransactionsApi.md#getfirmtransactions) | **GET** /api/v3/partner/firms/{firm_id}/transactions | 
*WebhookApi* | [**CreateWebhook**](docs/WebhookApi.md#createwebhook) | **POST** /api/v3/partner/webhooks | Create a webhook
*WebhookApi* | [**DeleteWebhook**](docs/WebhookApi.md#deletewebhook) | **DELETE** /api/v3/partner/webhooks/{webhook_id} | Delete Webhook
*WebhookApi* | [**GetChannelPartnerEventTopics**](docs/WebhookApi.md#getchannelpartnereventtopics) | **GET** /api/v3/partner/events/topics | Get a list of event topics for the channel partner
*WebhookApi* | [**GetChannelPartnerWebhookEvents**](docs/WebhookApi.md#getchannelpartnerwebhookevents) | **GET** /api/v3/partner/events | Get a list of events for the channel partner
*WebhookApi* | [**GetWebhooks**](docs/WebhookApi.md#getwebhooks) | **GET** /api/v3/partner/webhooks | Get list of webhooks for the partner
*WebhookApi* | [**ReceiveWebhook**](docs/WebhookApi.md#receivewebhook) | **POST** /api/v3/partner/webhook/receiver | Dummy receiver for webhooks.
*WebhookApi* | [**UpdateWebhook**](docs/WebhookApi.md#updatewebhook) | **PUT** /api/v3/partner/webhooks | Update a webhook


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AccountType](docs/AccountType.md)
 - [Model.Address](docs/Address.md)
 - [Model.AdjustInvoiceAmountRequest](docs/AdjustInvoiceAmountRequest.md)
 - [Model.AdjustTrustDepositAmountRequest](docs/AdjustTrustDepositAmountRequest.md)
 - [Model.ApiKeyResponse](docs/ApiKeyResponse.md)
 - [Model.ApiKeyRotation](docs/ApiKeyRotation.md)
 - [Model.Artifact](docs/Artifact.md)
 - [Model.ArtifactReceipt](docs/ArtifactReceipt.md)
 - [Model.ArtifactReceiptAccount](docs/ArtifactReceiptAccount.md)
 - [Model.ArtifactType](docs/ArtifactType.md)
 - [Model.BankAccount](docs/BankAccount.md)
 - [Model.BankAccountResponse](docs/BankAccountResponse.md)
 - [Model.BankAccountsResponse](docs/BankAccountsResponse.md)
 - [Model.CardPayment](docs/CardPayment.md)
 - [Model.Charge](docs/Charge.md)
 - [Model.ChargeAndPayResponse](docs/ChargeAndPayResponse.md)
 - [Model.ChargeResponse](docs/ChargeResponse.md)
 - [Model.Company](docs/Company.md)
 - [Model.CreateFirm](docs/CreateFirm.md)
 - [Model.CreateFirmAccountOwnerRequest](docs/CreateFirmAccountOwnerRequest.md)
 - [Model.Currency](docs/Currency.md)
 - [Model.CustomerDetails](docs/CustomerDetails.md)
 - [Model.CustomerPaymentMethod](docs/CustomerPaymentMethod.md)
 - [Model.CustomersResponse](docs/CustomersResponse.md)
 - [Model.DebitPayment](docs/DebitPayment.md)
 - [Model.Debtor](docs/Debtor.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.ErrorResponseErrorContext](docs/ErrorResponseErrorContext.md)
 - [Model.Event](docs/Event.md)
 - [Model.EventFilters](docs/EventFilters.md)
 - [Model.EventTopics](docs/EventTopics.md)
 - [Model.Events](docs/Events.md)
 - [Model.ExternalPayment](docs/ExternalPayment.md)
 - [Model.ExternalPaymentResponse](docs/ExternalPaymentResponse.md)
 - [Model.Firm](docs/Firm.md)
 - [Model.FirmBankAccountEvent](docs/FirmBankAccountEvent.md)
 - [Model.FirmDetails](docs/FirmDetails.md)
 - [Model.FirmOnboardingStatus](docs/FirmOnboardingStatus.md)
 - [Model.FirmResponse](docs/FirmResponse.md)
 - [Model.FirmStatusUpdatedEvent](docs/FirmStatusUpdatedEvent.md)
 - [Model.FirmsResponse](docs/FirmsResponse.md)
 - [Model.GetMagicLink200Response](docs/GetMagicLink200Response.md)
 - [Model.GetPartnerBranding200Response](docs/GetPartnerBranding200Response.md)
 - [Model.Invoice](docs/Invoice.md)
 - [Model.InvoiceResponse](docs/InvoiceResponse.md)
 - [Model.LineItem](docs/LineItem.md)
 - [Model.Matter](docs/Matter.md)
 - [Model.MatterRequest](docs/MatterRequest.md)
 - [Model.MatterResponse](docs/MatterResponse.md)
 - [Model.MatterStatement](docs/MatterStatement.md)
 - [Model.MetadataSearch](docs/MetadataSearch.md)
 - [Model.PaginatedTransaction](docs/PaginatedTransaction.md)
 - [Model.PaginationMetadata](docs/PaginationMetadata.md)
 - [Model.PartyBranding](docs/PartyBranding.md)
 - [Model.Payer](docs/Payer.md)
 - [Model.Payment](docs/Payment.md)
 - [Model.PaymentAuthorisedEvent](docs/PaymentAuthorisedEvent.md)
 - [Model.PaymentExternalPayment](docs/PaymentExternalPayment.md)
 - [Model.PaymentMethod](docs/PaymentMethod.md)
 - [Model.PaymentNotificationEvent](docs/PaymentNotificationEvent.md)
 - [Model.PaymentTokenBody](docs/PaymentTokenBody.md)
 - [Model.PaymentTokenResponse](docs/PaymentTokenResponse.md)
 - [Model.Payments](docs/Payments.md)
 - [Model.Payout](docs/Payout.md)
 - [Model.PayoutAccount](docs/PayoutAccount.md)
 - [Model.PayoutStatus](docs/PayoutStatus.md)
 - [Model.Payouts](docs/Payouts.md)
 - [Model.PayoutsResponse](docs/PayoutsResponse.md)
 - [Model.Person](docs/Person.md)
 - [Model.PostFirmBrandingColourRequest](docs/PostFirmBrandingColourRequest.md)
 - [Model.PostPartnerLogoUpload200Response](docs/PostPartnerLogoUpload200Response.md)
 - [Model.PostUpload200Response](docs/PostUpload200Response.md)
 - [Model.SplitCharge](docs/SplitCharge.md)
 - [Model.SplitChargesResponse](docs/SplitChargesResponse.md)
 - [Model.SurchargeChoice](docs/SurchargeChoice.md)
 - [Model.TermsOfService](docs/TermsOfService.md)
 - [Model.TokenType](docs/TokenType.md)
 - [Model.Transaction](docs/Transaction.md)
 - [Model.TransactionStatus](docs/TransactionStatus.md)
 - [Model.TransactionsResponse](docs/TransactionsResponse.md)
 - [Model.TrustDeposit](docs/TrustDeposit.md)
 - [Model.TrustDepositResponse](docs/TrustDepositResponse.md)
 - [Model.Webhook](docs/Webhook.md)
 - [Model.WebhookApiAuthentication](docs/WebhookApiAuthentication.md)
 - [Model.WebhookEvent](docs/WebhookEvent.md)
 - [Model.WebhookEventEvent](docs/WebhookEventEvent.md)
 - [Model.WebhookList](docs/WebhookList.md)
 - [Model.WebhookResponse](docs/WebhookResponse.md)
 - [Model.WebhookSendStatus](docs/WebhookSendStatus.md)
 - [Model.WebhookStatus](docs/WebhookStatus.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="APIAuth"></a>
### APIAuth

- **Type**: API key
- **API key parameter name**: X-API-KEY
- **Location**: HTTP header

<a name="PartnerAuth"></a>
### PartnerAuth

- **Type**: API key
- **API key parameter name**: X-CHANNEL-PARTNER-ID
- **Location**: HTTP header

