/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.46
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using FeeWise.Client;
using FeeWise.Model;

namespace FeeWise.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBankAccountApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List all firms bank account&#39;s.
        /// </summary>
        /// <remarks>
        /// Return all bank accounts linked to a firm.  If no accounts are linked an empty array is returned.
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>BankAccountsResponse</returns>
        BankAccountsResponse GetFirmBankAccounts(Guid firmId, int operationIndex = 0);

        /// <summary>
        /// List all firms bank account&#39;s.
        /// </summary>
        /// <remarks>
        /// Return all bank accounts linked to a firm.  If no accounts are linked an empty array is returned.
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of BankAccountsResponse</returns>
        ApiResponse<BankAccountsResponse> GetFirmBankAccountsWithHttpInfo(Guid firmId, int operationIndex = 0);
        /// <summary>
        /// Set firms default bank account.
        /// </summary>
        /// <remarks>
        /// Set the given account as the default bank account (Trust or Office). The account type will determine if the bank account becomes the default office or trust account.
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="accountId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>BankAccountResponse</returns>
        BankAccountResponse SetFirmsDefaultBankAccount(Guid firmId, Guid accountId, int operationIndex = 0);

        /// <summary>
        /// Set firms default bank account.
        /// </summary>
        /// <remarks>
        /// Set the given account as the default bank account (Trust or Office). The account type will determine if the bank account becomes the default office or trust account.
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="accountId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of BankAccountResponse</returns>
        ApiResponse<BankAccountResponse> SetFirmsDefaultBankAccountWithHttpInfo(Guid firmId, Guid accountId, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBankAccountApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// List all firms bank account&#39;s.
        /// </summary>
        /// <remarks>
        /// Return all bank accounts linked to a firm.  If no accounts are linked an empty array is returned.
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BankAccountsResponse</returns>
        System.Threading.Tasks.Task<BankAccountsResponse> GetFirmBankAccountsAsync(Guid firmId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List all firms bank account&#39;s.
        /// </summary>
        /// <remarks>
        /// Return all bank accounts linked to a firm.  If no accounts are linked an empty array is returned.
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BankAccountsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BankAccountsResponse>> GetFirmBankAccountsWithHttpInfoAsync(Guid firmId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Set firms default bank account.
        /// </summary>
        /// <remarks>
        /// Set the given account as the default bank account (Trust or Office). The account type will determine if the bank account becomes the default office or trust account.
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="accountId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BankAccountResponse</returns>
        System.Threading.Tasks.Task<BankAccountResponse> SetFirmsDefaultBankAccountAsync(Guid firmId, Guid accountId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Set firms default bank account.
        /// </summary>
        /// <remarks>
        /// Set the given account as the default bank account (Trust or Office). The account type will determine if the bank account becomes the default office or trust account.
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="accountId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BankAccountResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BankAccountResponse>> SetFirmsDefaultBankAccountWithHttpInfoAsync(Guid firmId, Guid accountId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBankAccountApi : IBankAccountApiSync, IBankAccountApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BankAccountApi : IBankAccountApi
    {
        private FeeWise.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BankAccountApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BankAccountApi(string basePath)
        {
            this.Configuration = FeeWise.Client.Configuration.MergeConfigurations(
                FeeWise.Client.GlobalConfiguration.Instance,
                new FeeWise.Client.Configuration { BasePath = basePath }
            );
            this.Client = new FeeWise.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new FeeWise.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = FeeWise.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BankAccountApi(FeeWise.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = FeeWise.Client.Configuration.MergeConfigurations(
                FeeWise.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new FeeWise.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new FeeWise.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = FeeWise.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public BankAccountApi(FeeWise.Client.ISynchronousClient client, FeeWise.Client.IAsynchronousClient asyncClient, FeeWise.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = FeeWise.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public FeeWise.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public FeeWise.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public FeeWise.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public FeeWise.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// List all firms bank account&#39;s. Return all bank accounts linked to a firm.  If no accounts are linked an empty array is returned.
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>BankAccountsResponse</returns>
        public BankAccountsResponse GetFirmBankAccounts(Guid firmId, int operationIndex = 0)
        {
            FeeWise.Client.ApiResponse<BankAccountsResponse> localVarResponse = GetFirmBankAccountsWithHttpInfo(firmId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all firms bank account&#39;s. Return all bank accounts linked to a firm.  If no accounts are linked an empty array is returned.
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of BankAccountsResponse</returns>
        public FeeWise.Client.ApiResponse<BankAccountsResponse> GetFirmBankAccountsWithHttpInfo(Guid firmId, int operationIndex = 0)
        {
            FeeWise.Client.RequestOptions localVarRequestOptions = new FeeWise.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = FeeWise.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = FeeWise.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("firm_id", FeeWise.Client.ClientUtils.ParameterToString(firmId)); // path parameter

            localVarRequestOptions.Operation = "BankAccountApi.GetFirmBankAccounts";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (APIAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-KEY")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-KEY", this.Configuration.GetApiKeyWithPrefix("X-API-KEY"));
            }
            // authentication (PartnerAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-CHANNEL-PARTNER-ID")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-CHANNEL-PARTNER-ID", this.Configuration.GetApiKeyWithPrefix("X-CHANNEL-PARTNER-ID"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<BankAccountsResponse>("/api/v3/partner/firms/{firm_id}/accounts", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetFirmBankAccounts", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List all firms bank account&#39;s. Return all bank accounts linked to a firm.  If no accounts are linked an empty array is returned.
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BankAccountsResponse</returns>
        public async System.Threading.Tasks.Task<BankAccountsResponse> GetFirmBankAccountsAsync(Guid firmId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            FeeWise.Client.ApiResponse<BankAccountsResponse> localVarResponse = await GetFirmBankAccountsWithHttpInfoAsync(firmId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all firms bank account&#39;s. Return all bank accounts linked to a firm.  If no accounts are linked an empty array is returned.
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BankAccountsResponse)</returns>
        public async System.Threading.Tasks.Task<FeeWise.Client.ApiResponse<BankAccountsResponse>> GetFirmBankAccountsWithHttpInfoAsync(Guid firmId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            FeeWise.Client.RequestOptions localVarRequestOptions = new FeeWise.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = FeeWise.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = FeeWise.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("firm_id", FeeWise.Client.ClientUtils.ParameterToString(firmId)); // path parameter

            localVarRequestOptions.Operation = "BankAccountApi.GetFirmBankAccounts";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (APIAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-KEY")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-KEY", this.Configuration.GetApiKeyWithPrefix("X-API-KEY"));
            }
            // authentication (PartnerAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-CHANNEL-PARTNER-ID")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-CHANNEL-PARTNER-ID", this.Configuration.GetApiKeyWithPrefix("X-CHANNEL-PARTNER-ID"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<BankAccountsResponse>("/api/v3/partner/firms/{firm_id}/accounts", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetFirmBankAccounts", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set firms default bank account. Set the given account as the default bank account (Trust or Office). The account type will determine if the bank account becomes the default office or trust account.
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="accountId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>BankAccountResponse</returns>
        public BankAccountResponse SetFirmsDefaultBankAccount(Guid firmId, Guid accountId, int operationIndex = 0)
        {
            FeeWise.Client.ApiResponse<BankAccountResponse> localVarResponse = SetFirmsDefaultBankAccountWithHttpInfo(firmId, accountId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set firms default bank account. Set the given account as the default bank account (Trust or Office). The account type will determine if the bank account becomes the default office or trust account.
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="accountId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of BankAccountResponse</returns>
        public FeeWise.Client.ApiResponse<BankAccountResponse> SetFirmsDefaultBankAccountWithHttpInfo(Guid firmId, Guid accountId, int operationIndex = 0)
        {
            FeeWise.Client.RequestOptions localVarRequestOptions = new FeeWise.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = FeeWise.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = FeeWise.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("firm_id", FeeWise.Client.ClientUtils.ParameterToString(firmId)); // path parameter
            localVarRequestOptions.PathParameters.Add("account_id", FeeWise.Client.ClientUtils.ParameterToString(accountId)); // path parameter

            localVarRequestOptions.Operation = "BankAccountApi.SetFirmsDefaultBankAccount";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (APIAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-KEY")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-KEY", this.Configuration.GetApiKeyWithPrefix("X-API-KEY"));
            }
            // authentication (PartnerAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-CHANNEL-PARTNER-ID")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-CHANNEL-PARTNER-ID", this.Configuration.GetApiKeyWithPrefix("X-CHANNEL-PARTNER-ID"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<BankAccountResponse>("/api/v3/partner/firms/{firm_id}/accounts/{account_id}/default", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SetFirmsDefaultBankAccount", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set firms default bank account. Set the given account as the default bank account (Trust or Office). The account type will determine if the bank account becomes the default office or trust account.
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="accountId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BankAccountResponse</returns>
        public async System.Threading.Tasks.Task<BankAccountResponse> SetFirmsDefaultBankAccountAsync(Guid firmId, Guid accountId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            FeeWise.Client.ApiResponse<BankAccountResponse> localVarResponse = await SetFirmsDefaultBankAccountWithHttpInfoAsync(firmId, accountId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set firms default bank account. Set the given account as the default bank account (Trust or Office). The account type will determine if the bank account becomes the default office or trust account.
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="accountId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BankAccountResponse)</returns>
        public async System.Threading.Tasks.Task<FeeWise.Client.ApiResponse<BankAccountResponse>> SetFirmsDefaultBankAccountWithHttpInfoAsync(Guid firmId, Guid accountId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            FeeWise.Client.RequestOptions localVarRequestOptions = new FeeWise.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = FeeWise.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = FeeWise.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("firm_id", FeeWise.Client.ClientUtils.ParameterToString(firmId)); // path parameter
            localVarRequestOptions.PathParameters.Add("account_id", FeeWise.Client.ClientUtils.ParameterToString(accountId)); // path parameter

            localVarRequestOptions.Operation = "BankAccountApi.SetFirmsDefaultBankAccount";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (APIAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-KEY")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-KEY", this.Configuration.GetApiKeyWithPrefix("X-API-KEY"));
            }
            // authentication (PartnerAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-CHANNEL-PARTNER-ID")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-CHANNEL-PARTNER-ID", this.Configuration.GetApiKeyWithPrefix("X-CHANNEL-PARTNER-ID"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<BankAccountResponse>("/api/v3/partner/firms/{firm_id}/accounts/{account_id}/default", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SetFirmsDefaultBankAccount", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
