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
    /// PaymentTokenResponse
    /// </summary>
    [DataContract(Name = "PaymentTokenResponse")]
    public partial class PaymentTokenResponse : IEquatable<PaymentTokenResponse>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TokenType
        /// </summary>
        [DataMember(Name = "token_type", EmitDefaultValue = false)]
        public TokenType? TokenType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTokenResponse" /> class.
        /// </summary>
        /// <param name="debtor">debtor.</param>
        /// <param name="paymentToken">The unique ID for this customer&#39;s payment method, this can be used to charge the associated customer.</param>
        /// <param name="captureUri">The URI to capture the payment details for this payment token.</param>
        /// <param name="tokenType">tokenType.</param>
        public PaymentTokenResponse(Debtor debtor = default(Debtor), Guid paymentToken = default(Guid), string captureUri = default(string), TokenType? tokenType = default(TokenType?))
        {
            this.Debtor = debtor;
            this.PaymentToken = paymentToken;
            this.CaptureUri = captureUri;
            this.TokenType = tokenType;
        }

        /// <summary>
        /// Gets or Sets Debtor
        /// </summary>
        [DataMember(Name = "debtor", EmitDefaultValue = false)]
        public Debtor Debtor { get; set; }

        /// <summary>
        /// The unique ID for this customer&#39;s payment method, this can be used to charge the associated customer
        /// </summary>
        /// <value>The unique ID for this customer&#39;s payment method, this can be used to charge the associated customer</value>
        [DataMember(Name = "payment_token", EmitDefaultValue = false)]
        public Guid PaymentToken { get; set; }

        /// <summary>
        /// The URI to capture the payment details for this payment token
        /// </summary>
        /// <value>The URI to capture the payment details for this payment token</value>
        [DataMember(Name = "capture_uri", EmitDefaultValue = false)]
        public string CaptureUri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentTokenResponse {\n");
            sb.Append("  Debtor: ").Append(Debtor).Append("\n");
            sb.Append("  PaymentToken: ").Append(PaymentToken).Append("\n");
            sb.Append("  CaptureUri: ").Append(CaptureUri).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
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
            return this.Equals(input as PaymentTokenResponse);
        }

        /// <summary>
        /// Returns true if PaymentTokenResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentTokenResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentTokenResponse input)
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
                    this.PaymentToken == input.PaymentToken ||
                    (this.PaymentToken != null &&
                    this.PaymentToken.Equals(input.PaymentToken))
                ) && 
                (
                    this.CaptureUri == input.CaptureUri ||
                    (this.CaptureUri != null &&
                    this.CaptureUri.Equals(input.CaptureUri))
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    this.TokenType.Equals(input.TokenType)
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
                if (this.PaymentToken != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentToken.GetHashCode();
                }
                if (this.CaptureUri != null)
                {
                    hashCode = (hashCode * 59) + this.CaptureUri.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TokenType.GetHashCode();
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
