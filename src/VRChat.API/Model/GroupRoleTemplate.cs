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
    /// Defines GroupRoleTemplate
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GroupRoleTemplate
    {
        /// <summary>
        /// Enum Default for value: default
        /// </summary>
        [EnumMember(Value = "default")]
        Default = 1,

        /// <summary>
        /// Enum ManagedFree for value: managedFree
        /// </summary>
        [EnumMember(Value = "managedFree")]
        ManagedFree = 2,

        /// <summary>
        /// Enum ManagedInvite for value: managedInvite
        /// </summary>
        [EnumMember(Value = "managedInvite")]
        ManagedInvite = 3,

        /// <summary>
        /// Enum ManagedRequest for value: managedRequest
        /// </summary>
        [EnumMember(Value = "managedRequest")]
        ManagedRequest = 4

    }

}
