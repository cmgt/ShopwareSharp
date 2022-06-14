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
    /// ProductListingResultAllOfCurrentFiltersPrice
    /// </summary>
    public partial class ProductListingResultAllOfCurrentFiltersPrice : IEquatable<ProductListingResultAllOfCurrentFiltersPrice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductListingResultAllOfCurrentFiltersPrice" /> class.
        /// </summary>
        /// <param name="min">min</param>
        /// <param name="max">max</param>
        public ProductListingResultAllOfCurrentFiltersPrice(int? min = default, int? max = default)
        {
            Min = min;
            Max = max;
        }

        /// <summary>
        /// Gets or Sets Min
        /// </summary>
        [JsonPropertyName("min")]
        public int? Min { get; set; }

        /// <summary>
        /// Gets or Sets Max
        /// </summary>
        [JsonPropertyName("max")]
        public int? Max { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductListingResultAllOfCurrentFiltersPrice {\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
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
            return this.Equals(input as ProductListingResultAllOfCurrentFiltersPrice);
        }

        /// <summary>
        /// Returns true if ProductListingResultAllOfCurrentFiltersPrice instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductListingResultAllOfCurrentFiltersPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductListingResultAllOfCurrentFiltersPrice? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Min == input.Min ||
                    this.Min.Equals(input.Min)
                ) && 
                (
                    this.Max == input.Max ||
                    this.Max.Equals(input.Max)
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
                hashCode = (hashCode * 59) + this.Min.GetHashCode();
                hashCode = (hashCode * 59) + this.Max.GetHashCode();
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
