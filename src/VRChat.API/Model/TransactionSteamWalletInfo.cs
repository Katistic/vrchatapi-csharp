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
    /// TransactionSteamWalletInfo
    /// </summary>
    [DataContract(Name = "TransactionSteamWalletInfo")]
    public partial class TransactionSteamWalletInfo : IEquatable<TransactionSteamWalletInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionSteamWalletInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionSteamWalletInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionSteamWalletInfo" /> class.
        /// </summary>
        /// <param name="state">state (required).</param>
        /// <param name="country">country (required) (default to &quot;US&quot;).</param>
        /// <param name="currency">currency (required) (default to &quot;USD&quot;).</param>
        /// <param name="status">status (required).</param>
        public TransactionSteamWalletInfo(string state = default(string), string country = "US", string currency = "USD", string status = default(string))
        {
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new ArgumentNullException("state is a required property for TransactionSteamWalletInfo and cannot be null");
            }
            this.State = state;
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new ArgumentNullException("country is a required property for TransactionSteamWalletInfo and cannot be null");
            }
            this.Country = country;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for TransactionSteamWalletInfo and cannot be null");
            }
            this.Currency = currency;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for TransactionSteamWalletInfo and cannot be null");
            }
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", IsRequired = true, EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionSteamWalletInfo {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as TransactionSteamWalletInfo);
        }

        /// <summary>
        /// Returns true if TransactionSteamWalletInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionSteamWalletInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionSteamWalletInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
            // Country (string) minLength
            if (this.Country != null && this.Country.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, length must be greater than 2.", new [] { "Country" });
            }

            // Currency (string) minLength
            if (this.Currency != null && this.Currency.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, length must be greater than 3.", new [] { "Currency" });
            }

            // Status (string) minLength
            if (this.Status != null && this.Status.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Status, length must be greater than 1.", new [] { "Status" });
            }

            yield break;
        }
    }

}
