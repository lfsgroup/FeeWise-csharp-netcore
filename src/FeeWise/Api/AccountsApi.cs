/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.102
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
    public interface IAccountsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create an account
        /// </summary>
        /// <remarks>
        /// Create an Office or Trust account for a Firm
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="bankAccount">New account details</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>BankAccount</returns>
        BankAccount CreateFirmBankAccount(Guid firmId, BankAccount bankAccount, int operationIndex = 0);

        /// <summary>
        /// Create an account
        /// </summary>
        /// <remarks>
        /// Create an Office or Trust account for a Firm
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="bankAccount">New account details</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of BankAccount</returns>
        ApiResponse<BankAccount> CreateFirmBankAccountWithHttpInfo(Guid firmId, BankAccount bankAccount, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create an account
        /// </summary>
        /// <remarks>
        /// Create an Office or Trust account for a Firm
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="bankAccount">New account details</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BankAccount</returns>
        System.Threading.Tasks.Task<BankAccount> CreateFirmBankAccountAsync(Guid firmId, BankAccount bankAccount, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create an account
        /// </summary>
        /// <remarks>
        /// Create an Office or Trust account for a Firm
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="bankAccount">New account details</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BankAccount)</returns>
        System.Threading.Tasks.Task<ApiResponse<BankAccount>> CreateFirmBankAccountWithHttpInfoAsync(Guid firmId, BankAccount bankAccount, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountsApi : IAccountsApiSync, IAccountsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AccountsApi : IAccountsApi
    {
        private FeeWise.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AccountsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AccountsApi(FeeWise.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AccountsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AccountsApi(FeeWise.Client.ISynchronousClient client, FeeWise.Client.IAsynchronousClient asyncClient, FeeWise.Client.IReadableConfiguration configuration)
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
        /// Create an account Create an Office or Trust account for a Firm
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="bankAccount">New account details</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>BankAccount</returns>
        public BankAccount CreateFirmBankAccount(Guid firmId, BankAccount bankAccount, int operationIndex = 0)
        {
            FeeWise.Client.ApiResponse<BankAccount> localVarResponse = CreateFirmBankAccountWithHttpInfo(firmId, bankAccount);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an account Create an Office or Trust account for a Firm
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="bankAccount">New account details</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of BankAccount</returns>
        public FeeWise.Client.ApiResponse<BankAccount> CreateFirmBankAccountWithHttpInfo(Guid firmId, BankAccount bankAccount, int operationIndex = 0)
        {
            // verify the required parameter 'bankAccount' is set
            if (bankAccount == null)
            {
                throw new FeeWise.Client.ApiException(400, "Missing required parameter 'bankAccount' when calling AccountsApi->CreateFirmBankAccount");
            }

            FeeWise.Client.RequestOptions localVarRequestOptions = new FeeWise.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
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
            localVarRequestOptions.Data = bankAccount;

            localVarRequestOptions.Operation = "AccountsApi.CreateFirmBankAccount";
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
            var localVarResponse = this.Client.Post<BankAccount>("/api/v3/partner/firms/{firm_id}/accounts", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateFirmBankAccount", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create an account Create an Office or Trust account for a Firm
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="bankAccount">New account details</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BankAccount</returns>
        public async System.Threading.Tasks.Task<BankAccount> CreateFirmBankAccountAsync(Guid firmId, BankAccount bankAccount, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            FeeWise.Client.ApiResponse<BankAccount> localVarResponse = await CreateFirmBankAccountWithHttpInfoAsync(firmId, bankAccount, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an account Create an Office or Trust account for a Firm
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="bankAccount">New account details</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BankAccount)</returns>
        public async System.Threading.Tasks.Task<FeeWise.Client.ApiResponse<BankAccount>> CreateFirmBankAccountWithHttpInfoAsync(Guid firmId, BankAccount bankAccount, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'bankAccount' is set
            if (bankAccount == null)
            {
                throw new FeeWise.Client.ApiException(400, "Missing required parameter 'bankAccount' when calling AccountsApi->CreateFirmBankAccount");
            }


            FeeWise.Client.RequestOptions localVarRequestOptions = new FeeWise.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
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
            localVarRequestOptions.Data = bankAccount;

            localVarRequestOptions.Operation = "AccountsApi.CreateFirmBankAccount";
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
            var localVarResponse = await this.AsynchronousClient.PostAsync<BankAccount>("/api/v3/partner/firms/{firm_id}/accounts", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateFirmBankAccount", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
