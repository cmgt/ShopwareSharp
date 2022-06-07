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
    /// RelationshipsAnyOf
    /// </summary>
    public partial class RelationshipsAnyOf : IEquatable<RelationshipsAnyOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelationshipsAnyOf" /> class.
        /// </summary>
        /// <param name="links">links</param>
        /// <param name="data">Member, whose value represents \&quot;resource linkage\&quot;.</param>
        public RelationshipsAnyOf(RelationshipLinks? links = default, RelationshipToOne? data = default)
        {
            Links = links;
            Data = data;
        }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [JsonPropertyName("links")]
        public RelationshipLinks? Links { get; set; }

        /// <summary>
        /// Member, whose value represents \&quot;resource linkage\&quot;.
        /// </summary>
        /// <value>Member, whose value represents \&quot;resource linkage\&quot;.</value>
        [JsonPropertyName("data")]
        public RelationshipToOne? Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RelationshipsAnyOf {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as RelationshipsAnyOf);
        }

        /// <summary>
        /// Returns true if RelationshipsAnyOf instances are equal
        /// </summary>
        /// <param name="input">Instance of RelationshipsAnyOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelationshipsAnyOf? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
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
