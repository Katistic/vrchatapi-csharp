/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.12.0
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
    /// DynamicContentRow
    /// </summary>
    [DataContract(Name = "DynamicContentRow")]
    public partial class DynamicContentRow : IEquatable<DynamicContentRow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicContentRow" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DynamicContentRow() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicContentRow" /> class.
        /// </summary>
        /// <param name="index">index.</param>
        /// <param name="name">name (required).</param>
        /// <param name="platform">Usually \&quot;ThisPlatformSupported\&quot;, but can also be other values such as \&quot;all\&quot; or platform specific identifiers. (required).</param>
        /// <param name="sortHeading">sortHeading (required).</param>
        /// <param name="sortOrder">sortOrder (required).</param>
        /// <param name="sortOwnership">sortOwnership (required).</param>
        /// <param name="tag">Tag to filter content for this row..</param>
        /// <param name="type">Type is not present if it is a world..</param>
        public DynamicContentRow(int index = default(int), string name = default(string), string platform = default(string), string sortHeading = default(string), string sortOrder = default(string), string sortOwnership = default(string), string tag = default(string), string type = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for DynamicContentRow and cannot be null");
            }
            this.Name = name;
            // to ensure "platform" is required (not null)
            if (platform == null)
            {
                throw new ArgumentNullException("platform is a required property for DynamicContentRow and cannot be null");
            }
            this.Platform = platform;
            // to ensure "sortHeading" is required (not null)
            if (sortHeading == null)
            {
                throw new ArgumentNullException("sortHeading is a required property for DynamicContentRow and cannot be null");
            }
            this.SortHeading = sortHeading;
            // to ensure "sortOrder" is required (not null)
            if (sortOrder == null)
            {
                throw new ArgumentNullException("sortOrder is a required property for DynamicContentRow and cannot be null");
            }
            this.SortOrder = sortOrder;
            // to ensure "sortOwnership" is required (not null)
            if (sortOwnership == null)
            {
                throw new ArgumentNullException("sortOwnership is a required property for DynamicContentRow and cannot be null");
            }
            this.SortOwnership = sortOwnership;
            this.Index = index;
            this.Tag = tag;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Usually \&quot;ThisPlatformSupported\&quot;, but can also be other values such as \&quot;all\&quot; or platform specific identifiers.
        /// </summary>
        /// <value>Usually \&quot;ThisPlatformSupported\&quot;, but can also be other values such as \&quot;all\&quot; or platform specific identifiers.</value>
        [DataMember(Name = "platform", IsRequired = true, EmitDefaultValue = true)]
        public string Platform { get; set; }

        /// <summary>
        /// Gets or Sets SortHeading
        /// </summary>
        [DataMember(Name = "sortHeading", IsRequired = true, EmitDefaultValue = true)]
        public string SortHeading { get; set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name = "sortOrder", IsRequired = true, EmitDefaultValue = true)]
        public string SortOrder { get; set; }

        /// <summary>
        /// Gets or Sets SortOwnership
        /// </summary>
        [DataMember(Name = "sortOwnership", IsRequired = true, EmitDefaultValue = true)]
        public string SortOwnership { get; set; }

        /// <summary>
        /// Tag to filter content for this row.
        /// </summary>
        /// <value>Tag to filter content for this row.</value>
        [DataMember(Name = "tag", EmitDefaultValue = false)]
        public string Tag { get; set; }

        /// <summary>
        /// Type is not present if it is a world.
        /// </summary>
        /// <value>Type is not present if it is a world.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DynamicContentRow {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  SortHeading: ").Append(SortHeading).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  SortOwnership: ").Append(SortOwnership).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as DynamicContentRow);
        }

        /// <summary>
        /// Returns true if DynamicContentRow instances are equal
        /// </summary>
        /// <param name="input">Instance of DynamicContentRow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicContentRow input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.SortHeading == input.SortHeading ||
                    (this.SortHeading != null &&
                    this.SortHeading.Equals(input.SortHeading))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
                ) && 
                (
                    this.SortOwnership == input.SortOwnership ||
                    (this.SortOwnership != null &&
                    this.SortOwnership.Equals(input.SortOwnership))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Platform != null)
                {
                    hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                }
                if (this.SortHeading != null)
                {
                    hashCode = (hashCode * 59) + this.SortHeading.GetHashCode();
                }
                if (this.SortOrder != null)
                {
                    hashCode = (hashCode * 59) + this.SortOrder.GetHashCode();
                }
                if (this.SortOwnership != null)
                {
                    hashCode = (hashCode * 59) + this.SortOwnership.GetHashCode();
                }
                if (this.Tag != null)
                {
                    hashCode = (hashCode * 59) + this.Tag.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
            // Index (int) minimum
            if (this.Index < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Index, must be a value greater than or equal to 0.", new [] { "Index" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Platform (string) minLength
            if (this.Platform != null && this.Platform.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Platform, length must be greater than 1.", new [] { "Platform" });
            }

            // SortHeading (string) minLength
            if (this.SortHeading != null && this.SortHeading.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SortHeading, length must be greater than 1.", new [] { "SortHeading" });
            }

            // SortOrder (string) minLength
            if (this.SortOrder != null && this.SortOrder.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SortOrder, length must be greater than 1.", new [] { "SortOrder" });
            }

            // SortOwnership (string) minLength
            if (this.SortOwnership != null && this.SortOwnership.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SortOwnership, length must be greater than 1.", new [] { "SortOwnership" });
            }

            // Tag (string) minLength
            if (this.Tag != null && this.Tag.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Tag, length must be greater than 1.", new [] { "Tag" });
            }

            yield break;
        }
    }

}
