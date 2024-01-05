/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.16.2
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
    /// Verify2FAResult
    /// </summary>
    [DataContract(Name = "Verify2FAResult")]
    public partial class Verify2FAResult : IEquatable<Verify2FAResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Verify2FAResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Verify2FAResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Verify2FAResult" /> class.
        /// </summary>
        /// <param name="verified">verified (required).</param>
        public Verify2FAResult(bool verified = default(bool))
        {
            this.Verified = verified;
        }

        /// <summary>
        /// Gets or Sets Verified
        /// </summary>
        [DataMember(Name = "verified", IsRequired = true, EmitDefaultValue = true)]
        public bool Verified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Verify2FAResult {\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
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
            return this.Equals(input as Verify2FAResult);
        }

        /// <summary>
        /// Returns true if Verify2FAResult instances are equal
        /// </summary>
        /// <param name="input">Instance of Verify2FAResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Verify2FAResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Verified == input.Verified ||
                    this.Verified.Equals(input.Verified)
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
                hashCode = (hashCode * 59) + this.Verified.GetHashCode();
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
