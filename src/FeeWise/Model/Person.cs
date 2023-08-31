/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.77
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
    /// Person
    /// </summary>
    [DataContract(Name = "Person")]
    public partial class Person : IEquatable<Person>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person" /> class.
        /// </summary>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="title">title.</param>
        /// <param name="phone">phone.</param>
        /// <param name="nationalId">nationalId.</param>
        /// <param name="email">email.</param>
        /// <param name="address">address.</param>
        /// <param name="dateOfBirth">dateOfBirth.</param>
        /// <param name="isExecutive">Indicates if the individual bears substantial responsibility for controlling, managing, or directing the organization..</param>
        /// <param name="isRepresentative">Representative refers to the designated primary representative of the account, authorized by the business to provide both personal information about themselves and general details about the account. It is essential to note that there can only be one representative assigned to the account at any given time, and during the account creation, this role is typically assigned to the individual responsible for opening the account..</param>
        /// <param name="ownershipPercentage">The percent owned of firm&#39;s legal entity owned by the person..</param>
        /// <param name="ssnLast4">The last four digits of the person&#39;s Social Security number, US only.</param>
        public Person(string firstName = default(string), string lastName = default(string), string title = default(string), string phone = default(string), string nationalId = default(string), string email = default(string), Address address = default(Address), DateTime dateOfBirth = default(DateTime), bool isExecutive = default(bool), bool isRepresentative = default(bool), string ownershipPercentage = default(string), string ssnLast4 = default(string))
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Title = title;
            this.Phone = phone;
            this.NationalId = nationalId;
            this.Email = email;
            this.Address = address;
            this.DateOfBirth = dateOfBirth;
            this.IsExecutive = isExecutive;
            this.IsRepresentative = isRepresentative;
            this.OwnershipPercentage = ownershipPercentage;
            this.SsnLast4 = ssnLast4;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "first_name", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "last_name", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets NationalId
        /// </summary>
        [DataMember(Name = "national_id", EmitDefaultValue = false)]
        public string NationalId { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public Address Address { get; set; }

        /// <summary>
        /// Gets or Sets DateOfBirth
        /// </summary>
        [DataMember(Name = "date_of_birth", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Indicates if the individual bears substantial responsibility for controlling, managing, or directing the organization.
        /// </summary>
        /// <value>Indicates if the individual bears substantial responsibility for controlling, managing, or directing the organization.</value>
        [DataMember(Name = "is_executive", EmitDefaultValue = true)]
        public bool IsExecutive { get; set; }

        /// <summary>
        /// Representative refers to the designated primary representative of the account, authorized by the business to provide both personal information about themselves and general details about the account. It is essential to note that there can only be one representative assigned to the account at any given time, and during the account creation, this role is typically assigned to the individual responsible for opening the account.
        /// </summary>
        /// <value>Representative refers to the designated primary representative of the account, authorized by the business to provide both personal information about themselves and general details about the account. It is essential to note that there can only be one representative assigned to the account at any given time, and during the account creation, this role is typically assigned to the individual responsible for opening the account.</value>
        [DataMember(Name = "is_representative", EmitDefaultValue = true)]
        public bool IsRepresentative { get; set; }

        /// <summary>
        /// The percent owned of firm&#39;s legal entity owned by the person.
        /// </summary>
        /// <value>The percent owned of firm&#39;s legal entity owned by the person.</value>
        [DataMember(Name = "ownership_percentage", EmitDefaultValue = false)]
        public string OwnershipPercentage { get; set; }

        /// <summary>
        /// The last four digits of the person&#39;s Social Security number, US only
        /// </summary>
        /// <value>The last four digits of the person&#39;s Social Security number, US only</value>
        [DataMember(Name = "ssn_last_4", EmitDefaultValue = false)]
        public string SsnLast4 { get; set; }

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
            sb.Append("class Person {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  NationalId: ").Append(NationalId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  IsExecutive: ").Append(IsExecutive).Append("\n");
            sb.Append("  IsRepresentative: ").Append(IsRepresentative).Append("\n");
            sb.Append("  OwnershipPercentage: ").Append(OwnershipPercentage).Append("\n");
            sb.Append("  SsnLast4: ").Append(SsnLast4).Append("\n");
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
            return this.Equals(input as Person);
        }

        /// <summary>
        /// Returns true if Person instances are equal
        /// </summary>
        /// <param name="input">Instance of Person to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Person input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.NationalId == input.NationalId ||
                    (this.NationalId != null &&
                    this.NationalId.Equals(input.NationalId))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) && 
                (
                    this.IsExecutive == input.IsExecutive ||
                    this.IsExecutive.Equals(input.IsExecutive)
                ) && 
                (
                    this.IsRepresentative == input.IsRepresentative ||
                    this.IsRepresentative.Equals(input.IsRepresentative)
                ) && 
                (
                    this.OwnershipPercentage == input.OwnershipPercentage ||
                    (this.OwnershipPercentage != null &&
                    this.OwnershipPercentage.Equals(input.OwnershipPercentage))
                ) && 
                (
                    this.SsnLast4 == input.SsnLast4 ||
                    (this.SsnLast4 != null &&
                    this.SsnLast4.Equals(input.SsnLast4))
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
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.NationalId != null)
                {
                    hashCode = (hashCode * 59) + this.NationalId.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.DateOfBirth != null)
                {
                    hashCode = (hashCode * 59) + this.DateOfBirth.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsExecutive.GetHashCode();
                hashCode = (hashCode * 59) + this.IsRepresentative.GetHashCode();
                if (this.OwnershipPercentage != null)
                {
                    hashCode = (hashCode * 59) + this.OwnershipPercentage.GetHashCode();
                }
                if (this.SsnLast4 != null)
                {
                    hashCode = (hashCode * 59) + this.SsnLast4.GetHashCode();
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
