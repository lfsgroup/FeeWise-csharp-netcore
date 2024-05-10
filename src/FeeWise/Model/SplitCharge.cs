/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.117
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
    /// A Split Charge enables a single payment to be distributed among multiple firm bank accounts. nb: Either the settlement_account_type or the settlement_account_id must be provided in each charge but not both. 
    /// </summary>
    [DataContract(Name = "SplitCharge")]
    public partial class SplitCharge : IEquatable<SplitCharge>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SplitCharge" /> class.
        /// </summary>
        /// <param name="splitChargeId">This is the uuid of the charge. This will be used for a &#39;GET&#39; of the split charge and in webhooks about this split charge. NB: this is generated and must NOT be supplied when creating a split charge. .</param>
        /// <param name="firmId">The firm the charge is being created for..</param>
        /// <param name="amount">The total amount the split charge is for. This amount should match the total for each charge being split..</param>
        /// <param name="matter">matter.</param>
        /// <param name="debtor">debtor.</param>
        /// <param name="charges">charges.</param>
        /// <param name="description">Description of the split charge..</param>
        /// <param name="paymentUri">The URI to allow the end user to pay the split charges..</param>
        /// <param name="metadata">Set of key value pairs that you can attach to an object. Useful for storing additional information about the object in a structured format..</param>
        public SplitCharge(Guid splitChargeId = default(Guid), Guid firmId = default(Guid), string amount = default(string), Matter matter = default(Matter), Debtor debtor = default(Debtor), List<Charge> charges = default(List<Charge>), string description = default(string), string paymentUri = default(string), Dictionary<string, string> metadata = default(Dictionary<string, string>))
        {
            this.SplitChargeId = splitChargeId;
            this.FirmId = firmId;
            this.Amount = amount;
            this.Matter = matter;
            this.Debtor = debtor;
            this.Charges = charges;
            this.Description = description;
            this.PaymentUri = paymentUri;
            this.Metadata = metadata;
        }

        /// <summary>
        /// This is the uuid of the charge. This will be used for a &#39;GET&#39; of the split charge and in webhooks about this split charge. NB: this is generated and must NOT be supplied when creating a split charge. 
        /// </summary>
        /// <value>This is the uuid of the charge. This will be used for a &#39;GET&#39; of the split charge and in webhooks about this split charge. NB: this is generated and must NOT be supplied when creating a split charge. </value>
        [DataMember(Name = "split_charge_id", EmitDefaultValue = false)]
        public Guid SplitChargeId { get; set; }

        /// <summary>
        /// The firm the charge is being created for.
        /// </summary>
        /// <value>The firm the charge is being created for.</value>
        [DataMember(Name = "firm_id", EmitDefaultValue = false)]
        public Guid FirmId { get; set; }

        /// <summary>
        /// The total amount the split charge is for. This amount should match the total for each charge being split.
        /// </summary>
        /// <value>The total amount the split charge is for. This amount should match the total for each charge being split.</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

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
        /// Gets or Sets Charges
        /// </summary>
        [DataMember(Name = "charges", EmitDefaultValue = false)]
        public List<Charge> Charges { get; set; }

        /// <summary>
        /// Description of the split charge.
        /// </summary>
        /// <value>Description of the split charge.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The URI to allow the end user to pay the split charges.
        /// </summary>
        /// <value>The URI to allow the end user to pay the split charges.</value>
        [DataMember(Name = "payment_uri", EmitDefaultValue = false)]
        public string PaymentUri { get; set; }

        /// <summary>
        /// Set of key value pairs that you can attach to an object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of key value pairs that you can attach to an object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SplitCharge {\n");
            sb.Append("  SplitChargeId: ").Append(SplitChargeId).Append("\n");
            sb.Append("  FirmId: ").Append(FirmId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Matter: ").Append(Matter).Append("\n");
            sb.Append("  Debtor: ").Append(Debtor).Append("\n");
            sb.Append("  Charges: ").Append(Charges).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PaymentUri: ").Append(PaymentUri).Append("\n");
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
            return this.Equals(input as SplitCharge);
        }

        /// <summary>
        /// Returns true if SplitCharge instances are equal
        /// </summary>
        /// <param name="input">Instance of SplitCharge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SplitCharge input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SplitChargeId == input.SplitChargeId ||
                    (this.SplitChargeId != null &&
                    this.SplitChargeId.Equals(input.SplitChargeId))
                ) && 
                (
                    this.FirmId == input.FirmId ||
                    (this.FirmId != null &&
                    this.FirmId.Equals(input.FirmId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                    this.Charges == input.Charges ||
                    this.Charges != null &&
                    input.Charges != null &&
                    this.Charges.SequenceEqual(input.Charges)
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
                if (this.SplitChargeId != null)
                {
                    hashCode = (hashCode * 59) + this.SplitChargeId.GetHashCode();
                }
                if (this.FirmId != null)
                {
                    hashCode = (hashCode * 59) + this.FirmId.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.Matter != null)
                {
                    hashCode = (hashCode * 59) + this.Matter.GetHashCode();
                }
                if (this.Debtor != null)
                {
                    hashCode = (hashCode * 59) + this.Debtor.GetHashCode();
                }
                if (this.Charges != null)
                {
                    hashCode = (hashCode * 59) + this.Charges.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.PaymentUri != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentUri.GetHashCode();
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
