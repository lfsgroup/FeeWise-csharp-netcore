/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.48
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
    /// Adjust the invoice amount 
    /// </summary>
    [DataContract(Name = "adjustInvoiceAmount_request")]
    public partial class AdjustInvoiceAmountRequest : IEquatable<AdjustInvoiceAmountRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdjustInvoiceAmountRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdjustInvoiceAmountRequest()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdjustInvoiceAmountRequest" /> class.
        /// </summary>
        /// <param name="newAmount">The new total amount for the invoice. (required).</param>
        public AdjustInvoiceAmountRequest(string newAmount = default(string))
        {
            // to ensure "newAmount" is required (not null)
            if (newAmount == null)
            {
                throw new ArgumentNullException("newAmount is a required property for AdjustInvoiceAmountRequest and cannot be null");
            }
            this.NewAmount = newAmount;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The new total amount for the invoice.
        /// </summary>
        /// <value>The new total amount for the invoice.</value>
        [DataMember(Name = "new_amount", IsRequired = true, EmitDefaultValue = true)]
        public string NewAmount { get; set; }

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
            sb.Append("class AdjustInvoiceAmountRequest {\n");
            sb.Append("  NewAmount: ").Append(NewAmount).Append("\n");
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
            return this.Equals(input as AdjustInvoiceAmountRequest);
        }

        /// <summary>
        /// Returns true if AdjustInvoiceAmountRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AdjustInvoiceAmountRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdjustInvoiceAmountRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NewAmount == input.NewAmount ||
                    (this.NewAmount != null &&
                    this.NewAmount.Equals(input.NewAmount))
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
                if (this.NewAmount != null)
                {
                    hashCode = (hashCode * 59) + this.NewAmount.GetHashCode();
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
