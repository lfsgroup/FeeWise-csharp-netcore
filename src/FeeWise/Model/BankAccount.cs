/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.93
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
    /// BankAccount
    /// </summary>
    [DataContract(Name = "BankAccount")]
    public partial class BankAccount : IEquatable<BankAccount>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [DataMember(Name = "account_type", IsRequired = true, EmitDefaultValue = true)]
        public AccountType AccountType { get; set; }
        /// <summary>
        /// Defines AccountHolderType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountHolderTypeEnum
        {
            /// <summary>
            /// Enum Company for value: Company
            /// </summary>
            [EnumMember(Value = "Company")]
            Company = 1,

            /// <summary>
            /// Enum Individual for value: Individual
            /// </summary>
            [EnumMember(Value = "Individual")]
            Individual = 2

        }


        /// <summary>
        /// Gets or Sets AccountHolderType
        /// </summary>
        [DataMember(Name = "account_holder_type", EmitDefaultValue = false)]
        public AccountHolderTypeEnum? AccountHolderType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BankAccount()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount" /> class.
        /// </summary>
        /// <param name="accountId">accountId.</param>
        /// <param name="accountType">accountType (required).</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="accountHolderType">accountHolderType.</param>
        /// <param name="accountNumber">accountNumber (required).</param>
        /// <param name="branchCode">branchCode (required).</param>
        /// <param name="alias">alias.</param>
        /// <param name="bank">bank.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="isDefault">isDefault.</param>
        public BankAccount(Guid accountId = default(Guid), AccountType accountType = default(AccountType), string accountName = default(string), AccountHolderTypeEnum? accountHolderType = default(AccountHolderTypeEnum?), string accountNumber = default(string), string branchCode = default(string), string alias = default(string), string bank = default(string), string countryCode = default(string), bool isDefault = default(bool))
        {
            this.AccountType = accountType;
            // to ensure "accountNumber" is required (not null)
            if (accountNumber == null)
            {
                throw new ArgumentNullException("accountNumber is a required property for BankAccount and cannot be null");
            }
            this.AccountNumber = accountNumber;
            // to ensure "branchCode" is required (not null)
            if (branchCode == null)
            {
                throw new ArgumentNullException("branchCode is a required property for BankAccount and cannot be null");
            }
            this.BranchCode = branchCode;
            this.AccountId = accountId;
            this.AccountName = accountName;
            this.AccountHolderType = accountHolderType;
            this.Alias = alias;
            this.Bank = bank;
            this.CountryCode = countryCode;
            this.IsDefault = isDefault;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public Guid AccountId { get; set; }

        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name = "account_name", EmitDefaultValue = false)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name = "account_number", IsRequired = true, EmitDefaultValue = true)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets BranchCode
        /// </summary>
        [DataMember(Name = "branch_code", IsRequired = true, EmitDefaultValue = true)]
        public string BranchCode { get; set; }

        /// <summary>
        /// Gets or Sets Alias
        /// </summary>
        [DataMember(Name = "alias", EmitDefaultValue = false)]
        public string Alias { get; set; }

        /// <summary>
        /// Gets or Sets Bank
        /// </summary>
        [DataMember(Name = "bank", EmitDefaultValue = false)]
        public string Bank { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name = "country_code", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name = "is_default", EmitDefaultValue = true)]
        public bool IsDefault { get; set; }

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
            sb.Append("class BankAccount {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  AccountHolderType: ").Append(AccountHolderType).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  BranchCode: ").Append(BranchCode).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Bank: ").Append(Bank).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
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
            return this.Equals(input as BankAccount);
        }

        /// <summary>
        /// Returns true if BankAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of BankAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankAccount input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    this.AccountType.Equals(input.AccountType)
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.AccountHolderType == input.AccountHolderType ||
                    this.AccountHolderType.Equals(input.AccountHolderType)
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.BranchCode == input.BranchCode ||
                    (this.BranchCode != null &&
                    this.BranchCode.Equals(input.BranchCode))
                ) && 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.Bank == input.Bank ||
                    (this.Bank != null &&
                    this.Bank.Equals(input.Bank))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.IsDefault == input.IsDefault ||
                    this.IsDefault.Equals(input.IsDefault)
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AccountType.GetHashCode();
                if (this.AccountName != null)
                {
                    hashCode = (hashCode * 59) + this.AccountName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AccountHolderType.GetHashCode();
                if (this.AccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.AccountNumber.GetHashCode();
                }
                if (this.BranchCode != null)
                {
                    hashCode = (hashCode * 59) + this.BranchCode.GetHashCode();
                }
                if (this.Alias != null)
                {
                    hashCode = (hashCode * 59) + this.Alias.GetHashCode();
                }
                if (this.Bank != null)
                {
                    hashCode = (hashCode * 59) + this.Bank.GetHashCode();
                }
                if (this.CountryCode != null)
                {
                    hashCode = (hashCode * 59) + this.CountryCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDefault.GetHashCode();
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
