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
    /// An object describing the server&#39;s implementation
    /// </summary>
    public partial class Jsonapi : IEquatable<Jsonapi>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Jsonapi" /> class.
        /// </summary>
        /// <param name="version">version</param>
        /// <param name="meta">Non-standard meta-information that can not be represented as an attribute or relationship.</param>
        public Jsonapi(string? version = default, Dictionary<string, Object>? meta = default)
        {
            _Version = version;
            Meta = meta;
        }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [JsonPropertyName("version")]
        public string? _Version { get; set; }

        /// <summary>
        /// Non-standard meta-information that can not be represented as an attribute or relationship.
        /// </summary>
        /// <value>Non-standard meta-information that can not be represented as an attribute or relationship.</value>
        [JsonPropertyName("meta")]
        public Dictionary<string, Object>? Meta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Jsonapi {\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return this.Equals(input as Jsonapi);
        }

        /// <summary>
        /// Returns true if Jsonapi instances are equal
        /// </summary>
        /// <param name="input">Instance of Jsonapi to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Jsonapi? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.Meta == input.Meta ||
                    this.Meta != null &&
                    input.Meta != null &&
                    this.Meta.SequenceEqual(input.Meta)
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
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                if (this.Meta != null)
                {
                    hashCode = (hashCode * 59) + this.Meta.GetHashCode();
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
