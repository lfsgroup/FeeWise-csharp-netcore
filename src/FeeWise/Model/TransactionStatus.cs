/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.112
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
    /// Defines TransactionStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionStatus
    {
        /// <summary>
        /// Enum Initialised for value: Initialised
        /// </summary>
        [EnumMember(Value = "Initialised")]
        Initialised = 1,

        /// <summary>
        /// Enum Processing for value: Processing
        /// </summary>
        [EnumMember(Value = "Processing")]
        Processing = 2,

        /// <summary>
        /// Enum Clearing for value: Clearing
        /// </summary>
        [EnumMember(Value = "Clearing")]
        Clearing = 3,

        /// <summary>
        /// Enum Paid for value: Paid
        /// </summary>
        [EnumMember(Value = "Paid")]
        Paid = 4,

        /// <summary>
        /// Enum Failed for value: Failed
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed = 5

    }

}
