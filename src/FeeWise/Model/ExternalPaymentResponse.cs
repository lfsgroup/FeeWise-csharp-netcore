/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.57
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
    /// ExternalPaymentResponse
    /// </summary>
    [DataContract(Name = "ExternalPaymentResponse")]
    public partial class ExternalPaymentResponse : IEquatable<ExternalPaymentResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalPaymentResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExternalPaymentResponse()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalPaymentResponse" /> class.
        /// </summary>
        /// <param name="artifactDetails">artifactDetails (required).</param>
        public ExternalPaymentResponse(Artifact artifactDetails = default(Artifact))
        {
            // to ensure "artifactDetails" is required (not null)
            if (artifactDetails == null)
            {
                throw new ArgumentNullException("artifactDetails is a required property for ExternalPaymentResponse and cannot be null");
            }
            this.ArtifactDetails = artifactDetails;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets ArtifactDetails
        /// </summary>
        [DataMember(Name = "artifact_details", IsRequired = true, EmitDefaultValue = true)]
        public Artifact ArtifactDetails { get; set; }

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
            sb.Append("class ExternalPaymentResponse {\n");
            sb.Append("  ArtifactDetails: ").Append(ArtifactDetails).Append("\n");
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
            return this.Equals(input as ExternalPaymentResponse);
        }

        /// <summary>
        /// Returns true if ExternalPaymentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalPaymentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalPaymentResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ArtifactDetails == input.ArtifactDetails ||
                    (this.ArtifactDetails != null &&
                    this.ArtifactDetails.Equals(input.ArtifactDetails))
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
                if (this.ArtifactDetails != null)
                {
                    hashCode = (hashCode * 59) + this.ArtifactDetails.GetHashCode();
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