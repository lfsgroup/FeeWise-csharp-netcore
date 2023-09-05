/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.84
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
    public interface IPartnerApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get partner branding
        /// </summary>
        /// <remarks>
        /// Get partner branding. Nb if branding is not set, an empty model will be returned
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetPartnerBranding200Response</returns>
        GetPartnerBranding200Response GetPartnerBranding(int operationIndex = 0);

        /// <summary>
        /// Get partner branding
        /// </summary>
        /// <remarks>
        /// Get partner branding. Nb if branding is not set, an empty model will be returned
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetPartnerBranding200Response</returns>
        ApiResponse<GetPartnerBranding200Response> GetPartnerBrandingWithHttpInfo(int operationIndex = 0);
        /// <summary>
        /// Upload partner logo
        /// </summary>
        /// <remarks>
        /// Upload a partner logo to FeeWise. This logo will be used wherever FeeWise and the partner have agreed to show a logo in the FeeWise UI. nb Content-Type header must be multipart/form-data example  curl -X POST -F \&quot;fwUploadFile&#x3D;@/path/to/file.png\&quot; \\     http://localhost:8080/api/v3/partner/upload \\       - -header &#39;X-CHANNEL-PARTNER-ID: &lt;channel partner id&gt;&#39; \\       - -header &#39;X-API-KEY: &lt;api key&gt;&#39; \\       - -header \&quot;Content-Type: multipart/form-data\&quot; 
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fwUploadFile"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PostUpload200Response</returns>
        PostUpload200Response PostPartnerLogoUpload(System.IO.Stream fwUploadFile = default(System.IO.Stream), int operationIndex = 0);

        /// <summary>
        /// Upload partner logo
        /// </summary>
        /// <remarks>
        /// Upload a partner logo to FeeWise. This logo will be used wherever FeeWise and the partner have agreed to show a logo in the FeeWise UI. nb Content-Type header must be multipart/form-data example  curl -X POST -F \&quot;fwUploadFile&#x3D;@/path/to/file.png\&quot; \\     http://localhost:8080/api/v3/partner/upload \\       - -header &#39;X-CHANNEL-PARTNER-ID: &lt;channel partner id&gt;&#39; \\       - -header &#39;X-API-KEY: &lt;api key&gt;&#39; \\       - -header \&quot;Content-Type: multipart/form-data\&quot; 
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fwUploadFile"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PostUpload200Response</returns>
        ApiResponse<PostUpload200Response> PostPartnerLogoUploadWithHttpInfo(System.IO.Stream fwUploadFile = default(System.IO.Stream), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPartnerApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get partner branding
        /// </summary>
        /// <remarks>
        /// Get partner branding. Nb if branding is not set, an empty model will be returned
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetPartnerBranding200Response</returns>
        System.Threading.Tasks.Task<GetPartnerBranding200Response> GetPartnerBrandingAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get partner branding
        /// </summary>
        /// <remarks>
        /// Get partner branding. Nb if branding is not set, an empty model will be returned
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetPartnerBranding200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetPartnerBranding200Response>> GetPartnerBrandingWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Upload partner logo
        /// </summary>
        /// <remarks>
        /// Upload a partner logo to FeeWise. This logo will be used wherever FeeWise and the partner have agreed to show a logo in the FeeWise UI. nb Content-Type header must be multipart/form-data example  curl -X POST -F \&quot;fwUploadFile&#x3D;@/path/to/file.png\&quot; \\     http://localhost:8080/api/v3/partner/upload \\       - -header &#39;X-CHANNEL-PARTNER-ID: &lt;channel partner id&gt;&#39; \\       - -header &#39;X-API-KEY: &lt;api key&gt;&#39; \\       - -header \&quot;Content-Type: multipart/form-data\&quot; 
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fwUploadFile"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PostUpload200Response</returns>
        System.Threading.Tasks.Task<PostUpload200Response> PostPartnerLogoUploadAsync(System.IO.Stream fwUploadFile = default(System.IO.Stream), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Upload partner logo
        /// </summary>
        /// <remarks>
        /// Upload a partner logo to FeeWise. This logo will be used wherever FeeWise and the partner have agreed to show a logo in the FeeWise UI. nb Content-Type header must be multipart/form-data example  curl -X POST -F \&quot;fwUploadFile&#x3D;@/path/to/file.png\&quot; \\     http://localhost:8080/api/v3/partner/upload \\       - -header &#39;X-CHANNEL-PARTNER-ID: &lt;channel partner id&gt;&#39; \\       - -header &#39;X-API-KEY: &lt;api key&gt;&#39; \\       - -header \&quot;Content-Type: multipart/form-data\&quot; 
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fwUploadFile"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PostUpload200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PostUpload200Response>> PostPartnerLogoUploadWithHttpInfoAsync(System.IO.Stream fwUploadFile = default(System.IO.Stream), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPartnerApi : IPartnerApiSync, IPartnerApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PartnerApi : IPartnerApi
    {
        private FeeWise.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PartnerApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PartnerApi(string basePath)
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
        /// Initializes a new instance of the <see cref="PartnerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PartnerApi(FeeWise.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="PartnerApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PartnerApi(FeeWise.Client.ISynchronousClient client, FeeWise.Client.IAsynchronousClient asyncClient, FeeWise.Client.IReadableConfiguration configuration)
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
        /// Get partner branding Get partner branding. Nb if branding is not set, an empty model will be returned
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetPartnerBranding200Response</returns>
        public GetPartnerBranding200Response GetPartnerBranding(int operationIndex = 0)
        {
            FeeWise.Client.ApiResponse<GetPartnerBranding200Response> localVarResponse = GetPartnerBrandingWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get partner branding Get partner branding. Nb if branding is not set, an empty model will be returned
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetPartnerBranding200Response</returns>
        public FeeWise.Client.ApiResponse<GetPartnerBranding200Response> GetPartnerBrandingWithHttpInfo(int operationIndex = 0)
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


            localVarRequestOptions.Operation = "PartnerApi.GetPartnerBranding";
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
            var localVarResponse = this.Client.Get<GetPartnerBranding200Response>("/api/v3/partner/branding", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPartnerBranding", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get partner branding Get partner branding. Nb if branding is not set, an empty model will be returned
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetPartnerBranding200Response</returns>
        public async System.Threading.Tasks.Task<GetPartnerBranding200Response> GetPartnerBrandingAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            FeeWise.Client.ApiResponse<GetPartnerBranding200Response> localVarResponse = await GetPartnerBrandingWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get partner branding Get partner branding. Nb if branding is not set, an empty model will be returned
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetPartnerBranding200Response)</returns>
        public async System.Threading.Tasks.Task<FeeWise.Client.ApiResponse<GetPartnerBranding200Response>> GetPartnerBrandingWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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


            localVarRequestOptions.Operation = "PartnerApi.GetPartnerBranding";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<GetPartnerBranding200Response>("/api/v3/partner/branding", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPartnerBranding", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Upload partner logo Upload a partner logo to FeeWise. This logo will be used wherever FeeWise and the partner have agreed to show a logo in the FeeWise UI. nb Content-Type header must be multipart/form-data example  curl -X POST -F \&quot;fwUploadFile&#x3D;@/path/to/file.png\&quot; \\     http://localhost:8080/api/v3/partner/upload \\       - -header &#39;X-CHANNEL-PARTNER-ID: &lt;channel partner id&gt;&#39; \\       - -header &#39;X-API-KEY: &lt;api key&gt;&#39; \\       - -header \&quot;Content-Type: multipart/form-data\&quot; 
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fwUploadFile"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PostUpload200Response</returns>
        public PostUpload200Response PostPartnerLogoUpload(System.IO.Stream fwUploadFile = default(System.IO.Stream), int operationIndex = 0)
        {
            FeeWise.Client.ApiResponse<PostUpload200Response> localVarResponse = PostPartnerLogoUploadWithHttpInfo(fwUploadFile);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Upload partner logo Upload a partner logo to FeeWise. This logo will be used wherever FeeWise and the partner have agreed to show a logo in the FeeWise UI. nb Content-Type header must be multipart/form-data example  curl -X POST -F \&quot;fwUploadFile&#x3D;@/path/to/file.png\&quot; \\     http://localhost:8080/api/v3/partner/upload \\       - -header &#39;X-CHANNEL-PARTNER-ID: &lt;channel partner id&gt;&#39; \\       - -header &#39;X-API-KEY: &lt;api key&gt;&#39; \\       - -header \&quot;Content-Type: multipart/form-data\&quot; 
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fwUploadFile"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PostUpload200Response</returns>
        public FeeWise.Client.ApiResponse<PostUpload200Response> PostPartnerLogoUploadWithHttpInfo(System.IO.Stream fwUploadFile = default(System.IO.Stream), int operationIndex = 0)
        {
            FeeWise.Client.RequestOptions localVarRequestOptions = new FeeWise.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
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

            if (fwUploadFile != null)
            {
                localVarRequestOptions.FileParameters.Add("fwUploadFile", fwUploadFile);
            }

            localVarRequestOptions.Operation = "PartnerApi.PostPartnerLogoUpload";
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
            var localVarResponse = this.Client.Post<PostUpload200Response>("/api/v3/partner/upload", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostPartnerLogoUpload", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Upload partner logo Upload a partner logo to FeeWise. This logo will be used wherever FeeWise and the partner have agreed to show a logo in the FeeWise UI. nb Content-Type header must be multipart/form-data example  curl -X POST -F \&quot;fwUploadFile&#x3D;@/path/to/file.png\&quot; \\     http://localhost:8080/api/v3/partner/upload \\       - -header &#39;X-CHANNEL-PARTNER-ID: &lt;channel partner id&gt;&#39; \\       - -header &#39;X-API-KEY: &lt;api key&gt;&#39; \\       - -header \&quot;Content-Type: multipart/form-data\&quot; 
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fwUploadFile"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PostUpload200Response</returns>
        public async System.Threading.Tasks.Task<PostUpload200Response> PostPartnerLogoUploadAsync(System.IO.Stream fwUploadFile = default(System.IO.Stream), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            FeeWise.Client.ApiResponse<PostUpload200Response> localVarResponse = await PostPartnerLogoUploadWithHttpInfoAsync(fwUploadFile, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Upload partner logo Upload a partner logo to FeeWise. This logo will be used wherever FeeWise and the partner have agreed to show a logo in the FeeWise UI. nb Content-Type header must be multipart/form-data example  curl -X POST -F \&quot;fwUploadFile&#x3D;@/path/to/file.png\&quot; \\     http://localhost:8080/api/v3/partner/upload \\       - -header &#39;X-CHANNEL-PARTNER-ID: &lt;channel partner id&gt;&#39; \\       - -header &#39;X-API-KEY: &lt;api key&gt;&#39; \\       - -header \&quot;Content-Type: multipart/form-data\&quot; 
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fwUploadFile"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PostUpload200Response)</returns>
        public async System.Threading.Tasks.Task<FeeWise.Client.ApiResponse<PostUpload200Response>> PostPartnerLogoUploadWithHttpInfoAsync(System.IO.Stream fwUploadFile = default(System.IO.Stream), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            FeeWise.Client.RequestOptions localVarRequestOptions = new FeeWise.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
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

            if (fwUploadFile != null)
            {
                localVarRequestOptions.FileParameters.Add("fwUploadFile", fwUploadFile);
            }

            localVarRequestOptions.Operation = "PartnerApi.PostPartnerLogoUpload";
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
            var localVarResponse = await this.AsynchronousClient.PostAsync<PostUpload200Response>("/api/v3/partner/upload", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostPartnerLogoUpload", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
