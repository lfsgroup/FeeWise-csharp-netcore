/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.82
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
    /// Event
    /// </summary>
    [DataContract(Name = "Event")]
    public partial class Event : IEquatable<Event>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public WebhookSendStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Event()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        /// <param name="webhookEventId">webhookEventId (required).</param>
        /// <param name="externalId">The id of the firm the webhook was related to. (required).</param>
        /// <param name="topic">The topic of the event. (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="payload">The webhooks payload and metadata about how and when the data was sent. (required).</param>
        /// <param name="sentAt">The timestamp the webhook send was attempted. (required).</param>
        public Event(Guid webhookEventId = default(Guid), string externalId = default(string), string topic = default(string), WebhookSendStatus status = default(WebhookSendStatus), Dictionary<string, Object> payload = default(Dictionary<string, Object>), DateTime sentAt = default(DateTime))
        {
            this.WebhookEventId = webhookEventId;
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new ArgumentNullException("externalId is a required property for Event and cannot be null");
            }
            this.ExternalId = externalId;
            // to ensure "topic" is required (not null)
            if (topic == null)
            {
                throw new ArgumentNullException("topic is a required property for Event and cannot be null");
            }
            this.Topic = topic;
            this.Status = status;
            // to ensure "payload" is required (not null)
            if (payload == null)
            {
                throw new ArgumentNullException("payload is a required property for Event and cannot be null");
            }
            this.Payload = payload;
            this.SentAt = sentAt;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets WebhookEventId
        /// </summary>
        [DataMember(Name = "webhook_event_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid WebhookEventId { get; set; }

        /// <summary>
        /// The id of the firm the webhook was related to.
        /// </summary>
        /// <value>The id of the firm the webhook was related to.</value>
        [DataMember(Name = "externalId", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The topic of the event.
        /// </summary>
        /// <value>The topic of the event.</value>
        [DataMember(Name = "topic", IsRequired = true, EmitDefaultValue = true)]
        public string Topic { get; set; }

        /// <summary>
        /// The webhooks payload and metadata about how and when the data was sent.
        /// </summary>
        /// <value>The webhooks payload and metadata about how and when the data was sent.</value>
        [DataMember(Name = "payload", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> Payload { get; set; }

        /// <summary>
        /// The timestamp the webhook send was attempted.
        /// </summary>
        /// <value>The timestamp the webhook send was attempted.</value>
        [DataMember(Name = "sent_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime SentAt { get; set; }

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
            sb.Append("class Event {\n");
            sb.Append("  WebhookEventId: ").Append(WebhookEventId).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Topic: ").Append(Topic).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  SentAt: ").Append(SentAt).Append("\n");
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
            return this.Equals(input as Event);
        }

        /// <summary>
        /// Returns true if Event instances are equal
        /// </summary>
        /// <param name="input">Instance of Event to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Event input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.WebhookEventId == input.WebhookEventId ||
                    (this.WebhookEventId != null &&
                    this.WebhookEventId.Equals(input.WebhookEventId))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Topic == input.Topic ||
                    (this.Topic != null &&
                    this.Topic.Equals(input.Topic))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Payload == input.Payload ||
                    this.Payload != null &&
                    input.Payload != null &&
                    this.Payload.SequenceEqual(input.Payload)
                ) && 
                (
                    this.SentAt == input.SentAt ||
                    (this.SentAt != null &&
                    this.SentAt.Equals(input.SentAt))
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
                if (this.WebhookEventId != null)
                {
                    hashCode = (hashCode * 59) + this.WebhookEventId.GetHashCode();
                }
                if (this.ExternalId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalId.GetHashCode();
                }
                if (this.Topic != null)
                {
                    hashCode = (hashCode * 59) + this.Topic.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Payload != null)
                {
                    hashCode = (hashCode * 59) + this.Payload.GetHashCode();
                }
                if (this.SentAt != null)
                {
                    hashCode = (hashCode * 59) + this.SentAt.GetHashCode();
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
