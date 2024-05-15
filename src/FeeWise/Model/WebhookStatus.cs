/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.119
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
using OpenAPIDateConverter = FeeWise.Client.OpenAPIDateConverter;

namespace FeeWise.Model
{
    /// <summary>
    /// Defines WebhookStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookStatus
    {
        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 1,

        /// <summary>
        /// Enum Enabled for value: Enabled
        /// </summary>
        [EnumMember(Value = "Enabled")]
        Enabled = 2,

        /// <summary>
        /// Enum Disabled for value: Disabled
        /// </summary>
        [EnumMember(Value = "Disabled")]
        Disabled = 3

    }

}
