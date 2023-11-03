/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.105
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
    /// A payment that was made outside of the FeeWise platform.
    /// </summary>
    [DataContract(Name = "ExternalPayment")]
    public partial class ExternalPayment : IEquatable<ExternalPayment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalPayment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExternalPayment()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalPayment" /> class.
        /// </summary>
        /// <param name="artifactId">The artifact (Invoice, TrustDeposit, ...) the payment is in relation to. (required).</param>
        /// <param name="amount">The amount of the external payment (required).</param>
        /// <param name="paymentType">Freeform description of the type (eg visa, amex, cash, bank transfer).</param>
        /// <param name="externalId">An ID, external to FeeWise, to identify the payment (required).</param>
        /// <param name="details">Freeform description of the payment (eg \&quot;Paid in person with cash - receipt GB-6832\&quot; ).</param>
        public ExternalPayment(Guid artifactId = default(Guid), string amount = default(string), string paymentType = default(string), string externalId = default(string), string details = default(string))
        {
            this.ArtifactId = artifactId;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for ExternalPayment and cannot be null");
            }
            this.Amount = amount;
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new ArgumentNullException("externalId is a required property for ExternalPayment and cannot be null");
            }
            this.ExternalId = externalId;
            this.PaymentType = paymentType;
            this.Details = details;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The artifact (Invoice, TrustDeposit, ...) the payment is in relation to.
        /// </summary>
        /// <value>The artifact (Invoice, TrustDeposit, ...) the payment is in relation to.</value>
        [DataMember(Name = "artifact_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid ArtifactId { get; set; }

        /// <summary>
        /// The amount of the external payment
        /// </summary>
        /// <value>The amount of the external payment</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public string Amount { get; set; }

        /// <summary>
        /// Freeform description of the type (eg visa, amex, cash, bank transfer)
        /// </summary>
        /// <value>Freeform description of the type (eg visa, amex, cash, bank transfer)</value>
        [DataMember(Name = "payment_type", EmitDefaultValue = false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// An ID, external to FeeWise, to identify the payment
        /// </summary>
        /// <value>An ID, external to FeeWise, to identify the payment</value>
        [DataMember(Name = "external_id", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Freeform description of the payment (eg \&quot;Paid in person with cash - receipt GB-6832\&quot; )
        /// </summary>
        /// <value>Freeform description of the payment (eg \&quot;Paid in person with cash - receipt GB-6832\&quot; )</value>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public string Details { get; set; }

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
            sb.Append("class ExternalPayment {\n");
            sb.Append("  ArtifactId: ").Append(ArtifactId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(input as ExternalPayment);
        }

        /// <summary>
        /// Returns true if ExternalPayment instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalPayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalPayment input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ArtifactId == input.ArtifactId ||
                    (this.ArtifactId != null &&
                    this.ArtifactId.Equals(input.ArtifactId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.PaymentType == input.PaymentType ||
                    (this.PaymentType != null &&
                    this.PaymentType.Equals(input.PaymentType))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
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
                if (this.ArtifactId != null)
                {
                    hashCode = (hashCode * 59) + this.ArtifactId.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.PaymentType != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentType.GetHashCode();
                }
                if (this.ExternalId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalId.GetHashCode();
                }
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
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
