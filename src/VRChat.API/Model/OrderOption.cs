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
    /// Defines OrderOption
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderOption
    {
        /// <summary>
        /// Enum Ascending for value: ascending
        /// </summary>
        [EnumMember(Value = "ascending")]
        Ascending = 1,

        /// <summary>
        /// Enum Descending for value: descending
        /// </summary>
        [EnumMember(Value = "descending")]
        Descending = 2

    }

}
