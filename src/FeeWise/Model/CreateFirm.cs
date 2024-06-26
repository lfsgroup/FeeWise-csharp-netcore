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
    /// CreateFirm
    /// </summary>
    [DataContract(Name = "CreateFirm")]
    public partial class CreateFirm : IEquatable<CreateFirm>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFirm" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateFirm() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFirm" /> class.
        /// </summary>
        /// <param name="company">company (required).</param>
        /// <param name="address">address (required).</param>
        /// <param name="officeAccount">officeAccount (required).</param>
        /// <param name="trustAccount">trustAccount.</param>
        /// <param name="roles">Roles can be either Representative, Executives or Owners..</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="termsOfService">termsOfService (required).</param>
        public CreateFirm(Company company = default(Company), Address address = default(Address), BankAccount officeAccount = default(BankAccount), BankAccount trustAccount = default(BankAccount), List<Person> roles = default(List<Person>), Dictionary<string, string> metadata = default(Dictionary<string, string>), TermsOfService termsOfService = default(TermsOfService))
        {
            // to ensure "company" is required (not null)
            if (company == null)
            {
                throw new ArgumentNullException("company is a required property for CreateFirm and cannot be null");
            }
            this.Company = company;
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for CreateFirm and cannot be null");
            }
            this.Address = address;
            // to ensure "officeAccount" is required (not null)
            if (officeAccount == null)
            {
                throw new ArgumentNullException("officeAccount is a required property for CreateFirm and cannot be null");
            }
            this.OfficeAccount = officeAccount;
            // to ensure "termsOfService" is required (not null)
            if (termsOfService == null)
            {
                throw new ArgumentNullException("termsOfService is a required property for CreateFirm and cannot be null");
            }
            this.TermsOfService = termsOfService;
            this.TrustAccount = trustAccount;
            this.Roles = roles;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name = "company", IsRequired = true, EmitDefaultValue = true)]
        public Company Company { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public Address Address { get; set; }

        /// <summary>
        /// Gets or Sets OfficeAccount
        /// </summary>
        [DataMember(Name = "office_account", IsRequired = true, EmitDefaultValue = true)]
        public BankAccount OfficeAccount { get; set; }

        /// <summary>
        /// Gets or Sets TrustAccount
        /// </summary>
        [DataMember(Name = "trust_account", EmitDefaultValue = false)]
        public BankAccount TrustAccount { get; set; }

        /// <summary>
        /// Roles can be either Representative, Executives or Owners.
        /// </summary>
        /// <value>Roles can be either Representative, Executives or Owners.</value>
        [DataMember(Name = "roles", EmitDefaultValue = false)]
        public List<Person> Roles { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets TermsOfService
        /// </summary>
        [DataMember(Name = "terms_of_service", IsRequired = true, EmitDefaultValue = true)]
        public TermsOfService TermsOfService { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateFirm {\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  OfficeAccount: ").Append(OfficeAccount).Append("\n");
            sb.Append("  TrustAccount: ").Append(TrustAccount).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  TermsOfService: ").Append(TermsOfService).Append("\n");
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
            return this.Equals(input as CreateFirm);
        }

        /// <summary>
        /// Returns true if CreateFirm instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateFirm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFirm input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.OfficeAccount == input.OfficeAccount ||
                    (this.OfficeAccount != null &&
                    this.OfficeAccount.Equals(input.OfficeAccount))
                ) && 
                (
                    this.TrustAccount == input.TrustAccount ||
                    (this.TrustAccount != null &&
                    this.TrustAccount.Equals(input.TrustAccount))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.TermsOfService == input.TermsOfService ||
                    (this.TermsOfService != null &&
                    this.TermsOfService.Equals(input.TermsOfService))
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
                if (this.Company != null)
                {
                    hashCode = (hashCode * 59) + this.Company.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.OfficeAccount != null)
                {
                    hashCode = (hashCode * 59) + this.OfficeAccount.GetHashCode();
                }
                if (this.TrustAccount != null)
                {
                    hashCode = (hashCode * 59) + this.TrustAccount.GetHashCode();
                }
                if (this.Roles != null)
                {
                    hashCode = (hashCode * 59) + this.Roles.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.TermsOfService != null)
                {
                    hashCode = (hashCode * 59) + this.TermsOfService.GetHashCode();
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
