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
    /// ApiKeyRotation
    /// </summary>
    [DataContract(Name = "ApiKeyRotation")]
    public partial class ApiKeyRotation : IEquatable<ApiKeyRotation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyRotation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiKeyRotation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyRotation" /> class.
        /// </summary>
        /// <param name="previousKeyExpiresHours">hours until expiry (0 to expire immediately, defaults to 48 hours) (required) (default to 48).</param>
        public ApiKeyRotation(int previousKeyExpiresHours = 48)
        {
            this.PreviousKeyExpiresHours = previousKeyExpiresHours;
        }

        /// <summary>
        /// hours until expiry (0 to expire immediately, defaults to 48 hours)
        /// </summary>
        /// <value>hours until expiry (0 to expire immediately, defaults to 48 hours)</value>
        [DataMember(Name = "previous_key_expires_hours", IsRequired = true, EmitDefaultValue = true)]
        public int PreviousKeyExpiresHours { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiKeyRotation {\n");
            sb.Append("  PreviousKeyExpiresHours: ").Append(PreviousKeyExpiresHours).Append("\n");
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
            return this.Equals(input as ApiKeyRotation);
        }

        /// <summary>
        /// Returns true if ApiKeyRotation instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiKeyRotation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiKeyRotation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PreviousKeyExpiresHours == input.PreviousKeyExpiresHours ||
                    this.PreviousKeyExpiresHours.Equals(input.PreviousKeyExpiresHours)
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
                hashCode = (hashCode * 59) + this.PreviousKeyExpiresHours.GetHashCode();
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
