/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.80
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
    /// CustomersResponse
    /// </summary>
    [DataContract(Name = "CustomersResponse")]
    public partial class CustomersResponse : IEquatable<CustomersResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomersResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomersResponse()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomersResponse" /> class.
        /// </summary>
        /// <param name="customers">customers (required).</param>
        public CustomersResponse(List<CustomerDetails> customers = default(List<CustomerDetails>))
        {
            // to ensure "customers" is required (not null)
            if (customers == null)
            {
                throw new ArgumentNullException("customers is a required property for CustomersResponse and cannot be null");
            }
            this.Customers = customers;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Customers
        /// </summary>
        [DataMember(Name = "customers", IsRequired = true, EmitDefaultValue = true)]
        public List<CustomerDetails> Customers { get; set; }

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
            sb.Append("class CustomersResponse {\n");
            sb.Append("  Customers: ").Append(Customers).Append("\n");
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
            return this.Equals(input as CustomersResponse);
        }

        /// <summary>
        /// Returns true if CustomersResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomersResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomersResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Customers == input.Customers ||
                    this.Customers != null &&
                    input.Customers != null &&
                    this.Customers.SequenceEqual(input.Customers)
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
                if (this.Customers != null)
                {
                    hashCode = (hashCode * 59) + this.Customers.GetHashCode();
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
