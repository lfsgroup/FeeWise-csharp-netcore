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
    /// FirmResponse
    /// </summary>
    [DataContract(Name = "FirmResponse")]
    public partial class FirmResponse : IEquatable<FirmResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FirmResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmResponse" /> class.
        /// </summary>
        /// <param name="firm">firm (required).</param>
        public FirmResponse(Firm firm = default(Firm))
        {
            // to ensure "firm" is required (not null)
            if (firm == null)
            {
                throw new ArgumentNullException("firm is a required property for FirmResponse and cannot be null");
            }
            this.Firm = firm;
        }

        /// <summary>
        /// Gets or Sets Firm
        /// </summary>
        [DataMember(Name = "firm", IsRequired = true, EmitDefaultValue = true)]
        public Firm Firm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FirmResponse {\n");
            sb.Append("  Firm: ").Append(Firm).Append("\n");
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
            return this.Equals(input as FirmResponse);
        }

        /// <summary>
        /// Returns true if FirmResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FirmResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FirmResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Firm == input.Firm ||
                    (this.Firm != null &&
                    this.Firm.Equals(input.Firm))
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
                if (this.Firm != null)
                {
                    hashCode = (hashCode * 59) + this.Firm.GetHashCode();
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
