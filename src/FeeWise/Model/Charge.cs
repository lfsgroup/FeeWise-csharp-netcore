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
    /// A Charge is created to request payment. Either the settlement_account_type or the settlement_account_id must be provided but not both. 
    /// </summary>
    [DataContract(Name = "Charge")]
    public partial class Charge : IEquatable<Charge>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="Charge" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Charge()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Charge" /> class.
        /// </summary>
        /// <param name="chargeId">This is the uuid of the charge. This will be used for a &#39;GET&#39; of the charge and in webhooks about this charge. NB: this is generated and must not be supplied when creating an charge. .</param>
        /// <param name="firmId">The firm the charge is being created for..</param>
        /// <param name="matter">matter.</param>
        /// <param name="debtor">debtor.</param>
        /// <param name="externalId">This is the id supplied by the channel partner / PMS and can be used for filtering charges. This should be unique for the PMS but this is not enforced..</param>
        /// <param name="externalReference">This a reference supplied by the channel partner / PMS and can be used for filtering charges..</param>
        /// <param name="amount">The total amount the charge is for. (required).</param>
        /// <param name="amountDue">The total amount outstanding on this charge..</param>
        /// <param name="currency">currency.</param>
        /// <param name="dueDate">dueDate.</param>
        /// <param name="settlementAccountType">settlementAccountType.</param>
        /// <param name="settlementAccountId">The id of the account the charge should be paid to. NB: if both the settlement_account_type and settlement_account_id are specified, it is a bad request. .</param>
        /// <param name="notes">Any notes relevant to the charge..</param>
        /// <param name="paymentMethodsOverride">paymentMethodsOverride.</param>
        /// <param name="description">Description of the charge..</param>
        /// <param name="storePaymentMethods">Choose which payment methods to save when the customer pays a charge..</param>
        /// <param name="surchargeChoiceOverride">surchargeChoiceOverride.</param>
        /// <param name="paymentUri">The URI to pay the charge..</param>
        /// <param name="metadata">Set of key value pairs that you can attach to an object. Useful for storing additional information about the object in a structured format..</param>
        public Charge(Guid chargeId = default(Guid), Guid firmId = default(Guid), Matter matter = default(Matter), Debtor debtor = default(Debtor), string externalId = default(string), string externalReference = default(string), string amount = default(string), string amountDue = default(string), Currency? currency = default(Currency?), DateTime dueDate = default(DateTime), AccountType? settlementAccountType = default(AccountType?), Guid settlementAccountId = default(Guid), List<string> notes = default(List<string>), List<PaymentMethod> paymentMethodsOverride = default(List<PaymentMethod>), string description = default(string), List<PaymentMethod> storePaymentMethods = default(List<PaymentMethod>), SurchargeChoice? surchargeChoiceOverride = default(SurchargeChoice?), string paymentUri = default(string), Dictionary<string, string> metadata = default(Dictionary<string, string>))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for Charge and cannot be null");
            }
            this.Amount = amount;
            this.ChargeId = chargeId;
            this.FirmId = firmId;
            this.Matter = matter;
            this.Debtor = debtor;
            this.ExternalId = externalId;
            this.ExternalReference = externalReference;
            this.AmountDue = amountDue;
            this.Currency = currency;
            this.DueDate = dueDate;
            this.SettlementAccountType = settlementAccountType;
            this.SettlementAccountId = settlementAccountId;
            this.Notes = notes;
            this.PaymentMethodsOverride = paymentMethodsOverride;
            this.Description = description;
            this.StorePaymentMethods = storePaymentMethods;
            this.SurchargeChoiceOverride = surchargeChoiceOverride;
            this.PaymentUri = paymentUri;
            this.Metadata = metadata;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// This is the uuid of the charge. This will be used for a &#39;GET&#39; of the charge and in webhooks about this charge. NB: this is generated and must not be supplied when creating an charge. 
        /// </summary>
        /// <value>This is the uuid of the charge. This will be used for a &#39;GET&#39; of the charge and in webhooks about this charge. NB: this is generated and must not be supplied when creating an charge. </value>
        [DataMember(Name = "charge_id", EmitDefaultValue = false)]
        public Guid ChargeId { get; set; }

        /// <summary>
        /// The firm the charge is being created for.
        /// </summary>
        /// <value>The firm the charge is being created for.</value>
        [DataMember(Name = "firm_id", EmitDefaultValue = false)]
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
        /// This is the id supplied by the channel partner / PMS and can be used for filtering charges. This should be unique for the PMS but this is not enforced.
        /// </summary>
        /// <value>This is the id supplied by the channel partner / PMS and can be used for filtering charges. This should be unique for the PMS but this is not enforced.</value>
        [DataMember(Name = "external_id", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// This a reference supplied by the channel partner / PMS and can be used for filtering charges.
        /// </summary>
        /// <value>This a reference supplied by the channel partner / PMS and can be used for filtering charges.</value>
        [DataMember(Name = "external_reference", EmitDefaultValue = false)]
        public string ExternalReference { get; set; }

        /// <summary>
        /// The total amount the charge is for.
        /// </summary>
        /// <value>The total amount the charge is for.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public string Amount { get; set; }

        /// <summary>
        /// The total amount outstanding on this charge.
        /// </summary>
        /// <value>The total amount outstanding on this charge.</value>
        [DataMember(Name = "amount_due", EmitDefaultValue = false)]
        public string AmountDue { get; set; }

        /// <summary>
        /// Gets or Sets DueDate
        /// </summary>
        [DataMember(Name = "due_date", EmitDefaultValue = false)]
        public DateTime DueDate { get; set; }

        /// <summary>
        /// The id of the account the charge should be paid to. NB: if both the settlement_account_type and settlement_account_id are specified, it is a bad request. 
        /// </summary>
        /// <value>The id of the account the charge should be paid to. NB: if both the settlement_account_type and settlement_account_id are specified, it is a bad request. </value>
        [DataMember(Name = "settlement_account_id", EmitDefaultValue = false)]
        public Guid SettlementAccountId { get; set; }

        /// <summary>
        /// Any notes relevant to the charge.
        /// </summary>
        /// <value>Any notes relevant to the charge.</value>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public List<string> Notes { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethodsOverride
        /// </summary>
        [DataMember(Name = "payment_methods_override", EmitDefaultValue = false)]
        public List<PaymentMethod> PaymentMethodsOverride { get; set; }

        /// <summary>
        /// Description of the charge.
        /// </summary>
        /// <value>Description of the charge.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Choose which payment methods to save when the customer pays a charge.
        /// </summary>
        /// <value>Choose which payment methods to save when the customer pays a charge.</value>
        [DataMember(Name = "store_payment_methods", EmitDefaultValue = false)]
        public List<PaymentMethod> StorePaymentMethods { get; set; }

        /// <summary>
        /// The URI to pay the charge.
        /// </summary>
        /// <value>The URI to pay the charge.</value>
        [DataMember(Name = "payment_uri", EmitDefaultValue = false)]
        public string PaymentUri { get; set; }

        /// <summary>
        /// Set of key value pairs that you can attach to an object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of key value pairs that you can attach to an object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

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
            sb.Append("class Charge {\n");
            sb.Append("  ChargeId: ").Append(ChargeId).Append("\n");
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
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  PaymentMethodsOverride: ").Append(PaymentMethodsOverride).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  StorePaymentMethods: ").Append(StorePaymentMethods).Append("\n");
            sb.Append("  SurchargeChoiceOverride: ").Append(SurchargeChoiceOverride).Append("\n");
            sb.Append("  PaymentUri: ").Append(PaymentUri).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as Charge);
        }

        /// <summary>
        /// Returns true if Charge instances are equal
        /// </summary>
        /// <param name="input">Instance of Charge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Charge input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ChargeId == input.ChargeId ||
                    (this.ChargeId != null &&
                    this.ChargeId.Equals(input.ChargeId))
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
                    this.Notes == input.Notes ||
                    this.Notes != null &&
                    input.Notes != null &&
                    this.Notes.SequenceEqual(input.Notes)
                ) && 
                (
                    this.PaymentMethodsOverride == input.PaymentMethodsOverride ||
                    this.PaymentMethodsOverride != null &&
                    input.PaymentMethodsOverride != null &&
                    this.PaymentMethodsOverride.SequenceEqual(input.PaymentMethodsOverride)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.StorePaymentMethods == input.StorePaymentMethods ||
                    this.StorePaymentMethods != null &&
                    input.StorePaymentMethods != null &&
                    this.StorePaymentMethods.SequenceEqual(input.StorePaymentMethods)
                ) && 
                (
                    this.SurchargeChoiceOverride == input.SurchargeChoiceOverride ||
                    this.SurchargeChoiceOverride.Equals(input.SurchargeChoiceOverride)
                ) && 
                (
                    this.PaymentUri == input.PaymentUri ||
                    (this.PaymentUri != null &&
                    this.PaymentUri.Equals(input.PaymentUri))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
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
                if (this.ChargeId != null)
                {
                    hashCode = (hashCode * 59) + this.ChargeId.GetHashCode();
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
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                if (this.PaymentMethodsOverride != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethodsOverride.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.StorePaymentMethods != null)
                {
                    hashCode = (hashCode * 59) + this.StorePaymentMethods.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SurchargeChoiceOverride.GetHashCode();
                if (this.PaymentUri != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentUri.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
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
