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
    /// Only visible via the /groups/:groupId/members endpoint, **not** when fetching a specific user.
    /// </summary>
    [DataContract(Name = "GroupMemberLimitedUser")]
    public partial class GroupMemberLimitedUser : IEquatable<GroupMemberLimitedUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMemberLimitedUser" /> class.
        /// </summary>
        /// <param name="id">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="thumbnailUrl">thumbnailUrl.</param>
        /// <param name="iconUrl">iconUrl.</param>
        public GroupMemberLimitedUser(string id = default(string), string displayName = default(string), string thumbnailUrl = default(string), string iconUrl = default(string))
        {
            this.Id = id;
            this.DisplayName = displayName;
            this.ThumbnailUrl = thumbnailUrl;
            this.IconUrl = iconUrl;
        }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets ThumbnailUrl
        /// </summary>
        [DataMember(Name = "thumbnailUrl", EmitDefaultValue = false)]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or Sets IconUrl
        /// </summary>
        [DataMember(Name = "iconUrl", EmitDefaultValue = false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupMemberLimitedUser {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  ThumbnailUrl: ").Append(ThumbnailUrl).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
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
            return this.Equals(input as GroupMemberLimitedUser);
        }

        /// <summary>
        /// Returns true if GroupMemberLimitedUser instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupMemberLimitedUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupMemberLimitedUser input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.ThumbnailUrl == input.ThumbnailUrl ||
                    (this.ThumbnailUrl != null &&
                    this.ThumbnailUrl.Equals(input.ThumbnailUrl))
                ) && 
                (
                    this.IconUrl == input.IconUrl ||
                    (this.IconUrl != null &&
                    this.IconUrl.Equals(input.IconUrl))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.ThumbnailUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ThumbnailUrl.GetHashCode();
                }
                if (this.IconUrl != null)
                {
                    hashCode = (hashCode * 59) + this.IconUrl.GetHashCode();
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
