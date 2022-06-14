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
    /// ContextTokenResponse
    /// </summary>
    public partial class ContextTokenResponse : IEquatable<ContextTokenResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContextTokenResponse" /> class.
        /// </summary>
        /// <param name="contextToken">Context token identifying the current user session.</param>
        public ContextTokenResponse(string? contextToken = default)
        {
            ContextToken = contextToken;
        }

        /// <summary>
        /// Context token identifying the current user session.
        /// </summary>
        /// <value>Context token identifying the current user session.</value>
        [JsonPropertyName("contextToken")]
        public string? ContextToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContextTokenResponse {\n");
            sb.Append("  ContextToken: ").Append(ContextToken).Append("\n");
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
            return this.Equals(input as ContextTokenResponse);
        }

        /// <summary>
        /// Returns true if ContextTokenResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ContextTokenResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContextTokenResponse? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContextToken == input.ContextToken ||
                    (this.ContextToken != null &&
                    this.ContextToken.Equals(input.ContextToken))
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
                if (this.ContextToken != null)
                {
                    hashCode = (hashCode * 59) + this.ContextToken.GetHashCode();
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
