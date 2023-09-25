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
    /// An Invoice is created to request payment. One of settlement_account_type or settlement_account_id must be specified but not both. 
    /// </summary>
    [DataContract(Name = "Invoice")]
    public partial class Invoice : IEquatable<Invoice>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public Currency? Currency { get; set; }

        /// <summary>
        /// Gets or Sets SettlementAccountType
        /// </summary>
        [DataMember(Name = "settlement_account_type", EmitDefaultValue = false)]
        public AccountType? SettlementAccountType { get; set; }

        /// <summary>
        /// Gets or Sets SurchargeChoiceOverride
        /// </summary>
        [DataMember(Name = "surcharge_choice_override", EmitDefaultValue = false)]
        public SurchargeChoice? SurchargeChoiceOverride { get; set; }
        /// <summary>
        /// The status of the invoice
        /// </summary>
        /// <value>The status of the invoice</value>
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
        /// The status of the invoice
        /// </summary>
        /// <value>The status of the invoice</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Invoice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Invoice()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Invoice" /> class.
        /// </summary>
        /// <param name="invoiceId">This is the uuid of the invoice. This will be used for and &#39;GET&#39; of the invoice and in webhooks about this invoice NB this is generated and must not be supplied when creating an invoice. .</param>
        /// <param name="firmId">The firm the invoice is raised for. (required).</param>
        /// <param name="matter">matter.</param>
        /// <param name="debtor">debtor.</param>
        /// <param name="externalId">This is the id supplied by the channel partner / PMS and can be used for filtering invoices. This should be unique for the PMS but this is not enforced. (required).</param>
        /// <param name="externalReference">This a reference supplied by the channel partner / PMS and can be used for filtering invoices..</param>
        /// <param name="amount">The total amount the invoice is for. (required).</param>
        /// <param name="amountDue">The total amount outstanding on this invoice..</param>
        /// <param name="currency">currency.</param>
        /// <param name="dueDate">dueDate.</param>
        /// <param name="settlementAccountType">settlementAccountType.</param>
        /// <param name="settlementAccountId">The id of the account the invoice settlement should be paid to.  NB, if both the settlement_account_type and settlement_account_id are specified, it is a bad request .</param>
        /// <param name="lineItems">lineItems.</param>
        /// <param name="notes">Freeform notes on the invoice.</param>
        /// <param name="payments">List of payments made against this invoice.</param>
        /// <param name="paymentMethodsOverride">paymentMethodsOverride.</param>
        /// <param name="surchargeChoiceOverride">surchargeChoiceOverride.</param>
        /// <param name="description">Freeform text for API user..</param>
        /// <param name="paymentUri">The URI to get the client payment instructions for this invoice.</param>
        /// <param name="status">The status of the invoice.</param>
        public Invoice(Guid invoiceId = default(Guid), Guid firmId = default(Guid), Matter matter = default(Matter), Debtor debtor = default(Debtor), string externalId = default(string), string externalReference = default(string), string amount = default(string), string amountDue = default(string), Currency? currency = default(Currency?), DateTime dueDate = default(DateTime), AccountType? settlementAccountType = default(AccountType?), Guid settlementAccountId = default(Guid), List<LineItem> lineItems = default(List<LineItem>), List<string> notes = default(List<string>), List<Payment> payments = default(List<Payment>), List<PaymentMethod> paymentMethodsOverride = default(List<PaymentMethod>), SurchargeChoice? surchargeChoiceOverride = default(SurchargeChoice?), string description = default(string), string paymentUri = default(string), StatusEnum? status = default(StatusEnum?))
        {
            this.FirmId = firmId;
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new ArgumentNullException("externalId is a required property for Invoice and cannot be null");
            }
            this.ExternalId = externalId;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for Invoice and cannot be null");
            }
            this.Amount = amount;
            this.InvoiceId = invoiceId;
            this.Matter = matter;
            this.Debtor = debtor;
            this.ExternalReference = externalReference;
            this.AmountDue = amountDue;
            this.Currency = currency;
            this.DueDate = dueDate;
            this.SettlementAccountType = settlementAccountType;
            this.SettlementAccountId = settlementAccountId;
            this.LineItems = lineItems;
            this.Notes = notes;
            this.Payments = payments;
            this.PaymentMethodsOverride = paymentMethodsOverride;
            this.SurchargeChoiceOverride = surchargeChoiceOverride;
            this.Description = description;
            this.PaymentUri = paymentUri;
            this.Status = status;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// This is the uuid of the invoice. This will be used for and &#39;GET&#39; of the invoice and in webhooks about this invoice NB this is generated and must not be supplied when creating an invoice. 
        /// </summary>
        /// <value>This is the uuid of the invoice. This will be used for and &#39;GET&#39; of the invoice and in webhooks about this invoice NB this is generated and must not be supplied when creating an invoice. </value>
        [DataMember(Name = "invoice_id", EmitDefaultValue = false)]
        public Guid InvoiceId { get; set; }

        /// <summary>
        /// The firm the invoice is raised for.
        /// </summary>
        /// <value>The firm the invoice is raised for.</value>
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
        /// This is the id supplied by the channel partner / PMS and can be used for filtering invoices. This should be unique for the PMS but this is not enforced.
        /// </summary>
        /// <value>This is the id supplied by the channel partner / PMS and can be used for filtering invoices. This should be unique for the PMS but this is not enforced.</value>
        [DataMember(Name = "external_id", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// This a reference supplied by the channel partner / PMS and can be used for filtering invoices.
        /// </summary>
        /// <value>This a reference supplied by the channel partner / PMS and can be used for filtering invoices.</value>
        [DataMember(Name = "external_reference", EmitDefaultValue = false)]
        public string ExternalReference { get; set; }

        /// <summary>
        /// The total amount the invoice is for.
        /// </summary>
        /// <value>The total amount the invoice is for.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public string Amount { get; set; }

        /// <summary>
        /// The total amount outstanding on this invoice.
        /// </summary>
        /// <value>The total amount outstanding on this invoice.</value>
        [DataMember(Name = "amount_due", EmitDefaultValue = false)]
        public string AmountDue { get; set; }

        /// <summary>
        /// Gets or Sets DueDate
        /// </summary>
        [DataMember(Name = "due_date", EmitDefaultValue = false)]
        public DateTime DueDate { get; set; }

        /// <summary>
        /// The id of the account the invoice settlement should be paid to.  NB, if both the settlement_account_type and settlement_account_id are specified, it is a bad request 
        /// </summary>
        /// <value>The id of the account the invoice settlement should be paid to.  NB, if both the settlement_account_type and settlement_account_id are specified, it is a bad request </value>
        [DataMember(Name = "settlement_account_id", EmitDefaultValue = false)]
        public Guid SettlementAccountId { get; set; }

        /// <summary>
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name = "line_items", EmitDefaultValue = false)]
        public List<LineItem> LineItems { get; set; }

        /// <summary>
        /// Freeform notes on the invoice
        /// </summary>
        /// <value>Freeform notes on the invoice</value>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public List<string> Notes { get; set; }

        /// <summary>
        /// List of payments made against this invoice
        /// </summary>
        /// <value>List of payments made against this invoice</value>
        [DataMember(Name = "payments", EmitDefaultValue = false)]
        public List<Payment> Payments { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethodsOverride
        /// </summary>
        [DataMember(Name = "payment_methods_override", EmitDefaultValue = false)]
        public List<PaymentMethod> PaymentMethodsOverride { get; set; }

        /// <summary>
        /// Freeform text for API user.
        /// </summary>
        /// <value>Freeform text for API user.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The URI to get the client payment instructions for this invoice
        /// </summary>
        /// <value>The URI to get the client payment instructions for this invoice</value>
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
            sb.Append("class Invoice {\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  FirmId: ").Append(FirmId).Append("\n");
            sb.Append("  Matter: ").Append(Matter).Append("\n");
            sb.Append("  Debtor: ").Append(Debtor).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  ExternalReference: ").Append(ExternalReference).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AmountDue: ").Append(AmountDue).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  SettlementAccountType: ").Append(SettlementAccountType).Append("\n");
            sb.Append("  SettlementAccountId: ").Append(SettlementAccountId).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
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
            return this.Equals(input as Invoice);
        }

        /// <summary>
        /// Returns true if Invoice instances are equal
        /// </summary>
        /// <param name="input">Instance of Invoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Invoice input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InvoiceId == input.InvoiceId ||
                    (this.InvoiceId != null &&
                    this.InvoiceId.Equals(input.InvoiceId))
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
                    this.SettlementAccountType == input.SettlementAccountType ||
                    this.SettlementAccountType.Equals(input.SettlementAccountType)
                ) && 
                (
                    this.SettlementAccountId == input.SettlementAccountId ||
                    (this.SettlementAccountId != null &&
                    this.SettlementAccountId.Equals(input.SettlementAccountId))
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
                if (this.InvoiceId != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceId.GetHashCode();
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
                hashCode = (hashCode * 59) + this.SettlementAccountType.GetHashCode();
                if (this.SettlementAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.SettlementAccountId.GetHashCode();
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
