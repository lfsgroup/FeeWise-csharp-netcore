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
    /// An artifact (invoice, matter, deposit, etc...), which also contains the payment receipt id
    /// </summary>
    [DataContract(Name = "ArtifactReceipt")]
    public partial class ArtifactReceipt : IEquatable<ArtifactReceipt>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ArtifactType
        /// </summary>
        [DataMember(Name = "artifact_type", IsRequired = true, EmitDefaultValue = true)]
        public ArtifactType ArtifactType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactReceipt" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ArtifactReceipt() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactReceipt" /> class.
        /// </summary>
        /// <param name="receiptId">The receipt ID (required).</param>
        /// <param name="matterExternalId">The external matter ID of the attached matter.</param>
        /// <param name="matterExternalReference">The external matter reference of the attached matter.</param>
        /// <param name="artifactId">The artifact ID (required).</param>
        /// <param name="artifactType">artifactType (required).</param>
        /// <param name="externalId">The external ID (required).</param>
        /// <param name="name">The artifact name (required).</param>
        /// <param name="description">The artifact description.</param>
        /// <param name="amountPaid">The amount paid for the artifact (required).</param>
        /// <param name="account">account (required).</param>
        public ArtifactReceipt(Guid receiptId = default(Guid), string matterExternalId = default(string), string matterExternalReference = default(string), Guid artifactId = default(Guid), ArtifactType artifactType = default(ArtifactType), string externalId = default(string), string name = default(string), string description = default(string), string amountPaid = default(string), ArtifactReceiptAccount account = default(ArtifactReceiptAccount))
        {
            this.ReceiptId = receiptId;
            this.ArtifactId = artifactId;
            this.ArtifactType = artifactType;
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new ArgumentNullException("externalId is a required property for ArtifactReceipt and cannot be null");
            }
            this.ExternalId = externalId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ArtifactReceipt and cannot be null");
            }
            this.Name = name;
            // to ensure "amountPaid" is required (not null)
            if (amountPaid == null)
            {
                throw new ArgumentNullException("amountPaid is a required property for ArtifactReceipt and cannot be null");
            }
            this.AmountPaid = amountPaid;
            // to ensure "account" is required (not null)
            if (account == null)
            {
                throw new ArgumentNullException("account is a required property for ArtifactReceipt and cannot be null");
            }
            this.Account = account;
            this.MatterExternalId = matterExternalId;
            this.MatterExternalReference = matterExternalReference;
            this.Description = description;
        }

        /// <summary>
        /// The receipt ID
        /// </summary>
        /// <value>The receipt ID</value>
        [DataMember(Name = "receipt_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid ReceiptId { get; set; }

        /// <summary>
        /// The external matter ID of the attached matter
        /// </summary>
        /// <value>The external matter ID of the attached matter</value>
        [DataMember(Name = "matter_external_id", EmitDefaultValue = false)]
        public string MatterExternalId { get; set; }

        /// <summary>
        /// The external matter reference of the attached matter
        /// </summary>
        /// <value>The external matter reference of the attached matter</value>
        [DataMember(Name = "matter_external_reference", EmitDefaultValue = false)]
        public string MatterExternalReference { get; set; }

        /// <summary>
        /// The artifact ID
        /// </summary>
        /// <value>The artifact ID</value>
        [DataMember(Name = "artifact_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid ArtifactId { get; set; }

        /// <summary>
        /// The external ID
        /// </summary>
        /// <value>The external ID</value>
        [DataMember(Name = "external_id", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The artifact name
        /// </summary>
        /// <value>The artifact name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The artifact description
        /// </summary>
        /// <value>The artifact description</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The amount paid for the artifact
        /// </summary>
        /// <value>The amount paid for the artifact</value>
        [DataMember(Name = "amount_paid", IsRequired = true, EmitDefaultValue = true)]
        public string AmountPaid { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", IsRequired = true, EmitDefaultValue = true)]
        public ArtifactReceiptAccount Account { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ArtifactReceipt {\n");
            sb.Append("  ReceiptId: ").Append(ReceiptId).Append("\n");
            sb.Append("  MatterExternalId: ").Append(MatterExternalId).Append("\n");
            sb.Append("  MatterExternalReference: ").Append(MatterExternalReference).Append("\n");
            sb.Append("  ArtifactId: ").Append(ArtifactId).Append("\n");
            sb.Append("  ArtifactType: ").Append(ArtifactType).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AmountPaid: ").Append(AmountPaid).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
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
            return this.Equals(input as ArtifactReceipt);
        }

        /// <summary>
        /// Returns true if ArtifactReceipt instances are equal
        /// </summary>
        /// <param name="input">Instance of ArtifactReceipt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArtifactReceipt input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ReceiptId == input.ReceiptId ||
                    (this.ReceiptId != null &&
                    this.ReceiptId.Equals(input.ReceiptId))
                ) && 
                (
                    this.MatterExternalId == input.MatterExternalId ||
                    (this.MatterExternalId != null &&
                    this.MatterExternalId.Equals(input.MatterExternalId))
                ) && 
                (
                    this.MatterExternalReference == input.MatterExternalReference ||
                    (this.MatterExternalReference != null &&
                    this.MatterExternalReference.Equals(input.MatterExternalReference))
                ) && 
                (
                    this.ArtifactId == input.ArtifactId ||
                    (this.ArtifactId != null &&
                    this.ArtifactId.Equals(input.ArtifactId))
                ) && 
                (
                    this.ArtifactType == input.ArtifactType ||
                    this.ArtifactType.Equals(input.ArtifactType)
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.AmountPaid == input.AmountPaid ||
                    (this.AmountPaid != null &&
                    this.AmountPaid.Equals(input.AmountPaid))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
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
                if (this.ReceiptId != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiptId.GetHashCode();
                }
                if (this.MatterExternalId != null)
                {
                    hashCode = (hashCode * 59) + this.MatterExternalId.GetHashCode();
                }
                if (this.MatterExternalReference != null)
                {
                    hashCode = (hashCode * 59) + this.MatterExternalReference.GetHashCode();
                }
                if (this.ArtifactId != null)
                {
                    hashCode = (hashCode * 59) + this.ArtifactId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ArtifactType.GetHashCode();
                if (this.ExternalId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.AmountPaid != null)
                {
                    hashCode = (hashCode * 59) + this.AmountPaid.GetHashCode();
                }
                if (this.Account != null)
                {
                    hashCode = (hashCode * 59) + this.Account.GetHashCode();
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
