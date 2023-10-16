/*
 * FeeWise Partner API
 *
 * API for partners
 *
 * The version of the OpenAPI document: 0.0.100
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
    /// Defines ArtifactType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ArtifactType
    {
        /// <summary>
        /// Enum Invoice for value: Invoice
        /// </summary>
        [EnumMember(Value = "Invoice")]
        Invoice = 1,

        /// <summary>
        /// Enum TrustDeposit for value: TrustDeposit
        /// </summary>
        [EnumMember(Value = "TrustDeposit")]
        TrustDeposit = 2,

        /// <summary>
        /// Enum Matter for value: Matter
        /// </summary>
        [EnumMember(Value = "Matter")]
        Matter = 3,

        /// <summary>
        /// Enum OfficeReplenishment for value: OfficeReplenishment
        /// </summary>
        [EnumMember(Value = "OfficeReplenishment")]
        OfficeReplenishment = 4,

        /// <summary>
        /// Enum TrustReplenishment for value: TrustReplenishment
        /// </summary>
        [EnumMember(Value = "TrustReplenishment")]
        TrustReplenishment = 5,

        /// <summary>
        /// Enum Charge for value: Charge
        /// </summary>
        [EnumMember(Value = "Charge")]
        Charge = 6

    }

}
