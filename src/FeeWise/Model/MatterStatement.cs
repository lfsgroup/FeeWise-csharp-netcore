/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.87
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
    /// MatterStatement
    /// </summary>
    [DataContract(Name = "MatterStatement")]
    public partial class MatterStatement : IEquatable<MatterStatement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatterStatement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MatterStatement()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatterStatement" /> class.
        /// </summary>
        /// <param name="matter">matter (required).</param>
        /// <param name="firmId">The firm the invoice is raised for. (required).</param>
        /// <param name="debtor">debtor (required).</param>
        /// <param name="artifacts">artifacts (required).</param>
        /// <param name="paymentUrl">The URI to get the client payment instructions for this matter statement (required).</param>
        public MatterStatement(Matter matter = default(Matter), Guid firmId = default(Guid), Debtor debtor = default(Debtor), List<Artifact> artifacts = default(List<Artifact>), string paymentUrl = default(string))
        {
            // to ensure "matter" is required (not null)
            if (matter == null)
            {
                throw new ArgumentNullException("matter is a required property for MatterStatement and cannot be null");
            }
            this.Matter = matter;
            this.FirmId = firmId;
            // to ensure "debtor" is required (not null)
            if (debtor == null)
            {
                throw new ArgumentNullException("debtor is a required property for MatterStatement and cannot be null");
            }
            this.Debtor = debtor;
            // to ensure "artifacts" is required (not null)
            if (artifacts == null)
            {
                throw new ArgumentNullException("artifacts is a required property for MatterStatement and cannot be null");
            }
            this.Artifacts = artifacts;
            // to ensure "paymentUrl" is required (not null)
            if (paymentUrl == null)
            {
                throw new ArgumentNullException("paymentUrl is a required property for MatterStatement and cannot be null");
            }
            this.PaymentUrl = paymentUrl;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Matter
        /// </summary>
        [DataMember(Name = "matter", IsRequired = true, EmitDefaultValue = true)]
        public Matter Matter { get; set; }

        /// <summary>
        /// The firm the invoice is raised for.
        /// </summary>
        /// <value>The firm the invoice is raised for.</value>
        [DataMember(Name = "firm_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid FirmId { get; set; }

        /// <summary>
        /// Gets or Sets Debtor
        /// </summary>
        [DataMember(Name = "debtor", IsRequired = true, EmitDefaultValue = true)]
        public Debtor Debtor { get; set; }

        /// <summary>
        /// Gets or Sets Artifacts
        /// </summary>
        [DataMember(Name = "artifacts", IsRequired = true, EmitDefaultValue = true)]
        public List<Artifact> Artifacts { get; set; }

        /// <summary>
        /// The URI to get the client payment instructions for this matter statement
        /// </summary>
        /// <value>The URI to get the client payment instructions for this matter statement</value>
        [DataMember(Name = "payment_url", IsRequired = true, EmitDefaultValue = true)]
        public string PaymentUrl { get; set; }

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
            sb.Append("class MatterStatement {\n");
            sb.Append("  Matter: ").Append(Matter).Append("\n");
            sb.Append("  FirmId: ").Append(FirmId).Append("\n");
            sb.Append("  Debtor: ").Append(Debtor).Append("\n");
            sb.Append("  Artifacts: ").Append(Artifacts).Append("\n");
            sb.Append("  PaymentUrl: ").Append(PaymentUrl).Append("\n");
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
            return this.Equals(input as MatterStatement);
        }

        /// <summary>
        /// Returns true if MatterStatement instances are equal
        /// </summary>
        /// <param name="input">Instance of MatterStatement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatterStatement input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Matter == input.Matter ||
                    (this.Matter != null &&
                    this.Matter.Equals(input.Matter))
                ) && 
                (
                    this.FirmId == input.FirmId ||
                    (this.FirmId != null &&
                    this.FirmId.Equals(input.FirmId))
                ) && 
                (
                    this.Debtor == input.Debtor ||
                    (this.Debtor != null &&
                    this.Debtor.Equals(input.Debtor))
                ) && 
                (
                    this.Artifacts == input.Artifacts ||
                    this.Artifacts != null &&
                    input.Artifacts != null &&
                    this.Artifacts.SequenceEqual(input.Artifacts)
                ) && 
                (
                    this.PaymentUrl == input.PaymentUrl ||
                    (this.PaymentUrl != null &&
                    this.PaymentUrl.Equals(input.PaymentUrl))
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
                if (this.Matter != null)
                {
                    hashCode = (hashCode * 59) + this.Matter.GetHashCode();
                }
                if (this.FirmId != null)
                {
                    hashCode = (hashCode * 59) + this.FirmId.GetHashCode();
                }
                if (this.Debtor != null)
                {
                    hashCode = (hashCode * 59) + this.Debtor.GetHashCode();
                }
                if (this.Artifacts != null)
                {
                    hashCode = (hashCode * 59) + this.Artifacts.GetHashCode();
                }
                if (this.PaymentUrl != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentUrl.GetHashCode();
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
