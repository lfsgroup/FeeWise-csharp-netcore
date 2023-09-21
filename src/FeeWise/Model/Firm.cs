/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.92
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
    /// Firm
    /// </summary>
    [DataContract(Name = "Firm")]
    public partial class Firm : IEquatable<Firm>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Synced for value: Synced
            /// </summary>
            [EnumMember(Value = "Synced")]
            Synced = 1,

            /// <summary>
            /// Enum InProgress for value: InProgress
            /// </summary>
            [EnumMember(Value = "InProgress")]
            InProgress = 2,

            /// <summary>
            /// Enum Denied for value: Denied
            /// </summary>
            [EnumMember(Value = "Denied")]
            Denied = 3

        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Firm" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Firm()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Firm" /> class.
        /// </summary>
        /// <param name="firmId">firmId (required).</param>
        /// <param name="tradingName">tradingName (required).</param>
        /// <param name="status">status (required).</param>
        public Firm(Guid firmId = default(Guid), string tradingName = default(string), StatusEnum status = default(StatusEnum))
        {
            this.FirmId = firmId;
            // to ensure "tradingName" is required (not null)
            if (tradingName == null)
            {
                throw new ArgumentNullException("tradingName is a required property for Firm and cannot be null");
            }
            this.TradingName = tradingName;
            this.Status = status;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets FirmId
        /// </summary>
        [DataMember(Name = "firm_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid FirmId { get; set; }

        /// <summary>
        /// Gets or Sets TradingName
        /// </summary>
        [DataMember(Name = "trading_name", IsRequired = true, EmitDefaultValue = true)]
        public string TradingName { get; set; }

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
            sb.Append("class Firm {\n");
            sb.Append("  FirmId: ").Append(FirmId).Append("\n");
            sb.Append("  TradingName: ").Append(TradingName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as Firm);
        }

        /// <summary>
        /// Returns true if Firm instances are equal
        /// </summary>
        /// <param name="input">Instance of Firm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Firm input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FirmId == input.FirmId ||
                    (this.FirmId != null &&
                    this.FirmId.Equals(input.FirmId))
                ) && 
                (
                    this.TradingName == input.TradingName ||
                    (this.TradingName != null &&
                    this.TradingName.Equals(input.TradingName))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                if (this.FirmId != null)
                {
                    hashCode = (hashCode * 59) + this.FirmId.GetHashCode();
                }
                if (this.TradingName != null)
                {
                    hashCode = (hashCode * 59) + this.TradingName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
