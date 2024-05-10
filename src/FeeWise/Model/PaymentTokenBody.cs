/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.117
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
    /// PaymentTokenBody
    /// </summary>
    [DataContract(Name = "PaymentTokenBody")]
    public partial class PaymentTokenBody : IEquatable<PaymentTokenBody>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TokenType
        /// </summary>
        [DataMember(Name = "token_type", EmitDefaultValue = false)]
        public TokenType? TokenType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTokenBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentTokenBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTokenBody" /> class.
        /// </summary>
        /// <param name="debtor">debtor (required).</param>
        /// <param name="tokenType">tokenType.</param>
        /// <param name="paymentMethods">paymentMethods.</param>
        public PaymentTokenBody(Debtor debtor = default(Debtor), TokenType? tokenType = default(TokenType?), List<PaymentMethod> paymentMethods = default(List<PaymentMethod>))
        {
            // to ensure "debtor" is required (not null)
            if (debtor == null)
            {
                throw new ArgumentNullException("debtor is a required property for PaymentTokenBody and cannot be null");
            }
            this.Debtor = debtor;
            this.TokenType = tokenType;
            this.PaymentMethods = paymentMethods;
        }

        /// <summary>
        /// Gets or Sets Debtor
        /// </summary>
        [DataMember(Name = "debtor", IsRequired = true, EmitDefaultValue = true)]
        public Debtor Debtor { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethods
        /// </summary>
        [DataMember(Name = "payment_methods", EmitDefaultValue = false)]
        public List<PaymentMethod> PaymentMethods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentTokenBody {\n");
            sb.Append("  Debtor: ").Append(Debtor).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  PaymentMethods: ").Append(PaymentMethods).Append("\n");
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
            return this.Equals(input as PaymentTokenBody);
        }

        /// <summary>
        /// Returns true if PaymentTokenBody instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentTokenBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentTokenBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Debtor == input.Debtor ||
                    (this.Debtor != null &&
                    this.Debtor.Equals(input.Debtor))
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    this.TokenType.Equals(input.TokenType)
                ) && 
                (
                    this.PaymentMethods == input.PaymentMethods ||
                    this.PaymentMethods != null &&
                    input.PaymentMethods != null &&
                    this.PaymentMethods.SequenceEqual(input.PaymentMethods)
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
                if (this.Debtor != null)
                {
                    hashCode = (hashCode * 59) + this.Debtor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TokenType.GetHashCode();
                if (this.PaymentMethods != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethods.GetHashCode();
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
