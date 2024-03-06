/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.111
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
    /// PayoutsResponse
    /// </summary>
    [DataContract(Name = "PayoutsResponse")]
    public partial class PayoutsResponse : IEquatable<PayoutsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutsResponse" /> class.
        /// </summary>
        /// <param name="payouts">payouts.</param>
        /// <param name="paginationMetadata">paginationMetadata.</param>
        public PayoutsResponse(List<Payout> payouts = default(List<Payout>), PaginationMetadata paginationMetadata = default(PaginationMetadata))
        {
            this.Payouts = payouts;
            this.PaginationMetadata = paginationMetadata;
        }

        /// <summary>
        /// Gets or Sets Payouts
        /// </summary>
        [DataMember(Name = "payouts", EmitDefaultValue = false)]
        public List<Payout> Payouts { get; set; }

        /// <summary>
        /// Gets or Sets PaginationMetadata
        /// </summary>
        [DataMember(Name = "pagination_metadata", EmitDefaultValue = false)]
        public PaginationMetadata PaginationMetadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PayoutsResponse {\n");
            sb.Append("  Payouts: ").Append(Payouts).Append("\n");
            sb.Append("  PaginationMetadata: ").Append(PaginationMetadata).Append("\n");
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
            return this.Equals(input as PayoutsResponse);
        }

        /// <summary>
        /// Returns true if PayoutsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Payouts == input.Payouts ||
                    this.Payouts != null &&
                    input.Payouts != null &&
                    this.Payouts.SequenceEqual(input.Payouts)
                ) && 
                (
                    this.PaginationMetadata == input.PaginationMetadata ||
                    (this.PaginationMetadata != null &&
                    this.PaginationMetadata.Equals(input.PaginationMetadata))
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
                if (this.Payouts != null)
                {
                    hashCode = (hashCode * 59) + this.Payouts.GetHashCode();
                }
                if (this.PaginationMetadata != null)
                {
                    hashCode = (hashCode * 59) + this.PaginationMetadata.GetHashCode();
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
