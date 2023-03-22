/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.52
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
        /// 
        /// </summary>
        /// <remarks>
        /// Get list of payouts for the channel partner since the provided timestamp.  If not supplied, payouts for the last 24 hours are returned. The channel partner is derived from the PartnerAuth security context 
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="since">Return payouts since this timestamp.  If not supplied, payouts for the last 24 hours are returned.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Payouts</returns>
        Payouts GetChannelPartnerPayouts(DateTime? since = default(DateTime?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get list of payouts for the channel partner since the provided timestamp.  If not supplied, payouts for the last 24 hours are returned. The channel partner is derived from the PartnerAuth security context 
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="since">Return payouts since this timestamp.  If not supplied, payouts for the last 24 hours are returned.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Payouts</returns>
        ApiResponse<Payouts> GetChannelPartnerPayoutsWithHttpInfo(DateTime? since = default(DateTime?), int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get list of payouts for the specified firm.  If the since parameter is not supplied, payouts for the last 24 hours are returned. 
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId">ID of the firm whose payouts are to be retrieved </param>
        /// <param name="since">Return payouts, for the given channel partner / firm, sent since this timestamp.  If not supplied, payouts for the last 24 hours are returned.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Payouts</returns>
        Payouts GetFirmPayouts(Guid firmId, DateTime? since = default(DateTime?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get list of payouts for the specified firm.  If the since parameter is not supplied, payouts for the last 24 hours are returned. 
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId">ID of the firm whose payouts are to be retrieved </param>
        /// <param name="since">Return payouts, for the given channel partner / firm, sent since this timestamp.  If not supplied, payouts for the last 24 hours are returned.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Payouts</returns>
        ApiResponse<Payouts> GetFirmPayoutsWithHttpInfo(Guid firmId, DateTime? since = default(DateTime?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPayoutsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get list of payouts for the channel partner since the provided timestamp.  If not supplied, payouts for the last 24 hours are returned. The channel partner is derived from the PartnerAuth security context 
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="since">Return payouts since this timestamp.  If not supplied, payouts for the last 24 hours are returned.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Payouts</returns>
        System.Threading.Tasks.Task<Payouts> GetChannelPartnerPayoutsAsync(DateTime? since = default(DateTime?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get list of payouts for the channel partner since the provided timestamp.  If not supplied, payouts for the last 24 hours are returned. The channel partner is derived from the PartnerAuth security context 
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="since">Return payouts since this timestamp.  If not supplied, payouts for the last 24 hours are returned.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Payouts)</returns>
        System.Threading.Tasks.Task<ApiResponse<Payouts>> GetChannelPartnerPayoutsWithHttpInfoAsync(DateTime? since = default(DateTime?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get list of payouts for the specified firm.  If the since parameter is not supplied, payouts for the last 24 hours are returned. 
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId">ID of the firm whose payouts are to be retrieved </param>
        /// <param name="since">Return payouts, for the given channel partner / firm, sent since this timestamp.  If not supplied, payouts for the last 24 hours are returned.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Payouts</returns>
        System.Threading.Tasks.Task<Payouts> GetFirmPayoutsAsync(Guid firmId, DateTime? since = default(DateTime?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get list of payouts for the specified firm.  If the since parameter is not supplied, payouts for the last 24 hours are returned. 
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId">ID of the firm whose payouts are to be retrieved </param>
        /// <param name="since">Return payouts, for the given channel partner / firm, sent since this timestamp.  If not supplied, payouts for the last 24 hours are returned.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Payouts)</returns>
        System.Threading.Tasks.Task<ApiResponse<Payouts>> GetFirmPayoutsWithHttpInfoAsync(Guid firmId, DateTime? since = default(DateTime?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
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
        ///  Get list of payouts for the channel partner since the provided timestamp.  If not supplied, payouts for the last 24 hours are returned. The channel partner is derived from the PartnerAuth security context 
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="since">Return payouts since this timestamp.  If not supplied, payouts for the last 24 hours are returned.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Payouts</returns>
        public Payouts GetChannelPartnerPayouts(DateTime? since = default(DateTime?), int operationIndex = 0)
        {
            FeeWise.Client.ApiResponse<Payouts> localVarResponse = GetChannelPartnerPayoutsWithHttpInfo(since);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Get list of payouts for the channel partner since the provided timestamp.  If not supplied, payouts for the last 24 hours are returned. The channel partner is derived from the PartnerAuth security context 
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="since">Return payouts since this timestamp.  If not supplied, payouts for the last 24 hours are returned.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Payouts</returns>
        public FeeWise.Client.ApiResponse<Payouts> GetChannelPartnerPayoutsWithHttpInfo(DateTime? since = default(DateTime?), int operationIndex = 0)
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
        ///  Get list of payouts for the channel partner since the provided timestamp.  If not supplied, payouts for the last 24 hours are returned. The channel partner is derived from the PartnerAuth security context 
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="since">Return payouts since this timestamp.  If not supplied, payouts for the last 24 hours are returned.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Payouts</returns>
        public async System.Threading.Tasks.Task<Payouts> GetChannelPartnerPayoutsAsync(DateTime? since = default(DateTime?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            FeeWise.Client.ApiResponse<Payouts> localVarResponse = await GetChannelPartnerPayoutsWithHttpInfoAsync(since, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Get list of payouts for the channel partner since the provided timestamp.  If not supplied, payouts for the last 24 hours are returned. The channel partner is derived from the PartnerAuth security context 
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="since">Return payouts since this timestamp.  If not supplied, payouts for the last 24 hours are returned.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Payouts)</returns>
        public async System.Threading.Tasks.Task<FeeWise.Client.ApiResponse<Payouts>> GetChannelPartnerPayoutsWithHttpInfoAsync(DateTime? since = default(DateTime?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

        /// <summary>
        ///  Get list of payouts for the specified firm.  If the since parameter is not supplied, payouts for the last 24 hours are returned. 
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId">ID of the firm whose payouts are to be retrieved </param>
        /// <param name="since">Return payouts, for the given channel partner / firm, sent since this timestamp.  If not supplied, payouts for the last 24 hours are returned.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Payouts</returns>
        public Payouts GetFirmPayouts(Guid firmId, DateTime? since = default(DateTime?), int operationIndex = 0)
        {
            FeeWise.Client.ApiResponse<Payouts> localVarResponse = GetFirmPayoutsWithHttpInfo(firmId, since);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Get list of payouts for the specified firm.  If the since parameter is not supplied, payouts for the last 24 hours are returned. 
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId">ID of the firm whose payouts are to be retrieved </param>
        /// <param name="since">Return payouts, for the given channel partner / firm, sent since this timestamp.  If not supplied, payouts for the last 24 hours are returned.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Payouts</returns>
        public FeeWise.Client.ApiResponse<Payouts> GetFirmPayoutsWithHttpInfo(Guid firmId, DateTime? since = default(DateTime?), int operationIndex = 0)
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
            if (since != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("", "since", since));
            }

            localVarRequestOptions.Operation = "PayoutsApi.GetFirmPayouts";
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
            var localVarResponse = this.Client.Get<Payouts>("/api/v3/partner/payouts/firms/{firm_id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetFirmPayouts", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Get list of payouts for the specified firm.  If the since parameter is not supplied, payouts for the last 24 hours are returned. 
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId">ID of the firm whose payouts are to be retrieved </param>
        /// <param name="since">Return payouts, for the given channel partner / firm, sent since this timestamp.  If not supplied, payouts for the last 24 hours are returned.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Payouts</returns>
        public async System.Threading.Tasks.Task<Payouts> GetFirmPayoutsAsync(Guid firmId, DateTime? since = default(DateTime?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            FeeWise.Client.ApiResponse<Payouts> localVarResponse = await GetFirmPayoutsWithHttpInfoAsync(firmId, since, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Get list of payouts for the specified firm.  If the since parameter is not supplied, payouts for the last 24 hours are returned. 
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId">ID of the firm whose payouts are to be retrieved </param>
        /// <param name="since">Return payouts, for the given channel partner / firm, sent since this timestamp.  If not supplied, payouts for the last 24 hours are returned.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Payouts)</returns>
        public async System.Threading.Tasks.Task<FeeWise.Client.ApiResponse<Payouts>> GetFirmPayoutsWithHttpInfoAsync(Guid firmId, DateTime? since = default(DateTime?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
            if (since != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("", "since", since));
            }

            localVarRequestOptions.Operation = "PayoutsApi.GetFirmPayouts";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<Payouts>("/api/v3/partner/payouts/firms/{firm_id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetFirmPayouts", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
