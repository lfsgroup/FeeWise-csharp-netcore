/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.53
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
    /// Details of the settlement account
    /// </summary>
    [DataContract(Name = "ArtifactReceipt_account")]
    public partial class ArtifactReceiptAccount : IEquatable<ArtifactReceiptAccount>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [DataMember(Name = "account_type", IsRequired = true, EmitDefaultValue = true)]
        public AccountType AccountType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactReceiptAccount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ArtifactReceiptAccount()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactReceiptAccount" /> class.
        /// </summary>
        /// <param name="accountType">accountType (required).</param>
        /// <param name="branchCode">branchCode (required).</param>
        /// <param name="accountNumber">accountNumber (required).</param>
        /// <param name="alias">The name of the account for the Firm.</param>
        /// <param name="countryCode">The country the account is in (required).</param>
        public ArtifactReceiptAccount(AccountType accountType = default(AccountType), string branchCode = default(string), string accountNumber = default(string), string alias = default(string), string countryCode = default(string))
        {
            this.AccountType = accountType;
            // to ensure "branchCode" is required (not null)
            if (branchCode == null)
            {
                throw new ArgumentNullException("branchCode is a required property for ArtifactReceiptAccount and cannot be null");
            }
            this.BranchCode = branchCode;
            // to ensure "accountNumber" is required (not null)
            if (accountNumber == null)
            {
                throw new ArgumentNullException("accountNumber is a required property for ArtifactReceiptAccount and cannot be null");
            }
            this.AccountNumber = accountNumber;
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new ArgumentNullException("countryCode is a required property for ArtifactReceiptAccount and cannot be null");
            }
            this.CountryCode = countryCode;
            this.Alias = alias;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets BranchCode
        /// </summary>
        [DataMember(Name = "branch_code", IsRequired = true, EmitDefaultValue = true)]
        public string BranchCode { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name = "account_number", IsRequired = true, EmitDefaultValue = true)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The name of the account for the Firm
        /// </summary>
        /// <value>The name of the account for the Firm</value>
        [DataMember(Name = "alias", EmitDefaultValue = false)]
        public string Alias { get; set; }

        /// <summary>
        /// The country the account is in
        /// </summary>
        /// <value>The country the account is in</value>
        [DataMember(Name = "country_code", IsRequired = true, EmitDefaultValue = true)]
        public string CountryCode { get; set; }

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
            sb.Append("class ArtifactReceiptAccount {\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  BranchCode: ").Append(BranchCode).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
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
            return this.Equals(input as ArtifactReceiptAccount);
        }

        /// <summary>
        /// Returns true if ArtifactReceiptAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of ArtifactReceiptAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArtifactReceiptAccount input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountType == input.AccountType ||
                    this.AccountType.Equals(input.AccountType)
                ) && 
                (
                    this.BranchCode == input.BranchCode ||
                    (this.BranchCode != null &&
                    this.BranchCode.Equals(input.BranchCode))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
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
                hashCode = (hashCode * 59) + this.AccountType.GetHashCode();
                if (this.BranchCode != null)
                {
                    hashCode = (hashCode * 59) + this.BranchCode.GetHashCode();
                }
                if (this.AccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.AccountNumber.GetHashCode();
                }
                if (this.Alias != null)
                {
                    hashCode = (hashCode * 59) + this.Alias.GetHashCode();
                }
                if (this.CountryCode != null)
                {
                    hashCode = (hashCode * 59) + this.CountryCode.GetHashCode();
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
