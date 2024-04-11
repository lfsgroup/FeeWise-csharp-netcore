/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.113
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
    /// Webhook
    /// </summary>
    [DataContract(Name = "Webhook")]
    public partial class Webhook : IEquatable<Webhook>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public WebhookStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Webhook" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Webhook() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Webhook" /> class.
        /// </summary>
        /// <param name="webhookId">webhookId.</param>
        /// <param name="partyId">partyId (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="url">url (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="events">events (required).</param>
        /// <param name="authentication">authentication (required).</param>
        public Webhook(Guid webhookId = default(Guid), Guid partyId = default(Guid), string name = default(string), string description = default(string), string url = default(string), WebhookStatus status = default(WebhookStatus), List<string> events = default(List<string>), WebhookApiAuthentication authentication = default(WebhookApiAuthentication))
        {
            this.PartyId = partyId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Webhook and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for Webhook and cannot be null");
            }
            this.Description = description;
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for Webhook and cannot be null");
            }
            this.Url = url;
            this.Status = status;
            // to ensure "events" is required (not null)
            if (events == null)
            {
                throw new ArgumentNullException("events is a required property for Webhook and cannot be null");
            }
            this.Events = events;
            // to ensure "authentication" is required (not null)
            if (authentication == null)
            {
                throw new ArgumentNullException("authentication is a required property for Webhook and cannot be null");
            }
            this.Authentication = authentication;
            this.WebhookId = webhookId;
        }

        /// <summary>
        /// Gets or Sets WebhookId
        /// </summary>
        [DataMember(Name = "webhook_id", EmitDefaultValue = false)]
        public Guid WebhookId { get; set; }

        /// <summary>
        /// Gets or Sets PartyId
        /// </summary>
        [DataMember(Name = "party_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid PartyId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "events", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Events { get; set; }

        /// <summary>
        /// Gets or Sets Authentication
        /// </summary>
        [DataMember(Name = "authentication", IsRequired = true, EmitDefaultValue = true)]
        public WebhookApiAuthentication Authentication { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Webhook {\n");
            sb.Append("  WebhookId: ").Append(WebhookId).Append("\n");
            sb.Append("  PartyId: ").Append(PartyId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Authentication: ").Append(Authentication).Append("\n");
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
            return this.Equals(input as Webhook);
        }

        /// <summary>
        /// Returns true if Webhook instances are equal
        /// </summary>
        /// <param name="input">Instance of Webhook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Webhook input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.WebhookId == input.WebhookId ||
                    (this.WebhookId != null &&
                    this.WebhookId.Equals(input.WebhookId))
                ) && 
                (
                    this.PartyId == input.PartyId ||
                    (this.PartyId != null &&
                    this.PartyId.Equals(input.PartyId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.Authentication == input.Authentication ||
                    (this.Authentication != null &&
                    this.Authentication.Equals(input.Authentication))
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
                if (this.WebhookId != null)
                {
                    hashCode = (hashCode * 59) + this.WebhookId.GetHashCode();
                }
                if (this.PartyId != null)
                {
                    hashCode = (hashCode * 59) + this.PartyId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Events != null)
                {
                    hashCode = (hashCode * 59) + this.Events.GetHashCode();
                }
                if (this.Authentication != null)
                {
                    hashCode = (hashCode * 59) + this.Authentication.GetHashCode();
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
