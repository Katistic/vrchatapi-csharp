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
    /// APIConfigEvents
    /// </summary>
    [DataContract(Name = "APIConfigEvents")]
    public partial class APIConfigEvents : IEquatable<APIConfigEvents>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIConfigEvents" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected APIConfigEvents() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="APIConfigEvents" /> class.
        /// </summary>
        /// <param name="distanceClose">Unknown (required).</param>
        /// <param name="distanceFactor">Unknown (required).</param>
        /// <param name="distanceFar">Unknown (required).</param>
        /// <param name="groupDistance">Unknown (required).</param>
        /// <param name="maximumBunchSize">Unknown (required).</param>
        /// <param name="notVisibleFactor">Unknown (required).</param>
        /// <param name="playerOrderBucketSize">Unknown (required).</param>
        /// <param name="playerOrderFactor">Unknown (required).</param>
        /// <param name="slowUpdateFactorThreshold">Unknown (required).</param>
        /// <param name="viewSegmentLength">Unknown (required).</param>
        public APIConfigEvents(int distanceClose = default(int), int distanceFactor = default(int), int distanceFar = default(int), int groupDistance = default(int), int maximumBunchSize = default(int), int notVisibleFactor = default(int), int playerOrderBucketSize = default(int), int playerOrderFactor = default(int), int slowUpdateFactorThreshold = default(int), int viewSegmentLength = default(int))
        {
            this.DistanceClose = distanceClose;
            this.DistanceFactor = distanceFactor;
            this.DistanceFar = distanceFar;
            this.GroupDistance = groupDistance;
            this.MaximumBunchSize = maximumBunchSize;
            this.NotVisibleFactor = notVisibleFactor;
            this.PlayerOrderBucketSize = playerOrderBucketSize;
            this.PlayerOrderFactor = playerOrderFactor;
            this.SlowUpdateFactorThreshold = slowUpdateFactorThreshold;
            this.ViewSegmentLength = viewSegmentLength;
        }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name = "distanceClose", IsRequired = true, EmitDefaultValue = true)]
        public int DistanceClose { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name = "distanceFactor", IsRequired = true, EmitDefaultValue = true)]
        public int DistanceFactor { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name = "distanceFar", IsRequired = true, EmitDefaultValue = true)]
        public int DistanceFar { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name = "groupDistance", IsRequired = true, EmitDefaultValue = true)]
        public int GroupDistance { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name = "maximumBunchSize", IsRequired = true, EmitDefaultValue = true)]
        public int MaximumBunchSize { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name = "notVisibleFactor", IsRequired = true, EmitDefaultValue = true)]
        public int NotVisibleFactor { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name = "playerOrderBucketSize", IsRequired = true, EmitDefaultValue = true)]
        public int PlayerOrderBucketSize { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name = "playerOrderFactor", IsRequired = true, EmitDefaultValue = true)]
        public int PlayerOrderFactor { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name = "slowUpdateFactorThreshold", IsRequired = true, EmitDefaultValue = true)]
        public int SlowUpdateFactorThreshold { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <value>Unknown</value>
        [DataMember(Name = "viewSegmentLength", IsRequired = true, EmitDefaultValue = true)]
        public int ViewSegmentLength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class APIConfigEvents {\n");
            sb.Append("  DistanceClose: ").Append(DistanceClose).Append("\n");
            sb.Append("  DistanceFactor: ").Append(DistanceFactor).Append("\n");
            sb.Append("  DistanceFar: ").Append(DistanceFar).Append("\n");
            sb.Append("  GroupDistance: ").Append(GroupDistance).Append("\n");
            sb.Append("  MaximumBunchSize: ").Append(MaximumBunchSize).Append("\n");
            sb.Append("  NotVisibleFactor: ").Append(NotVisibleFactor).Append("\n");
            sb.Append("  PlayerOrderBucketSize: ").Append(PlayerOrderBucketSize).Append("\n");
            sb.Append("  PlayerOrderFactor: ").Append(PlayerOrderFactor).Append("\n");
            sb.Append("  SlowUpdateFactorThreshold: ").Append(SlowUpdateFactorThreshold).Append("\n");
            sb.Append("  ViewSegmentLength: ").Append(ViewSegmentLength).Append("\n");
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
            return this.Equals(input as APIConfigEvents);
        }

        /// <summary>
        /// Returns true if APIConfigEvents instances are equal
        /// </summary>
        /// <param name="input">Instance of APIConfigEvents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIConfigEvents input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DistanceClose == input.DistanceClose ||
                    this.DistanceClose.Equals(input.DistanceClose)
                ) && 
                (
                    this.DistanceFactor == input.DistanceFactor ||
                    this.DistanceFactor.Equals(input.DistanceFactor)
                ) && 
                (
                    this.DistanceFar == input.DistanceFar ||
                    this.DistanceFar.Equals(input.DistanceFar)
                ) && 
                (
                    this.GroupDistance == input.GroupDistance ||
                    this.GroupDistance.Equals(input.GroupDistance)
                ) && 
                (
                    this.MaximumBunchSize == input.MaximumBunchSize ||
                    this.MaximumBunchSize.Equals(input.MaximumBunchSize)
                ) && 
                (
                    this.NotVisibleFactor == input.NotVisibleFactor ||
                    this.NotVisibleFactor.Equals(input.NotVisibleFactor)
                ) && 
                (
                    this.PlayerOrderBucketSize == input.PlayerOrderBucketSize ||
                    this.PlayerOrderBucketSize.Equals(input.PlayerOrderBucketSize)
                ) && 
                (
                    this.PlayerOrderFactor == input.PlayerOrderFactor ||
                    this.PlayerOrderFactor.Equals(input.PlayerOrderFactor)
                ) && 
                (
                    this.SlowUpdateFactorThreshold == input.SlowUpdateFactorThreshold ||
                    this.SlowUpdateFactorThreshold.Equals(input.SlowUpdateFactorThreshold)
                ) && 
                (
                    this.ViewSegmentLength == input.ViewSegmentLength ||
                    this.ViewSegmentLength.Equals(input.ViewSegmentLength)
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
                hashCode = (hashCode * 59) + this.DistanceClose.GetHashCode();
                hashCode = (hashCode * 59) + this.DistanceFactor.GetHashCode();
                hashCode = (hashCode * 59) + this.DistanceFar.GetHashCode();
                hashCode = (hashCode * 59) + this.GroupDistance.GetHashCode();
                hashCode = (hashCode * 59) + this.MaximumBunchSize.GetHashCode();
                hashCode = (hashCode * 59) + this.NotVisibleFactor.GetHashCode();
                hashCode = (hashCode * 59) + this.PlayerOrderBucketSize.GetHashCode();
                hashCode = (hashCode * 59) + this.PlayerOrderFactor.GetHashCode();
                hashCode = (hashCode * 59) + this.SlowUpdateFactorThreshold.GetHashCode();
                hashCode = (hashCode * 59) + this.ViewSegmentLength.GetHashCode();
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
