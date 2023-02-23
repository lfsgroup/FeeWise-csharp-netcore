/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.48
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
    /// The matter request object contains all matter information, debtor details and artifacts, invoices or trust deposits, to be created for the matter.
    /// </summary>
    [DataContract(Name = "MatterRequest")]
    public partial class MatterRequest : IEquatable<MatterRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatterRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MatterRequest()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatterRequest" /> class.
        /// </summary>
        /// <param name="firmId">The firm the invoice is raised for. (required).</param>
        /// <param name="matter">matter (required).</param>
        /// <param name="debtor">debtor.</param>
        /// <param name="artifacts">artifacts (required).</param>
        public MatterRequest(Guid firmId = default(Guid), Matter matter = default(Matter), Debtor debtor = default(Debtor), List<Artifact> artifacts = default(List<Artifact>))
        {
            this.FirmId = firmId;
            // to ensure "matter" is required (not null)
            if (matter == null)
            {
                throw new ArgumentNullException("matter is a required property for MatterRequest and cannot be null");
            }
            this.Matter = matter;
            // to ensure "artifacts" is required (not null)
            if (artifacts == null)
            {
                throw new ArgumentNullException("artifacts is a required property for MatterRequest and cannot be null");
            }
            this.Artifacts = artifacts;
            this.Debtor = debtor;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The firm the invoice is raised for.
        /// </summary>
        /// <value>The firm the invoice is raised for.</value>
        [DataMember(Name = "firm_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid FirmId { get; set; }

        /// <summary>
        /// Gets or Sets Matter
        /// </summary>
        [DataMember(Name = "matter", IsRequired = true, EmitDefaultValue = true)]
        public Matter Matter { get; set; }

        /// <summary>
        /// Gets or Sets Debtor
        /// </summary>
        [DataMember(Name = "debtor", EmitDefaultValue = false)]
        public Debtor Debtor { get; set; }

        /// <summary>
        /// Gets or Sets Artifacts
        /// </summary>
        [DataMember(Name = "artifacts", IsRequired = true, EmitDefaultValue = true)]
        public List<Artifact> Artifacts { get; set; }

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
            sb.Append("class MatterRequest {\n");
            sb.Append("  FirmId: ").Append(FirmId).Append("\n");
            sb.Append("  Matter: ").Append(Matter).Append("\n");
            sb.Append("  Debtor: ").Append(Debtor).Append("\n");
            sb.Append("  Artifacts: ").Append(Artifacts).Append("\n");
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
            return this.Equals(input as MatterRequest);
        }

        /// <summary>
        /// Returns true if MatterRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MatterRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatterRequest input)
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
                    this.Matter == input.Matter ||
                    (this.Matter != null &&
                    this.Matter.Equals(input.Matter))
                ) && 
                (
                    this.Debtor == input.Debtor ||
                    (this.Debtor != null &&
                    this.Debtor.Equals(input.Debtor))
                ) && 
                (
                    this.Artifacts == input.Artifacts ||
                    this.Artifacts != null &&
                    input.Artifacts != null &&
                    this.Artifacts.SequenceEqual(input.Artifacts)
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
                if (this.Matter != null)
                {
                    hashCode = (hashCode * 59) + this.Matter.GetHashCode();
                }
                if (this.Debtor != null)
                {
                    hashCode = (hashCode * 59) + this.Debtor.GetHashCode();
                }
                if (this.Artifacts != null)
                {
                    hashCode = (hashCode * 59) + this.Artifacts.GetHashCode();
                }
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