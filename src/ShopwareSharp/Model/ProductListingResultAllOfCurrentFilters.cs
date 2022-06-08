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
    /// Contains the state of the filters. These can be used to create listing filters.
    /// </summary>
    [DataContract(Name = "ProductListingResult_allOf_currentFilters")]
    public partial class ProductListingResultAllOfCurrentFilters : IEquatable<ProductListingResultAllOfCurrentFilters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductListingResultAllOfCurrentFilters" /> class.
        /// </summary>
        /// <param name="navigationId">navigationId.</param>
        /// <param name="manufacturer">manufacturer.</param>
        /// <param name="price">price.</param>
        /// <param name="rating">rating.</param>
        /// <param name="shippingFree">shippingFree.</param>
        /// <param name="properties">properties.</param>
        public ProductListingResultAllOfCurrentFilters(string navigationId = default(string), List<Object> manufacturer = default(List<Object>), ProductListingResultAllOfCurrentFiltersPrice price = default(ProductListingResultAllOfCurrentFiltersPrice), int rating = default(int), bool shippingFree = default(bool), List<Object> properties = default(List<Object>))
        {
            this.NavigationId = navigationId;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Rating = rating;
            this.ShippingFree = shippingFree;
            this.Properties = properties;
        }

        /// <summary>
        /// Gets or Sets NavigationId
        /// </summary>
        [DataMember(Name = "navigationId", EmitDefaultValue = false)]
        public string NavigationId { get; set; }

        /// <summary>
        /// Gets or Sets Manufacturer
        /// </summary>
        [DataMember(Name = "manufacturer", EmitDefaultValue = false)]
        public List<Object> Manufacturer { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public ProductListingResultAllOfCurrentFiltersPrice Price { get; set; }

        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [DataMember(Name = "rating", EmitDefaultValue = false)]
        public int Rating { get; set; }

        /// <summary>
        /// Gets or Sets ShippingFree
        /// </summary>
        [DataMember(Name = "shipping-free", EmitDefaultValue = true)]
        public bool ShippingFree { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public List<Object> Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductListingResultAllOfCurrentFilters {\n");
            sb.Append("  NavigationId: ").Append(NavigationId).Append("\n");
            sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  ShippingFree: ").Append(ShippingFree).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(input as ProductListingResultAllOfCurrentFilters);
        }

        /// <summary>
        /// Returns true if ProductListingResultAllOfCurrentFilters instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductListingResultAllOfCurrentFilters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductListingResultAllOfCurrentFilters input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NavigationId == input.NavigationId ||
                    (this.NavigationId != null &&
                    this.NavigationId.Equals(input.NavigationId))
                ) && 
                (
                    this.Manufacturer == input.Manufacturer ||
                    this.Manufacturer != null &&
                    input.Manufacturer != null &&
                    this.Manufacturer.SequenceEqual(input.Manufacturer)
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Rating == input.Rating ||
                    this.Rating.Equals(input.Rating)
                ) && 
                (
                    this.ShippingFree == input.ShippingFree ||
                    this.ShippingFree.Equals(input.ShippingFree)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
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
                if (this.NavigationId != null)
                {
                    hashCode = (hashCode * 59) + this.NavigationId.GetHashCode();
                }
                if (this.Manufacturer != null)
                {
                    hashCode = (hashCode * 59) + this.Manufacturer.GetHashCode();
                }
                if (this.Price != null)
                {
                    hashCode = (hashCode * 59) + this.Price.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Rating.GetHashCode();
                hashCode = (hashCode * 59) + this.ShippingFree.GetHashCode();
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
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