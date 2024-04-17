/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.114
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
    /// Defines PaymentMethod
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentMethod
    {
        /// <summary>
        /// Enum Card for value: Card
        /// </summary>
        [EnumMember(Value = "Card")]
        Card = 1,

        /// <summary>
        /// Enum DirectDebit for value: DirectDebit
        /// </summary>
        [EnumMember(Value = "DirectDebit")]
        DirectDebit = 2

    }

}
