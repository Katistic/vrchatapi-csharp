/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.16.5
 * Contact: vrchatapi.lpv0t@aries.fyi
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
    /// CreateGroupGalleryRequest
    /// </summary>
    [DataContract(Name = "CreateGroupGalleryRequest")]
    public partial class CreateGroupGalleryRequest : IEquatable<CreateGroupGalleryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroupGalleryRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateGroupGalleryRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroupGalleryRequest" /> class.
        /// </summary>
        /// <param name="name">Name of the gallery. (required).</param>
        /// <param name="description">Description of the gallery..</param>
        /// <param name="membersOnly">Whether the gallery is members only. (default to false).</param>
        /// <param name="roleIdsToView"> .</param>
        /// <param name="roleIdsToSubmit"> .</param>
        /// <param name="roleIdsToAutoApprove"> .</param>
        /// <param name="roleIdsToManage"> .</param>
        public CreateGroupGalleryRequest(string name = default(string), string description = default(string), bool membersOnly = false, List<string> roleIdsToView = default(List<string>), List<string> roleIdsToSubmit = default(List<string>), List<string> roleIdsToAutoApprove = default(List<string>), List<string> roleIdsToManage = default(List<string>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateGroupGalleryRequest and cannot be null");
            }
            this.Name = name;
            this.Description = description;
            this.MembersOnly = membersOnly;
            this.RoleIdsToView = roleIdsToView;
            this.RoleIdsToSubmit = roleIdsToSubmit;
            this.RoleIdsToAutoApprove = roleIdsToAutoApprove;
            this.RoleIdsToManage = roleIdsToManage;
        }

        /// <summary>
        /// Name of the gallery.
        /// </summary>
        /// <value>Name of the gallery.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Description of the gallery.
        /// </summary>
        /// <value>Description of the gallery.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Whether the gallery is members only.
        /// </summary>
        /// <value>Whether the gallery is members only.</value>
        [DataMember(Name = "membersOnly", EmitDefaultValue = true)]
        public bool MembersOnly { get; set; }

        /// <summary>
        ///  
        /// </summary>
        /// <value> </value>
        [DataMember(Name = "roleIdsToView", EmitDefaultValue = true)]
        public List<string> RoleIdsToView { get; set; }

        /// <summary>
        ///  
        /// </summary>
        /// <value> </value>
        [DataMember(Name = "roleIdsToSubmit", EmitDefaultValue = true)]
        public List<string> RoleIdsToSubmit { get; set; }

        /// <summary>
        ///  
        /// </summary>
        /// <value> </value>
        [DataMember(Name = "roleIdsToAutoApprove", EmitDefaultValue = true)]
        public List<string> RoleIdsToAutoApprove { get; set; }

        /// <summary>
        ///  
        /// </summary>
        /// <value> </value>
        [DataMember(Name = "roleIdsToManage", EmitDefaultValue = true)]
        public List<string> RoleIdsToManage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateGroupGalleryRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MembersOnly: ").Append(MembersOnly).Append("\n");
            sb.Append("  RoleIdsToView: ").Append(RoleIdsToView).Append("\n");
            sb.Append("  RoleIdsToSubmit: ").Append(RoleIdsToSubmit).Append("\n");
            sb.Append("  RoleIdsToAutoApprove: ").Append(RoleIdsToAutoApprove).Append("\n");
            sb.Append("  RoleIdsToManage: ").Append(RoleIdsToManage).Append("\n");
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
            return this.Equals(input as CreateGroupGalleryRequest);
        }

        /// <summary>
        /// Returns true if CreateGroupGalleryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateGroupGalleryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateGroupGalleryRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.MembersOnly == input.MembersOnly ||
                    this.MembersOnly.Equals(input.MembersOnly)
                ) && 
                (
                    this.RoleIdsToView == input.RoleIdsToView ||
                    this.RoleIdsToView != null &&
                    input.RoleIdsToView != null &&
                    this.RoleIdsToView.SequenceEqual(input.RoleIdsToView)
                ) && 
                (
                    this.RoleIdsToSubmit == input.RoleIdsToSubmit ||
                    this.RoleIdsToSubmit != null &&
                    input.RoleIdsToSubmit != null &&
                    this.RoleIdsToSubmit.SequenceEqual(input.RoleIdsToSubmit)
                ) && 
                (
                    this.RoleIdsToAutoApprove == input.RoleIdsToAutoApprove ||
                    this.RoleIdsToAutoApprove != null &&
                    input.RoleIdsToAutoApprove != null &&
                    this.RoleIdsToAutoApprove.SequenceEqual(input.RoleIdsToAutoApprove)
                ) && 
                (
                    this.RoleIdsToManage == input.RoleIdsToManage ||
                    this.RoleIdsToManage != null &&
                    input.RoleIdsToManage != null &&
                    this.RoleIdsToManage.SequenceEqual(input.RoleIdsToManage)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MembersOnly.GetHashCode();
                if (this.RoleIdsToView != null)
                {
                    hashCode = (hashCode * 59) + this.RoleIdsToView.GetHashCode();
                }
                if (this.RoleIdsToSubmit != null)
                {
                    hashCode = (hashCode * 59) + this.RoleIdsToSubmit.GetHashCode();
                }
                if (this.RoleIdsToAutoApprove != null)
                {
                    hashCode = (hashCode * 59) + this.RoleIdsToAutoApprove.GetHashCode();
                }
                if (this.RoleIdsToManage != null)
                {
                    hashCode = (hashCode * 59) + this.RoleIdsToManage.GetHashCode();
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
            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 0.", new [] { "Description" });
            }

            yield break;
        }
    }

}
