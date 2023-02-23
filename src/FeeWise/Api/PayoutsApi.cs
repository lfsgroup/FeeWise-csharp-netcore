/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.48
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
    public interface IPayoutsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Search for payouts for the channel partner
        /// </summary>
        /// <remarks>
        /// Search for payouts for a channel partner..         The filters supplied in the query params must *all* be met.         The channel partner is derived from the PartnerAuth security context. 
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payoutId">Get a specific payout. If this is specified, other query params should not be specified  and will result in a BadRequest if the are.  (optional)</param>
        /// <param name="account">Get payouts going to a specific account.  (optional)</param>
        /// <param name="firmId">Get payouts going to a specific firm  (optional)</param>
        /// <param name="sincePayoutId">If supplied, all payouts since this payout was sent, are retrieved. The retrieved payouts are subject to the  other filter params (firm_id, settlement_account_id).   NB - &#39;since_payout_id&#39; and &#39;since&#39; are mutually exclusive. Supplying both results in a BadRequest error.  (optional)</param>
        /// <param name="since">Return payouts sent since this timestamp. If not supplied, payouts for the last 24 hours are returned.   NB - &#39;since_payout_id&#39; and &#39;since&#39; are mutually exclusive. Supplying both results in a BadRequest error.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Payouts</returns>
        Payouts GetChannelPartnerPayouts(Guid? payoutId = default(Guid?), GetChannelPartnerPayoutsAccountParameter account = default(GetChannelPartnerPayoutsAccountParameter), Guid? firmId = default(Guid?), Guid? sincePayoutId = default(Guid?), DateTime? since = default(DateTime?), int operationIndex = 0);

        /// <summary>
        /// Search for payouts for the channel partner
        /// </summary>
        /// <remarks>
        /// Search for payouts for a channel partner..         The filters supplied in the query params must *all* be met.         The channel partner is derived from the PartnerAuth security context. 
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payoutId">Get a specific payout. If this is specified, other query params should not be specified  and will result in a BadRequest if the are.  (optional)</param>
        /// <param name="account">Get payouts going to a specific account.  (optional)</param>
        /// <param name="firmId">Get payouts going to a specific firm  (optional)</param>
        /// <param name="sincePayoutId">If supplied, all payouts since this payout was sent, are retrieved. The retrieved payouts are subject to the  other filter params (firm_id, settlement_account_id).   NB - &#39;since_payout_id&#39; and &#39;since&#39; are mutually exclusive. Supplying both results in a BadRequest error.  (optional)</param>
        /// <param name="since">Return payouts sent since this timestamp. If not supplied, payouts for the last 24 hours are returned.   NB - &#39;since_payout_id&#39; and &#39;since&#39; are mutually exclusive. Supplying both results in a BadRequest error.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Payouts</returns>
        ApiResponse<Payouts> GetChannelPartnerPayoutsWithHttpInfo(Guid? payoutId = default(Guid?), GetChannelPartnerPayoutsAccountParameter account = default(GetChannelPartnerPayoutsAccountParameter), Guid? firmId = default(Guid?), Guid? sincePayoutId = default(Guid?), DateTime? since = default(DateTime?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPayoutsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Search for payouts for the channel partner
        /// </summary>
        /// <remarks>
        /// Search for payouts for a channel partner..         The filters supplied in the query params must *all* be met.         The channel partner is derived from the PartnerAuth security context. 
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payoutId">Get a specific payout. If this is specified, other query params should not be specified  and will result in a BadRequest if the are.  (optional)</param>
        /// <param name="account">Get payouts going to a specific account.  (optional)</param>
        /// <param name="firmId">Get payouts going to a specific firm  (optional)</param>
        /// <param name="sincePayoutId">If supplied, all payouts since this payout was sent, are retrieved. The retrieved payouts are subject to the  other filter params (firm_id, settlement_account_id).   NB - &#39;since_payout_id&#39; and &#39;since&#39; are mutually exclusive. Supplying both results in a BadRequest error.  (optional)</param>
        /// <param name="since">Return payouts sent since this timestamp. If not supplied, payouts for the last 24 hours are returned.   NB - &#39;since_payout_id&#39; and &#39;since&#39; are mutually exclusive. Supplying both results in a BadRequest error.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Payouts</returns>
        System.Threading.Tasks.Task<Payouts> GetChannelPartnerPayoutsAsync(Guid? payoutId = default(Guid?), GetChannelPartnerPayoutsAccountParameter account = default(GetChannelPartnerPayoutsAccountParameter), Guid? firmId = default(Guid?), Guid? sincePayoutId = default(Guid?), DateTime? since = default(DateTime?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Search for payouts for the channel partner
        /// </summary>
        /// <remarks>
        /// Search for payouts for a channel partner..         The filters supplied in the query params must *all* be met.         The channel partner is derived from the PartnerAuth security context. 
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payoutId">Get a specific payout. If this is specified, other query params should not be specified  and will result in a BadRequest if the are.  (optional)</param>
        /// <param name="account">Get payouts going to a specific account.  (optional)</param>
        /// <param name="firmId">Get payouts going to a specific firm  (optional)</param>
        /// <param name="sincePayoutId">If supplied, all payouts since this payout was sent, are retrieved. The retrieved payouts are subject to the  other filter params (firm_id, settlement_account_id).   NB - &#39;since_payout_id&#39; and &#39;since&#39; are mutually exclusive. Supplying both results in a BadRequest error.  (optional)</param>
        /// <param name="since">Return payouts sent since this timestamp. If not supplied, payouts for the last 24 hours are returned.   NB - &#39;since_payout_id&#39; and &#39;since&#39; are mutually exclusive. Supplying both results in a BadRequest error.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Payouts)</returns>
        System.Threading.Tasks.Task<ApiResponse<Payouts>> GetChannelPartnerPayoutsWithHttpInfoAsync(Guid? payoutId = default(Guid?), GetChannelPartnerPayoutsAccountParameter account = default(GetChannelPartnerPayoutsAccountParameter), Guid? firmId = default(Guid?), Guid? sincePayoutId = default(Guid?), DateTime? since = default(DateTime?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPayoutsApi : IPayoutsApiSync, IPayoutsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PayoutsApi : IPayoutsApi
    {
        private FeeWise.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PayoutsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PayoutsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="PayoutsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PayoutsApi(FeeWise.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="PayoutsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PayoutsApi(FeeWise.Client.ISynchronousClient client, FeeWise.Client.IAsynchronousClient asyncClient, FeeWise.Client.IReadableConfiguration configuration)
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
        /// Search for payouts for the channel partner Search for payouts for a channel partner..         The filters supplied in the query params must *all* be met.         The channel partner is derived from the PartnerAuth security context. 
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payoutId">Get a specific payout. If this is specified, other query params should not be specified  and will result in a BadRequest if the are.  (optional)</param>
        /// <param name="account">Get payouts going to a specific account.  (optional)</param>
        /// <param name="firmId">Get payouts going to a specific firm  (optional)</param>
        /// <param name="sincePayoutId">If supplied, all payouts since this payout was sent, are retrieved. The retrieved payouts are subject to the  other filter params (firm_id, settlement_account_id).   NB - &#39;since_payout_id&#39; and &#39;since&#39; are mutually exclusive. Supplying both results in a BadRequest error.  (optional)</param>
        /// <param name="since">Return payouts sent since this timestamp. If not supplied, payouts for the last 24 hours are returned.   NB - &#39;since_payout_id&#39; and &#39;since&#39; are mutually exclusive. Supplying both results in a BadRequest error.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Payouts</returns>
        public Payouts GetChannelPartnerPayouts(Guid? payoutId = default(Guid?), GetChannelPartnerPayoutsAccountParameter account = default(GetChannelPartnerPayoutsAccountParameter), Guid? firmId = default(Guid?), Guid? sincePayoutId = default(Guid?), DateTime? since = default(DateTime?), int operationIndex = 0)
        {
            FeeWise.Client.ApiResponse<Payouts> localVarResponse = GetChannelPartnerPayoutsWithHttpInfo(payoutId, account, firmId, sincePayoutId, since);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search for payouts for the channel partner Search for payouts for a channel partner..         The filters supplied in the query params must *all* be met.         The channel partner is derived from the PartnerAuth security context. 
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payoutId">Get a specific payout. If this is specified, other query params should not be specified  and will result in a BadRequest if the are.  (optional)</param>
        /// <param name="account">Get payouts going to a specific account.  (optional)</param>
        /// <param name="firmId">Get payouts going to a specific firm  (optional)</param>
        /// <param name="sincePayoutId">If supplied, all payouts since this payout was sent, are retrieved. The retrieved payouts are subject to the  other filter params (firm_id, settlement_account_id).   NB - &#39;since_payout_id&#39; and &#39;since&#39; are mutually exclusive. Supplying both results in a BadRequest error.  (optional)</param>
        /// <param name="since">Return payouts sent since this timestamp. If not supplied, payouts for the last 24 hours are returned.   NB - &#39;since_payout_id&#39; and &#39;since&#39; are mutually exclusive. Supplying both results in a BadRequest error.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Payouts</returns>
        public FeeWise.Client.ApiResponse<Payouts> GetChannelPartnerPayoutsWithHttpInfo(Guid? payoutId = default(Guid?), GetChannelPartnerPayoutsAccountParameter account = default(GetChannelPartnerPayoutsAccountParameter), Guid? firmId = default(Guid?), Guid? sincePayoutId = default(Guid?), DateTime? since = default(DateTime?), int operationIndex = 0)
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

            if (payoutId != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("", "payout_id", payoutId));
            }
            if (account != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("", "account", account));
            }
            if (firmId != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("", "firm_id", firmId));
            }
            if (sincePayoutId != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("", "since_payout_id", sincePayoutId));
            }
            if (since != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("", "since", since));
            }

            localVarRequestOptions.Operation = "PayoutsApi.GetChannelPartnerPayouts";
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
            var localVarResponse = this.Client.Get<Payouts>("/api/v3/partner/payouts", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetChannelPartnerPayouts", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Search for payouts for the channel partner Search for payouts for a channel partner..         The filters supplied in the query params must *all* be met.         The channel partner is derived from the PartnerAuth security context. 
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payoutId">Get a specific payout. If this is specified, other query params should not be specified  and will result in a BadRequest if the are.  (optional)</param>
        /// <param name="account">Get payouts going to a specific account.  (optional)</param>
        /// <param name="firmId">Get payouts going to a specific firm  (optional)</param>
        /// <param name="sincePayoutId">If supplied, all payouts since this payout was sent, are retrieved. The retrieved payouts are subject to the  other filter params (firm_id, settlement_account_id).   NB - &#39;since_payout_id&#39; and &#39;since&#39; are mutually exclusive. Supplying both results in a BadRequest error.  (optional)</param>
        /// <param name="since">Return payouts sent since this timestamp. If not supplied, payouts for the last 24 hours are returned.   NB - &#39;since_payout_id&#39; and &#39;since&#39; are mutually exclusive. Supplying both results in a BadRequest error.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Payouts</returns>
        public async System.Threading.Tasks.Task<Payouts> GetChannelPartnerPayoutsAsync(Guid? payoutId = default(Guid?), GetChannelPartnerPayoutsAccountParameter account = default(GetChannelPartnerPayoutsAccountParameter), Guid? firmId = default(Guid?), Guid? sincePayoutId = default(Guid?), DateTime? since = default(DateTime?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            FeeWise.Client.ApiResponse<Payouts> localVarResponse = await GetChannelPartnerPayoutsWithHttpInfoAsync(payoutId, account, firmId, sincePayoutId, since, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search for payouts for the channel partner Search for payouts for a channel partner..         The filters supplied in the query params must *all* be met.         The channel partner is derived from the PartnerAuth security context. 
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payoutId">Get a specific payout. If this is specified, other query params should not be specified  and will result in a BadRequest if the are.  (optional)</param>
        /// <param name="account">Get payouts going to a specific account.  (optional)</param>
        /// <param name="firmId">Get payouts going to a specific firm  (optional)</param>
        /// <param name="sincePayoutId">If supplied, all payouts since this payout was sent, are retrieved. The retrieved payouts are subject to the  other filter params (firm_id, settlement_account_id).   NB - &#39;since_payout_id&#39; and &#39;since&#39; are mutually exclusive. Supplying both results in a BadRequest error.  (optional)</param>
        /// <param name="since">Return payouts sent since this timestamp. If not supplied, payouts for the last 24 hours are returned.   NB - &#39;since_payout_id&#39; and &#39;since&#39; are mutually exclusive. Supplying both results in a BadRequest error.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Payouts)</returns>
        public async System.Threading.Tasks.Task<FeeWise.Client.ApiResponse<Payouts>> GetChannelPartnerPayoutsWithHttpInfoAsync(Guid? payoutId = default(Guid?), GetChannelPartnerPayoutsAccountParameter account = default(GetChannelPartnerPayoutsAccountParameter), Guid? firmId = default(Guid?), Guid? sincePayoutId = default(Guid?), DateTime? since = default(DateTime?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            if (payoutId != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("", "payout_id", payoutId));
            }
            if (account != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("", "account", account));
            }
            if (firmId != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("", "firm_id", firmId));
            }
            if (sincePayoutId != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("", "since_payout_id", sincePayoutId));
            }
            if (since != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("", "since", since));
            }

            localVarRequestOptions.Operation = "PayoutsApi.GetChannelPartnerPayouts";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<Payouts>("/api/v3/partner/payouts", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetChannelPartnerPayouts", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
