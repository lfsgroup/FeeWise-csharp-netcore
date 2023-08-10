/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.71
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
    /// CustomerPaymentMethodAllOf
    /// </summary>
    [DataContract(Name = "CustomerPaymentMethod_allOf")]
    public partial class CustomerPaymentMethodAllOf : IEquatable<CustomerPaymentMethodAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerPaymentMethodAllOf" /> class.
        /// </summary>
        /// <param name="paymentToken">The unique ID for this customer&#39;s payment method, this can be used to charge the associated customer.</param>
        public CustomerPaymentMethodAllOf(Guid paymentToken = default(Guid))
        {
            this.PaymentToken = paymentToken;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The unique ID for this customer&#39;s payment method, this can be used to charge the associated customer
        /// </summary>
        /// <value>The unique ID for this customer&#39;s payment method, this can be used to charge the associated customer</value>
        [DataMember(Name = "payment_token", EmitDefaultValue = false)]
        public Guid PaymentToken { get; set; }

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
            sb.Append("class CustomerPaymentMethodAllOf {\n");
            sb.Append("  PaymentToken: ").Append(PaymentToken).Append("\n");
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
            return this.Equals(input as CustomerPaymentMethodAllOf);
        }

        /// <summary>
        /// Returns true if CustomerPaymentMethodAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerPaymentMethodAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerPaymentMethodAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PaymentToken == input.PaymentToken ||
                    (this.PaymentToken != null &&
                    this.PaymentToken.Equals(input.PaymentToken))
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
                if (this.PaymentToken != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentToken.GetHashCode();
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
