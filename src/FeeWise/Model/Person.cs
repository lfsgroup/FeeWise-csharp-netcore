/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.103
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
        [JsonConstructorAttribute]
        protected Person()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Person" /> class.
        /// </summary>
        /// <param name="personId">personId.</param>
        /// <param name="firstName">firstName (required).</param>
        /// <param name="middleName">middleName.</param>
        /// <param name="lastName">lastName (required).</param>
        /// <param name="title">title (required).</param>
        /// <param name="phone">phone.</param>
        /// <param name="nationalId">This field may be required to be populated, depending on the region.  For the US , this is the social security number, and is required. For CA, this is the social insurance number. .</param>
        /// <param name="email">email (required).</param>
        /// <param name="address">address (required).</param>
        /// <param name="dateOfBirth">dateOfBirth (required).</param>
        /// <param name="isExecutive">Indicates if the individual bears substantial responsibility for controlling, managing, or directing the organization. (required).</param>
        /// <param name="isRepresentative">Representative refers to the designated primary representative of the account, authorized by the business to provide both personal information about themselves and general details about the account. It is essential to note that there can only be one representative assigned to the account at any given time, and during the account creation, this role is typically assigned to the individual responsible for opening the account. (required).</param>
        /// <param name="ownershipPercentage">The percent owned of firm&#39;s legal entity owned by the person. (required).</param>
        /// <param name="ssnLast4">The last four digits of the person&#39;s Social Security number, US only.</param>
        public Person(Guid personId = default(Guid), string firstName = default(string), string middleName = default(string), string lastName = default(string), string title = default(string), string phone = default(string), string nationalId = default(string), string email = default(string), Address address = default(Address), DateTime dateOfBirth = default(DateTime), bool isExecutive = default(bool), bool isRepresentative = default(bool), string ownershipPercentage = default(string), string ssnLast4 = default(string))
        {
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new ArgumentNullException("firstName is a required property for Person and cannot be null");
            }
            this.FirstName = firstName;
            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new ArgumentNullException("lastName is a required property for Person and cannot be null");
            }
            this.LastName = lastName;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for Person and cannot be null");
            }
            this.Title = title;
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for Person and cannot be null");
            }
            this.Email = email;
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for Person and cannot be null");
            }
            this.Address = address;
            this.DateOfBirth = dateOfBirth;
            this.IsExecutive = isExecutive;
            this.IsRepresentative = isRepresentative;
            // to ensure "ownershipPercentage" is required (not null)
            if (ownershipPercentage == null)
            {
                throw new ArgumentNullException("ownershipPercentage is a required property for Person and cannot be null");
            }
            this.OwnershipPercentage = ownershipPercentage;
            this.PersonId = personId;
            this.MiddleName = middleName;
            this.Phone = phone;
            this.NationalId = nationalId;
            this.SsnLast4 = ssnLast4;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets PersonId
        /// </summary>
        [DataMember(Name = "person_id", EmitDefaultValue = false)]
        public Guid PersonId { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "first_name", IsRequired = true, EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets MiddleName
        /// </summary>
        [DataMember(Name = "middle_name", EmitDefaultValue = false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "last_name", IsRequired = true, EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// This field may be required to be populated, depending on the region.  For the US , this is the social security number, and is required. For CA, this is the social insurance number. 
        /// </summary>
        /// <value>This field may be required to be populated, depending on the region.  For the US , this is the social security number, and is required. For CA, this is the social insurance number. </value>
        [DataMember(Name = "national_id", EmitDefaultValue = false)]
        public string NationalId { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public Address Address { get; set; }

        /// <summary>
        /// Gets or Sets DateOfBirth
        /// </summary>
        [DataMember(Name = "date_of_birth", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Indicates if the individual bears substantial responsibility for controlling, managing, or directing the organization.
        /// </summary>
        /// <value>Indicates if the individual bears substantial responsibility for controlling, managing, or directing the organization.</value>
        [DataMember(Name = "is_executive", IsRequired = true, EmitDefaultValue = true)]
        public bool IsExecutive { get; set; }

        /// <summary>
        /// Representative refers to the designated primary representative of the account, authorized by the business to provide both personal information about themselves and general details about the account. It is essential to note that there can only be one representative assigned to the account at any given time, and during the account creation, this role is typically assigned to the individual responsible for opening the account.
        /// </summary>
        /// <value>Representative refers to the designated primary representative of the account, authorized by the business to provide both personal information about themselves and general details about the account. It is essential to note that there can only be one representative assigned to the account at any given time, and during the account creation, this role is typically assigned to the individual responsible for opening the account.</value>
        [DataMember(Name = "is_representative", IsRequired = true, EmitDefaultValue = true)]
        public bool IsRepresentative { get; set; }

        /// <summary>
        /// The percent owned of firm&#39;s legal entity owned by the person.
        /// </summary>
        /// <value>The percent owned of firm&#39;s legal entity owned by the person.</value>
        [DataMember(Name = "ownership_percentage", IsRequired = true, EmitDefaultValue = true)]
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
            sb.Append("  PersonId: ").Append(PersonId).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
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
                    this.PersonId == input.PersonId ||
                    (this.PersonId != null &&
                    this.PersonId.Equals(input.PersonId))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.MiddleName == input.MiddleName ||
                    (this.MiddleName != null &&
                    this.MiddleName.Equals(input.MiddleName))
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
                if (this.PersonId != null)
                {
                    hashCode = (hashCode * 59) + this.PersonId.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.MiddleName != null)
                {
                    hashCode = (hashCode * 59) + this.MiddleName.GetHashCode();
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
