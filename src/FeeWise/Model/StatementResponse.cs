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
    /// StatementResponse
    /// </summary>
    [DataContract(Name = "StatementResponse")]
    public partial class StatementResponse : IEquatable<StatementResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatementResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StatementResponse()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="StatementResponse" /> class.
        /// </summary>
        /// <param name="statement">statement (required).</param>
        /// <param name="paymentUrl">The URI to get the client payment instructions for this invoice.</param>
        public StatementResponse(Statement statement = default(Statement), string paymentUrl = default(string))
        {
            // to ensure "statement" is required (not null)
            if (statement == null)
            {
                throw new ArgumentNullException("statement is a required property for StatementResponse and cannot be null");
            }
            this.Statement = statement;
            this.PaymentUrl = paymentUrl;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Statement
        /// </summary>
        [DataMember(Name = "statement", IsRequired = true, EmitDefaultValue = true)]
        public Statement Statement { get; set; }

        /// <summary>
        /// The URI to get the client payment instructions for this invoice
        /// </summary>
        /// <value>The URI to get the client payment instructions for this invoice</value>
        [DataMember(Name = "payment_url", EmitDefaultValue = false)]
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
            sb.Append("class StatementResponse {\n");
            sb.Append("  Statement: ").Append(Statement).Append("\n");
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
            return this.Equals(input as StatementResponse);
        }

        /// <summary>
        /// Returns true if StatementResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of StatementResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatementResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Statement == input.Statement ||
                    (this.Statement != null &&
                    this.Statement.Equals(input.Statement))
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
                if (this.Statement != null)
                {
                    hashCode = (hashCode * 59) + this.Statement.GetHashCode();
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
