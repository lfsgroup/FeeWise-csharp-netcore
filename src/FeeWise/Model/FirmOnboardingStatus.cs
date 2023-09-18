/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.87
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
    /// Firm&#39;s status.
    /// </summary>
    /// <value>Firm&#39;s status.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FirmOnboardingStatus
    {
        /// <summary>
        /// Enum Pending for value: Pending
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending = 1,

        /// <summary>
        /// Enum Awaiting for value: Awaiting
        /// </summary>
        [EnumMember(Value = "Awaiting")]
        Awaiting = 2,

        /// <summary>
        /// Enum Active for value: Active
        /// </summary>
        [EnumMember(Value = "Active")]
        Active = 3,

        /// <summary>
        /// Enum Closed for value: Closed
        /// </summary>
        [EnumMember(Value = "Closed")]
        Closed = 4

    }

}
