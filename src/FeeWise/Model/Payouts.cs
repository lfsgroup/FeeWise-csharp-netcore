/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.114
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
    /// Payouts
    /// </summary>
    [DataContract(Name = "Payouts")]
    public partial class Payouts : IEquatable<Payouts>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Payouts" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Payouts() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Payouts" /> class.
        /// </summary>
        /// <param name="payouts">payouts (required).</param>
        public Payouts(List<Payout> payouts = default(List<Payout>))
        {
            // to ensure "payouts" is required (not null)
            if (payouts == null)
            {
                throw new ArgumentNullException("payouts is a required property for Payouts and cannot be null");
            }
            this._Payouts = payouts;
        }

        /// <summary>
        /// Gets or Sets _Payouts
        /// </summary>
        [DataMember(Name = "payouts", IsRequired = true, EmitDefaultValue = true)]
        public List<Payout> _Payouts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Payouts {\n");
            sb.Append("  _Payouts: ").Append(_Payouts).Append("\n");
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
            return this.Equals(input as Payouts);
        }

        /// <summary>
        /// Returns true if Payouts instances are equal
        /// </summary>
        /// <param name="input">Instance of Payouts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Payouts input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._Payouts == input._Payouts ||
                    this._Payouts != null &&
                    input._Payouts != null &&
                    this._Payouts.SequenceEqual(input._Payouts)
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
                if (this._Payouts != null)
                {
                    hashCode = (hashCode * 59) + this._Payouts.GetHashCode();
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
