/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.109
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
    /// CustomerPaymentMethod
    /// </summary>
    [DataContract(Name = "CustomerPaymentMethod")]
    public partial class CustomerPaymentMethod : IEquatable<CustomerPaymentMethod>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "payment_method", EmitDefaultValue = false)]
        public PaymentMethod? PaymentMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerPaymentMethod" /> class.
        /// </summary>
        /// <param name="paymentToken">The unique ID for this customer&#39;s payment method, this can be used to charge the associated customer.</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="card">card.</param>
        /// <param name="debit">debit.</param>
        public CustomerPaymentMethod(Guid paymentToken = default(Guid), PaymentMethod? paymentMethod = default(PaymentMethod?), CardPayment card = default(CardPayment), DebitPayment debit = default(DebitPayment))
        {
            this.PaymentToken = paymentToken;
            this.PaymentMethod = paymentMethod;
            this.Card = card;
            this.Debit = debit;
        }

        /// <summary>
        /// The unique ID for this customer&#39;s payment method, this can be used to charge the associated customer
        /// </summary>
        /// <value>The unique ID for this customer&#39;s payment method, this can be used to charge the associated customer</value>
        [DataMember(Name = "payment_token", EmitDefaultValue = false)]
        public Guid PaymentToken { get; set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name = "card", EmitDefaultValue = false)]
        public CardPayment Card { get; set; }

        /// <summary>
        /// Gets or Sets Debit
        /// </summary>
        [DataMember(Name = "debit", EmitDefaultValue = false)]
        public DebitPayment Debit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerPaymentMethod {\n");
            sb.Append("  PaymentToken: ").Append(PaymentToken).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  Debit: ").Append(Debit).Append("\n");
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
            return this.Equals(input as CustomerPaymentMethod);
        }

        /// <summary>
        /// Returns true if CustomerPaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerPaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerPaymentMethod input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PaymentToken == input.PaymentToken ||
                    (this.PaymentToken != null &&
                    this.PaymentToken.Equals(input.PaymentToken))
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    this.PaymentMethod.Equals(input.PaymentMethod)
                ) && 
                (
                    this.Card == input.Card ||
                    (this.Card != null &&
                    this.Card.Equals(input.Card))
                ) && 
                (
                    this.Debit == input.Debit ||
                    (this.Debit != null &&
                    this.Debit.Equals(input.Debit))
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
                if (this.PaymentToken != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentToken.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PaymentMethod.GetHashCode();
                if (this.Card != null)
                {
                    hashCode = (hashCode * 59) + this.Card.GetHashCode();
                }
                if (this.Debit != null)
                {
                    hashCode = (hashCode * 59) + this.Debit.GetHashCode();
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
