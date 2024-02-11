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
    /// Defines FavoriteGroupVisibility
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FavoriteGroupVisibility
    {
        /// <summary>
        /// Enum Private for value: private
        /// </summary>
        [EnumMember(Value = "private")]
        Private = 1,

        /// <summary>
        /// Enum Friends for value: friends
        /// </summary>
        [EnumMember(Value = "friends")]
        Friends = 2,

        /// <summary>
        /// Enum Public for value: public
        /// </summary>
        [EnumMember(Value = "public")]
        Public = 3

    }

}
