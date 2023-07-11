/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.62
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
    /// TrustDepositResponse
    /// </summary>
    [DataContract(Name = "TrustDepositResponse")]
    public partial class TrustDepositResponse : IEquatable<TrustDepositResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustDepositResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrustDepositResponse()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustDepositResponse" /> class.
        /// </summary>
        /// <param name="trustDeposit">trustDeposit (required).</param>
        public TrustDepositResponse(TrustDeposit trustDeposit = default(TrustDeposit))
        {
            // to ensure "trustDeposit" is required (not null)
            if (trustDeposit == null)
            {
                throw new ArgumentNullException("trustDeposit is a required property for TrustDepositResponse and cannot be null");
            }
            this.TrustDeposit = trustDeposit;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets TrustDeposit
        /// </summary>
        [DataMember(Name = "trust_deposit", IsRequired = true, EmitDefaultValue = true)]
        public TrustDeposit TrustDeposit { get; set; }

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
            sb.Append("class TrustDepositResponse {\n");
            sb.Append("  TrustDeposit: ").Append(TrustDeposit).Append("\n");
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
            return this.Equals(input as TrustDepositResponse);
        }

        /// <summary>
        /// Returns true if TrustDepositResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TrustDepositResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrustDepositResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TrustDeposit == input.TrustDeposit ||
                    (this.TrustDeposit != null &&
                    this.TrustDeposit.Equals(input.TrustDeposit))
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
                if (this.TrustDeposit != null)
                {
                    hashCode = (hashCode * 59) + this.TrustDeposit.GetHashCode();
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
