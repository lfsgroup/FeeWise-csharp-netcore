/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.113
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
    /// SplitChargesResponse
    /// </summary>
    [DataContract(Name = "SplitChargesResponse")]
    public partial class SplitChargesResponse : IEquatable<SplitChargesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SplitChargesResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SplitChargesResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SplitChargesResponse" /> class.
        /// </summary>
        /// <param name="splitCharge">splitCharge (required).</param>
        public SplitChargesResponse(SplitCharge splitCharge = default(SplitCharge))
        {
            // to ensure "splitCharge" is required (not null)
            if (splitCharge == null)
            {
                throw new ArgumentNullException("splitCharge is a required property for SplitChargesResponse and cannot be null");
            }
            this.SplitCharge = splitCharge;
        }

        /// <summary>
        /// Gets or Sets SplitCharge
        /// </summary>
        [DataMember(Name = "splitCharge", IsRequired = true, EmitDefaultValue = true)]
        public SplitCharge SplitCharge { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SplitChargesResponse {\n");
            sb.Append("  SplitCharge: ").Append(SplitCharge).Append("\n");
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
            return this.Equals(input as SplitChargesResponse);
        }

        /// <summary>
        /// Returns true if SplitChargesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SplitChargesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SplitChargesResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SplitCharge == input.SplitCharge ||
                    (this.SplitCharge != null &&
                    this.SplitCharge.Equals(input.SplitCharge))
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
                if (this.SplitCharge != null)
                {
                    hashCode = (hashCode * 59) + this.SplitCharge.GetHashCode();
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
