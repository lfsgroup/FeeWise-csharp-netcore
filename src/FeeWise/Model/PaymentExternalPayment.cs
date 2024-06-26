/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.122
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
    /// If the payment.payment_type is &#39;External&#39;, the external_payment property *may* be available.             The values for these properties are supplied in the call to &#39;RecordExternalPayment&#39; 
    /// </summary>
    [DataContract(Name = "Payment_external_payment")]
    public partial class PaymentExternalPayment : IEquatable<PaymentExternalPayment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentExternalPayment" /> class.
        /// </summary>
        /// <param name="type">The type supplied when the external payment was recorded.</param>
        /// <param name="externalId">The id supplied when the external payment was recorded.</param>
        /// <param name="details">The details supplied when the external payment was recorded.</param>
        public PaymentExternalPayment(string type = default(string), string externalId = default(string), string details = default(string))
        {
            this.Type = type;
            this.ExternalId = externalId;
            this.Details = details;
        }

        /// <summary>
        /// The type supplied when the external payment was recorded
        /// </summary>
        /// <value>The type supplied when the external payment was recorded</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The id supplied when the external payment was recorded
        /// </summary>
        /// <value>The id supplied when the external payment was recorded</value>
        [DataMember(Name = "external_id", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The details supplied when the external payment was recorded
        /// </summary>
        /// <value>The details supplied when the external payment was recorded</value>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public string Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentExternalPayment {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(input as PaymentExternalPayment);
        }

        /// <summary>
        /// Returns true if PaymentExternalPayment instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentExternalPayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentExternalPayment input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.ExternalId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalId.GetHashCode();
                }
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
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
