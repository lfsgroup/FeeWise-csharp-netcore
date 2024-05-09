/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.115
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
    /// EventFilters
    /// </summary>
    [DataContract(Name = "EventFilters")]
    public partial class EventFilters : IEquatable<EventFilters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventFilters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EventFilters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventFilters" /> class.
        /// </summary>
        /// <param name="status">status (required).</param>
        /// <param name="topic">topic (required).</param>
        /// <param name="since">since (required).</param>
        public EventFilters(string status = default(string), string topic = default(string), DateTime since = default(DateTime))
        {
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for EventFilters and cannot be null");
            }
            this.Status = status;
            // to ensure "topic" is required (not null)
            if (topic == null)
            {
                throw new ArgumentNullException("topic is a required property for EventFilters and cannot be null");
            }
            this.Topic = topic;
            this.Since = since;
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Topic
        /// </summary>
        [DataMember(Name = "topic", IsRequired = true, EmitDefaultValue = true)]
        public string Topic { get; set; }

        /// <summary>
        /// Gets or Sets Since
        /// </summary>
        [DataMember(Name = "since", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Since { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EventFilters {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Topic: ").Append(Topic).Append("\n");
            sb.Append("  Since: ").Append(Since).Append("\n");
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
            return this.Equals(input as EventFilters);
        }

        /// <summary>
        /// Returns true if EventFilters instances are equal
        /// </summary>
        /// <param name="input">Instance of EventFilters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventFilters input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Topic == input.Topic ||
                    (this.Topic != null &&
                    this.Topic.Equals(input.Topic))
                ) && 
                (
                    this.Since == input.Since ||
                    (this.Since != null &&
                    this.Since.Equals(input.Since))
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
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Topic != null)
                {
                    hashCode = (hashCode * 59) + this.Topic.GetHashCode();
                }
                if (this.Since != null)
                {
                    hashCode = (hashCode * 59) + this.Since.GetHashCode();
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
