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
    /// ReadLandingPageRequest
    /// </summary>
    [DataContract(Name = "readLandingPage_request")]
    public partial class ReadLandingPageRequest : IEquatable<ReadLandingPageRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadLandingPageRequest" /> class.
        /// </summary>
        /// <param name="page">Search result page.</param>
        /// <param name="limit">Number of items per result page. If not set, the limit will be set according to the default products per page, defined in the system settings..</param>
        /// <param name="filter">List of filters to restrict the search result. For more information, see [Search Queries &gt; Filter](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#filter).</param>
        /// <param name="sort">Sorting in the search result..</param>
        /// <param name="postFilter">Filters that applied without affecting aggregations. For more information, see [Search Queries &gt; Post Filter](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#post-filter).</param>
        /// <param name="associations">Used to fetch associations which are not fetched by default..</param>
        /// <param name="aggregations">Used to perform aggregations on the search result. For more information, see [Search Queries &gt; Aggregations](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#aggregations).</param>
        /// <param name="grouping">Perform groupings over certain fields.</param>
        /// <param name="order">Specifies the sorting of the products by &#x60;availableSortings&#x60;. If not set, the default sorting will be set according to the shop settings. The available sorting options are sent within the response under the &#x60;availableSortings&#x60; key. In order to sort by a field, consider using the &#x60;sort&#x60; parameter from the listing criteria. Do not use both parameters together, as it might lead to unexpected results..</param>
        /// <param name="p">Search result page (default to 1).</param>
        /// <param name="manufacturer">Filter by manufacturers. List of manufacturer identifiers separated by a &#x60;|&#x60;..</param>
        /// <param name="minPrice">Filters by a minimum product price. Has to be lower than the &#x60;max-price&#x60; filter. (default to 0).</param>
        /// <param name="maxPrice">Filters by a maximum product price. Has to be higher than the &#x60;min-price&#x60; filter. (default to 0).</param>
        /// <param name="rating">Filter products with a minimum average rating..</param>
        /// <param name="shippingFree">Filters products that are marked as shipping-free. (default to false).</param>
        /// <param name="properties">Filters products by their properties. List of property identifiers separated by a &#x60;|&#x60;..</param>
        /// <param name="manufacturerFilter">Enables/disabled filtering by manufacturer. If set to false, the &#x60;manufacturer&#x60; filter will be ignored. Also the &#x60;aggregations[manufacturer]&#x60; key will be removed from the response. (default to true).</param>
        /// <param name="priceFilter">Enables/disabled filtering by price. If set to false, the &#x60;min-price&#x60; and &#x60;max-price&#x60; filter will be ignored. Also the &#x60;aggregations[price]&#x60; key will be removed from the response. (default to true).</param>
        /// <param name="ratingFilter">Enables/disabled filtering by rating. If set to false, the &#x60;rating&#x60; filter will be ignored. Also the &#x60;aggregations[rating]&#x60; key will be removed from the response. (default to true).</param>
        /// <param name="shippingFreeFilter">Enables/disabled filtering by shipping-free products. If set to false, the &#x60;shipping-free&#x60; filter will be ignored. Also the &#x60;aggregations[shipping-free]&#x60; key will be removed from the response. (default to true).</param>
        /// <param name="propertyFilter">Enables/disabled filtering by properties products. If set to false, the &#x60;properties&#x60; filter will be ignored. Also the &#x60;aggregations[properties]&#x60; key will be removed from the response. (default to true).</param>
        /// <param name="propertyWhitelist">A whitelist of property identifiers which can be used for filtering. List of property identifiers separated by a &#x60;|&#x60;. The &#x60;property-filter&#x60; must be &#x60;true&#x60;, otherwise the whitelist has no effect..</param>
        /// <param name="reduceAggregations">By sending the parameter &#x60;reduce-aggregations&#x60; , the post-filters that were applied by the customer, are also applied to the aggregations. This has the consequence that only values are returned in the aggregations that would lead to further filter results. This parameter is a flag, the value has no effect..</param>
        /// <param name="slots">Resolves only the given slot identifiers. The identifiers have to be seperated by a &#x60;|&#x60; character..</param>
        public ReadLandingPageRequest(int page = default(int), int limit = default(int), List<CriteriaFilterInner> filter = default(List<CriteriaFilterInner>), List<CriteriaSortInner> sort = default(List<CriteriaSortInner>), List<CriteriaFilterInner> postFilter = default(List<CriteriaFilterInner>), Object associations = default(Object), List<CriteriaAggregationsInner> aggregations = default(List<CriteriaAggregationsInner>), List<string> grouping = default(List<string>), string order = default(string), int p = 1, string manufacturer = default(string), int minPrice = 0, int maxPrice = 0, int rating = default(int), bool shippingFree = false, string properties = default(string), bool manufacturerFilter = true, bool priceFilter = true, bool ratingFilter = true, bool shippingFreeFilter = true, bool propertyFilter = true, string propertyWhitelist = default(string), string reduceAggregations = default(string), string slots = default(string))
        {
            this.Page = page;
            this.Limit = limit;
            this.Filter = filter;
            this.Sort = sort;
            this.PostFilter = postFilter;
            this.Associations = associations;
            this.Aggregations = aggregations;
            this.Grouping = grouping;
            this.Order = order;
            this.P = p;
            this.Manufacturer = manufacturer;
            this.MinPrice = minPrice;
            this.MaxPrice = maxPrice;
            this.Rating = rating;
            this.ShippingFree = shippingFree;
            this.Properties = properties;
            this.ManufacturerFilter = manufacturerFilter;
            this.PriceFilter = priceFilter;
            this.RatingFilter = ratingFilter;
            this.ShippingFreeFilter = shippingFreeFilter;
            this.PropertyFilter = propertyFilter;
            this.PropertyWhitelist = propertyWhitelist;
            this.ReduceAggregations = reduceAggregations;
            this.Slots = slots;
        }

        /// <summary>
        /// Search result page
        /// </summary>
        /// <value>Search result page</value>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public int Page { get; set; }

        /// <summary>
        /// Number of items per result page. If not set, the limit will be set according to the default products per page, defined in the system settings.
        /// </summary>
        /// <value>Number of items per result page. If not set, the limit will be set according to the default products per page, defined in the system settings.</value>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int Limit { get; set; }

        /// <summary>
        /// List of filters to restrict the search result. For more information, see [Search Queries &gt; Filter](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#filter)
        /// </summary>
        /// <value>List of filters to restrict the search result. For more information, see [Search Queries &gt; Filter](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#filter)</value>
        [DataMember(Name = "filter", EmitDefaultValue = false)]
        public List<CriteriaFilterInner> Filter { get; set; }

        /// <summary>
        /// Sorting in the search result.
        /// </summary>
        /// <value>Sorting in the search result.</value>
        [DataMember(Name = "sort", EmitDefaultValue = false)]
        public List<CriteriaSortInner> Sort { get; set; }

        /// <summary>
        /// Filters that applied without affecting aggregations. For more information, see [Search Queries &gt; Post Filter](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#post-filter)
        /// </summary>
        /// <value>Filters that applied without affecting aggregations. For more information, see [Search Queries &gt; Post Filter](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#post-filter)</value>
        [DataMember(Name = "post-filter", EmitDefaultValue = false)]
        public List<CriteriaFilterInner> PostFilter { get; set; }

        /// <summary>
        /// Used to fetch associations which are not fetched by default.
        /// </summary>
        /// <value>Used to fetch associations which are not fetched by default.</value>
        [DataMember(Name = "associations", EmitDefaultValue = false)]
        public Object Associations { get; set; }

        /// <summary>
        /// Used to perform aggregations on the search result. For more information, see [Search Queries &gt; Aggregations](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#aggregations)
        /// </summary>
        /// <value>Used to perform aggregations on the search result. For more information, see [Search Queries &gt; Aggregations](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#aggregations)</value>
        [DataMember(Name = "aggregations", EmitDefaultValue = false)]
        public List<CriteriaAggregationsInner> Aggregations { get; set; }

        /// <summary>
        /// Perform groupings over certain fields
        /// </summary>
        /// <value>Perform groupings over certain fields</value>
        [DataMember(Name = "grouping", EmitDefaultValue = false)]
        public List<string> Grouping { get; set; }

        /// <summary>
        /// Specifies the sorting of the products by &#x60;availableSortings&#x60;. If not set, the default sorting will be set according to the shop settings. The available sorting options are sent within the response under the &#x60;availableSortings&#x60; key. In order to sort by a field, consider using the &#x60;sort&#x60; parameter from the listing criteria. Do not use both parameters together, as it might lead to unexpected results.
        /// </summary>
        /// <value>Specifies the sorting of the products by &#x60;availableSortings&#x60;. If not set, the default sorting will be set according to the shop settings. The available sorting options are sent within the response under the &#x60;availableSortings&#x60; key. In order to sort by a field, consider using the &#x60;sort&#x60; parameter from the listing criteria. Do not use both parameters together, as it might lead to unexpected results.</value>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public string Order { get; set; }

        /// <summary>
        /// Search result page
        /// </summary>
        /// <value>Search result page</value>
        [DataMember(Name = "p", EmitDefaultValue = false)]
        public int P { get; set; }

        /// <summary>
        /// Filter by manufacturers. List of manufacturer identifiers separated by a &#x60;|&#x60;.
        /// </summary>
        /// <value>Filter by manufacturers. List of manufacturer identifiers separated by a &#x60;|&#x60;.</value>
        [DataMember(Name = "manufacturer", EmitDefaultValue = false)]
        public string Manufacturer { get; set; }

        /// <summary>
        /// Filters by a minimum product price. Has to be lower than the &#x60;max-price&#x60; filter.
        /// </summary>
        /// <value>Filters by a minimum product price. Has to be lower than the &#x60;max-price&#x60; filter.</value>
        [DataMember(Name = "min-price", EmitDefaultValue = false)]
        public int MinPrice { get; set; }

        /// <summary>
        /// Filters by a maximum product price. Has to be higher than the &#x60;min-price&#x60; filter.
        /// </summary>
        /// <value>Filters by a maximum product price. Has to be higher than the &#x60;min-price&#x60; filter.</value>
        [DataMember(Name = "max-price", EmitDefaultValue = false)]
        public int MaxPrice { get; set; }

        /// <summary>
        /// Filter products with a minimum average rating.
        /// </summary>
        /// <value>Filter products with a minimum average rating.</value>
        [DataMember(Name = "rating", EmitDefaultValue = false)]
        public int Rating { get; set; }

        /// <summary>
        /// Filters products that are marked as shipping-free.
        /// </summary>
        /// <value>Filters products that are marked as shipping-free.</value>
        [DataMember(Name = "shipping-free", EmitDefaultValue = true)]
        public bool ShippingFree { get; set; }

        /// <summary>
        /// Filters products by their properties. List of property identifiers separated by a &#x60;|&#x60;.
        /// </summary>
        /// <value>Filters products by their properties. List of property identifiers separated by a &#x60;|&#x60;.</value>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public string Properties { get; set; }

        /// <summary>
        /// Enables/disabled filtering by manufacturer. If set to false, the &#x60;manufacturer&#x60; filter will be ignored. Also the &#x60;aggregations[manufacturer]&#x60; key will be removed from the response.
        /// </summary>
        /// <value>Enables/disabled filtering by manufacturer. If set to false, the &#x60;manufacturer&#x60; filter will be ignored. Also the &#x60;aggregations[manufacturer]&#x60; key will be removed from the response.</value>
        [DataMember(Name = "manufacturer-filter", EmitDefaultValue = true)]
        public bool ManufacturerFilter { get; set; }

        /// <summary>
        /// Enables/disabled filtering by price. If set to false, the &#x60;min-price&#x60; and &#x60;max-price&#x60; filter will be ignored. Also the &#x60;aggregations[price]&#x60; key will be removed from the response.
        /// </summary>
        /// <value>Enables/disabled filtering by price. If set to false, the &#x60;min-price&#x60; and &#x60;max-price&#x60; filter will be ignored. Also the &#x60;aggregations[price]&#x60; key will be removed from the response.</value>
        [DataMember(Name = "price-filter", EmitDefaultValue = true)]
        public bool PriceFilter { get; set; }

        /// <summary>
        /// Enables/disabled filtering by rating. If set to false, the &#x60;rating&#x60; filter will be ignored. Also the &#x60;aggregations[rating]&#x60; key will be removed from the response.
        /// </summary>
        /// <value>Enables/disabled filtering by rating. If set to false, the &#x60;rating&#x60; filter will be ignored. Also the &#x60;aggregations[rating]&#x60; key will be removed from the response.</value>
        [DataMember(Name = "rating-filter", EmitDefaultValue = true)]
        public bool RatingFilter { get; set; }

        /// <summary>
        /// Enables/disabled filtering by shipping-free products. If set to false, the &#x60;shipping-free&#x60; filter will be ignored. Also the &#x60;aggregations[shipping-free]&#x60; key will be removed from the response.
        /// </summary>
        /// <value>Enables/disabled filtering by shipping-free products. If set to false, the &#x60;shipping-free&#x60; filter will be ignored. Also the &#x60;aggregations[shipping-free]&#x60; key will be removed from the response.</value>
        [DataMember(Name = "shipping-free-filter", EmitDefaultValue = true)]
        public bool ShippingFreeFilter { get; set; }

        /// <summary>
        /// Enables/disabled filtering by properties products. If set to false, the &#x60;properties&#x60; filter will be ignored. Also the &#x60;aggregations[properties]&#x60; key will be removed from the response.
        /// </summary>
        /// <value>Enables/disabled filtering by properties products. If set to false, the &#x60;properties&#x60; filter will be ignored. Also the &#x60;aggregations[properties]&#x60; key will be removed from the response.</value>
        [DataMember(Name = "property-filter", EmitDefaultValue = true)]
        public bool PropertyFilter { get; set; }

        /// <summary>
        /// A whitelist of property identifiers which can be used for filtering. List of property identifiers separated by a &#x60;|&#x60;. The &#x60;property-filter&#x60; must be &#x60;true&#x60;, otherwise the whitelist has no effect.
        /// </summary>
        /// <value>A whitelist of property identifiers which can be used for filtering. List of property identifiers separated by a &#x60;|&#x60;. The &#x60;property-filter&#x60; must be &#x60;true&#x60;, otherwise the whitelist has no effect.</value>
        [DataMember(Name = "property-whitelist", EmitDefaultValue = false)]
        public string PropertyWhitelist { get; set; }

        /// <summary>
        /// By sending the parameter &#x60;reduce-aggregations&#x60; , the post-filters that were applied by the customer, are also applied to the aggregations. This has the consequence that only values are returned in the aggregations that would lead to further filter results. This parameter is a flag, the value has no effect.
        /// </summary>
        /// <value>By sending the parameter &#x60;reduce-aggregations&#x60; , the post-filters that were applied by the customer, are also applied to the aggregations. This has the consequence that only values are returned in the aggregations that would lead to further filter results. This parameter is a flag, the value has no effect.</value>
        [DataMember(Name = "reduce-aggregations", EmitDefaultValue = true)]
        public string ReduceAggregations { get; set; }

        /// <summary>
        /// Resolves only the given slot identifiers. The identifiers have to be seperated by a &#x60;|&#x60; character.
        /// </summary>
        /// <value>Resolves only the given slot identifiers. The identifiers have to be seperated by a &#x60;|&#x60; character.</value>
        [DataMember(Name = "slots", EmitDefaultValue = false)]
        public string Slots { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReadLandingPageRequest {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  PostFilter: ").Append(PostFilter).Append("\n");
            sb.Append("  Associations: ").Append(Associations).Append("\n");
            sb.Append("  Aggregations: ").Append(Aggregations).Append("\n");
            sb.Append("  Grouping: ").Append(Grouping).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  P: ").Append(P).Append("\n");
            sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
            sb.Append("  MinPrice: ").Append(MinPrice).Append("\n");
            sb.Append("  MaxPrice: ").Append(MaxPrice).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  ShippingFree: ").Append(ShippingFree).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  ManufacturerFilter: ").Append(ManufacturerFilter).Append("\n");
            sb.Append("  PriceFilter: ").Append(PriceFilter).Append("\n");
            sb.Append("  RatingFilter: ").Append(RatingFilter).Append("\n");
            sb.Append("  ShippingFreeFilter: ").Append(ShippingFreeFilter).Append("\n");
            sb.Append("  PropertyFilter: ").Append(PropertyFilter).Append("\n");
            sb.Append("  PropertyWhitelist: ").Append(PropertyWhitelist).Append("\n");
            sb.Append("  ReduceAggregations: ").Append(ReduceAggregations).Append("\n");
            sb.Append("  Slots: ").Append(Slots).Append("\n");
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
            return this.Equals(input as ReadLandingPageRequest);
        }

        /// <summary>
        /// Returns true if ReadLandingPageRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ReadLandingPageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReadLandingPageRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Page == input.Page ||
                    this.Page.Equals(input.Page)
                ) && 
                (
                    this.Limit == input.Limit ||
                    this.Limit.Equals(input.Limit)
                ) && 
                (
                    this.Filter == input.Filter ||
                    this.Filter != null &&
                    input.Filter != null &&
                    this.Filter.SequenceEqual(input.Filter)
                ) && 
                (
                    this.Sort == input.Sort ||
                    this.Sort != null &&
                    input.Sort != null &&
                    this.Sort.SequenceEqual(input.Sort)
                ) && 
                (
                    this.PostFilter == input.PostFilter ||
                    this.PostFilter != null &&
                    input.PostFilter != null &&
                    this.PostFilter.SequenceEqual(input.PostFilter)
                ) && 
                (
                    this.Associations == input.Associations ||
                    (this.Associations != null &&
                    this.Associations.Equals(input.Associations))
                ) && 
                (
                    this.Aggregations == input.Aggregations ||
                    this.Aggregations != null &&
                    input.Aggregations != null &&
                    this.Aggregations.SequenceEqual(input.Aggregations)
                ) && 
                (
                    this.Grouping == input.Grouping ||
                    this.Grouping != null &&
                    input.Grouping != null &&
                    this.Grouping.SequenceEqual(input.Grouping)
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.P == input.P ||
                    this.P.Equals(input.P)
                ) && 
                (
                    this.Manufacturer == input.Manufacturer ||
                    (this.Manufacturer != null &&
                    this.Manufacturer.Equals(input.Manufacturer))
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
                    this.Rating == input.Rating ||
                    this.Rating.Equals(input.Rating)
                ) && 
                (
                    this.ShippingFree == input.ShippingFree ||
                    this.ShippingFree.Equals(input.ShippingFree)
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
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
                    this.Slots == input.Slots ||
                    (this.Slots != null &&
                    this.Slots.Equals(input.Slots))
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
                hashCode = (hashCode * 59) + this.Page.GetHashCode();
                hashCode = (hashCode * 59) + this.Limit.GetHashCode();
                if (this.Filter != null)
                {
                    hashCode = (hashCode * 59) + this.Filter.GetHashCode();
                }
                if (this.Sort != null)
                {
                    hashCode = (hashCode * 59) + this.Sort.GetHashCode();
                }
                if (this.PostFilter != null)
                {
                    hashCode = (hashCode * 59) + this.PostFilter.GetHashCode();
                }
                if (this.Associations != null)
                {
                    hashCode = (hashCode * 59) + this.Associations.GetHashCode();
                }
                if (this.Aggregations != null)
                {
                    hashCode = (hashCode * 59) + this.Aggregations.GetHashCode();
                }
                if (this.Grouping != null)
                {
                    hashCode = (hashCode * 59) + this.Grouping.GetHashCode();
                }
                if (this.Order != null)
                {
                    hashCode = (hashCode * 59) + this.Order.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.P.GetHashCode();
                if (this.Manufacturer != null)
                {
                    hashCode = (hashCode * 59) + this.Manufacturer.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MinPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.Rating.GetHashCode();
                hashCode = (hashCode * 59) + this.ShippingFree.GetHashCode();
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ManufacturerFilter.GetHashCode();
                hashCode = (hashCode * 59) + this.PriceFilter.GetHashCode();
                hashCode = (hashCode * 59) + this.RatingFilter.GetHashCode();
                hashCode = (hashCode * 59) + this.ShippingFreeFilter.GetHashCode();
                hashCode = (hashCode * 59) + this.PropertyFilter.GetHashCode();
                if (this.PropertyWhitelist != null)
                {
                    hashCode = (hashCode * 59) + this.PropertyWhitelist.GetHashCode();
                }
                if (this.ReduceAggregations != null)
                {
                    hashCode = (hashCode * 59) + this.ReduceAggregations.GetHashCode();
                }
                if (this.Slots != null)
                {
                    hashCode = (hashCode * 59) + this.Slots.GetHashCode();
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
            // Limit (int) minimum
            if (this.Limit < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Limit, must be a value greater than or equal to 0.", new [] { "Limit" });
            }

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

}