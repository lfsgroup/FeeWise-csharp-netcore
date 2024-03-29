/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.47
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
    /// Parameters for generating a statement of account. The statement of account will include Invoices and Trust Deposits that match the provided information
    /// </summary>
    [DataContract(Name = "Statement")]
    public partial class Statement : IEquatable<Statement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Statement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Statement()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Statement" /> class.
        /// </summary>
        /// <param name="firmId">The FeeWise Firm ID. (required).</param>
        /// <param name="externalMatterId">The ID of a matter from the calling system. See external_id field in &#39;#/components/schemas/Matter&#39;.</param>
        /// <param name="externalDebtorId">The ID of a debtor from the calling system. See external_id field in &#39;#/components/schemas/Debtor&#39; (required).</param>
        /// <param name="endDate">an optional end date for retrieving Invoices or Trust Deposits. Will retrieve anything created on or before this date..</param>
        /// <param name="startDate">an optional start date for retrieving Invoices or Trust Deposits. Will retrieve anything created on or after this date..</param>
        public Statement(Guid firmId = default(Guid), string externalMatterId = default(string), string externalDebtorId = default(string), DateTime endDate = default(DateTime), DateTime startDate = default(DateTime))
        {
            this.FirmId = firmId;
            // to ensure "externalDebtorId" is required (not null)
            if (externalDebtorId == null)
            {
                throw new ArgumentNullException("externalDebtorId is a required property for Statement and cannot be null");
            }
            this.ExternalDebtorId = externalDebtorId;
            this.ExternalMatterId = externalMatterId;
            this.EndDate = endDate;
            this.StartDate = startDate;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The FeeWise Firm ID.
        /// </summary>
        /// <value>The FeeWise Firm ID.</value>
        [DataMember(Name = "firm_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid FirmId { get; set; }

        /// <summary>
        /// The ID of a matter from the calling system. See external_id field in &#39;#/components/schemas/Matter&#39;
        /// </summary>
        /// <value>The ID of a matter from the calling system. See external_id field in &#39;#/components/schemas/Matter&#39;</value>
        [DataMember(Name = "external_matter_id", EmitDefaultValue = false)]
        public string ExternalMatterId { get; set; }

        /// <summary>
        /// The ID of a debtor from the calling system. See external_id field in &#39;#/components/schemas/Debtor&#39;
        /// </summary>
        /// <value>The ID of a debtor from the calling system. See external_id field in &#39;#/components/schemas/Debtor&#39;</value>
        [DataMember(Name = "external_debtor_id", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalDebtorId { get; set; }

        /// <summary>
        /// an optional end date for retrieving Invoices or Trust Deposits. Will retrieve anything created on or before this date.
        /// </summary>
        /// <value>an optional end date for retrieving Invoices or Trust Deposits. Will retrieve anything created on or before this date.</value>
        [DataMember(Name = "end_date", EmitDefaultValue = false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// an optional start date for retrieving Invoices or Trust Deposits. Will retrieve anything created on or after this date.
        /// </summary>
        /// <value>an optional start date for retrieving Invoices or Trust Deposits. Will retrieve anything created on or after this date.</value>
        [DataMember(Name = "start_date", EmitDefaultValue = false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Statement {\n");
            sb.Append("  FirmId: ").Append(FirmId).Append("\n");
            sb.Append("  ExternalMatterId: ").Append(ExternalMatterId).Append("\n");
            sb.Append("  ExternalDebtorId: ").Append(ExternalDebtorId).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
            return this.Equals(input as Statement);
        }

        /// <summary>
        /// Returns true if Statement instances are equal
        /// </summary>
        /// <param name="input">Instance of Statement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Statement input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FirmId == input.FirmId ||
                    (this.FirmId != null &&
                    this.FirmId.Equals(input.FirmId))
                ) && 
                (
                    this.ExternalMatterId == input.ExternalMatterId ||
                    (this.ExternalMatterId != null &&
                    this.ExternalMatterId.Equals(input.ExternalMatterId))
                ) && 
                (
                    this.ExternalDebtorId == input.ExternalDebtorId ||
                    (this.ExternalDebtorId != null &&
                    this.ExternalDebtorId.Equals(input.ExternalDebtorId))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
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
                if (this.FirmId != null)
                {
                    hashCode = (hashCode * 59) + this.FirmId.GetHashCode();
                }
                if (this.ExternalMatterId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalMatterId.GetHashCode();
                }
                if (this.ExternalDebtorId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalDebtorId.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
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
