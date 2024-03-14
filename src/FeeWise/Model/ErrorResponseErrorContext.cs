/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.112
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
    /// Optional fields, may be populated with additional context of the error.
    /// </summary>
    [DataContract(Name = "ErrorResponse_error_context")]
    public partial class ErrorResponseErrorContext : IEquatable<ErrorResponseErrorContext>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponseErrorContext" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="declineCode">declineCode.</param>
        public ErrorResponseErrorContext(string code = default(string), string declineCode = default(string))
        {
            this.Code = code;
            this.DeclineCode = declineCode;
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets DeclineCode
        /// </summary>
        [DataMember(Name = "decline_code", EmitDefaultValue = false)]
        public string DeclineCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ErrorResponseErrorContext {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  DeclineCode: ").Append(DeclineCode).Append("\n");
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
            return this.Equals(input as ErrorResponseErrorContext);
        }

        /// <summary>
        /// Returns true if ErrorResponseErrorContext instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorResponseErrorContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorResponseErrorContext input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.DeclineCode == input.DeclineCode ||
                    (this.DeclineCode != null &&
                    this.DeclineCode.Equals(input.DeclineCode))
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.DeclineCode != null)
                {
                    hashCode = (hashCode * 59) + this.DeclineCode.GetHashCode();
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
