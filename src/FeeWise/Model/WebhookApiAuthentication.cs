/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.121
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
    /// WebhookApiAuthentication
    /// </summary>
    [DataContract(Name = "WebhookApiAuthentication")]
    public partial class WebhookApiAuthentication : IEquatable<WebhookApiAuthentication>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookApiAuthentication" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookApiAuthentication() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookApiAuthentication" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="addPosition">addPosition.</param>
        /// <param name="data">Either \&quot;username\&quot; and \&quot;password\&quot; or \&quot;token\&quot; keys (required).</param>
        public WebhookApiAuthentication(string type = default(string), string addPosition = default(string), Dictionary<string, string> data = default(Dictionary<string, string>))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for WebhookApiAuthentication and cannot be null");
            }
            this.Type = type;
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for WebhookApiAuthentication and cannot be null");
            }
            this.Data = data;
            this.AddPosition = addPosition;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets AddPosition
        /// </summary>
        [DataMember(Name = "add_position", EmitDefaultValue = false)]
        public string AddPosition { get; set; }

        /// <summary>
        /// Either \&quot;username\&quot; and \&quot;password\&quot; or \&quot;token\&quot; keys
        /// </summary>
        /// <value>Either \&quot;username\&quot; and \&quot;password\&quot; or \&quot;token\&quot; keys</value>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookApiAuthentication {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AddPosition: ").Append(AddPosition).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as WebhookApiAuthentication);
        }

        /// <summary>
        /// Returns true if WebhookApiAuthentication instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookApiAuthentication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookApiAuthentication input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.AddPosition == input.AddPosition ||
                    (this.AddPosition != null &&
                    this.AddPosition.Equals(input.AddPosition))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.AddPosition != null)
                {
                    hashCode = (hashCode * 59) + this.AddPosition.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
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
