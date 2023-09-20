/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.89
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
    /// PaymentAuthorisedEvent
    /// </summary>
    [DataContract(Name = "PaymentAuthorisedEvent")]
    public partial class PaymentAuthorisedEvent : IEquatable<PaymentAuthorisedEvent>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "payment_method", IsRequired = true, EmitDefaultValue = true)]
        public PaymentMethod PaymentMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAuthorisedEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentAuthorisedEvent()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAuthorisedEvent" /> class.
        /// </summary>
        /// <param name="artifacts">artifacts (required).</param>
        /// <param name="paymentId">The payment ID (required).</param>
        /// <param name="amountPaid">The amount paid (required).</param>
        /// <param name="cardPayment">cardPayment.</param>
        /// <param name="debitPayment">debitPayment.</param>
        /// <param name="firmId">The firm ID (required).</param>
        /// <param name="paymentMethod">paymentMethod (required).</param>
        /// <param name="paymentMethodDetail">The payment method detail.</param>
        public PaymentAuthorisedEvent(List<ArtifactReceipt> artifacts = default(List<ArtifactReceipt>), Guid paymentId = default(Guid), string amountPaid = default(string), CardPayment cardPayment = default(CardPayment), DebitPayment debitPayment = default(DebitPayment), Guid firmId = default(Guid), PaymentMethod paymentMethod = default(PaymentMethod), string paymentMethodDetail = default(string))
        {
            // to ensure "artifacts" is required (not null)
            if (artifacts == null)
            {
                throw new ArgumentNullException("artifacts is a required property for PaymentAuthorisedEvent and cannot be null");
            }
            this.Artifacts = artifacts;
            this.PaymentId = paymentId;
            // to ensure "amountPaid" is required (not null)
            if (amountPaid == null)
            {
                throw new ArgumentNullException("amountPaid is a required property for PaymentAuthorisedEvent and cannot be null");
            }
            this.AmountPaid = amountPaid;
            this.FirmId = firmId;
            this.PaymentMethod = paymentMethod;
            this.CardPayment = cardPayment;
            this.DebitPayment = debitPayment;
            this.PaymentMethodDetail = paymentMethodDetail;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Artifacts
        /// </summary>
        [DataMember(Name = "artifacts", IsRequired = true, EmitDefaultValue = true)]
        public List<ArtifactReceipt> Artifacts { get; set; }

        /// <summary>
        /// The payment ID
        /// </summary>
        /// <value>The payment ID</value>
        [DataMember(Name = "payment_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid PaymentId { get; set; }

        /// <summary>
        /// The amount paid
        /// </summary>
        /// <value>The amount paid</value>
        [DataMember(Name = "amount_paid", IsRequired = true, EmitDefaultValue = true)]
        public string AmountPaid { get; set; }

        /// <summary>
        /// Gets or Sets CardPayment
        /// </summary>
        [DataMember(Name = "card_payment", EmitDefaultValue = false)]
        public CardPayment CardPayment { get; set; }

        /// <summary>
        /// Gets or Sets DebitPayment
        /// </summary>
        [DataMember(Name = "debit_payment", EmitDefaultValue = false)]
        public DebitPayment DebitPayment { get; set; }

        /// <summary>
        /// The firm ID
        /// </summary>
        /// <value>The firm ID</value>
        [DataMember(Name = "firm_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid FirmId { get; set; }

        /// <summary>
        /// The payment method detail
        /// </summary>
        /// <value>The payment method detail</value>
        [DataMember(Name = "payment_method_detail", EmitDefaultValue = false)]
        public string PaymentMethodDetail { get; set; }

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
            sb.Append("class PaymentAuthorisedEvent {\n");
            sb.Append("  Artifacts: ").Append(Artifacts).Append("\n");
            sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
            sb.Append("  AmountPaid: ").Append(AmountPaid).Append("\n");
            sb.Append("  CardPayment: ").Append(CardPayment).Append("\n");
            sb.Append("  DebitPayment: ").Append(DebitPayment).Append("\n");
            sb.Append("  FirmId: ").Append(FirmId).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  PaymentMethodDetail: ").Append(PaymentMethodDetail).Append("\n");
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
            return this.Equals(input as PaymentAuthorisedEvent);
        }

        /// <summary>
        /// Returns true if PaymentAuthorisedEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentAuthorisedEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentAuthorisedEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Artifacts == input.Artifacts ||
                    this.Artifacts != null &&
                    input.Artifacts != null &&
                    this.Artifacts.SequenceEqual(input.Artifacts)
                ) && 
                (
                    this.PaymentId == input.PaymentId ||
                    (this.PaymentId != null &&
                    this.PaymentId.Equals(input.PaymentId))
                ) && 
                (
                    this.AmountPaid == input.AmountPaid ||
                    (this.AmountPaid != null &&
                    this.AmountPaid.Equals(input.AmountPaid))
                ) && 
                (
                    this.CardPayment == input.CardPayment ||
                    (this.CardPayment != null &&
                    this.CardPayment.Equals(input.CardPayment))
                ) && 
                (
                    this.DebitPayment == input.DebitPayment ||
                    (this.DebitPayment != null &&
                    this.DebitPayment.Equals(input.DebitPayment))
                ) && 
                (
                    this.FirmId == input.FirmId ||
                    (this.FirmId != null &&
                    this.FirmId.Equals(input.FirmId))
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    this.PaymentMethod.Equals(input.PaymentMethod)
                ) && 
                (
                    this.PaymentMethodDetail == input.PaymentMethodDetail ||
                    (this.PaymentMethodDetail != null &&
                    this.PaymentMethodDetail.Equals(input.PaymentMethodDetail))
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
                if (this.Artifacts != null)
                {
                    hashCode = (hashCode * 59) + this.Artifacts.GetHashCode();
                }
                if (this.PaymentId != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentId.GetHashCode();
                }
                if (this.AmountPaid != null)
                {
                    hashCode = (hashCode * 59) + this.AmountPaid.GetHashCode();
                }
                if (this.CardPayment != null)
                {
                    hashCode = (hashCode * 59) + this.CardPayment.GetHashCode();
                }
                if (this.DebitPayment != null)
                {
                    hashCode = (hashCode * 59) + this.DebitPayment.GetHashCode();
                }
                if (this.FirmId != null)
                {
                    hashCode = (hashCode * 59) + this.FirmId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PaymentMethod.GetHashCode();
                if (this.PaymentMethodDetail != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethodDetail.GetHashCode();
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
