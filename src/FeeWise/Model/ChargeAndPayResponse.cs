/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.70
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
    /// ChargeAndPayResponse
    /// </summary>
    [DataContract(Name = "ChargeAndPayResponse")]
    public partial class ChargeAndPayResponse : IEquatable<ChargeAndPayResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeAndPayResponse" /> class.
        /// </summary>
        /// <param name="charge">charge.</param>
        /// <param name="paymentId">The unique ID for this charges payment.</param>
        public ChargeAndPayResponse(Charge charge = default(Charge), Guid paymentId = default(Guid))
        {
            this.Charge = charge;
            this.PaymentId = paymentId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Charge
        /// </summary>
        [DataMember(Name = "charge", EmitDefaultValue = false)]
        public Charge Charge { get; set; }

        /// <summary>
        /// The unique ID for this charges payment
        /// </summary>
        /// <value>The unique ID for this charges payment</value>
        [DataMember(Name = "payment_id", EmitDefaultValue = false)]
        public Guid PaymentId { get; set; }

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
            sb.Append("class ChargeAndPayResponse {\n");
            sb.Append("  Charge: ").Append(Charge).Append("\n");
            sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
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
            return this.Equals(input as ChargeAndPayResponse);
        }

        /// <summary>
        /// Returns true if ChargeAndPayResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargeAndPayResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeAndPayResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Charge == input.Charge ||
                    (this.Charge != null &&
                    this.Charge.Equals(input.Charge))
                ) && 
                (
                    this.PaymentId == input.PaymentId ||
                    (this.PaymentId != null &&
                    this.PaymentId.Equals(input.PaymentId))
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
                if (this.Charge != null)
                {
                    hashCode = (hashCode * 59) + this.Charge.GetHashCode();
                }
                if (this.PaymentId != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentId.GetHashCode();
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
