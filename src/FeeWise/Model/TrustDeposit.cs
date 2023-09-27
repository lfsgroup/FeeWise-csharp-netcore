/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.94
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
    /// A TrustDeposit is created to request payment into a Trust account 
    /// </summary>
    [DataContract(Name = "TrustDeposit")]
    public partial class TrustDeposit : IEquatable<TrustDeposit>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public Currency? Currency { get; set; }

        /// <summary>
        /// Gets or Sets SurchargeChoiceOverride
        /// </summary>
        [DataMember(Name = "surcharge_choice_override", EmitDefaultValue = false)]
        public SurchargeChoice? SurchargeChoiceOverride { get; set; }
        /// <summary>
        /// The status of the trust deposit. This must not be set when creating an trust deposit.
        /// </summary>
        /// <value>The status of the trust deposit. This must not be set when creating an trust deposit.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Draft for value: Draft
            /// </summary>
            [EnumMember(Value = "Draft")]
            Draft = 1,

            /// <summary>
            /// Enum Submitted for value: Submitted
            /// </summary>
            [EnumMember(Value = "Submitted")]
            Submitted = 2,

            /// <summary>
            /// Enum Authorised for value: Authorised
            /// </summary>
            [EnumMember(Value = "Authorised")]
            Authorised = 3,

            /// <summary>
            /// Enum Voided for value: Voided
            /// </summary>
            [EnumMember(Value = "Voided")]
            Voided = 4

        }


        /// <summary>
        /// The status of the trust deposit. This must not be set when creating an trust deposit.
        /// </summary>
        /// <value>The status of the trust deposit. This must not be set when creating an trust deposit.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustDeposit" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrustDeposit()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustDeposit" /> class.
        /// </summary>
        /// <param name="trustDepositId">This is the uuid of the Trust Deposit. This will be used for any &#39;GET&#39; of the Trust Deposit and in webhooks about this Trust Deposit NB this is generated and must not be supplied when creating a Trust Deposit. .</param>
        /// <param name="firmId">The firm the trust deposit is raised for. (required).</param>
        /// <param name="matter">matter.</param>
        /// <param name="debtor">debtor.</param>
        /// <param name="externalId">This is the id supplied by the channel partner / PMS and can be used for filtering trust deposits. This should be unique for the PMS but this is not enforced. (required).</param>
        /// <param name="externalReference">This a reference supplied by the channel partner / PMS and can be used for filtering trust deposits..</param>
        /// <param name="amount">The total amount the trust deposit is for. (required).</param>
        /// <param name="amountDue">The total amount outstanding on this trust deposit..</param>
        /// <param name="currency">currency.</param>
        /// <param name="dueDate">dueDate.</param>
        /// <param name="lineItems">lineItems.</param>
        /// <param name="notes">Freeform notes on the trust deposit.</param>
        /// <param name="payments">List of payments made against this trust deposit..</param>
        /// <param name="settlementAccountId">The id of the account the trust deposit should be paid to.  If not supplied, the default trust deposit for the firm will be used .</param>
        /// <param name="paymentMethodsOverride">paymentMethodsOverride.</param>
        /// <param name="surchargeChoiceOverride">surchargeChoiceOverride.</param>
        /// <param name="description">Freeform text for channel partner / PMS..</param>
        /// <param name="paymentUri">The URI to send to customer.    They will follow this link to make a payment.    NB This must not be set when creating an invoice. .</param>
        /// <param name="status">The status of the trust deposit. This must not be set when creating an trust deposit..</param>
        public TrustDeposit(Guid trustDepositId = default(Guid), Guid firmId = default(Guid), Matter matter = default(Matter), Debtor debtor = default(Debtor), string externalId = default(string), string externalReference = default(string), string amount = default(string), string amountDue = default(string), Currency? currency = default(Currency?), DateTime dueDate = default(DateTime), List<LineItem> lineItems = default(List<LineItem>), List<string> notes = default(List<string>), List<Payment> payments = default(List<Payment>), Guid settlementAccountId = default(Guid), List<PaymentMethod> paymentMethodsOverride = default(List<PaymentMethod>), SurchargeChoice? surchargeChoiceOverride = default(SurchargeChoice?), string description = default(string), string paymentUri = default(string), StatusEnum? status = default(StatusEnum?))
        {
            this.FirmId = firmId;
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new ArgumentNullException("externalId is a required property for TrustDeposit and cannot be null");
            }
            this.ExternalId = externalId;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for TrustDeposit and cannot be null");
            }
            this.Amount = amount;
            this.TrustDepositId = trustDepositId;
            this.Matter = matter;
            this.Debtor = debtor;
            this.ExternalReference = externalReference;
            this.AmountDue = amountDue;
            this.Currency = currency;
            this.DueDate = dueDate;
            this.LineItems = lineItems;
            this.Notes = notes;
            this.Payments = payments;
            this.SettlementAccountId = settlementAccountId;
            this.PaymentMethodsOverride = paymentMethodsOverride;
            this.SurchargeChoiceOverride = surchargeChoiceOverride;
            this.Description = description;
            this.PaymentUri = paymentUri;
            this.Status = status;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// This is the uuid of the Trust Deposit. This will be used for any &#39;GET&#39; of the Trust Deposit and in webhooks about this Trust Deposit NB this is generated and must not be supplied when creating a Trust Deposit. 
        /// </summary>
        /// <value>This is the uuid of the Trust Deposit. This will be used for any &#39;GET&#39; of the Trust Deposit and in webhooks about this Trust Deposit NB this is generated and must not be supplied when creating a Trust Deposit. </value>
        [DataMember(Name = "trust_deposit_id", EmitDefaultValue = false)]
        public Guid TrustDepositId { get; set; }

        /// <summary>
        /// The firm the trust deposit is raised for.
        /// </summary>
        /// <value>The firm the trust deposit is raised for.</value>
        [DataMember(Name = "firm_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid FirmId { get; set; }

        /// <summary>
        /// Gets or Sets Matter
        /// </summary>
        [DataMember(Name = "matter", EmitDefaultValue = false)]
        public Matter Matter { get; set; }

        /// <summary>
        /// Gets or Sets Debtor
        /// </summary>
        [DataMember(Name = "debtor", EmitDefaultValue = false)]
        public Debtor Debtor { get; set; }

        /// <summary>
        /// This is the id supplied by the channel partner / PMS and can be used for filtering trust deposits. This should be unique for the PMS but this is not enforced.
        /// </summary>
        /// <value>This is the id supplied by the channel partner / PMS and can be used for filtering trust deposits. This should be unique for the PMS but this is not enforced.</value>
        [DataMember(Name = "external_id", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// This a reference supplied by the channel partner / PMS and can be used for filtering trust deposits.
        /// </summary>
        /// <value>This a reference supplied by the channel partner / PMS and can be used for filtering trust deposits.</value>
        [DataMember(Name = "external_reference", EmitDefaultValue = false)]
        public string ExternalReference { get; set; }

        /// <summary>
        /// The total amount the trust deposit is for.
        /// </summary>
        /// <value>The total amount the trust deposit is for.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public string Amount { get; set; }

        /// <summary>
        /// The total amount outstanding on this trust deposit.
        /// </summary>
        /// <value>The total amount outstanding on this trust deposit.</value>
        [DataMember(Name = "amount_due", EmitDefaultValue = false)]
        public string AmountDue { get; set; }

        /// <summary>
        /// Gets or Sets DueDate
        /// </summary>
        [DataMember(Name = "due_date", EmitDefaultValue = false)]
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name = "line_items", EmitDefaultValue = false)]
        public List<LineItem> LineItems { get; set; }

        /// <summary>
        /// Freeform notes on the trust deposit
        /// </summary>
        /// <value>Freeform notes on the trust deposit</value>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public List<string> Notes { get; set; }

        /// <summary>
        /// List of payments made against this trust deposit.
        /// </summary>
        /// <value>List of payments made against this trust deposit.</value>
        [DataMember(Name = "payments", EmitDefaultValue = false)]
        public List<Payment> Payments { get; set; }

        /// <summary>
        /// The id of the account the trust deposit should be paid to.  If not supplied, the default trust deposit for the firm will be used 
        /// </summary>
        /// <value>The id of the account the trust deposit should be paid to.  If not supplied, the default trust deposit for the firm will be used </value>
        [DataMember(Name = "settlement_account_id", EmitDefaultValue = false)]
        public Guid SettlementAccountId { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethodsOverride
        /// </summary>
        [DataMember(Name = "payment_methods_override", EmitDefaultValue = false)]
        public List<PaymentMethod> PaymentMethodsOverride { get; set; }

        /// <summary>
        /// Freeform text for channel partner / PMS.
        /// </summary>
        /// <value>Freeform text for channel partner / PMS.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The URI to send to customer.    They will follow this link to make a payment.    NB This must not be set when creating an invoice. 
        /// </summary>
        /// <value>The URI to send to customer.    They will follow this link to make a payment.    NB This must not be set when creating an invoice. </value>
        [DataMember(Name = "payment_uri", EmitDefaultValue = false)]
        public string PaymentUri { get; set; }

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
            sb.Append("class TrustDeposit {\n");
            sb.Append("  TrustDepositId: ").Append(TrustDepositId).Append("\n");
            sb.Append("  FirmId: ").Append(FirmId).Append("\n");
            sb.Append("  Matter: ").Append(Matter).Append("\n");
            sb.Append("  Debtor: ").Append(Debtor).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  ExternalReference: ").Append(ExternalReference).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AmountDue: ").Append(AmountDue).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("  SettlementAccountId: ").Append(SettlementAccountId).Append("\n");
            sb.Append("  PaymentMethodsOverride: ").Append(PaymentMethodsOverride).Append("\n");
            sb.Append("  SurchargeChoiceOverride: ").Append(SurchargeChoiceOverride).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PaymentUri: ").Append(PaymentUri).Append("\n");
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
            return this.Equals(input as TrustDeposit);
        }

        /// <summary>
        /// Returns true if TrustDeposit instances are equal
        /// </summary>
        /// <param name="input">Instance of TrustDeposit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrustDeposit input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TrustDepositId == input.TrustDepositId ||
                    (this.TrustDepositId != null &&
                    this.TrustDepositId.Equals(input.TrustDepositId))
                ) && 
                (
                    this.FirmId == input.FirmId ||
                    (this.FirmId != null &&
                    this.FirmId.Equals(input.FirmId))
                ) && 
                (
                    this.Matter == input.Matter ||
                    (this.Matter != null &&
                    this.Matter.Equals(input.Matter))
                ) && 
                (
                    this.Debtor == input.Debtor ||
                    (this.Debtor != null &&
                    this.Debtor.Equals(input.Debtor))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.ExternalReference == input.ExternalReference ||
                    (this.ExternalReference != null &&
                    this.ExternalReference.Equals(input.ExternalReference))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.AmountDue == input.AmountDue ||
                    (this.AmountDue != null &&
                    this.AmountDue.Equals(input.AmountDue))
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.Notes == input.Notes ||
                    this.Notes != null &&
                    input.Notes != null &&
                    this.Notes.SequenceEqual(input.Notes)
                ) && 
                (
                    this.Payments == input.Payments ||
                    this.Payments != null &&
                    input.Payments != null &&
                    this.Payments.SequenceEqual(input.Payments)
                ) && 
                (
                    this.SettlementAccountId == input.SettlementAccountId ||
                    (this.SettlementAccountId != null &&
                    this.SettlementAccountId.Equals(input.SettlementAccountId))
                ) && 
                (
                    this.PaymentMethodsOverride == input.PaymentMethodsOverride ||
                    this.PaymentMethodsOverride != null &&
                    input.PaymentMethodsOverride != null &&
                    this.PaymentMethodsOverride.SequenceEqual(input.PaymentMethodsOverride)
                ) && 
                (
                    this.SurchargeChoiceOverride == input.SurchargeChoiceOverride ||
                    this.SurchargeChoiceOverride.Equals(input.SurchargeChoiceOverride)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.PaymentUri == input.PaymentUri ||
                    (this.PaymentUri != null &&
                    this.PaymentUri.Equals(input.PaymentUri))
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
                if (this.TrustDepositId != null)
                {
                    hashCode = (hashCode * 59) + this.TrustDepositId.GetHashCode();
                }
                if (this.FirmId != null)
                {
                    hashCode = (hashCode * 59) + this.FirmId.GetHashCode();
                }
                if (this.Matter != null)
                {
                    hashCode = (hashCode * 59) + this.Matter.GetHashCode();
                }
                if (this.Debtor != null)
                {
                    hashCode = (hashCode * 59) + this.Debtor.GetHashCode();
                }
                if (this.ExternalId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalId.GetHashCode();
                }
                if (this.ExternalReference != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalReference.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.AmountDue != null)
                {
                    hashCode = (hashCode * 59) + this.AmountDue.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                if (this.DueDate != null)
                {
                    hashCode = (hashCode * 59) + this.DueDate.GetHashCode();
                }
                if (this.LineItems != null)
                {
                    hashCode = (hashCode * 59) + this.LineItems.GetHashCode();
                }
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                if (this.Payments != null)
                {
                    hashCode = (hashCode * 59) + this.Payments.GetHashCode();
                }
                if (this.SettlementAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.SettlementAccountId.GetHashCode();
                }
                if (this.PaymentMethodsOverride != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethodsOverride.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SurchargeChoiceOverride.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.PaymentUri != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentUri.GetHashCode();
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
