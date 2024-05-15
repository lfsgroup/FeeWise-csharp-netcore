/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.119
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
    /// FirmsResponse
    /// </summary>
    [DataContract(Name = "FirmsResponse")]
    public partial class FirmsResponse : IEquatable<FirmsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FirmsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmsResponse" /> class.
        /// </summary>
        /// <param name="firms">firms (required).</param>
        public FirmsResponse(List<FirmDetails> firms = default(List<FirmDetails>))
        {
            // to ensure "firms" is required (not null)
            if (firms == null)
            {
                throw new ArgumentNullException("firms is a required property for FirmsResponse and cannot be null");
            }
            this.Firms = firms;
        }

        /// <summary>
        /// Gets or Sets Firms
        /// </summary>
        [DataMember(Name = "firms", IsRequired = true, EmitDefaultValue = true)]
        public List<FirmDetails> Firms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FirmsResponse {\n");
            sb.Append("  Firms: ").Append(Firms).Append("\n");
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
            return this.Equals(input as FirmsResponse);
        }

        /// <summary>
        /// Returns true if FirmsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FirmsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FirmsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Firms == input.Firms ||
                    this.Firms != null &&
                    input.Firms != null &&
                    this.Firms.SequenceEqual(input.Firms)
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
                if (this.Firms != null)
                {
                    hashCode = (hashCode * 59) + this.Firms.GetHashCode();
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
