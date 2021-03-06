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
    /// ProductListingResultAllOf
    /// </summary>
    public partial class ProductListingResultAllOf : IEquatable<ProductListingResultAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductListingResultAllOf" /> class.
        /// </summary>
        /// <param name="currentFilters">currentFilters</param>
        /// <param name="availableSortings">Contains the available sorting. These can be used to show a sorting select-box in the product listing.</param>
        /// <param name="sorting">sorting</param>
        /// <param name="elements">elements</param>
        public ProductListingResultAllOf(ProductListingResultAllOfCurrentFilters? currentFilters = default, List<Object>? availableSortings = default, string? sorting = default, List<Product>? elements = default)
        {
            CurrentFilters = currentFilters;
            AvailableSortings = availableSortings;
            Sorting = sorting;
            Elements = elements;
        }

        /// <summary>
        /// Gets or Sets CurrentFilters
        /// </summary>
        [JsonPropertyName("currentFilters")]
        public ProductListingResultAllOfCurrentFilters? CurrentFilters { get; set; }

        /// <summary>
        /// Contains the available sorting. These can be used to show a sorting select-box in the product listing.
        /// </summary>
        /// <value>Contains the available sorting. These can be used to show a sorting select-box in the product listing.</value>
        [JsonPropertyName("availableSortings")]
        public List<Object>? AvailableSortings { get; set; }

        /// <summary>
        /// Gets or Sets Sorting
        /// </summary>
        [JsonPropertyName("sorting")]
        public string? Sorting { get; set; }

        /// <summary>
        /// Gets or Sets Elements
        /// </summary>
        [JsonPropertyName("elements")]
        public List<Product>? Elements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductListingResultAllOf {\n");
            sb.Append("  CurrentFilters: ").Append(CurrentFilters).Append("\n");
            sb.Append("  AvailableSortings: ").Append(AvailableSortings).Append("\n");
            sb.Append("  Sorting: ").Append(Sorting).Append("\n");
            sb.Append("  Elements: ").Append(Elements).Append("\n");
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
            return this.Equals(input as ProductListingResultAllOf);
        }

        /// <summary>
        /// Returns true if ProductListingResultAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductListingResultAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductListingResultAllOf? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CurrentFilters == input.CurrentFilters ||
                    (this.CurrentFilters != null &&
                    this.CurrentFilters.Equals(input.CurrentFilters))
                ) && 
                (
                    this.AvailableSortings == input.AvailableSortings ||
                    this.AvailableSortings != null &&
                    input.AvailableSortings != null &&
                    this.AvailableSortings.SequenceEqual(input.AvailableSortings)
                ) && 
                (
                    this.Sorting == input.Sorting ||
                    (this.Sorting != null &&
                    this.Sorting.Equals(input.Sorting))
                ) && 
                (
                    this.Elements == input.Elements ||
                    this.Elements != null &&
                    input.Elements != null &&
                    this.Elements.SequenceEqual(input.Elements)
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
                if (this.CurrentFilters != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentFilters.GetHashCode();
                }
                if (this.AvailableSortings != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableSortings.GetHashCode();
                }
                if (this.Sorting != null)
                {
                    hashCode = (hashCode * 59) + this.Sorting.GetHashCode();
                }
                if (this.Elements != null)
                {
                    hashCode = (hashCode * 59) + this.Elements.GetHashCode();
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
