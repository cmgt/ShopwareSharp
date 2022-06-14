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
    /// ReadCategoryRequest
    /// </summary>
    public partial class ReadCategoryRequest : IEquatable<ReadCategoryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadCategoryRequest" /> class.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="productListingCriteria"></param>
        /// <param name="order">Specifies the sorting of the products by &#x60;availableSortings&#x60;. If not set, the default sorting will be set according to the shop settings. The available sorting options are sent within the response under the &#x60;availableSortings&#x60; key. In order to sort by a field, consider using the &#x60;sort&#x60; parameter from the listing criteria. Do not use both parameters together, as it might lead to unexpected results.</param>
        /// <param name="manufacturer">Filter by manufacturers. List of manufacturer identifiers separated by a &#x60;|&#x60;.</param>
        /// <param name="rating">Filter products with a minimum average rating.</param>
        /// <param name="properties">Filters products by their properties. List of property identifiers separated by a &#x60;|&#x60;.</param>
        /// <param name="propertyWhitelist">A whitelist of property identifiers which can be used for filtering. List of property identifiers separated by a &#x60;|&#x60;. The &#x60;property-filter&#x60; must be &#x60;true&#x60;, otherwise the whitelist has no effect.</param>
        /// <param name="reduceAggregations">By sending the parameter &#x60;reduce-aggregations&#x60; , the post-filters that were applied by the customer, are also applied to the aggregations. This has the consequence that only values are returned in the aggregations that would lead to further filter results. This parameter is a flag, the value has no effect.</param>
        /// <param name="p">Search result page (default to 1)</param>
        /// <param name="minPrice">Filters by a minimum product price. Has to be lower than the &#x60;max-price&#x60; filter. (default to 0)</param>
        /// <param name="maxPrice">Filters by a maximum product price. Has to be higher than the &#x60;min-price&#x60; filter. (default to 0)</param>
        /// <param name="shippingFree">Filters products that are marked as shipping-free. (default to false)</param>
        /// <param name="manufacturerFilter">Enables/disabled filtering by manufacturer. If set to false, the &#x60;manufacturer&#x60; filter will be ignored. Also the &#x60;aggregations[manufacturer]&#x60; key will be removed from the response. (default to true)</param>
        /// <param name="priceFilter">Enables/disabled filtering by price. If set to false, the &#x60;min-price&#x60; and &#x60;max-price&#x60; filter will be ignored. Also the &#x60;aggregations[price]&#x60; key will be removed from the response. (default to true)</param>
        /// <param name="ratingFilter">Enables/disabled filtering by rating. If set to false, the &#x60;rating&#x60; filter will be ignored. Also the &#x60;aggregations[rating]&#x60; key will be removed from the response. (default to true)</param>
        /// <param name="shippingFreeFilter">Enables/disabled filtering by shipping-free products. If set to false, the &#x60;shipping-free&#x60; filter will be ignored. Also the &#x60;aggregations[shipping-free]&#x60; key will be removed from the response. (default to true)</param>
        /// <param name="propertyFilter">Enables/disabled filtering by properties products. If set to false, the &#x60;properties&#x60; filter will be ignored. Also the &#x60;aggregations[properties]&#x60; key will be removed from the response. (default to true)</param>
        public ReadCategoryRequest(Criteria criteria, ProductListingCriteria productListingCriteria, string? order = default, string? manufacturer = default, int? rating = default, string? properties = default, string? propertyWhitelist = default, string? reduceAggregations = default, int? p = 1, int? minPrice = 0, int? maxPrice = 0, bool? shippingFree = false, bool? manufacturerFilter = true, bool? priceFilter = true, bool? ratingFilter = true, bool? shippingFreeFilter = true, bool? propertyFilter = true)
        {
            Criteria = criteria;
            ProductListingCriteria = productListingCriteria;
            Order = order;
            Manufacturer = manufacturer;
            Rating = rating;
            Properties = properties;
            PropertyWhitelist = propertyWhitelist;
            ReduceAggregations = reduceAggregations;
            P = p;
            MinPrice = minPrice;
            MaxPrice = maxPrice;
            ShippingFree = shippingFree;
            ManufacturerFilter = manufacturerFilter;
            PriceFilter = priceFilter;
            RatingFilter = ratingFilter;
            ShippingFreeFilter = shippingFreeFilter;
            PropertyFilter = propertyFilter;
        }

        /// <summary>
        /// Gets or Sets Criteria
        /// </summary>
        public Criteria Criteria { get; set; }

        /// <summary>
        /// Gets or Sets ProductListingCriteria
        /// </summary>
        public ProductListingCriteria ProductListingCriteria { get; set; }

        /// <summary>
        /// Specifies the sorting of the products by &#x60;availableSortings&#x60;. If not set, the default sorting will be set according to the shop settings. The available sorting options are sent within the response under the &#x60;availableSortings&#x60; key. In order to sort by a field, consider using the &#x60;sort&#x60; parameter from the listing criteria. Do not use both parameters together, as it might lead to unexpected results.
        /// </summary>
        /// <value>Specifies the sorting of the products by &#x60;availableSortings&#x60;. If not set, the default sorting will be set according to the shop settings. The available sorting options are sent within the response under the &#x60;availableSortings&#x60; key. In order to sort by a field, consider using the &#x60;sort&#x60; parameter from the listing criteria. Do not use both parameters together, as it might lead to unexpected results.</value>
        [JsonPropertyName("order")]
        public string? Order { get; set; }

        /// <summary>
        /// Filter by manufacturers. List of manufacturer identifiers separated by a &#x60;|&#x60;.
        /// </summary>
        /// <value>Filter by manufacturers. List of manufacturer identifiers separated by a &#x60;|&#x60;.</value>
        [JsonPropertyName("manufacturer")]
        public string? Manufacturer { get; set; }

        /// <summary>
        /// Filter products with a minimum average rating.
        /// </summary>
        /// <value>Filter products with a minimum average rating.</value>
        [JsonPropertyName("rating")]
        public int? Rating { get; set; }

        /// <summary>
        /// Filters products by their properties. List of property identifiers separated by a &#x60;|&#x60;.
        /// </summary>
        /// <value>Filters products by their properties. List of property identifiers separated by a &#x60;|&#x60;.</value>
        [JsonPropertyName("properties")]
        public string? Properties { get; set; }

        /// <summary>
        /// A whitelist of property identifiers which can be used for filtering. List of property identifiers separated by a &#x60;|&#x60;. The &#x60;property-filter&#x60; must be &#x60;true&#x60;, otherwise the whitelist has no effect.
        /// </summary>
        /// <value>A whitelist of property identifiers which can be used for filtering. List of property identifiers separated by a &#x60;|&#x60;. The &#x60;property-filter&#x60; must be &#x60;true&#x60;, otherwise the whitelist has no effect.</value>
        [JsonPropertyName("property-whitelist")]
        public string? PropertyWhitelist { get; set; }

        /// <summary>
        /// By sending the parameter &#x60;reduce-aggregations&#x60; , the post-filters that were applied by the customer, are also applied to the aggregations. This has the consequence that only values are returned in the aggregations that would lead to further filter results. This parameter is a flag, the value has no effect.
        /// </summary>
        /// <value>By sending the parameter &#x60;reduce-aggregations&#x60; , the post-filters that were applied by the customer, are also applied to the aggregations. This has the consequence that only values are returned in the aggregations that would lead to further filter results. This parameter is a flag, the value has no effect.</value>
        [JsonPropertyName("reduce-aggregations")]
        public string? ReduceAggregations { get; set; }

        /// <summary>
        /// Search result page
        /// </summary>
        /// <value>Search result page</value>
        [JsonPropertyName("p")]
        public int? P { get; set; }

        /// <summary>
        /// Filters by a minimum product price. Has to be lower than the &#x60;max-price&#x60; filter.
        /// </summary>
        /// <value>Filters by a minimum product price. Has to be lower than the &#x60;max-price&#x60; filter.</value>
        [JsonPropertyName("min-price")]
        public int? MinPrice { get; set; }

        /// <summary>
        /// Filters by a maximum product price. Has to be higher than the &#x60;min-price&#x60; filter.
        /// </summary>
        /// <value>Filters by a maximum product price. Has to be higher than the &#x60;min-price&#x60; filter.</value>
        [JsonPropertyName("max-price")]
        public int? MaxPrice { get; set; }

        /// <summary>
        /// Filters products that are marked as shipping-free.
        /// </summary>
        /// <value>Filters products that are marked as shipping-free.</value>
        [JsonPropertyName("shipping-free")]
        public bool? ShippingFree { get; set; }

        /// <summary>
        /// Enables/disabled filtering by manufacturer. If set to false, the &#x60;manufacturer&#x60; filter will be ignored. Also the &#x60;aggregations[manufacturer]&#x60; key will be removed from the response.
        /// </summary>
        /// <value>Enables/disabled filtering by manufacturer. If set to false, the &#x60;manufacturer&#x60; filter will be ignored. Also the &#x60;aggregations[manufacturer]&#x60; key will be removed from the response.</value>
        [JsonPropertyName("manufacturer-filter")]
        public bool? ManufacturerFilter { get; set; }

        /// <summary>
        /// Enables/disabled filtering by price. If set to false, the &#x60;min-price&#x60; and &#x60;max-price&#x60; filter will be ignored. Also the &#x60;aggregations[price]&#x60; key will be removed from the response.
        /// </summary>
        /// <value>Enables/disabled filtering by price. If set to false, the &#x60;min-price&#x60; and &#x60;max-price&#x60; filter will be ignored. Also the &#x60;aggregations[price]&#x60; key will be removed from the response.</value>
        [JsonPropertyName("price-filter")]
        public bool? PriceFilter { get; set; }

        /// <summary>
        /// Enables/disabled filtering by rating. If set to false, the &#x60;rating&#x60; filter will be ignored. Also the &#x60;aggregations[rating]&#x60; key will be removed from the response.
        /// </summary>
        /// <value>Enables/disabled filtering by rating. If set to false, the &#x60;rating&#x60; filter will be ignored. Also the &#x60;aggregations[rating]&#x60; key will be removed from the response.</value>
        [JsonPropertyName("rating-filter")]
        public bool? RatingFilter { get; set; }

        /// <summary>
        /// Enables/disabled filtering by shipping-free products. If set to false, the &#x60;shipping-free&#x60; filter will be ignored. Also the &#x60;aggregations[shipping-free]&#x60; key will be removed from the response.
        /// </summary>
        /// <value>Enables/disabled filtering by shipping-free products. If set to false, the &#x60;shipping-free&#x60; filter will be ignored. Also the &#x60;aggregations[shipping-free]&#x60; key will be removed from the response.</value>
        [JsonPropertyName("shipping-free-filter")]
        public bool? ShippingFreeFilter { get; set; }

        /// <summary>
        /// Enables/disabled filtering by properties products. If set to false, the &#x60;properties&#x60; filter will be ignored. Also the &#x60;aggregations[properties]&#x60; key will be removed from the response.
        /// </summary>
        /// <value>Enables/disabled filtering by properties products. If set to false, the &#x60;properties&#x60; filter will be ignored. Also the &#x60;aggregations[properties]&#x60; key will be removed from the response.</value>
        [JsonPropertyName("property-filter")]
        public bool? PropertyFilter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReadCategoryRequest {\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  PropertyWhitelist: ").Append(PropertyWhitelist).Append("\n");
            sb.Append("  ReduceAggregations: ").Append(ReduceAggregations).Append("\n");
            sb.Append("  P: ").Append(P).Append("\n");
            sb.Append("  MinPrice: ").Append(MinPrice).Append("\n");
            sb.Append("  MaxPrice: ").Append(MaxPrice).Append("\n");
            sb.Append("  ShippingFree: ").Append(ShippingFree).Append("\n");
            sb.Append("  ManufacturerFilter: ").Append(ManufacturerFilter).Append("\n");
            sb.Append("  PriceFilter: ").Append(PriceFilter).Append("\n");
            sb.Append("  RatingFilter: ").Append(RatingFilter).Append("\n");
            sb.Append("  ShippingFreeFilter: ").Append(ShippingFreeFilter).Append("\n");
            sb.Append("  PropertyFilter: ").Append(PropertyFilter).Append("\n");
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
            return this.Equals(input as ReadCategoryRequest);
        }

        /// <summary>
        /// Returns true if ReadCategoryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ReadCategoryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReadCategoryRequest? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.Manufacturer == input.Manufacturer ||
                    (this.Manufacturer != null &&
                    this.Manufacturer.Equals(input.Manufacturer))
                ) && 
                (
                    this.Rating == input.Rating ||
                    this.Rating.Equals(input.Rating)
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && 
                (
                    this.PropertyWhitelist == input.PropertyWhitelist ||
                    (this.PropertyWhitelist != null &&
                    this.PropertyWhitelist.Equals(input.PropertyWhitelist))
                ) && 
                (
                    this.ReduceAggregations == input.ReduceAggregations ||
                    (this.ReduceAggregations != null &&
                    this.ReduceAggregations.Equals(input.ReduceAggregations))
                ) && 
                (
                    this.P == input.P ||
                    this.P.Equals(input.P)
                ) && 
                (
                    this.MinPrice == input.MinPrice ||
                    this.MinPrice.Equals(input.MinPrice)
                ) && 
                (
                    this.MaxPrice == input.MaxPrice ||
                    this.MaxPrice.Equals(input.MaxPrice)
                ) && 
                (
                    this.ShippingFree == input.ShippingFree ||
                    this.ShippingFree.Equals(input.ShippingFree)
                ) && 
                (
                    this.ManufacturerFilter == input.ManufacturerFilter ||
                    this.ManufacturerFilter.Equals(input.ManufacturerFilter)
                ) && 
                (
                    this.PriceFilter == input.PriceFilter ||
                    this.PriceFilter.Equals(input.PriceFilter)
                ) && 
                (
                    this.RatingFilter == input.RatingFilter ||
                    this.RatingFilter.Equals(input.RatingFilter)
                ) && 
                (
                    this.ShippingFreeFilter == input.ShippingFreeFilter ||
                    this.ShippingFreeFilter.Equals(input.ShippingFreeFilter)
                ) && 
                (
                    this.PropertyFilter == input.PropertyFilter ||
                    this.PropertyFilter.Equals(input.PropertyFilter)
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
                if (this.Order != null)
                {
                    hashCode = (hashCode * 59) + this.Order.GetHashCode();
                }
                if (this.Manufacturer != null)
                {
                    hashCode = (hashCode * 59) + this.Manufacturer.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Rating.GetHashCode();
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                if (this.PropertyWhitelist != null)
                {
                    hashCode = (hashCode * 59) + this.PropertyWhitelist.GetHashCode();
                }
                if (this.ReduceAggregations != null)
                {
                    hashCode = (hashCode * 59) + this.ReduceAggregations.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.P.GetHashCode();
                hashCode = (hashCode * 59) + this.MinPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.ShippingFree.GetHashCode();
                hashCode = (hashCode * 59) + this.ManufacturerFilter.GetHashCode();
                hashCode = (hashCode * 59) + this.PriceFilter.GetHashCode();
                hashCode = (hashCode * 59) + this.RatingFilter.GetHashCode();
                hashCode = (hashCode * 59) + this.ShippingFreeFilter.GetHashCode();
                hashCode = (hashCode * 59) + this.PropertyFilter.GetHashCode();
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
            // MinPrice (int) minimum
            if (this.MinPrice < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinPrice, must be a value greater than or equal to 0.", new [] { "MinPrice" });
            }

            // MaxPrice (int) minimum
            if (this.MaxPrice < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxPrice, must be a value greater than or equal to 0.", new [] { "MaxPrice" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type ReadCategoryRequest
    /// </summary>
    public class ReadCategoryRequestJsonConverter : JsonConverter<ReadCategoryRequest>
    {
        /// <summary>
        /// Returns a boolean if the type is compatible with this converter.
        /// </summary>
        /// <param name="typeToConvert"></param>
        /// <returns></returns>
        public override bool CanConvert(Type typeToConvert) => typeof(ReadCategoryRequest).IsAssignableFrom(typeToConvert);

        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ReadCategoryRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();

            Utf8JsonReader criteriaReader = reader;
            bool criteriaDeserialized = Client.ClientUtils.TryDeserialize<Criteria>(ref criteriaReader, options, out Criteria? criteria);

            Utf8JsonReader productListingCriteriaReader = reader;
            bool productListingCriteriaDeserialized = Client.ClientUtils.TryDeserialize<ProductListingCriteria>(ref productListingCriteriaReader, options, out ProductListingCriteria? productListingCriteria);

            string? order = default;
            string? manufacturer = default;
            int? rating = default;
            string? properties = default;
            string? propertyWhitelist = default;
            string? reduceAggregations = default;
            int? p = default;
            int? minPrice = default;
            int? maxPrice = default;
            bool? shippingFree = default;
            bool? manufacturerFilter = default;
            bool? priceFilter = default;
            bool? ratingFilter = default;
            bool? shippingFreeFilter = default;
            bool? propertyFilter = default;

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject && currentDepth == reader.CurrentDepth)
                    break;

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    string? propertyName = reader.GetString();
                    reader.Read();

                    switch (propertyName)
                    {
                        case "order":
                            order = reader.GetString();
                            break;
                        case "manufacturer":
                            manufacturer = reader.GetString();
                            break;
                        case "rating":
                            rating = reader.GetInt32();
                            break;
                        case "properties":
                            properties = reader.GetString();
                            break;
                        case "property-whitelist":
                            propertyWhitelist = reader.GetString();
                            break;
                        case "reduce-aggregations":
                            reduceAggregations = reader.GetString();
                            break;
                        case "p":
                            p = reader.GetInt32();
                            break;
                        case "min-price":
                            minPrice = reader.GetInt32();
                            break;
                        case "max-price":
                            maxPrice = reader.GetInt32();
                            break;
                        case "shipping-free":
                            shippingFree = reader.GetBoolean();
                            break;
                        case "manufacturer-filter":
                            manufacturerFilter = reader.GetBoolean();
                            break;
                        case "price-filter":
                            priceFilter = reader.GetBoolean();
                            break;
                        case "rating-filter":
                            ratingFilter = reader.GetBoolean();
                            break;
                        case "shipping-free-filter":
                            shippingFreeFilter = reader.GetBoolean();
                            break;
                        case "property-filter":
                            propertyFilter = reader.GetBoolean();
                            break;
                    }
                }
            }

            return new ReadCategoryRequest(criteria, productListingCriteria, order, manufacturer, rating, properties, propertyWhitelist, reduceAggregations, p, minPrice, maxPrice, shippingFree, manufacturerFilter, priceFilter, ratingFilter, shippingFreeFilter, propertyFilter);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="readCategoryRequest"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ReadCategoryRequest readCategoryRequest, JsonSerializerOptions options) => throw new NotImplementedException();
    }
}
