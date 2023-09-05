/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.84
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
    /// Describes a payment coming into the system (client of a firm paying an invoice, trust deposit, ...)
    /// </summary>
    [DataContract(Name = "Payment")]
    public partial class Payment : IEquatable<Payment>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets PaymentType
        /// </summary>
        [DataMember(Name = "payment_type", EmitDefaultValue = false)]
        public PaymentMethod? PaymentType { get; set; }

        /// <summary>
        /// Gets or Sets ArtifactType
        /// </summary>
        [DataMember(Name = "artifact_type", IsRequired = true, EmitDefaultValue = true)]
        public ArtifactType ArtifactType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Payment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Payment()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Payment" /> class.
        /// </summary>
        /// <param name="transactionId">The unique id of this single transaction in the payout. (required).</param>
        /// <param name="paymentId">The id of the payment. nb A single payment may contain multiple transactions and may not be unique. (required).</param>
        /// <param name="paymentType">paymentType.</param>
        /// <param name="artifactId">The artifact (Invoice, TrustDeposit, ...) the payment is in relation to. (required).</param>
        /// <param name="artifactType">artifactType (required).</param>
        /// <param name="externalId">This is the id of the artifact supplied by the channel partner / PMS..</param>
        /// <param name="externalPayment">externalPayment.</param>
        /// <param name="received">The amount received from the client..</param>
        /// <param name="refunded">The amount refunded (back to the client) against this payment..</param>
        /// <param name="paidOut">The total amount paid to the firm for this payment (required).</param>
        /// <param name="currency">The currency the payment was made in. (required).</param>
        /// <param name="date">When the payment was made. (required).</param>
        public Payment(Guid transactionId = default(Guid), Guid paymentId = default(Guid), PaymentMethod? paymentType = default(PaymentMethod?), Guid artifactId = default(Guid), ArtifactType artifactType = default(ArtifactType), string externalId = default(string), PaymentExternalPayment externalPayment = default(PaymentExternalPayment), string received = default(string), string refunded = default(string), string paidOut = default(string), string currency = default(string), DateTime date = default(DateTime))
        {
            this.TransactionId = transactionId;
            this.PaymentId = paymentId;
            this.ArtifactId = artifactId;
            this.ArtifactType = artifactType;
            // to ensure "paidOut" is required (not null)
            if (paidOut == null)
            {
                throw new ArgumentNullException("paidOut is a required property for Payment and cannot be null");
            }
            this.PaidOut = paidOut;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for Payment and cannot be null");
            }
            this.Currency = currency;
            this.Date = date;
            this.PaymentType = paymentType;
            this.ExternalId = externalId;
            this.ExternalPayment = externalPayment;
            this.Received = received;
            this.Refunded = refunded;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The unique id of this single transaction in the payout.
        /// </summary>
        /// <value>The unique id of this single transaction in the payout.</value>
        [DataMember(Name = "transaction_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid TransactionId { get; set; }

        /// <summary>
        /// The id of the payment. nb A single payment may contain multiple transactions and may not be unique.
        /// </summary>
        /// <value>The id of the payment. nb A single payment may contain multiple transactions and may not be unique.</value>
        [DataMember(Name = "payment_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid PaymentId { get; set; }

        /// <summary>
        /// The artifact (Invoice, TrustDeposit, ...) the payment is in relation to.
        /// </summary>
        /// <value>The artifact (Invoice, TrustDeposit, ...) the payment is in relation to.</value>
        [DataMember(Name = "artifact_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid ArtifactId { get; set; }

        /// <summary>
        /// This is the id of the artifact supplied by the channel partner / PMS.
        /// </summary>
        /// <value>This is the id of the artifact supplied by the channel partner / PMS.</value>
        [DataMember(Name = "external_id", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets ExternalPayment
        /// </summary>
        [DataMember(Name = "external_payment", EmitDefaultValue = false)]
        public PaymentExternalPayment ExternalPayment { get; set; }

        /// <summary>
        /// The amount received from the client.
        /// </summary>
        /// <value>The amount received from the client.</value>
        [DataMember(Name = "received", EmitDefaultValue = false)]
        public string Received { get; set; }

        /// <summary>
        /// The amount refunded (back to the client) against this payment.
        /// </summary>
        /// <value>The amount refunded (back to the client) against this payment.</value>
        [DataMember(Name = "refunded", EmitDefaultValue = false)]
        public string Refunded { get; set; }

        /// <summary>
        /// The total amount paid to the firm for this payment
        /// </summary>
        /// <value>The total amount paid to the firm for this payment</value>
        [DataMember(Name = "paid_out", IsRequired = true, EmitDefaultValue = true)]
        public string PaidOut { get; set; }

        /// <summary>
        /// The currency the payment was made in.
        /// </summary>
        /// <value>The currency the payment was made in.</value>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// When the payment was made.
        /// </summary>
        /// <value>When the payment was made.</value>
        [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Date { get; set; }

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
            sb.Append("class Payment {\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  ArtifactId: ").Append(ArtifactId).Append("\n");
            sb.Append("  ArtifactType: ").Append(ArtifactType).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  ExternalPayment: ").Append(ExternalPayment).Append("\n");
            sb.Append("  Received: ").Append(Received).Append("\n");
            sb.Append("  Refunded: ").Append(Refunded).Append("\n");
            sb.Append("  PaidOut: ").Append(PaidOut).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return this.Equals(input as Payment);
        }

        /// <summary>
        /// Returns true if Payment instances are equal
        /// </summary>
        /// <param name="input">Instance of Payment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Payment input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.PaymentId == input.PaymentId ||
                    (this.PaymentId != null &&
                    this.PaymentId.Equals(input.PaymentId))
                ) && 
                (
                    this.PaymentType == input.PaymentType ||
                    this.PaymentType.Equals(input.PaymentType)
                ) && 
                (
                    this.ArtifactId == input.ArtifactId ||
                    (this.ArtifactId != null &&
                    this.ArtifactId.Equals(input.ArtifactId))
                ) && 
                (
                    this.ArtifactType == input.ArtifactType ||
                    this.ArtifactType.Equals(input.ArtifactType)
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.ExternalPayment == input.ExternalPayment ||
                    (this.ExternalPayment != null &&
                    this.ExternalPayment.Equals(input.ExternalPayment))
                ) && 
                (
                    this.Received == input.Received ||
                    (this.Received != null &&
                    this.Received.Equals(input.Received))
                ) && 
                (
                    this.Refunded == input.Refunded ||
                    (this.Refunded != null &&
                    this.Refunded.Equals(input.Refunded))
                ) && 
                (
                    this.PaidOut == input.PaidOut ||
                    (this.PaidOut != null &&
                    this.PaidOut.Equals(input.PaidOut))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
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
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
                }
                if (this.PaymentId != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PaymentType.GetHashCode();
                if (this.ArtifactId != null)
                {
                    hashCode = (hashCode * 59) + this.ArtifactId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ArtifactType.GetHashCode();
                if (this.ExternalId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalId.GetHashCode();
                }
                if (this.ExternalPayment != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalPayment.GetHashCode();
                }
                if (this.Received != null)
                {
                    hashCode = (hashCode * 59) + this.Received.GetHashCode();
                }
                if (this.Refunded != null)
                {
                    hashCode = (hashCode * 59) + this.Refunded.GetHashCode();
                }
                if (this.PaidOut != null)
                {
                    hashCode = (hashCode * 59) + this.PaidOut.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
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
