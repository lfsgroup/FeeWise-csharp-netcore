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
    /// FirmDetails
    /// </summary>
    [DataContract(Name = "FirmDetails")]
    public partial class FirmDetails : IEquatable<FirmDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FirmDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmDetails" /> class.
        /// </summary>
        /// <param name="company">company (required).</param>
        /// <param name="address">address (required).</param>
        /// <param name="accounts">accounts (required).</param>
        /// <param name="roles">Must have one and only one representative.  Representative person is an authorised person who represents the firms. The representative must be either an executive or owner. All owners of the firm with greater that 25% must be specified. .</param>
        /// <param name="termsOfService">termsOfService.</param>
        /// <param name="metadata">Set of key value pairs attached to the firm object when it was created..</param>
        public FirmDetails(Company company = default(Company), Address address = default(Address), List<BankAccount> accounts = default(List<BankAccount>), List<Person> roles = default(List<Person>), TermsOfService termsOfService = default(TermsOfService), Dictionary<string, string> metadata = default(Dictionary<string, string>))
        {
            // to ensure "company" is required (not null)
            if (company == null)
            {
                throw new ArgumentNullException("company is a required property for FirmDetails and cannot be null");
            }
            this.Company = company;
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for FirmDetails and cannot be null");
            }
            this.Address = address;
            // to ensure "accounts" is required (not null)
            if (accounts == null)
            {
                throw new ArgumentNullException("accounts is a required property for FirmDetails and cannot be null");
            }
            this.Accounts = accounts;
            this.Roles = roles;
            this.TermsOfService = termsOfService;
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
        /// Gets or Sets Accounts
        /// </summary>
        [DataMember(Name = "accounts", IsRequired = true, EmitDefaultValue = true)]
        public List<BankAccount> Accounts { get; set; }

        /// <summary>
        /// Must have one and only one representative.  Representative person is an authorised person who represents the firms. The representative must be either an executive or owner. All owners of the firm with greater that 25% must be specified. 
        /// </summary>
        /// <value>Must have one and only one representative.  Representative person is an authorised person who represents the firms. The representative must be either an executive or owner. All owners of the firm with greater that 25% must be specified. </value>
        [DataMember(Name = "roles", EmitDefaultValue = false)]
        public List<Person> Roles { get; set; }

        /// <summary>
        /// Gets or Sets TermsOfService
        /// </summary>
        [DataMember(Name = "terms_of_service", EmitDefaultValue = false)]
        public TermsOfService TermsOfService { get; set; }

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
            sb.Append("class FirmDetails {\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  TermsOfService: ").Append(TermsOfService).Append("\n");
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
            return this.Equals(input as FirmDetails);
        }

        /// <summary>
        /// Returns true if FirmDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of FirmDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FirmDetails input)
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
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.TermsOfService == input.TermsOfService ||
                    (this.TermsOfService != null &&
                    this.TermsOfService.Equals(input.TermsOfService))
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
                if (this.Company != null)
                {
                    hashCode = (hashCode * 59) + this.Company.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.Accounts != null)
                {
                    hashCode = (hashCode * 59) + this.Accounts.GetHashCode();
                }
                if (this.Roles != null)
                {
                    hashCode = (hashCode * 59) + this.Roles.GetHashCode();
                }
                if (this.TermsOfService != null)
                {
                    hashCode = (hashCode * 59) + this.TermsOfService.GetHashCode();
                }
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
