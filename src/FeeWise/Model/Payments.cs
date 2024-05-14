/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.118
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
    /// Payments
    /// </summary>
    [DataContract(Name = "Payments")]
    public partial class Payments : IEquatable<Payments>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Payments" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Payments() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Payments" /> class.
        /// </summary>
        /// <param name="payments">payments (required).</param>
        public Payments(List<Payment> payments = default(List<Payment>))
        {
            // to ensure "payments" is required (not null)
            if (payments == null)
            {
                throw new ArgumentNullException("payments is a required property for Payments and cannot be null");
            }
            this._Payments = payments;
        }

        /// <summary>
        /// Gets or Sets _Payments
        /// </summary>
        [DataMember(Name = "payments", IsRequired = true, EmitDefaultValue = true)]
        public List<Payment> _Payments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Payments {\n");
            sb.Append("  _Payments: ").Append(_Payments).Append("\n");
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
            return this.Equals(input as Payments);
        }

        /// <summary>
        /// Returns true if Payments instances are equal
        /// </summary>
        /// <param name="input">Instance of Payments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Payments input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._Payments == input._Payments ||
                    this._Payments != null &&
                    input._Payments != null &&
                    this._Payments.SequenceEqual(input._Payments)
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
                if (this._Payments != null)
                {
                    hashCode = (hashCode * 59) + this._Payments.GetHashCode();
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
