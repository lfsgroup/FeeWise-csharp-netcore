/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.103
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
    /// Company
    /// </summary>
    [DataContract(Name = "Company")]
    public partial class Company : IEquatable<Company>, IValidatableObject
    {
        /// <summary>
        /// Defines LegalStructure
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LegalStructureEnum
        {
            /// <summary>
            /// Enum MultiMemberLLC for value: MultiMemberLLC
            /// </summary>
            [EnumMember(Value = "MultiMemberLLC")]
            MultiMemberLLC = 1,

            /// <summary>
            /// Enum PrivateCorporation for value: PrivateCorporation
            /// </summary>
            [EnumMember(Value = "PrivateCorporation")]
            PrivateCorporation = 2,

            /// <summary>
            /// Enum PrivatePartnership for value: PrivatePartnership
            /// </summary>
            [EnumMember(Value = "PrivatePartnership")]
            PrivatePartnership = 3,

            /// <summary>
            /// Enum PublicCorporation for value: PublicCorporation
            /// </summary>
            [EnumMember(Value = "PublicCorporation")]
            PublicCorporation = 4,

            /// <summary>
            /// Enum PublicPartnership for value: PublicPartnership
            /// </summary>
            [EnumMember(Value = "PublicPartnership")]
            PublicPartnership = 5,

            /// <summary>
            /// Enum SingleMemberLLC for value: SingleMemberLLC
            /// </summary>
            [EnumMember(Value = "SingleMemberLLC")]
            SingleMemberLLC = 6,

            /// <summary>
            /// Enum SoleProprietorship for value: SoleProprietorship
            /// </summary>
            [EnumMember(Value = "SoleProprietorship")]
            SoleProprietorship = 7,

            /// <summary>
            /// Enum UnincorporatedAssociation for value: UnincorporatedAssociation
            /// </summary>
            [EnumMember(Value = "UnincorporatedAssociation")]
            UnincorporatedAssociation = 8,

            /// <summary>
            /// Enum Individual for value: Individual
            /// </summary>
            [EnumMember(Value = "Individual")]
            Individual = 9

        }


        /// <summary>
        /// Gets or Sets LegalStructure
        /// </summary>
        [DataMember(Name = "legal_structure", IsRequired = true, EmitDefaultValue = true)]
        public LegalStructureEnum LegalStructure { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public FirmOnboardingStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Company" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Company()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Company" /> class.
        /// </summary>
        /// <param name="firmId">Create the company details for a firm. NB the field &#x60;firm_id&#x60;, must NOT be supplied during &#x60;create&#x60;. If supplied, BadResponse will be returned. The firm_id is used by FeeWise to refer to a firm. It is populated once the firm has been created and will be available in the response. (or any GET Firm requests) See external_id .</param>
        /// <param name="externalId">Allows callers to use their own system id, for the firm. external_id will always be returned in any responses, where a FeeWise Firm is returned..</param>
        /// <param name="legalName">legalName (required).</param>
        /// <param name="legalIdentifier">legalIdentifier.</param>
        /// <param name="legalStructure">legalStructure (required).</param>
        /// <param name="taxId">taxId (required).</param>
        /// <param name="tradingName">tradingName (required).</param>
        /// <param name="website">website (required).</param>
        /// <param name="supportEmail">supportEmail.</param>
        /// <param name="supportNumber">supportNumber.</param>
        /// <param name="contactEmail">contactEmail (required).</param>
        /// <param name="contactNumber">contactNumber (required).</param>
        /// <param name="billingEmail">billingEmail (required).</param>
        /// <param name="billingNumber">billingNumber.</param>
        /// <param name="status">status.</param>
        public Company(Guid firmId = default(Guid), string externalId = default(string), string legalName = default(string), string legalIdentifier = default(string), LegalStructureEnum legalStructure = default(LegalStructureEnum), string taxId = default(string), string tradingName = default(string), string website = default(string), CompanySupportEmail supportEmail = default(CompanySupportEmail), string supportNumber = default(string), string contactEmail = default(string), string contactNumber = default(string), string billingEmail = default(string), string billingNumber = default(string), FirmOnboardingStatus? status = default(FirmOnboardingStatus?))
        {
            // to ensure "legalName" is required (not null)
            if (legalName == null)
            {
                throw new ArgumentNullException("legalName is a required property for Company and cannot be null");
            }
            this.LegalName = legalName;
            this.LegalStructure = legalStructure;
            // to ensure "taxId" is required (not null)
            if (taxId == null)
            {
                throw new ArgumentNullException("taxId is a required property for Company and cannot be null");
            }
            this.TaxId = taxId;
            // to ensure "tradingName" is required (not null)
            if (tradingName == null)
            {
                throw new ArgumentNullException("tradingName is a required property for Company and cannot be null");
            }
            this.TradingName = tradingName;
            // to ensure "website" is required (not null)
            if (website == null)
            {
                throw new ArgumentNullException("website is a required property for Company and cannot be null");
            }
            this.Website = website;
            // to ensure "contactEmail" is required (not null)
            if (contactEmail == null)
            {
                throw new ArgumentNullException("contactEmail is a required property for Company and cannot be null");
            }
            this.ContactEmail = contactEmail;
            // to ensure "contactNumber" is required (not null)
            if (contactNumber == null)
            {
                throw new ArgumentNullException("contactNumber is a required property for Company and cannot be null");
            }
            this.ContactNumber = contactNumber;
            // to ensure "billingEmail" is required (not null)
            if (billingEmail == null)
            {
                throw new ArgumentNullException("billingEmail is a required property for Company and cannot be null");
            }
            this.BillingEmail = billingEmail;
            this.FirmId = firmId;
            this.ExternalId = externalId;
            this.LegalIdentifier = legalIdentifier;
            this.SupportEmail = supportEmail;
            this.SupportNumber = supportNumber;
            this.BillingNumber = billingNumber;
            this.Status = status;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Create the company details for a firm. NB the field &#x60;firm_id&#x60;, must NOT be supplied during &#x60;create&#x60;. If supplied, BadResponse will be returned. The firm_id is used by FeeWise to refer to a firm. It is populated once the firm has been created and will be available in the response. (or any GET Firm requests) See external_id 
        /// </summary>
        /// <value>Create the company details for a firm. NB the field &#x60;firm_id&#x60;, must NOT be supplied during &#x60;create&#x60;. If supplied, BadResponse will be returned. The firm_id is used by FeeWise to refer to a firm. It is populated once the firm has been created and will be available in the response. (or any GET Firm requests) See external_id </value>
        [DataMember(Name = "firm_id", EmitDefaultValue = false)]
        public Guid FirmId { get; set; }

        /// <summary>
        /// Allows callers to use their own system id, for the firm. external_id will always be returned in any responses, where a FeeWise Firm is returned.
        /// </summary>
        /// <value>Allows callers to use their own system id, for the firm. external_id will always be returned in any responses, where a FeeWise Firm is returned.</value>
        [DataMember(Name = "external_id", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets LegalName
        /// </summary>
        [DataMember(Name = "legal_name", IsRequired = true, EmitDefaultValue = true)]
        public string LegalName { get; set; }

        /// <summary>
        /// Gets or Sets LegalIdentifier
        /// </summary>
        [DataMember(Name = "legal_identifier", EmitDefaultValue = false)]
        public string LegalIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets TaxId
        /// </summary>
        [DataMember(Name = "tax_id", IsRequired = true, EmitDefaultValue = true)]
        public string TaxId { get; set; }

        /// <summary>
        /// Gets or Sets TradingName
        /// </summary>
        [DataMember(Name = "trading_name", IsRequired = true, EmitDefaultValue = true)]
        public string TradingName { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name = "website", IsRequired = true, EmitDefaultValue = true)]
        public string Website { get; set; }

        /// <summary>
        /// Gets or Sets SupportEmail
        /// </summary>
        [DataMember(Name = "support_email", EmitDefaultValue = false)]
        public CompanySupportEmail SupportEmail { get; set; }

        /// <summary>
        /// Gets or Sets SupportNumber
        /// </summary>
        [DataMember(Name = "support_number", EmitDefaultValue = false)]
        public string SupportNumber { get; set; }

        /// <summary>
        /// Gets or Sets ContactEmail
        /// </summary>
        [DataMember(Name = "contact_email", IsRequired = true, EmitDefaultValue = true)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// Gets or Sets ContactNumber
        /// </summary>
        [DataMember(Name = "contact_number", IsRequired = true, EmitDefaultValue = true)]
        public string ContactNumber { get; set; }

        /// <summary>
        /// Gets or Sets BillingEmail
        /// </summary>
        [DataMember(Name = "billing_email", IsRequired = true, EmitDefaultValue = true)]
        public string BillingEmail { get; set; }

        /// <summary>
        /// Gets or Sets BillingNumber
        /// </summary>
        [DataMember(Name = "billing_number", EmitDefaultValue = false)]
        public string BillingNumber { get; set; }

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
            sb.Append("class Company {\n");
            sb.Append("  FirmId: ").Append(FirmId).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  LegalName: ").Append(LegalName).Append("\n");
            sb.Append("  LegalIdentifier: ").Append(LegalIdentifier).Append("\n");
            sb.Append("  LegalStructure: ").Append(LegalStructure).Append("\n");
            sb.Append("  TaxId: ").Append(TaxId).Append("\n");
            sb.Append("  TradingName: ").Append(TradingName).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  SupportEmail: ").Append(SupportEmail).Append("\n");
            sb.Append("  SupportNumber: ").Append(SupportNumber).Append("\n");
            sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
            sb.Append("  ContactNumber: ").Append(ContactNumber).Append("\n");
            sb.Append("  BillingEmail: ").Append(BillingEmail).Append("\n");
            sb.Append("  BillingNumber: ").Append(BillingNumber).Append("\n");
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
            return this.Equals(input as Company);
        }

        /// <summary>
        /// Returns true if Company instances are equal
        /// </summary>
        /// <param name="input">Instance of Company to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Company input)
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
                    this.LegalIdentifier == input.LegalIdentifier ||
                    (this.LegalIdentifier != null &&
                    this.LegalIdentifier.Equals(input.LegalIdentifier))
                ) && 
                (
                    this.LegalStructure == input.LegalStructure ||
                    this.LegalStructure.Equals(input.LegalStructure)
                ) && 
                (
                    this.TaxId == input.TaxId ||
                    (this.TaxId != null &&
                    this.TaxId.Equals(input.TaxId))
                ) && 
                (
                    this.TradingName == input.TradingName ||
                    (this.TradingName != null &&
                    this.TradingName.Equals(input.TradingName))
                ) && 
                (
                    this.Website == input.Website ||
                    (this.Website != null &&
                    this.Website.Equals(input.Website))
                ) && 
                (
                    this.SupportEmail == input.SupportEmail ||
                    (this.SupportEmail != null &&
                    this.SupportEmail.Equals(input.SupportEmail))
                ) && 
                (
                    this.SupportNumber == input.SupportNumber ||
                    (this.SupportNumber != null &&
                    this.SupportNumber.Equals(input.SupportNumber))
                ) && 
                (
                    this.ContactEmail == input.ContactEmail ||
                    (this.ContactEmail != null &&
                    this.ContactEmail.Equals(input.ContactEmail))
                ) && 
                (
                    this.ContactNumber == input.ContactNumber ||
                    (this.ContactNumber != null &&
                    this.ContactNumber.Equals(input.ContactNumber))
                ) && 
                (
                    this.BillingEmail == input.BillingEmail ||
                    (this.BillingEmail != null &&
                    this.BillingEmail.Equals(input.BillingEmail))
                ) && 
                (
                    this.BillingNumber == input.BillingNumber ||
                    (this.BillingNumber != null &&
                    this.BillingNumber.Equals(input.BillingNumber))
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
                if (this.ExternalId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalId.GetHashCode();
                }
                if (this.LegalName != null)
                {
                    hashCode = (hashCode * 59) + this.LegalName.GetHashCode();
                }
                if (this.LegalIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.LegalIdentifier.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LegalStructure.GetHashCode();
                if (this.TaxId != null)
                {
                    hashCode = (hashCode * 59) + this.TaxId.GetHashCode();
                }
                if (this.TradingName != null)
                {
                    hashCode = (hashCode * 59) + this.TradingName.GetHashCode();
                }
                if (this.Website != null)
                {
                    hashCode = (hashCode * 59) + this.Website.GetHashCode();
                }
                if (this.SupportEmail != null)
                {
                    hashCode = (hashCode * 59) + this.SupportEmail.GetHashCode();
                }
                if (this.SupportNumber != null)
                {
                    hashCode = (hashCode * 59) + this.SupportNumber.GetHashCode();
                }
                if (this.ContactEmail != null)
                {
                    hashCode = (hashCode * 59) + this.ContactEmail.GetHashCode();
                }
                if (this.ContactNumber != null)
                {
                    hashCode = (hashCode * 59) + this.ContactNumber.GetHashCode();
                }
                if (this.BillingEmail != null)
                {
                    hashCode = (hashCode * 59) + this.BillingEmail.GetHashCode();
                }
                if (this.BillingNumber != null)
                {
                    hashCode = (hashCode * 59) + this.BillingNumber.GetHashCode();
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
