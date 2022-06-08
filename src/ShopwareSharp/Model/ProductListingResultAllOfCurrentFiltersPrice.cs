/*
 * Shopware Store API
 *
 * This endpoint reference contains an overview of all endpoints comprising the Shopware Store API
 *
 * The version of the OpenAPI document: 6.4.9999999.9999999-dev
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
using FileParameter = ShopwareSharp.Client.FileParameter;
using OpenAPIDateConverter = ShopwareSharp.Client.OpenAPIDateConverter;

namespace ShopwareSharp.Model
{
    /// <summary>
    /// ProductListingResultAllOfCurrentFiltersPrice
    /// </summary>
    [DataContract(Name = "ProductListingResult_allOf_currentFilters_price")]
    public partial class ProductListingResultAllOfCurrentFiltersPrice : IEquatable<ProductListingResultAllOfCurrentFiltersPrice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductListingResultAllOfCurrentFiltersPrice" /> class.
        /// </summary>
        /// <param name="min">min.</param>
        /// <param name="max">max.</param>
        public ProductListingResultAllOfCurrentFiltersPrice(int min = default(int), int max = default(int))
        {
            this.Min = min;
            this.Max = max;
        }

        /// <summary>
        /// Gets or Sets Min
        /// </summary>
        [DataMember(Name = "min", EmitDefaultValue = false)]
        public int Min { get; set; }

        /// <summary>
        /// Gets or Sets Max
        /// </summary>
        [DataMember(Name = "max", EmitDefaultValue = false)]
        public int Max { get; set; }

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
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductListingResultAllOfCurrentFiltersPrice);
        }

        /// <summary>
        /// Returns true if ProductListingResultAllOfCurrentFiltersPrice instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductListingResultAllOfCurrentFiltersPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductListingResultAllOfCurrentFiltersPrice input)
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