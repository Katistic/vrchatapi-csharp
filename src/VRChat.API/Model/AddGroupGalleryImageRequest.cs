/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.10.1
 * Contact: me@ariesclark.com
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
using OpenAPIDateConverter = VRChat.API.Client.OpenAPIDateConverter;

namespace VRChat.API.Model
{
    /// <summary>
    /// AddGroupGalleryImageRequest
    /// </summary>
    [DataContract(Name = "AddGroupGalleryImageRequest")]
    public partial class AddGroupGalleryImageRequest : IEquatable<AddGroupGalleryImageRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddGroupGalleryImageRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddGroupGalleryImageRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddGroupGalleryImageRequest" /> class.
        /// </summary>
        /// <param name="fileId">fileId (required).</param>
        public AddGroupGalleryImageRequest(string fileId = default(string))
        {
            // to ensure "fileId" is required (not null)
            if (fileId == null)
            {
                throw new ArgumentNullException("fileId is a required property for AddGroupGalleryImageRequest and cannot be null");
            }
            this.FileId = fileId;
        }

        /// <summary>
        /// Gets or Sets FileId
        /// </summary>
        [DataMember(Name = "fileId", IsRequired = true, EmitDefaultValue = true)]
        public string FileId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddGroupGalleryImageRequest {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
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
            return this.Equals(input as AddGroupGalleryImageRequest);
        }

        /// <summary>
        /// Returns true if AddGroupGalleryImageRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AddGroupGalleryImageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddGroupGalleryImageRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FileId == input.FileId ||
                    (this.FileId != null &&
                    this.FileId.Equals(input.FileId))
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
                if (this.FileId != null)
                {
                    hashCode = (hashCode * 59) + this.FileId.GetHashCode();
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
            // FileId (string) pattern
            Regex regexFileId = new Regex(@"file_[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}", RegexOptions.CultureInvariant);
            if (false == regexFileId.Match(this.FileId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FileId, must match a pattern of " + regexFileId, new [] { "FileId" });
            }

            yield break;
        }
    }

}
