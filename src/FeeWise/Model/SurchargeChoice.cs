/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.97
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
    /// Defines SurchargeChoice
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SurchargeChoice
    {
        /// <summary>
        /// Enum Customer for value: Customer
        /// </summary>
        [EnumMember(Value = "Customer")]
        Customer = 1,

        /// <summary>
        /// Enum Merchant for value: Merchant
        /// </summary>
        [EnumMember(Value = "Merchant")]
        Merchant = 2

    }

}
