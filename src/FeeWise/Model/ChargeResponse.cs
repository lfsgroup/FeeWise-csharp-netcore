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
    /// ChargeResponse
    /// </summary>
    [DataContract(Name = "ChargeResponse")]
    public partial class ChargeResponse : IEquatable<ChargeResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChargeResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeResponse" /> class.
        /// </summary>
        /// <param name="charge">charge (required).</param>
        public ChargeResponse(Charge charge = default(Charge))
        {
            // to ensure "charge" is required (not null)
            if (charge == null)
            {
                throw new ArgumentNullException("charge is a required property for ChargeResponse and cannot be null");
            }
            this.Charge = charge;
        }

        /// <summary>
        /// Gets or Sets Charge
        /// </summary>
        [DataMember(Name = "charge", IsRequired = true, EmitDefaultValue = true)]
        public Charge Charge { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChargeResponse {\n");
            sb.Append("  Charge: ").Append(Charge).Append("\n");
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
            return this.Equals(input as ChargeResponse);
        }

        /// <summary>
        /// Returns true if ChargeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Charge == input.Charge ||
                    (this.Charge != null &&
                    this.Charge.Equals(input.Charge))
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
                if (this.Charge != null)
                {
                    hashCode = (hashCode * 59) + this.Charge.GetHashCode();
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
