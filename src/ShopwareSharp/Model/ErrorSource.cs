// <auto-generated>
/*
 * Shopware Store API
 *
 * This endpoint reference contains an overview of all endpoints comprising the Shopware Store API
 *
 * The version of the OpenAPI document: 6.4.9999999.9999999-dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace ShopwareSharp.Model
{
    /// <summary>
    /// ErrorSource
    /// </summary>
    public partial class ErrorSource : IEquatable<ErrorSource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorSource" /> class.
        /// </summary>
        /// <param name="pointer">A JSON Pointer [RFC6901] to the associated entity in the request document [e.g. \&quot;/data\&quot; for a primary data object, or \&quot;/data/attributes/title\&quot; for a specific attribute].</param>
        /// <param name="_parameter">A string indicating which query parameter caused the error.</param>
        public ErrorSource(string? pointer = default, string? _parameter = default)
        {
            Pointer = pointer;
            Parameter = _parameter;
        }

        /// <summary>
        /// A JSON Pointer [RFC6901] to the associated entity in the request document [e.g. \&quot;/data\&quot; for a primary data object, or \&quot;/data/attributes/title\&quot; for a specific attribute].
        /// </summary>
        /// <value>A JSON Pointer [RFC6901] to the associated entity in the request document [e.g. \&quot;/data\&quot; for a primary data object, or \&quot;/data/attributes/title\&quot; for a specific attribute].</value>
        [JsonPropertyName("pointer")]
        public string? Pointer { get; set; }

        /// <summary>
        /// A string indicating which query parameter caused the error.
        /// </summary>
        /// <value>A string indicating which query parameter caused the error.</value>
        [JsonPropertyName("parameter")]
        public string? Parameter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ErrorSource {\n");
            sb.Append("  Pointer: ").Append(Pointer).Append("\n");
            sb.Append("  Parameter: ").Append(Parameter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object? input)
        {
            return this.Equals(input as ErrorSource);
        }

        /// <summary>
        /// Returns true if ErrorSource instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorSource? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Pointer == input.Pointer ||
                    (this.Pointer != null &&
                    this.Pointer.Equals(input.Pointer))
                ) && 
                (
                    this.Parameter == input.Parameter ||
                    (this.Parameter != null &&
                    this.Parameter.Equals(input.Parameter))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Pointer != null)
                {
                    hashCode = (hashCode * 59) + this.Pointer.GetHashCode();
                }
                if (this.Parameter != null)
                {
                    hashCode = (hashCode * 59) + this.Parameter.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
