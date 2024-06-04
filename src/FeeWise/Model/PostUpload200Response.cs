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
    /// PostUpload200Response
    /// </summary>
    [DataContract(Name = "postUpload_200_response")]
    public partial class PostUpload200Response : IEquatable<PostUpload200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostUpload200Response" /> class.
        /// </summary>
        /// <param name="url">URL of the uploaded file. For security reasons the URL will be only provided for logo and icon files. .</param>
        /// <param name="uploadedFileName">Name of the uploaded file..</param>
        /// <param name="uploadedFileSizeInBytes">Size of the uploaded file, in bytes..</param>
        public PostUpload200Response(string url = default(string), string uploadedFileName = default(string), int uploadedFileSizeInBytes = default(int))
        {
            this.Url = url;
            this.UploadedFileName = uploadedFileName;
            this.UploadedFileSizeInBytes = uploadedFileSizeInBytes;
        }

        /// <summary>
        /// URL of the uploaded file. For security reasons the URL will be only provided for logo and icon files. 
        /// </summary>
        /// <value>URL of the uploaded file. For security reasons the URL will be only provided for logo and icon files. </value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Name of the uploaded file.
        /// </summary>
        /// <value>Name of the uploaded file.</value>
        [DataMember(Name = "uploaded_file_name", EmitDefaultValue = false)]
        public string UploadedFileName { get; set; }

        /// <summary>
        /// Size of the uploaded file, in bytes.
        /// </summary>
        /// <value>Size of the uploaded file, in bytes.</value>
        [DataMember(Name = "uploaded_file_size_in_bytes", EmitDefaultValue = false)]
        public int UploadedFileSizeInBytes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostUpload200Response {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  UploadedFileName: ").Append(UploadedFileName).Append("\n");
            sb.Append("  UploadedFileSizeInBytes: ").Append(UploadedFileSizeInBytes).Append("\n");
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
            return this.Equals(input as PostUpload200Response);
        }

        /// <summary>
        /// Returns true if PostUpload200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of PostUpload200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostUpload200Response input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.UploadedFileName == input.UploadedFileName ||
                    (this.UploadedFileName != null &&
                    this.UploadedFileName.Equals(input.UploadedFileName))
                ) && 
                (
                    this.UploadedFileSizeInBytes == input.UploadedFileSizeInBytes ||
                    this.UploadedFileSizeInBytes.Equals(input.UploadedFileSizeInBytes)
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
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.UploadedFileName != null)
                {
                    hashCode = (hashCode * 59) + this.UploadedFileName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UploadedFileSizeInBytes.GetHashCode();
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
