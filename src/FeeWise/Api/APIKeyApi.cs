/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.91
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
    public interface IAPIKeyApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Rotate API Key
        /// </summary>
        /// <remarks>
        /// Produces a new API-KEY. This new key and the previous key will both be valid until they expire. The key expiry is set by system defaults but may be customised for this specific key in the request. 
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKeyRotation"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiKeyResponse</returns>
        ApiKeyResponse RotateApiKey(ApiKeyRotation apiKeyRotation = default(ApiKeyRotation), int operationIndex = 0);

        /// <summary>
        /// Rotate API Key
        /// </summary>
        /// <remarks>
        /// Produces a new API-KEY. This new key and the previous key will both be valid until they expire. The key expiry is set by system defaults but may be customised for this specific key in the request. 
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKeyRotation"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiKeyResponse</returns>
        ApiResponse<ApiKeyResponse> RotateApiKeyWithHttpInfo(ApiKeyRotation apiKeyRotation = default(ApiKeyRotation), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAPIKeyApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Rotate API Key
        /// </summary>
        /// <remarks>
        /// Produces a new API-KEY. This new key and the previous key will both be valid until they expire. The key expiry is set by system defaults but may be customised for this specific key in the request. 
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKeyRotation"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiKeyResponse</returns>
        System.Threading.Tasks.Task<ApiKeyResponse> RotateApiKeyAsync(ApiKeyRotation apiKeyRotation = default(ApiKeyRotation), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Rotate API Key
        /// </summary>
        /// <remarks>
        /// Produces a new API-KEY. This new key and the previous key will both be valid until they expire. The key expiry is set by system defaults but may be customised for this specific key in the request. 
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKeyRotation"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiKeyResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiKeyResponse>> RotateApiKeyWithHttpInfoAsync(ApiKeyRotation apiKeyRotation = default(ApiKeyRotation), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAPIKeyApi : IAPIKeyApiSync, IAPIKeyApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class APIKeyApi : IAPIKeyApi
    {
        private FeeWise.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public APIKeyApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public APIKeyApi(string basePath)
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
        /// Initializes a new instance of the <see cref="APIKeyApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public APIKeyApi(FeeWise.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="APIKeyApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public APIKeyApi(FeeWise.Client.ISynchronousClient client, FeeWise.Client.IAsynchronousClient asyncClient, FeeWise.Client.IReadableConfiguration configuration)
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
        /// Rotate API Key Produces a new API-KEY. This new key and the previous key will both be valid until they expire. The key expiry is set by system defaults but may be customised for this specific key in the request. 
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKeyRotation"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiKeyResponse</returns>
        public ApiKeyResponse RotateApiKey(ApiKeyRotation apiKeyRotation = default(ApiKeyRotation), int operationIndex = 0)
        {
            FeeWise.Client.ApiResponse<ApiKeyResponse> localVarResponse = RotateApiKeyWithHttpInfo(apiKeyRotation);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Rotate API Key Produces a new API-KEY. This new key and the previous key will both be valid until they expire. The key expiry is set by system defaults but may be customised for this specific key in the request. 
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKeyRotation"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiKeyResponse</returns>
        public FeeWise.Client.ApiResponse<ApiKeyResponse> RotateApiKeyWithHttpInfo(ApiKeyRotation apiKeyRotation = default(ApiKeyRotation), int operationIndex = 0)
        {
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

            localVarRequestOptions.Data = apiKeyRotation;

            localVarRequestOptions.Operation = "APIKeyApi.RotateApiKey";
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
            var localVarResponse = this.Client.Post<ApiKeyResponse>("/api/v3/partner/rotatekey", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RotateApiKey", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Rotate API Key Produces a new API-KEY. This new key and the previous key will both be valid until they expire. The key expiry is set by system defaults but may be customised for this specific key in the request. 
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKeyRotation"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiKeyResponse</returns>
        public async System.Threading.Tasks.Task<ApiKeyResponse> RotateApiKeyAsync(ApiKeyRotation apiKeyRotation = default(ApiKeyRotation), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            FeeWise.Client.ApiResponse<ApiKeyResponse> localVarResponse = await RotateApiKeyWithHttpInfoAsync(apiKeyRotation, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Rotate API Key Produces a new API-KEY. This new key and the previous key will both be valid until they expire. The key expiry is set by system defaults but may be customised for this specific key in the request. 
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKeyRotation"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiKeyResponse)</returns>
        public async System.Threading.Tasks.Task<FeeWise.Client.ApiResponse<ApiKeyResponse>> RotateApiKeyWithHttpInfoAsync(ApiKeyRotation apiKeyRotation = default(ApiKeyRotation), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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

            localVarRequestOptions.Data = apiKeyRotation;

            localVarRequestOptions.Operation = "APIKeyApi.RotateApiKey";
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
            var localVarResponse = await this.AsynchronousClient.PostAsync<ApiKeyResponse>("/api/v3/partner/rotatekey", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RotateApiKey", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
