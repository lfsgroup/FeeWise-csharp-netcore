/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.110
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
    /// Current status of the payout. The status changes to paid, if the transaction goes through, or to failed or cancelled (within 5 business days) 
    /// </summary>
    /// <value>Current status of the payout. The status changes to paid, if the transaction goes through, or to failed or cancelled (within 5 business days) </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PayoutStatus
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        /// Enum Submitted for value: Submitted
        /// </summary>
        [EnumMember(Value = "Submitted")]
        Submitted = 2,

        /// <summary>
        /// Enum Paid for value: Paid
        /// </summary>
        [EnumMember(Value = "Paid")]
        Paid = 3,

        /// <summary>
        /// Enum Failed for value: Failed
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed = 4,

        /// <summary>
        /// Enum Cancelled for value: Cancelled
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled = 5

    }

}
