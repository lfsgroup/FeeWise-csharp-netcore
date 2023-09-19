/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.88
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
    /// PostFirmBrandingColourRequest
    /// </summary>
    [DataContract(Name = "postFirmBrandingColour_request")]
    public partial class PostFirmBrandingColourRequest : IEquatable<PostFirmBrandingColourRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostFirmBrandingColourRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostFirmBrandingColourRequest()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostFirmBrandingColourRequest" /> class.
        /// </summary>
        /// <param name="colour">RGB hex colour code. Alpha channel not supported The branding will be used in the FeeWise firm dashboard  (required).</param>
        public PostFirmBrandingColourRequest(string colour = default(string))
        {
            // to ensure "colour" is required (not null)
            if (colour == null)
            {
                throw new ArgumentNullException("colour is a required property for PostFirmBrandingColourRequest and cannot be null");
            }
            this.Colour = colour;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// RGB hex colour code. Alpha channel not supported The branding will be used in the FeeWise firm dashboard 
        /// </summary>
        /// <value>RGB hex colour code. Alpha channel not supported The branding will be used in the FeeWise firm dashboard </value>
        [DataMember(Name = "colour", IsRequired = true, EmitDefaultValue = true)]
        public string Colour { get; set; }

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
            sb.Append("class PostFirmBrandingColourRequest {\n");
            sb.Append("  Colour: ").Append(Colour).Append("\n");
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
            return this.Equals(input as PostFirmBrandingColourRequest);
        }

        /// <summary>
        /// Returns true if PostFirmBrandingColourRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PostFirmBrandingColourRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostFirmBrandingColourRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Colour == input.Colour ||
                    (this.Colour != null &&
                    this.Colour.Equals(input.Colour))
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
                if (this.Colour != null)
                {
                    hashCode = (hashCode * 59) + this.Colour.GetHashCode();
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
            // Colour (string) pattern
            Regex regexColour = new Regex(@"^#([a-fA-F0-9]{6})$", RegexOptions.CultureInvariant);
            if (false == regexColour.Match(this.Colour).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Colour, must match a pattern of " + regexColour, new [] { "Colour" });
            }

            yield break;
        }
    }

}
