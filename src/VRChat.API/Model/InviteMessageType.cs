/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.16.4
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
    /// Defines InviteMessageType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InviteMessageType
    {
        /// <summary>
        /// Enum Message for value: message
        /// </summary>
        [EnumMember(Value = "message")]
        Message = 1,

        /// <summary>
        /// Enum Response for value: response
        /// </summary>
        [EnumMember(Value = "response")]
        Response = 2,

        /// <summary>
        /// Enum Request for value: request
        /// </summary>
        [EnumMember(Value = "request")]
        Request = 3,

        /// <summary>
        /// Enum RequestResponse for value: requestResponse
        /// </summary>
        [EnumMember(Value = "requestResponse")]
        RequestResponse = 4

    }

}
