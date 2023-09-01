/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.80
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
    /// A token represents a customer&#39;s payment details.  Payment Tokens can be used in place of a payment method, for Charge types.  If the token type is SingleUse, it can only be used once. 
    /// </summary>
    /// <value>A token represents a customer&#39;s payment details.  Payment Tokens can be used in place of a payment method, for Charge types.  If the token type is SingleUse, it can only be used once. </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TokenType
    {
        /// <summary>
        /// Enum SingleUse for value: SingleUse
        /// </summary>
        [EnumMember(Value = "SingleUse")]
        SingleUse = 1,

        /// <summary>
        /// Enum MultiUse for value: MultiUse
        /// </summary>
        [EnumMember(Value = "MultiUse")]
        MultiUse = 2

    }

}
