/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.96
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
    /// CardPayment
    /// </summary>
    [DataContract(Name = "CardPayment")]
    public partial class CardPayment : IEquatable<CardPayment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardPayment" /> class.
        /// </summary>
        /// <param name="scheme">Card scheme (e.g. Visa, Mastercard).</param>
        /// <param name="schemePartialNumber">Partial card number.</param>
        /// <param name="fundingType">Funding type (e.g. credit, debit).</param>
        /// <param name="country">Country code (e.g. US, CA).</param>
        /// <param name="expirationDate">expirationDate.</param>
        public CardPayment(string scheme = default(string), string schemePartialNumber = default(string), string fundingType = default(string), string country = default(string), DateTime expirationDate = default(DateTime))
        {
            this.Scheme = scheme;
            this.SchemePartialNumber = schemePartialNumber;
            this.FundingType = fundingType;
            this.Country = country;
            this.ExpirationDate = expirationDate;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Card scheme (e.g. Visa, Mastercard)
        /// </summary>
        /// <value>Card scheme (e.g. Visa, Mastercard)</value>
        [DataMember(Name = "scheme", EmitDefaultValue = false)]
        public string Scheme { get; set; }

        /// <summary>
        /// Partial card number
        /// </summary>
        /// <value>Partial card number</value>
        [DataMember(Name = "scheme_partial_number", EmitDefaultValue = false)]
        public string SchemePartialNumber { get; set; }

        /// <summary>
        /// Funding type (e.g. credit, debit)
        /// </summary>
        /// <value>Funding type (e.g. credit, debit)</value>
        [DataMember(Name = "funding_type", EmitDefaultValue = false)]
        public string FundingType { get; set; }

        /// <summary>
        /// Country code (e.g. US, CA)
        /// </summary>
        /// <value>Country code (e.g. US, CA)</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name = "expiration_date", EmitDefaultValue = false)]
        public DateTime ExpirationDate { get; set; }

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
            sb.Append("class CardPayment {\n");
            sb.Append("  Scheme: ").Append(Scheme).Append("\n");
            sb.Append("  SchemePartialNumber: ").Append(SchemePartialNumber).Append("\n");
            sb.Append("  FundingType: ").Append(FundingType).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
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
            return this.Equals(input as CardPayment);
        }

        /// <summary>
        /// Returns true if CardPayment instances are equal
        /// </summary>
        /// <param name="input">Instance of CardPayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardPayment input)
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
                    this.SchemePartialNumber == input.SchemePartialNumber ||
                    (this.SchemePartialNumber != null &&
                    this.SchemePartialNumber.Equals(input.SchemePartialNumber))
                ) && 
                (
                    this.FundingType == input.FundingType ||
                    (this.FundingType != null &&
                    this.FundingType.Equals(input.FundingType))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
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
                if (this.Scheme != null)
                {
                    hashCode = (hashCode * 59) + this.Scheme.GetHashCode();
                }
                if (this.SchemePartialNumber != null)
                {
                    hashCode = (hashCode * 59) + this.SchemePartialNumber.GetHashCode();
                }
                if (this.FundingType != null)
                {
                    hashCode = (hashCode * 59) + this.FundingType.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.ExpirationDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExpirationDate.GetHashCode();
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
