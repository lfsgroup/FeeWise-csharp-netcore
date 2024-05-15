/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.120
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = FeeWise.Client.OpenAPIDateConverter;

namespace FeeWise.Model
{
    /// <summary>
    /// Metadata about the pagination of a list of objects. Returned in the response body of any paginated list. 
    /// </summary>
    [DataContract(Name = "PaginationMetadata")]
    public partial class PaginationMetadata : IEquatable<PaginationMetadata>, IValidatableObject
    {
        /// <summary>
        /// Order the records are sorted by, using the sort_by property
        /// </summary>
        /// <value>Order the records are sorted by, using the sort_by property</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RequestedSortOrderEnum
        {
            /// <summary>
            /// Enum Asc for value: asc
            /// </summary>
            [EnumMember(Value = "asc")]
            Asc = 1,

            /// <summary>
            /// Enum Desc for value: desc
            /// </summary>
            [EnumMember(Value = "desc")]
            Desc = 2

        }


        /// <summary>
        /// Order the records are sorted by, using the sort_by property
        /// </summary>
        /// <value>Order the records are sorted by, using the sort_by property</value>
        [DataMember(Name = "requested_sort_order", EmitDefaultValue = false)]
        public RequestedSortOrderEnum? RequestedSortOrder { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationMetadata" /> class.
        /// </summary>
        /// <param name="requestedPage">The requested page number.</param>
        /// <param name="requestedPageSize">Records per page..</param>
        /// <param name="requestedFromDate">The requested from date.</param>
        /// <param name="requestedToDate">The requested to date.</param>
        /// <param name="requestedSortBy">Field that the records were requested to be sorted by..</param>
        /// <param name="requestedStatusFilter">Status that the records were requested to be filtered with..</param>
        /// <param name="requestedAccountIdFilter">Account IDs that the results were filtered with.</param>
        /// <param name="requestedSortOrder">Order the records are sorted by, using the sort_by property (default to RequestedSortOrderEnum.Asc).</param>
        /// <param name="currentPageStartIndex">Index of the first record on the current page.  E.g. To render- Items 1-10, on page 1, 11-20 on page 2, etc. .</param>
        /// <param name="currentPageEndIndex">Index of the last record on the current page.  E.g. To render- Items 1-10, on page 1, 11-20 on page 2, etc. .</param>
        /// <param name="totalRecords">Total number of records returned..</param>
        /// <param name="totalPages">Total number of pages returned. TODO.</param>
        /// <param name="firstPage">Number of the first page. TODO.</param>
        /// <param name="lastPage">Number of the last page. TODO.</param>
        public PaginationMetadata(int requestedPage = default(int), int requestedPageSize = default(int), DateTime requestedFromDate = default(DateTime), DateTime requestedToDate = default(DateTime), string requestedSortBy = default(string), List<string> requestedStatusFilter = default(List<string>), List<Guid> requestedAccountIdFilter = default(List<Guid>), RequestedSortOrderEnum? requestedSortOrder = RequestedSortOrderEnum.Asc, int currentPageStartIndex = default(int), int currentPageEndIndex = default(int), int totalRecords = default(int), int totalPages = default(int), int firstPage = default(int), int lastPage = default(int))
        {
            this.RequestedPage = requestedPage;
            this.RequestedPageSize = requestedPageSize;
            this.RequestedFromDate = requestedFromDate;
            this.RequestedToDate = requestedToDate;
            this.RequestedSortBy = requestedSortBy;
            this.RequestedStatusFilter = requestedStatusFilter;
            this.RequestedAccountIdFilter = requestedAccountIdFilter;
            this.RequestedSortOrder = requestedSortOrder;
            this.CurrentPageStartIndex = currentPageStartIndex;
            this.CurrentPageEndIndex = currentPageEndIndex;
            this.TotalRecords = totalRecords;
            this.TotalPages = totalPages;
            this.FirstPage = firstPage;
            this.LastPage = lastPage;
        }

        /// <summary>
        /// The requested page number
        /// </summary>
        /// <value>The requested page number</value>
        [DataMember(Name = "requested_page", EmitDefaultValue = false)]
        public int RequestedPage { get; set; }

        /// <summary>
        /// Records per page.
        /// </summary>
        /// <value>Records per page.</value>
        [DataMember(Name = "requested_page_size", EmitDefaultValue = false)]
        public int RequestedPageSize { get; set; }

        /// <summary>
        /// The requested from date
        /// </summary>
        /// <value>The requested from date</value>
        [DataMember(Name = "requested_from_date", EmitDefaultValue = false)]
        public DateTime RequestedFromDate { get; set; }

        /// <summary>
        /// The requested to date
        /// </summary>
        /// <value>The requested to date</value>
        [DataMember(Name = "requested_to_date", EmitDefaultValue = false)]
        public DateTime RequestedToDate { get; set; }

        /// <summary>
        /// Field that the records were requested to be sorted by.
        /// </summary>
        /// <value>Field that the records were requested to be sorted by.</value>
        [DataMember(Name = "requested_sort_by", EmitDefaultValue = false)]
        public string RequestedSortBy { get; set; }

        /// <summary>
        /// Status that the records were requested to be filtered with.
        /// </summary>
        /// <value>Status that the records were requested to be filtered with.</value>
        [DataMember(Name = "requested_status_filter", EmitDefaultValue = false)]
        public List<string> RequestedStatusFilter { get; set; }

        /// <summary>
        /// Account IDs that the results were filtered with
        /// </summary>
        /// <value>Account IDs that the results were filtered with</value>
        [DataMember(Name = "requested_account_id_filter", EmitDefaultValue = false)]
        public List<Guid> RequestedAccountIdFilter { get; set; }

        /// <summary>
        /// Index of the first record on the current page.  E.g. To render- Items 1-10, on page 1, 11-20 on page 2, etc. 
        /// </summary>
        /// <value>Index of the first record on the current page.  E.g. To render- Items 1-10, on page 1, 11-20 on page 2, etc. </value>
        [DataMember(Name = "current_page_start_index", EmitDefaultValue = false)]
        public int CurrentPageStartIndex { get; set; }

        /// <summary>
        /// Index of the last record on the current page.  E.g. To render- Items 1-10, on page 1, 11-20 on page 2, etc. 
        /// </summary>
        /// <value>Index of the last record on the current page.  E.g. To render- Items 1-10, on page 1, 11-20 on page 2, etc. </value>
        [DataMember(Name = "current_page_end_index", EmitDefaultValue = false)]
        public int CurrentPageEndIndex { get; set; }

        /// <summary>
        /// Total number of records returned.
        /// </summary>
        /// <value>Total number of records returned.</value>
        [DataMember(Name = "total_records", EmitDefaultValue = false)]
        public int TotalRecords { get; set; }

        /// <summary>
        /// Total number of pages returned. TODO
        /// </summary>
        /// <value>Total number of pages returned. TODO</value>
        [DataMember(Name = "total_pages", EmitDefaultValue = false)]
        public int TotalPages { get; set; }

        /// <summary>
        /// Number of the first page. TODO
        /// </summary>
        /// <value>Number of the first page. TODO</value>
        [DataMember(Name = "first_page", EmitDefaultValue = false)]
        public int FirstPage { get; set; }

        /// <summary>
        /// Number of the last page. TODO
        /// </summary>
        /// <value>Number of the last page. TODO</value>
        [DataMember(Name = "last_page", EmitDefaultValue = false)]
        public int LastPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaginationMetadata {\n");
            sb.Append("  RequestedPage: ").Append(RequestedPage).Append("\n");
            sb.Append("  RequestedPageSize: ").Append(RequestedPageSize).Append("\n");
            sb.Append("  RequestedFromDate: ").Append(RequestedFromDate).Append("\n");
            sb.Append("  RequestedToDate: ").Append(RequestedToDate).Append("\n");
            sb.Append("  RequestedSortBy: ").Append(RequestedSortBy).Append("\n");
            sb.Append("  RequestedStatusFilter: ").Append(RequestedStatusFilter).Append("\n");
            sb.Append("  RequestedAccountIdFilter: ").Append(RequestedAccountIdFilter).Append("\n");
            sb.Append("  RequestedSortOrder: ").Append(RequestedSortOrder).Append("\n");
            sb.Append("  CurrentPageStartIndex: ").Append(CurrentPageStartIndex).Append("\n");
            sb.Append("  CurrentPageEndIndex: ").Append(CurrentPageEndIndex).Append("\n");
            sb.Append("  TotalRecords: ").Append(TotalRecords).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  FirstPage: ").Append(FirstPage).Append("\n");
            sb.Append("  LastPage: ").Append(LastPage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaginationMetadata);
        }

        /// <summary>
        /// Returns true if PaginationMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of PaginationMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaginationMetadata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RequestedPage == input.RequestedPage ||
                    this.RequestedPage.Equals(input.RequestedPage)
                ) && 
                (
                    this.RequestedPageSize == input.RequestedPageSize ||
                    this.RequestedPageSize.Equals(input.RequestedPageSize)
                ) && 
                (
                    this.RequestedFromDate == input.RequestedFromDate ||
                    (this.RequestedFromDate != null &&
                    this.RequestedFromDate.Equals(input.RequestedFromDate))
                ) && 
                (
                    this.RequestedToDate == input.RequestedToDate ||
                    (this.RequestedToDate != null &&
                    this.RequestedToDate.Equals(input.RequestedToDate))
                ) && 
                (
                    this.RequestedSortBy == input.RequestedSortBy ||
                    (this.RequestedSortBy != null &&
                    this.RequestedSortBy.Equals(input.RequestedSortBy))
                ) && 
                (
                    this.RequestedStatusFilter == input.RequestedStatusFilter ||
                    this.RequestedStatusFilter != null &&
                    input.RequestedStatusFilter != null &&
                    this.RequestedStatusFilter.SequenceEqual(input.RequestedStatusFilter)
                ) && 
                (
                    this.RequestedAccountIdFilter == input.RequestedAccountIdFilter ||
                    this.RequestedAccountIdFilter != null &&
                    input.RequestedAccountIdFilter != null &&
                    this.RequestedAccountIdFilter.SequenceEqual(input.RequestedAccountIdFilter)
                ) && 
                (
                    this.RequestedSortOrder == input.RequestedSortOrder ||
                    this.RequestedSortOrder.Equals(input.RequestedSortOrder)
                ) && 
                (
                    this.CurrentPageStartIndex == input.CurrentPageStartIndex ||
                    this.CurrentPageStartIndex.Equals(input.CurrentPageStartIndex)
                ) && 
                (
                    this.CurrentPageEndIndex == input.CurrentPageEndIndex ||
                    this.CurrentPageEndIndex.Equals(input.CurrentPageEndIndex)
                ) && 
                (
                    this.TotalRecords == input.TotalRecords ||
                    this.TotalRecords.Equals(input.TotalRecords)
                ) && 
                (
                    this.TotalPages == input.TotalPages ||
                    this.TotalPages.Equals(input.TotalPages)
                ) && 
                (
                    this.FirstPage == input.FirstPage ||
                    this.FirstPage.Equals(input.FirstPage)
                ) && 
                (
                    this.LastPage == input.LastPage ||
                    this.LastPage.Equals(input.LastPage)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.RequestedPage.GetHashCode();
                hashCode = (hashCode * 59) + this.RequestedPageSize.GetHashCode();
                if (this.RequestedFromDate != null)
                {
                    hashCode = (hashCode * 59) + this.RequestedFromDate.GetHashCode();
                }
                if (this.RequestedToDate != null)
                {
                    hashCode = (hashCode * 59) + this.RequestedToDate.GetHashCode();
                }
                if (this.RequestedSortBy != null)
                {
                    hashCode = (hashCode * 59) + this.RequestedSortBy.GetHashCode();
                }
                if (this.RequestedStatusFilter != null)
                {
                    hashCode = (hashCode * 59) + this.RequestedStatusFilter.GetHashCode();
                }
                if (this.RequestedAccountIdFilter != null)
                {
                    hashCode = (hashCode * 59) + this.RequestedAccountIdFilter.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RequestedSortOrder.GetHashCode();
                hashCode = (hashCode * 59) + this.CurrentPageStartIndex.GetHashCode();
                hashCode = (hashCode * 59) + this.CurrentPageEndIndex.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalRecords.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalPages.GetHashCode();
                hashCode = (hashCode * 59) + this.FirstPage.GetHashCode();
                hashCode = (hashCode * 59) + this.LastPage.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
