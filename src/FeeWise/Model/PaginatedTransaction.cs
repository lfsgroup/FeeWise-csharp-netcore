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
    /// PaginatedTransaction
    /// </summary>
    [DataContract(Name = "PaginatedTransaction")]
    public partial class PaginatedTransaction : IEquatable<PaginatedTransaction>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [DataMember(Name = "account_type", IsRequired = true, EmitDefaultValue = true)]
        public AccountType AccountType { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public TransactionStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaginatedTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedTransaction" /> class.
        /// </summary>
        /// <param name="paymentReference">UUID of the payment intent (in FeeWise). This is the Payment id shown in the payment receipt. (required).</param>
        /// <param name="accountId">FW ID of the settlement account.</param>
        /// <param name="payoutId">ID of the payout (if paid out)..</param>
        /// <param name="payoutDate">Timestamp when the associated payout was made to the firm from FeeWise..</param>
        /// <param name="reference">The artifact reference. (required).</param>
        /// <param name="debtor">debtor.</param>
        /// <param name="matterReference">The name of the matter the payment is made for..</param>
        /// <param name="matterDescription">The description of the matter the payment is made for..</param>
        /// <param name="paymentDate">Timestamp when the payment was made by the client. (required).</param>
        /// <param name="customerPaymentMethod">customerPaymentMethod.</param>
        /// <param name="accountAlias">The account alias (name). (required).</param>
        /// <param name="accountType">accountType (required).</param>
        /// <param name="amount">Amount paid (received from client gross) (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="payerDetails">payerDetails.</param>
        /// <param name="clientReference">Only present if the artifact is of type payment link.</param>
        /// <param name="metadata">metadata that the partner has attached to the original artifact (charge, invoice, trust deposit, etc).</param>
        public PaginatedTransaction(Guid paymentReference = default(Guid), Guid accountId = default(Guid), Guid payoutId = default(Guid), DateTime payoutDate = default(DateTime), string reference = default(string), Debtor debtor = default(Debtor), string matterReference = default(string), string matterDescription = default(string), DateTime paymentDate = default(DateTime), CustomerPaymentMethod customerPaymentMethod = default(CustomerPaymentMethod), string accountAlias = default(string), AccountType accountType = default(AccountType), string amount = default(string), TransactionStatus status = default(TransactionStatus), Payer payerDetails = default(Payer), string clientReference = default(string), Dictionary<string, string> metadata = default(Dictionary<string, string>))
        {
            this.PaymentReference = paymentReference;
            // to ensure "reference" is required (not null)
            if (reference == null)
            {
                throw new ArgumentNullException("reference is a required property for PaginatedTransaction and cannot be null");
            }
            this.Reference = reference;
            this.PaymentDate = paymentDate;
            // to ensure "accountAlias" is required (not null)
            if (accountAlias == null)
            {
                throw new ArgumentNullException("accountAlias is a required property for PaginatedTransaction and cannot be null");
            }
            this.AccountAlias = accountAlias;
            this.AccountType = accountType;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for PaginatedTransaction and cannot be null");
            }
            this.Amount = amount;
            this.Status = status;
            this.AccountId = accountId;
            this.PayoutId = payoutId;
            this.PayoutDate = payoutDate;
            this.Debtor = debtor;
            this.MatterReference = matterReference;
            this.MatterDescription = matterDescription;
            this.CustomerPaymentMethod = customerPaymentMethod;
            this.PayerDetails = payerDetails;
            this.ClientReference = clientReference;
            this.Metadata = metadata;
        }

        /// <summary>
        /// UUID of the payment intent (in FeeWise). This is the Payment id shown in the payment receipt.
        /// </summary>
        /// <value>UUID of the payment intent (in FeeWise). This is the Payment id shown in the payment receipt.</value>
        [DataMember(Name = "payment_reference", IsRequired = true, EmitDefaultValue = true)]
        public Guid PaymentReference { get; set; }

        /// <summary>
        /// FW ID of the settlement account
        /// </summary>
        /// <value>FW ID of the settlement account</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public Guid AccountId { get; set; }

        /// <summary>
        /// ID of the payout (if paid out).
        /// </summary>
        /// <value>ID of the payout (if paid out).</value>
        [DataMember(Name = "payout_id", EmitDefaultValue = false)]
        public Guid PayoutId { get; set; }

        /// <summary>
        /// Timestamp when the associated payout was made to the firm from FeeWise.
        /// </summary>
        /// <value>Timestamp when the associated payout was made to the firm from FeeWise.</value>
        [DataMember(Name = "payout_date", EmitDefaultValue = false)]
        public DateTime PayoutDate { get; set; }

        /// <summary>
        /// The artifact reference.
        /// </summary>
        /// <value>The artifact reference.</value>
        [DataMember(Name = "reference", IsRequired = true, EmitDefaultValue = true)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets Debtor
        /// </summary>
        [DataMember(Name = "debtor", EmitDefaultValue = false)]
        public Debtor Debtor { get; set; }

        /// <summary>
        /// The name of the matter the payment is made for.
        /// </summary>
        /// <value>The name of the matter the payment is made for.</value>
        [DataMember(Name = "matter_reference", EmitDefaultValue = false)]
        public string MatterReference { get; set; }

        /// <summary>
        /// The description of the matter the payment is made for.
        /// </summary>
        /// <value>The description of the matter the payment is made for.</value>
        [DataMember(Name = "matter_description", EmitDefaultValue = false)]
        public string MatterDescription { get; set; }

        /// <summary>
        /// Timestamp when the payment was made by the client.
        /// </summary>
        /// <value>Timestamp when the payment was made by the client.</value>
        [DataMember(Name = "payment_date", IsRequired = true, EmitDefaultValue = true)]
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// Gets or Sets CustomerPaymentMethod
        /// </summary>
        [DataMember(Name = "customer_payment_method", EmitDefaultValue = false)]
        public CustomerPaymentMethod CustomerPaymentMethod { get; set; }

        /// <summary>
        /// The account alias (name).
        /// </summary>
        /// <value>The account alias (name).</value>
        [DataMember(Name = "account_alias", IsRequired = true, EmitDefaultValue = true)]
        public string AccountAlias { get; set; }

        /// <summary>
        /// Amount paid (received from client gross)
        /// </summary>
        /// <value>Amount paid (received from client gross)</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or Sets PayerDetails
        /// </summary>
        [DataMember(Name = "payer_details", EmitDefaultValue = false)]
        public Payer PayerDetails { get; set; }

        /// <summary>
        /// Only present if the artifact is of type payment link
        /// </summary>
        /// <value>Only present if the artifact is of type payment link</value>
        [DataMember(Name = "client_reference", EmitDefaultValue = false)]
        public string ClientReference { get; set; }

        /// <summary>
        /// metadata that the partner has attached to the original artifact (charge, invoice, trust deposit, etc)
        /// </summary>
        /// <value>metadata that the partner has attached to the original artifact (charge, invoice, trust deposit, etc)</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaginatedTransaction {\n");
            sb.Append("  PaymentReference: ").Append(PaymentReference).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  PayoutId: ").Append(PayoutId).Append("\n");
            sb.Append("  PayoutDate: ").Append(PayoutDate).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Debtor: ").Append(Debtor).Append("\n");
            sb.Append("  MatterReference: ").Append(MatterReference).Append("\n");
            sb.Append("  MatterDescription: ").Append(MatterDescription).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  CustomerPaymentMethod: ").Append(CustomerPaymentMethod).Append("\n");
            sb.Append("  AccountAlias: ").Append(AccountAlias).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PayerDetails: ").Append(PayerDetails).Append("\n");
            sb.Append("  ClientReference: ").Append(ClientReference).Append("\n");
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
            return this.Equals(input as PaginatedTransaction);
        }

        /// <summary>
        /// Returns true if PaginatedTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of PaginatedTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaginatedTransaction input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PaymentReference == input.PaymentReference ||
                    (this.PaymentReference != null &&
                    this.PaymentReference.Equals(input.PaymentReference))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.PayoutId == input.PayoutId ||
                    (this.PayoutId != null &&
                    this.PayoutId.Equals(input.PayoutId))
                ) && 
                (
                    this.PayoutDate == input.PayoutDate ||
                    (this.PayoutDate != null &&
                    this.PayoutDate.Equals(input.PayoutDate))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Debtor == input.Debtor ||
                    (this.Debtor != null &&
                    this.Debtor.Equals(input.Debtor))
                ) && 
                (
                    this.MatterReference == input.MatterReference ||
                    (this.MatterReference != null &&
                    this.MatterReference.Equals(input.MatterReference))
                ) && 
                (
                    this.MatterDescription == input.MatterDescription ||
                    (this.MatterDescription != null &&
                    this.MatterDescription.Equals(input.MatterDescription))
                ) && 
                (
                    this.PaymentDate == input.PaymentDate ||
                    (this.PaymentDate != null &&
                    this.PaymentDate.Equals(input.PaymentDate))
                ) && 
                (
                    this.CustomerPaymentMethod == input.CustomerPaymentMethod ||
                    (this.CustomerPaymentMethod != null &&
                    this.CustomerPaymentMethod.Equals(input.CustomerPaymentMethod))
                ) && 
                (
                    this.AccountAlias == input.AccountAlias ||
                    (this.AccountAlias != null &&
                    this.AccountAlias.Equals(input.AccountAlias))
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    this.AccountType.Equals(input.AccountType)
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.PayerDetails == input.PayerDetails ||
                    (this.PayerDetails != null &&
                    this.PayerDetails.Equals(input.PayerDetails))
                ) && 
                (
                    this.ClientReference == input.ClientReference ||
                    (this.ClientReference != null &&
                    this.ClientReference.Equals(input.ClientReference))
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
                if (this.PaymentReference != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentReference.GetHashCode();
                }
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.PayoutId != null)
                {
                    hashCode = (hashCode * 59) + this.PayoutId.GetHashCode();
                }
                if (this.PayoutDate != null)
                {
                    hashCode = (hashCode * 59) + this.PayoutDate.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.Debtor != null)
                {
                    hashCode = (hashCode * 59) + this.Debtor.GetHashCode();
                }
                if (this.MatterReference != null)
                {
                    hashCode = (hashCode * 59) + this.MatterReference.GetHashCode();
                }
                if (this.MatterDescription != null)
                {
                    hashCode = (hashCode * 59) + this.MatterDescription.GetHashCode();
                }
                if (this.PaymentDate != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentDate.GetHashCode();
                }
                if (this.CustomerPaymentMethod != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerPaymentMethod.GetHashCode();
                }
                if (this.AccountAlias != null)
                {
                    hashCode = (hashCode * 59) + this.AccountAlias.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AccountType.GetHashCode();
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.PayerDetails != null)
                {
                    hashCode = (hashCode * 59) + this.PayerDetails.GetHashCode();
                }
                if (this.ClientReference != null)
                {
                    hashCode = (hashCode * 59) + this.ClientReference.GetHashCode();
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
