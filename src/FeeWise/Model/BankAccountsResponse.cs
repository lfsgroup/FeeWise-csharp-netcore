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
    /// BankAccountsResponse
    /// </summary>
    [DataContract(Name = "BankAccountsResponse")]
    public partial class BankAccountsResponse : IEquatable<BankAccountsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BankAccountsResponse()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountsResponse" /> class.
        /// </summary>
        /// <param name="officeAccounts">officeAccounts (required).</param>
        /// <param name="trustAccounts">trustAccounts (required).</param>
        public BankAccountsResponse(List<BankAccount> officeAccounts = default(List<BankAccount>), List<BankAccount> trustAccounts = default(List<BankAccount>))
        {
            // to ensure "officeAccounts" is required (not null)
            if (officeAccounts == null)
            {
                throw new ArgumentNullException("officeAccounts is a required property for BankAccountsResponse and cannot be null");
            }
            this.OfficeAccounts = officeAccounts;
            // to ensure "trustAccounts" is required (not null)
            if (trustAccounts == null)
            {
                throw new ArgumentNullException("trustAccounts is a required property for BankAccountsResponse and cannot be null");
            }
            this.TrustAccounts = trustAccounts;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets OfficeAccounts
        /// </summary>
        [DataMember(Name = "office_accounts", IsRequired = true, EmitDefaultValue = true)]
        public List<BankAccount> OfficeAccounts { get; set; }

        /// <summary>
        /// Gets or Sets TrustAccounts
        /// </summary>
        [DataMember(Name = "trust_accounts", IsRequired = true, EmitDefaultValue = true)]
        public List<BankAccount> TrustAccounts { get; set; }

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
            sb.Append("class BankAccountsResponse {\n");
            sb.Append("  OfficeAccounts: ").Append(OfficeAccounts).Append("\n");
            sb.Append("  TrustAccounts: ").Append(TrustAccounts).Append("\n");
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
            return this.Equals(input as BankAccountsResponse);
        }

        /// <summary>
        /// Returns true if BankAccountsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BankAccountsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankAccountsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OfficeAccounts == input.OfficeAccounts ||
                    this.OfficeAccounts != null &&
                    input.OfficeAccounts != null &&
                    this.OfficeAccounts.SequenceEqual(input.OfficeAccounts)
                ) && 
                (
                    this.TrustAccounts == input.TrustAccounts ||
                    this.TrustAccounts != null &&
                    input.TrustAccounts != null &&
                    this.TrustAccounts.SequenceEqual(input.TrustAccounts)
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
                if (this.OfficeAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.OfficeAccounts.GetHashCode();
                }
                if (this.TrustAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.TrustAccounts.GetHashCode();
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
