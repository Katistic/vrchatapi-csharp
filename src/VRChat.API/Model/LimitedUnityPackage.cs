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
    /// LimitedUnityPackage
    /// </summary>
    [DataContract(Name = "LimitedUnityPackage")]
    public partial class LimitedUnityPackage : IEquatable<LimitedUnityPackage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LimitedUnityPackage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LimitedUnityPackage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LimitedUnityPackage" /> class.
        /// </summary>
        /// <param name="platform">This can be &#x60;standalonewindows&#x60; or &#x60;android&#x60;, but can also pretty much be any random Unity verison such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;. (required).</param>
        /// <param name="unityVersion">unityVersion (required).</param>
        public LimitedUnityPackage(string platform = default(string), string unityVersion = default(string))
        {
            // to ensure "platform" is required (not null)
            if (platform == null)
            {
                throw new ArgumentNullException("platform is a required property for LimitedUnityPackage and cannot be null");
            }
            this.Platform = platform;
            // to ensure "unityVersion" is required (not null)
            if (unityVersion == null)
            {
                throw new ArgumentNullException("unityVersion is a required property for LimitedUnityPackage and cannot be null");
            }
            this.UnityVersion = unityVersion;
        }

        /// <summary>
        /// This can be &#x60;standalonewindows&#x60; or &#x60;android&#x60;, but can also pretty much be any random Unity verison such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;.
        /// </summary>
        /// <value>This can be &#x60;standalonewindows&#x60; or &#x60;android&#x60;, but can also pretty much be any random Unity verison such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;.</value>
        [DataMember(Name = "platform", IsRequired = true, EmitDefaultValue = true)]
        public string Platform { get; set; }

        /// <summary>
        /// Gets or Sets UnityVersion
        /// </summary>
        [DataMember(Name = "unityVersion", IsRequired = true, EmitDefaultValue = true)]
        public string UnityVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LimitedUnityPackage {\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  UnityVersion: ").Append(UnityVersion).Append("\n");
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
            return this.Equals(input as LimitedUnityPackage);
        }

        /// <summary>
        /// Returns true if LimitedUnityPackage instances are equal
        /// </summary>
        /// <param name="input">Instance of LimitedUnityPackage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LimitedUnityPackage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.UnityVersion == input.UnityVersion ||
                    (this.UnityVersion != null &&
                    this.UnityVersion.Equals(input.UnityVersion))
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
                if (this.Platform != null)
                {
                    hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                }
                if (this.UnityVersion != null)
                {
                    hashCode = (hashCode * 59) + this.UnityVersion.GetHashCode();
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
            // UnityVersion (string) minLength
            if (this.UnityVersion != null && this.UnityVersion.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnityVersion, length must be greater than 1.", new [] { "UnityVersion" });
            }

            yield break;
        }
    }

}
