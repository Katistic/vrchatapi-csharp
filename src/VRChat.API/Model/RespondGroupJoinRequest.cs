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
    /// RespondGroupJoinRequest
    /// </summary>
    [DataContract(Name = "RespondGroupJoinRequest")]
    public partial class RespondGroupJoinRequest : IEquatable<RespondGroupJoinRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RespondGroupJoinRequest" /> class.
        /// </summary>
        /// <param name="action">action.</param>
        public RespondGroupJoinRequest(string action = default(string))
        {
            this.Action = action;
        }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public string Action { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RespondGroupJoinRequest {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
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
            return this.Equals(input as RespondGroupJoinRequest);
        }

        /// <summary>
        /// Returns true if RespondGroupJoinRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RespondGroupJoinRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RespondGroupJoinRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
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
                if (this.Action != null)
                {
                    hashCode = (hashCode * 59) + this.Action.GetHashCode();
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
