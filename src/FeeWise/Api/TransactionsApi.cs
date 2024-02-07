/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.110
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
    public interface ITransactionsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Search for transactions for a channel partner..         Filters supplied in the query params must *all* be met. 
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="from">Return transactions since this timestamp. If not supplied, \&quot;from\&quot; defaults to the last 7 days\&quot;.  (optional)</param>
        /// <param name="to">Return payments created before timestamp. If not supplied, \&quot;to\&quot; defaults to now.  (optional)</param>
        /// <param name="page">Pagination - Page number to return  (optional, default to 1)</param>
        /// <param name="pageSize">Pagination - Transactions per page  (optional, default to 20)</param>
        /// <param name="sortBy">Field to sort by, from the transaction model (optional, default to payment_date)</param>
        /// <param name="order">Sorting order (asc or desc). Default is desc  (optional, default to desc)</param>
        /// <param name="statusFilter">Filter by status nb: Example usage, comma separated, in query... /transactions?status_filter&#x3D;Paid,Initialised  (optional)</param>
        /// <param name="accountIdFilter">Filter by account id nb: Example usage, comma separated, in query... /transactions?account_id&#x3D;57d43c4e-f18d-40ae-9511-2aeafbf68def,b7dc7851-5cc4-41d5-8174-f00ad916f76b  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TransactionsResponse</returns>
        TransactionsResponse GetFirmTransactions(Guid firmId, DateTime? from = default(DateTime?), DateTime? to = default(DateTime?), int? page = default(int?), int? pageSize = default(int?), string sortBy = default(string), string order = default(string), List<string> statusFilter = default(List<string>), List<Guid> accountIdFilter = default(List<Guid>), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Search for transactions for a channel partner..         Filters supplied in the query params must *all* be met. 
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="from">Return transactions since this timestamp. If not supplied, \&quot;from\&quot; defaults to the last 7 days\&quot;.  (optional)</param>
        /// <param name="to">Return payments created before timestamp. If not supplied, \&quot;to\&quot; defaults to now.  (optional)</param>
        /// <param name="page">Pagination - Page number to return  (optional, default to 1)</param>
        /// <param name="pageSize">Pagination - Transactions per page  (optional, default to 20)</param>
        /// <param name="sortBy">Field to sort by, from the transaction model (optional, default to payment_date)</param>
        /// <param name="order">Sorting order (asc or desc). Default is desc  (optional, default to desc)</param>
        /// <param name="statusFilter">Filter by status nb: Example usage, comma separated, in query... /transactions?status_filter&#x3D;Paid,Initialised  (optional)</param>
        /// <param name="accountIdFilter">Filter by account id nb: Example usage, comma separated, in query... /transactions?account_id&#x3D;57d43c4e-f18d-40ae-9511-2aeafbf68def,b7dc7851-5cc4-41d5-8174-f00ad916f76b  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TransactionsResponse</returns>
        ApiResponse<TransactionsResponse> GetFirmTransactionsWithHttpInfo(Guid firmId, DateTime? from = default(DateTime?), DateTime? to = default(DateTime?), int? page = default(int?), int? pageSize = default(int?), string sortBy = default(string), string order = default(string), List<string> statusFilter = default(List<string>), List<Guid> accountIdFilter = default(List<Guid>), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITransactionsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Search for transactions for a channel partner..         Filters supplied in the query params must *all* be met. 
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="from">Return transactions since this timestamp. If not supplied, \&quot;from\&quot; defaults to the last 7 days\&quot;.  (optional)</param>
        /// <param name="to">Return payments created before timestamp. If not supplied, \&quot;to\&quot; defaults to now.  (optional)</param>
        /// <param name="page">Pagination - Page number to return  (optional, default to 1)</param>
        /// <param name="pageSize">Pagination - Transactions per page  (optional, default to 20)</param>
        /// <param name="sortBy">Field to sort by, from the transaction model (optional, default to payment_date)</param>
        /// <param name="order">Sorting order (asc or desc). Default is desc  (optional, default to desc)</param>
        /// <param name="statusFilter">Filter by status nb: Example usage, comma separated, in query... /transactions?status_filter&#x3D;Paid,Initialised  (optional)</param>
        /// <param name="accountIdFilter">Filter by account id nb: Example usage, comma separated, in query... /transactions?account_id&#x3D;57d43c4e-f18d-40ae-9511-2aeafbf68def,b7dc7851-5cc4-41d5-8174-f00ad916f76b  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TransactionsResponse</returns>
        System.Threading.Tasks.Task<TransactionsResponse> GetFirmTransactionsAsync(Guid firmId, DateTime? from = default(DateTime?), DateTime? to = default(DateTime?), int? page = default(int?), int? pageSize = default(int?), string sortBy = default(string), string order = default(string), List<string> statusFilter = default(List<string>), List<Guid> accountIdFilter = default(List<Guid>), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Search for transactions for a channel partner..         Filters supplied in the query params must *all* be met. 
        /// </remarks>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="from">Return transactions since this timestamp. If not supplied, \&quot;from\&quot; defaults to the last 7 days\&quot;.  (optional)</param>
        /// <param name="to">Return payments created before timestamp. If not supplied, \&quot;to\&quot; defaults to now.  (optional)</param>
        /// <param name="page">Pagination - Page number to return  (optional, default to 1)</param>
        /// <param name="pageSize">Pagination - Transactions per page  (optional, default to 20)</param>
        /// <param name="sortBy">Field to sort by, from the transaction model (optional, default to payment_date)</param>
        /// <param name="order">Sorting order (asc or desc). Default is desc  (optional, default to desc)</param>
        /// <param name="statusFilter">Filter by status nb: Example usage, comma separated, in query... /transactions?status_filter&#x3D;Paid,Initialised  (optional)</param>
        /// <param name="accountIdFilter">Filter by account id nb: Example usage, comma separated, in query... /transactions?account_id&#x3D;57d43c4e-f18d-40ae-9511-2aeafbf68def,b7dc7851-5cc4-41d5-8174-f00ad916f76b  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TransactionsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransactionsResponse>> GetFirmTransactionsWithHttpInfoAsync(Guid firmId, DateTime? from = default(DateTime?), DateTime? to = default(DateTime?), int? page = default(int?), int? pageSize = default(int?), string sortBy = default(string), string order = default(string), List<string> statusFilter = default(List<string>), List<Guid> accountIdFilter = default(List<Guid>), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITransactionsApi : ITransactionsApiSync, ITransactionsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TransactionsApi : ITransactionsApi
    {
        private FeeWise.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransactionsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransactionsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TransactionsApi(FeeWise.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public TransactionsApi(FeeWise.Client.ISynchronousClient client, FeeWise.Client.IAsynchronousClient asyncClient, FeeWise.Client.IReadableConfiguration configuration)
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
        ///  Search for transactions for a channel partner..         Filters supplied in the query params must *all* be met. 
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="from">Return transactions since this timestamp. If not supplied, \&quot;from\&quot; defaults to the last 7 days\&quot;.  (optional)</param>
        /// <param name="to">Return payments created before timestamp. If not supplied, \&quot;to\&quot; defaults to now.  (optional)</param>
        /// <param name="page">Pagination - Page number to return  (optional, default to 1)</param>
        /// <param name="pageSize">Pagination - Transactions per page  (optional, default to 20)</param>
        /// <param name="sortBy">Field to sort by, from the transaction model (optional, default to payment_date)</param>
        /// <param name="order">Sorting order (asc or desc). Default is desc  (optional, default to desc)</param>
        /// <param name="statusFilter">Filter by status nb: Example usage, comma separated, in query... /transactions?status_filter&#x3D;Paid,Initialised  (optional)</param>
        /// <param name="accountIdFilter">Filter by account id nb: Example usage, comma separated, in query... /transactions?account_id&#x3D;57d43c4e-f18d-40ae-9511-2aeafbf68def,b7dc7851-5cc4-41d5-8174-f00ad916f76b  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TransactionsResponse</returns>
        public TransactionsResponse GetFirmTransactions(Guid firmId, DateTime? from = default(DateTime?), DateTime? to = default(DateTime?), int? page = default(int?), int? pageSize = default(int?), string sortBy = default(string), string order = default(string), List<string> statusFilter = default(List<string>), List<Guid> accountIdFilter = default(List<Guid>), int operationIndex = 0)
        {
            FeeWise.Client.ApiResponse<TransactionsResponse> localVarResponse = GetFirmTransactionsWithHttpInfo(firmId, from, to, page, pageSize, sortBy, order, statusFilter, accountIdFilter);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Search for transactions for a channel partner..         Filters supplied in the query params must *all* be met. 
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="from">Return transactions since this timestamp. If not supplied, \&quot;from\&quot; defaults to the last 7 days\&quot;.  (optional)</param>
        /// <param name="to">Return payments created before timestamp. If not supplied, \&quot;to\&quot; defaults to now.  (optional)</param>
        /// <param name="page">Pagination - Page number to return  (optional, default to 1)</param>
        /// <param name="pageSize">Pagination - Transactions per page  (optional, default to 20)</param>
        /// <param name="sortBy">Field to sort by, from the transaction model (optional, default to payment_date)</param>
        /// <param name="order">Sorting order (asc or desc). Default is desc  (optional, default to desc)</param>
        /// <param name="statusFilter">Filter by status nb: Example usage, comma separated, in query... /transactions?status_filter&#x3D;Paid,Initialised  (optional)</param>
        /// <param name="accountIdFilter">Filter by account id nb: Example usage, comma separated, in query... /transactions?account_id&#x3D;57d43c4e-f18d-40ae-9511-2aeafbf68def,b7dc7851-5cc4-41d5-8174-f00ad916f76b  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TransactionsResponse</returns>
        public FeeWise.Client.ApiResponse<TransactionsResponse> GetFirmTransactionsWithHttpInfo(Guid firmId, DateTime? from = default(DateTime?), DateTime? to = default(DateTime?), int? page = default(int?), int? pageSize = default(int?), string sortBy = default(string), string order = default(string), List<string> statusFilter = default(List<string>), List<Guid> accountIdFilter = default(List<Guid>), int operationIndex = 0)
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
            if (from != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("", "from", from));
            }
            if (to != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("", "to", to));
            }
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }
            if (sortBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("", "sort_by", sortBy));
            }
            if (order != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("", "order", order));
            }
            if (statusFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("csv", "status_filter", statusFilter));
            }
            if (accountIdFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("csv", "account_id_filter", accountIdFilter));
            }

            localVarRequestOptions.Operation = "TransactionsApi.GetFirmTransactions";
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
            var localVarResponse = this.Client.Get<TransactionsResponse>("/api/v3/partner/firms/{firm_id}/transactions", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetFirmTransactions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Search for transactions for a channel partner..         Filters supplied in the query params must *all* be met. 
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="from">Return transactions since this timestamp. If not supplied, \&quot;from\&quot; defaults to the last 7 days\&quot;.  (optional)</param>
        /// <param name="to">Return payments created before timestamp. If not supplied, \&quot;to\&quot; defaults to now.  (optional)</param>
        /// <param name="page">Pagination - Page number to return  (optional, default to 1)</param>
        /// <param name="pageSize">Pagination - Transactions per page  (optional, default to 20)</param>
        /// <param name="sortBy">Field to sort by, from the transaction model (optional, default to payment_date)</param>
        /// <param name="order">Sorting order (asc or desc). Default is desc  (optional, default to desc)</param>
        /// <param name="statusFilter">Filter by status nb: Example usage, comma separated, in query... /transactions?status_filter&#x3D;Paid,Initialised  (optional)</param>
        /// <param name="accountIdFilter">Filter by account id nb: Example usage, comma separated, in query... /transactions?account_id&#x3D;57d43c4e-f18d-40ae-9511-2aeafbf68def,b7dc7851-5cc4-41d5-8174-f00ad916f76b  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TransactionsResponse</returns>
        public async System.Threading.Tasks.Task<TransactionsResponse> GetFirmTransactionsAsync(Guid firmId, DateTime? from = default(DateTime?), DateTime? to = default(DateTime?), int? page = default(int?), int? pageSize = default(int?), string sortBy = default(string), string order = default(string), List<string> statusFilter = default(List<string>), List<Guid> accountIdFilter = default(List<Guid>), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            FeeWise.Client.ApiResponse<TransactionsResponse> localVarResponse = await GetFirmTransactionsWithHttpInfoAsync(firmId, from, to, page, pageSize, sortBy, order, statusFilter, accountIdFilter, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Search for transactions for a channel partner..         Filters supplied in the query params must *all* be met. 
        /// </summary>
        /// <exception cref="FeeWise.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firmId"></param>
        /// <param name="from">Return transactions since this timestamp. If not supplied, \&quot;from\&quot; defaults to the last 7 days\&quot;.  (optional)</param>
        /// <param name="to">Return payments created before timestamp. If not supplied, \&quot;to\&quot; defaults to now.  (optional)</param>
        /// <param name="page">Pagination - Page number to return  (optional, default to 1)</param>
        /// <param name="pageSize">Pagination - Transactions per page  (optional, default to 20)</param>
        /// <param name="sortBy">Field to sort by, from the transaction model (optional, default to payment_date)</param>
        /// <param name="order">Sorting order (asc or desc). Default is desc  (optional, default to desc)</param>
        /// <param name="statusFilter">Filter by status nb: Example usage, comma separated, in query... /transactions?status_filter&#x3D;Paid,Initialised  (optional)</param>
        /// <param name="accountIdFilter">Filter by account id nb: Example usage, comma separated, in query... /transactions?account_id&#x3D;57d43c4e-f18d-40ae-9511-2aeafbf68def,b7dc7851-5cc4-41d5-8174-f00ad916f76b  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TransactionsResponse)</returns>
        public async System.Threading.Tasks.Task<FeeWise.Client.ApiResponse<TransactionsResponse>> GetFirmTransactionsWithHttpInfoAsync(Guid firmId, DateTime? from = default(DateTime?), DateTime? to = default(DateTime?), int? page = default(int?), int? pageSize = default(int?), string sortBy = default(string), string order = default(string), List<string> statusFilter = default(List<string>), List<Guid> accountIdFilter = default(List<Guid>), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
            if (from != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("", "from", from));
            }
            if (to != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("", "to", to));
            }
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }
            if (sortBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("", "sort_by", sortBy));
            }
            if (order != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("", "order", order));
            }
            if (statusFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("csv", "status_filter", statusFilter));
            }
            if (accountIdFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(FeeWise.Client.ClientUtils.ParameterToMultiMap("csv", "account_id_filter", accountIdFilter));
            }

            localVarRequestOptions.Operation = "TransactionsApi.GetFirmTransactions";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<TransactionsResponse>("/api/v3/partner/firms/{firm_id}/transactions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetFirmTransactions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
