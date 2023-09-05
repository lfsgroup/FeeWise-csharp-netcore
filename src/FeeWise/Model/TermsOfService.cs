/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.84
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
    /// Document that the firm has signed and provided, e.g. FeeWise Terms of Service
    /// </summary>
    [DataContract(Name = "TermsOfService")]
    public partial class TermsOfService : IEquatable<TermsOfService>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TermsOfService" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TermsOfService()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="TermsOfService" /> class.
        /// </summary>
        /// <param name="documentName">documentName (required).</param>
        /// <param name="accepted">accepted (required).</param>
        /// <param name="acceptedIp">acceptedIp (required).</param>
        public TermsOfService(string documentName = default(string), DateTime accepted = default(DateTime), string acceptedIp = default(string))
        {
            // to ensure "documentName" is required (not null)
            if (documentName == null)
            {
                throw new ArgumentNullException("documentName is a required property for TermsOfService and cannot be null");
            }
            this.DocumentName = documentName;
            this.Accepted = accepted;
            // to ensure "acceptedIp" is required (not null)
            if (acceptedIp == null)
            {
                throw new ArgumentNullException("acceptedIp is a required property for TermsOfService and cannot be null");
            }
            this.AcceptedIp = acceptedIp;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets DocumentName
        /// </summary>
        [DataMember(Name = "document_name", IsRequired = true, EmitDefaultValue = true)]
        public string DocumentName { get; set; }

        /// <summary>
        /// Gets or Sets Accepted
        /// </summary>
        [DataMember(Name = "accepted", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Accepted { get; set; }

        /// <summary>
        /// Gets or Sets AcceptedIp
        /// </summary>
        [DataMember(Name = "accepted_ip", IsRequired = true, EmitDefaultValue = true)]
        public string AcceptedIp { get; set; }

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
            sb.Append("class TermsOfService {\n");
            sb.Append("  DocumentName: ").Append(DocumentName).Append("\n");
            sb.Append("  Accepted: ").Append(Accepted).Append("\n");
            sb.Append("  AcceptedIp: ").Append(AcceptedIp).Append("\n");
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
            return this.Equals(input as TermsOfService);
        }

        /// <summary>
        /// Returns true if TermsOfService instances are equal
        /// </summary>
        /// <param name="input">Instance of TermsOfService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TermsOfService input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DocumentName == input.DocumentName ||
                    (this.DocumentName != null &&
                    this.DocumentName.Equals(input.DocumentName))
                ) && 
                (
                    this.Accepted == input.Accepted ||
                    (this.Accepted != null &&
                    this.Accepted.Equals(input.Accepted))
                ) && 
                (
                    this.AcceptedIp == input.AcceptedIp ||
                    (this.AcceptedIp != null &&
                    this.AcceptedIp.Equals(input.AcceptedIp))
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
                if (this.DocumentName != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentName.GetHashCode();
                }
                if (this.Accepted != null)
                {
                    hashCode = (hashCode * 59) + this.Accepted.GetHashCode();
                }
                if (this.AcceptedIp != null)
                {
                    hashCode = (hashCode * 59) + this.AcceptedIp.GetHashCode();
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
