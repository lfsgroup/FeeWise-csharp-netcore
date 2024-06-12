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
    /// DebitPayment
    /// </summary>
    [DataContract(Name = "DebitPayment")]
    public partial class DebitPayment : IEquatable<DebitPayment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DebitPayment" /> class.
        /// </summary>
        /// <param name="scheme">Scheme (e.g. us_bank_account, au_bsb_account).</param>
        /// <param name="country">Country code (e.g. US, CA).</param>
        /// <param name="bankName">Name of the bank.</param>
        /// <param name="accountName">Name of the account holder.</param>
        /// <param name="branchCode">Bank branch code.</param>
        /// <param name="accountPartialNumber">Partial account number.</param>
        public DebitPayment(string scheme = default(string), string country = default(string), string bankName = default(string), string accountName = default(string), string branchCode = default(string), string accountPartialNumber = default(string))
        {
            this.Scheme = scheme;
            this.Country = country;
            this.BankName = bankName;
            this.AccountName = accountName;
            this.BranchCode = branchCode;
            this.AccountPartialNumber = accountPartialNumber;
        }

        /// <summary>
        /// Scheme (e.g. us_bank_account, au_bsb_account)
        /// </summary>
        /// <value>Scheme (e.g. us_bank_account, au_bsb_account)</value>
        [DataMember(Name = "scheme", EmitDefaultValue = false)]
        public string Scheme { get; set; }

        /// <summary>
        /// Country code (e.g. US, CA)
        /// </summary>
        /// <value>Country code (e.g. US, CA)</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Name of the bank
        /// </summary>
        /// <value>Name of the bank</value>
        [DataMember(Name = "bank_name", EmitDefaultValue = false)]
        public string BankName { get; set; }

        /// <summary>
        /// Name of the account holder
        /// </summary>
        /// <value>Name of the account holder</value>
        [DataMember(Name = "account_name", EmitDefaultValue = false)]
        public string AccountName { get; set; }

        /// <summary>
        /// Bank branch code
        /// </summary>
        /// <value>Bank branch code</value>
        [DataMember(Name = "branch_code", EmitDefaultValue = false)]
        public string BranchCode { get; set; }

        /// <summary>
        /// Partial account number
        /// </summary>
        /// <value>Partial account number</value>
        [DataMember(Name = "account_partial_number", EmitDefaultValue = false)]
        public string AccountPartialNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DebitPayment {\n");
            sb.Append("  Scheme: ").Append(Scheme).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  BranchCode: ").Append(BranchCode).Append("\n");
            sb.Append("  AccountPartialNumber: ").Append(AccountPartialNumber).Append("\n");
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
            return this.Equals(input as DebitPayment);
        }

        /// <summary>
        /// Returns true if DebitPayment instances are equal
        /// </summary>
        /// <param name="input">Instance of DebitPayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DebitPayment input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Scheme == input.Scheme ||
                    (this.Scheme != null &&
                    this.Scheme.Equals(input.Scheme))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.BranchCode == input.BranchCode ||
                    (this.BranchCode != null &&
                    this.BranchCode.Equals(input.BranchCode))
                ) && 
                (
                    this.AccountPartialNumber == input.AccountPartialNumber ||
                    (this.AccountPartialNumber != null &&
                    this.AccountPartialNumber.Equals(input.AccountPartialNumber))
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
                if (this.Scheme != null)
                {
                    hashCode = (hashCode * 59) + this.Scheme.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.BankName != null)
                {
                    hashCode = (hashCode * 59) + this.BankName.GetHashCode();
                }
                if (this.AccountName != null)
                {
                    hashCode = (hashCode * 59) + this.AccountName.GetHashCode();
                }
                if (this.BranchCode != null)
                {
                    hashCode = (hashCode * 59) + this.BranchCode.GetHashCode();
                }
                if (this.AccountPartialNumber != null)
                {
                    hashCode = (hashCode * 59) + this.AccountPartialNumber.GetHashCode();
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
