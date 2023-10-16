/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.100
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
    /// WebhookList
    /// </summary>
    [DataContract(Name = "WebhookList")]
    public partial class WebhookList : IEquatable<WebhookList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookList()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookList" /> class.
        /// </summary>
        /// <param name="webhooks">webhooks (required).</param>
        public WebhookList(List<Webhook> webhooks = default(List<Webhook>))
        {
            // to ensure "webhooks" is required (not null)
            if (webhooks == null)
            {
                throw new ArgumentNullException("webhooks is a required property for WebhookList and cannot be null");
            }
            this.Webhooks = webhooks;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Webhooks
        /// </summary>
        [DataMember(Name = "webhooks", IsRequired = true, EmitDefaultValue = true)]
        public List<Webhook> Webhooks { get; set; }

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
            sb.Append("class WebhookList {\n");
            sb.Append("  Webhooks: ").Append(Webhooks).Append("\n");
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
            return this.Equals(input as WebhookList);
        }

        /// <summary>
        /// Returns true if WebhookList instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookList input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Webhooks == input.Webhooks ||
                    this.Webhooks != null &&
                    input.Webhooks != null &&
                    this.Webhooks.SequenceEqual(input.Webhooks)
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
                if (this.Webhooks != null)
                {
                    hashCode = (hashCode * 59) + this.Webhooks.GetHashCode();
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
