/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.72
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
    /// EventTopics
    /// </summary>
    [DataContract(Name = "EventTopics")]
    public partial class EventTopics : IEquatable<EventTopics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventTopics" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EventTopics()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventTopics" /> class.
        /// </summary>
        /// <param name="eventTopics">eventTopics (required).</param>
        public EventTopics(List<string> eventTopics = default(List<string>))
        {
            // to ensure "eventTopics" is required (not null)
            if (eventTopics == null)
            {
                throw new ArgumentNullException("eventTopics is a required property for EventTopics and cannot be null");
            }
            this._EventTopics = eventTopics;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets _EventTopics
        /// </summary>
        [DataMember(Name = "event_topics", IsRequired = true, EmitDefaultValue = true)]
        public List<string> _EventTopics { get; set; }

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
            sb.Append("class EventTopics {\n");
            sb.Append("  _EventTopics: ").Append(_EventTopics).Append("\n");
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
            return this.Equals(input as EventTopics);
        }

        /// <summary>
        /// Returns true if EventTopics instances are equal
        /// </summary>
        /// <param name="input">Instance of EventTopics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventTopics input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._EventTopics == input._EventTopics ||
                    this._EventTopics != null &&
                    input._EventTopics != null &&
                    this._EventTopics.SequenceEqual(input._EventTopics)
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
                if (this._EventTopics != null)
                {
                    hashCode = (hashCode * 59) + this._EventTopics.GetHashCode();
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
