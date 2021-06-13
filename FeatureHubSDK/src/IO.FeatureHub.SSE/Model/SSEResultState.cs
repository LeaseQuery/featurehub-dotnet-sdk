/* 
 * FeatureServiceApi
 *
 * This describes the API clients use for accessing features
 *
 * The version of the OpenAPI document: 1.1.2
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = IO.FeatureHub.SSE.Client.OpenAPIDateConverter;

namespace IO.FeatureHub.SSE.Model
{
    /// <summary>
    /// Defines SSEResultState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SSEResultState
    {
        /// <summary>
        /// Enum Ack for value: ack
        /// </summary>
        [EnumMember(Value = "ack")]
        Ack = 1,

        /// <summary>
        /// Enum Bye for value: bye
        /// </summary>
        [EnumMember(Value = "bye")]
        Bye = 2,

        /// <summary>
        /// Enum Failure for value: failure
        /// </summary>
        [EnumMember(Value = "failure")]
        Failure = 3,

        /// <summary>
        /// Enum Features for value: features
        /// </summary>
        [EnumMember(Value = "features")]
        Features = 4,

        /// <summary>
        /// Enum Feature for value: feature
        /// </summary>
        [EnumMember(Value = "feature")]
        Feature = 5,

        /// <summary>
        /// Enum Deletefeature for value: delete_feature
        /// </summary>
        [EnumMember(Value = "delete_feature")]
        Deletefeature = 6

    }

}
