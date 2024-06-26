/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.122
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
    /// TransactionsResponse
    /// </summary>
    [DataContract(Name = "TransactionsResponse")]
    public partial class TransactionsResponse : IEquatable<TransactionsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsResponse" /> class.
        /// </summary>
        /// <param name="transactions">transactions (required).</param>
        /// <param name="paginationMetadata">paginationMetadata.</param>
        public TransactionsResponse(List<Transaction> transactions = default(List<Transaction>), PaginationMetadata paginationMetadata = default(PaginationMetadata))
        {
            // to ensure "transactions" is required (not null)
            if (transactions == null)
            {
                throw new ArgumentNullException("transactions is a required property for TransactionsResponse and cannot be null");
            }
            this.Transactions = transactions;
            this.PaginationMetadata = paginationMetadata;
        }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name = "transactions", IsRequired = true, EmitDefaultValue = true)]
        public List<Transaction> Transactions { get; set; }

        /// <summary>
        /// Gets or Sets PaginationMetadata
        /// </summary>
        [DataMember(Name = "pagination_metadata", EmitDefaultValue = false)]
        public PaginationMetadata PaginationMetadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionsResponse {\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  PaginationMetadata: ").Append(PaginationMetadata).Append("\n");
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
            return this.Equals(input as TransactionsResponse);
        }

        /// <summary>
        /// Returns true if TransactionsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    input.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
                ) && 
                (
                    this.PaginationMetadata == input.PaginationMetadata ||
                    (this.PaginationMetadata != null &&
                    this.PaginationMetadata.Equals(input.PaginationMetadata))
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
                if (this.Transactions != null)
                {
                    hashCode = (hashCode * 59) + this.Transactions.GetHashCode();
                }
                if (this.PaginationMetadata != null)
                {
                    hashCode = (hashCode * 59) + this.PaginationMetadata.GetHashCode();
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
