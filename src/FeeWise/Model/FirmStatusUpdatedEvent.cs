/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.116
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
    /// FirmStatusUpdatedEvent
    /// </summary>
    [DataContract(Name = "FirmStatusUpdatedEvent")]
    public partial class FirmStatusUpdatedEvent : IEquatable<FirmStatusUpdatedEvent>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public FirmOnboardingStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmStatusUpdatedEvent" /> class.
        /// </summary>
        /// <param name="firmId">FeeWise&#39; unique ID for the firm.</param>
        /// <param name="externalId">Unique ID for the firm, set by partners.</param>
        /// <param name="legalName">legalName.</param>
        /// <param name="tradingName">tradingName.</param>
        /// <param name="status">status.</param>
        /// <param name="metadata">Set of key value pairs attached to the firm object when it was created..</param>
        public FirmStatusUpdatedEvent(Guid firmId = default(Guid), string externalId = default(string), string legalName = default(string), string tradingName = default(string), FirmOnboardingStatus? status = default(FirmOnboardingStatus?), Dictionary<string, string> metadata = default(Dictionary<string, string>))
        {
            this.FirmId = firmId;
            this.ExternalId = externalId;
            this.LegalName = legalName;
            this.TradingName = tradingName;
            this.Status = status;
            this.Metadata = metadata;
        }

        /// <summary>
        /// FeeWise&#39; unique ID for the firm
        /// </summary>
        /// <value>FeeWise&#39; unique ID for the firm</value>
        [DataMember(Name = "firm_id", EmitDefaultValue = false)]
        public Guid FirmId { get; set; }

        /// <summary>
        /// Unique ID for the firm, set by partners
        /// </summary>
        /// <value>Unique ID for the firm, set by partners</value>
        [DataMember(Name = "external_id", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets LegalName
        /// </summary>
        [DataMember(Name = "legal_name", EmitDefaultValue = false)]
        public string LegalName { get; set; }

        /// <summary>
        /// Gets or Sets TradingName
        /// </summary>
        [DataMember(Name = "trading_name", EmitDefaultValue = false)]
        public string TradingName { get; set; }

        /// <summary>
        /// Set of key value pairs attached to the firm object when it was created.
        /// </summary>
        /// <value>Set of key value pairs attached to the firm object when it was created.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FirmStatusUpdatedEvent {\n");
            sb.Append("  FirmId: ").Append(FirmId).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  LegalName: ").Append(LegalName).Append("\n");
            sb.Append("  TradingName: ").Append(TradingName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as FirmStatusUpdatedEvent);
        }

        /// <summary>
        /// Returns true if FirmStatusUpdatedEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of FirmStatusUpdatedEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FirmStatusUpdatedEvent input)
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
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.LegalName == input.LegalName ||
                    (this.LegalName != null &&
                    this.LegalName.Equals(input.LegalName))
                ) && 
                (
                    this.TradingName == input.TradingName ||
                    (this.TradingName != null &&
                    this.TradingName.Equals(input.TradingName))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
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
                if (this.FirmId != null)
                {
                    hashCode = (hashCode * 59) + this.FirmId.GetHashCode();
                }
                if (this.ExternalId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalId.GetHashCode();
                }
                if (this.LegalName != null)
                {
                    hashCode = (hashCode * 59) + this.LegalName.GetHashCode();
                }
                if (this.TradingName != null)
                {
                    hashCode = (hashCode * 59) + this.TradingName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
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
