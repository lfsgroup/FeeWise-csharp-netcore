/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.104
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
    /// Describes a payout made by the system to a channel partner&#39;s firm
    /// </summary>
    [DataContract(Name = "Payout")]
    public partial class Payout : IEquatable<Payout>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public PayoutStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Payout" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Payout()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Payout" /> class.
        /// </summary>
        /// <param name="payoutReference">The unique reference of the payout. This will appear in the bank account statement the payout was made to. (required).</param>
        /// <param name="date">When the payout was made. (required).</param>
        /// <param name="payoutTotal">The total paid out to the firm. This is the sum of the transactions paid_out amounts. (required).</param>
        /// <param name="account">account (required).</param>
        /// <param name="firmId">The id of the firm the payout was made to. (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="transactions">A list of the payments that are included in this payout (required).</param>
        public Payout(string payoutReference = default(string), DateTime date = default(DateTime), string payoutTotal = default(string), PayoutAccount account = default(PayoutAccount), Guid firmId = default(Guid), PayoutStatus status = default(PayoutStatus), List<Payment> transactions = default(List<Payment>))
        {
            // to ensure "payoutReference" is required (not null)
            if (payoutReference == null)
            {
                throw new ArgumentNullException("payoutReference is a required property for Payout and cannot be null");
            }
            this.PayoutReference = payoutReference;
            this.Date = date;
            // to ensure "payoutTotal" is required (not null)
            if (payoutTotal == null)
            {
                throw new ArgumentNullException("payoutTotal is a required property for Payout and cannot be null");
            }
            this.PayoutTotal = payoutTotal;
            // to ensure "account" is required (not null)
            if (account == null)
            {
                throw new ArgumentNullException("account is a required property for Payout and cannot be null");
            }
            this.Account = account;
            this.FirmId = firmId;
            this.Status = status;
            // to ensure "transactions" is required (not null)
            if (transactions == null)
            {
                throw new ArgumentNullException("transactions is a required property for Payout and cannot be null");
            }
            this.Transactions = transactions;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The unique reference of the payout. This will appear in the bank account statement the payout was made to.
        /// </summary>
        /// <value>The unique reference of the payout. This will appear in the bank account statement the payout was made to.</value>
        [DataMember(Name = "payout_reference", IsRequired = true, EmitDefaultValue = true)]
        public string PayoutReference { get; set; }

        /// <summary>
        /// When the payout was made.
        /// </summary>
        /// <value>When the payout was made.</value>
        [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The total paid out to the firm. This is the sum of the transactions paid_out amounts.
        /// </summary>
        /// <value>The total paid out to the firm. This is the sum of the transactions paid_out amounts.</value>
        [DataMember(Name = "payout_total", IsRequired = true, EmitDefaultValue = true)]
        public string PayoutTotal { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", IsRequired = true, EmitDefaultValue = true)]
        public PayoutAccount Account { get; set; }

        /// <summary>
        /// The id of the firm the payout was made to.
        /// </summary>
        /// <value>The id of the firm the payout was made to.</value>
        [DataMember(Name = "firm_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid FirmId { get; set; }

        /// <summary>
        /// A list of the payments that are included in this payout
        /// </summary>
        /// <value>A list of the payments that are included in this payout</value>
        [DataMember(Name = "transactions", IsRequired = true, EmitDefaultValue = true)]
        public List<Payment> Transactions { get; set; }

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
            sb.Append("class Payout {\n");
            sb.Append("  PayoutReference: ").Append(PayoutReference).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  PayoutTotal: ").Append(PayoutTotal).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  FirmId: ").Append(FirmId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
            return this.Equals(input as Payout);
        }

        /// <summary>
        /// Returns true if Payout instances are equal
        /// </summary>
        /// <param name="input">Instance of Payout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Payout input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PayoutReference == input.PayoutReference ||
                    (this.PayoutReference != null &&
                    this.PayoutReference.Equals(input.PayoutReference))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.PayoutTotal == input.PayoutTotal ||
                    (this.PayoutTotal != null &&
                    this.PayoutTotal.Equals(input.PayoutTotal))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.FirmId == input.FirmId ||
                    (this.FirmId != null &&
                    this.FirmId.Equals(input.FirmId))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    input.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
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
                if (this.PayoutReference != null)
                {
                    hashCode = (hashCode * 59) + this.PayoutReference.GetHashCode();
                }
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                if (this.PayoutTotal != null)
                {
                    hashCode = (hashCode * 59) + this.PayoutTotal.GetHashCode();
                }
                if (this.Account != null)
                {
                    hashCode = (hashCode * 59) + this.Account.GetHashCode();
                }
                if (this.FirmId != null)
                {
                    hashCode = (hashCode * 59) + this.FirmId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Transactions != null)
                {
                    hashCode = (hashCode * 59) + this.Transactions.GetHashCode();
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
