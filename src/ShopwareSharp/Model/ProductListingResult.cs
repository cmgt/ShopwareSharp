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
    /// ProductListingResult
    /// </summary>
    [DataContract(Name = "ProductListingResult")]
    public partial class ProductListingResult : IEquatable<ProductListingResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductListingResult" /> class.
        /// </summary>
        /// <param name="apiAlias">Alias which can be used to restrict response fields. For more information see [includes](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#includes-apialias)..</param>
        /// <param name="entity">entity.</param>
        /// <param name="total">The total number of found entities.</param>
        /// <param name="aggregations">Contains aggregated data. A simple example is the determination of the average price from a product search query..</param>
        /// <param name="page">The actual page. This can be used for pagination..</param>
        /// <param name="limit">The actual limit. This is used for pagination and goes together with the page..</param>
        /// <param name="currentFilters">currentFilters.</param>
        /// <param name="availableSortings">Contains the available sorting. These can be used to show a sorting select-box in the product listing..</param>
        /// <param name="sorting">sorting.</param>
        /// <param name="elements">elements.</param>
        public ProductListingResult(string apiAlias = default(string), string entity = default(string), int total = default(int), List<Object> aggregations = default(List<Object>), int page = default(int), int limit = default(int), ProductListingResultAllOfCurrentFilters currentFilters = default(ProductListingResultAllOfCurrentFilters), List<Object> availableSortings = default(List<Object>), string sorting = default(string), List<Product> elements = default(List<Product>))
        {
            this._ApiAlias = apiAlias;
            if (this.ApiAlias != null)
            {
                this._flagApiAlias = true;
            }
            this._Entity = entity;
            if (this.Entity != null)
            {
                this._flagEntity = true;
            }
            this._Total = total;
            if (this.Total != null)
            {
                this._flagTotal = true;
            }
            this._Aggregations = aggregations;
            if (this.Aggregations != null)
            {
                this._flagAggregations = true;
            }
            this._Page = page;
            if (this.Page != null)
            {
                this._flagPage = true;
            }
            this._Limit = limit;
            if (this.Limit != null)
            {
                this._flagLimit = true;
            }
            this._CurrentFilters = currentFilters;
            if (this.CurrentFilters != null)
            {
                this._flagCurrentFilters = true;
            }
            this._AvailableSortings = availableSortings;
            if (this.AvailableSortings != null)
            {
                this._flagAvailableSortings = true;
            }
            this._Sorting = sorting;
            if (this.Sorting != null)
            {
                this._flagSorting = true;
            }
            this._Elements = elements;
            if (this.Elements != null)
            {
                this._flagElements = true;
            }
        }

        /// <summary>
        /// Alias which can be used to restrict response fields. For more information see [includes](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#includes-apialias).
        /// </summary>
        /// <value>Alias which can be used to restrict response fields. For more information see [includes](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#includes-apialias).</value>
        [DataMember(Name = "apiAlias", EmitDefaultValue = false)]
        public string ApiAlias
        {
            get{ return _ApiAlias;}
            set
            {
                _ApiAlias = value;
                _flagApiAlias = true;
            }
        }
        private string _ApiAlias;
        private bool _flagApiAlias;

        /// <summary>
        /// Returns false as ApiAlias should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeApiAlias()
        {
            return _flagApiAlias;
        }
        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name = "entity", EmitDefaultValue = false)]
        public string Entity
        {
            get{ return _Entity;}
            set
            {
                _Entity = value;
                _flagEntity = true;
            }
        }
        private string _Entity;
        private bool _flagEntity;

        /// <summary>
        /// Returns false as Entity should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEntity()
        {
            return _flagEntity;
        }
        /// <summary>
        /// The total number of found entities
        /// </summary>
        /// <value>The total number of found entities</value>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public int Total
        {
            get{ return _Total;}
            set
            {
                _Total = value;
                _flagTotal = true;
            }
        }
        private int _Total;
        private bool _flagTotal;

        /// <summary>
        /// Returns false as Total should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotal()
        {
            return _flagTotal;
        }
        /// <summary>
        /// Contains aggregated data. A simple example is the determination of the average price from a product search query.
        /// </summary>
        /// <value>Contains aggregated data. A simple example is the determination of the average price from a product search query.</value>
        [DataMember(Name = "aggregations", EmitDefaultValue = false)]
        public List<Object> Aggregations
        {
            get{ return _Aggregations;}
            set
            {
                _Aggregations = value;
                _flagAggregations = true;
            }
        }
        private List<Object> _Aggregations;
        private bool _flagAggregations;

        /// <summary>
        /// Returns false as Aggregations should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAggregations()
        {
            return _flagAggregations;
        }
        /// <summary>
        /// The actual page. This can be used for pagination.
        /// </summary>
        /// <value>The actual page. This can be used for pagination.</value>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public int Page
        {
            get{ return _Page;}
            set
            {
                _Page = value;
                _flagPage = true;
            }
        }
        private int _Page;
        private bool _flagPage;

        /// <summary>
        /// Returns false as Page should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePage()
        {
            return _flagPage;
        }
        /// <summary>
        /// The actual limit. This is used for pagination and goes together with the page.
        /// </summary>
        /// <value>The actual limit. This is used for pagination and goes together with the page.</value>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int Limit
        {
            get{ return _Limit;}
            set
            {
                _Limit = value;
                _flagLimit = true;
            }
        }
        private int _Limit;
        private bool _flagLimit;

        /// <summary>
        /// Returns false as Limit should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLimit()
        {
            return _flagLimit;
        }
        /// <summary>
        /// Gets or Sets CurrentFilters
        /// </summary>
        [DataMember(Name = "currentFilters", EmitDefaultValue = false)]
        public ProductListingResultAllOfCurrentFilters CurrentFilters
        {
            get{ return _CurrentFilters;}
            set
            {
                _CurrentFilters = value;
                _flagCurrentFilters = true;
            }
        }
        private ProductListingResultAllOfCurrentFilters _CurrentFilters;
        private bool _flagCurrentFilters;

        /// <summary>
        /// Returns false as CurrentFilters should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrentFilters()
        {
            return _flagCurrentFilters;
        }
        /// <summary>
        /// Contains the available sorting. These can be used to show a sorting select-box in the product listing.
        /// </summary>
        /// <value>Contains the available sorting. These can be used to show a sorting select-box in the product listing.</value>
        [DataMember(Name = "availableSortings", EmitDefaultValue = false)]
        public List<Object> AvailableSortings
        {
            get{ return _AvailableSortings;}
            set
            {
                _AvailableSortings = value;
                _flagAvailableSortings = true;
            }
        }
        private List<Object> _AvailableSortings;
        private bool _flagAvailableSortings;

        /// <summary>
        /// Returns false as AvailableSortings should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAvailableSortings()
        {
            return _flagAvailableSortings;
        }
        /// <summary>
        /// Gets or Sets Sorting
        /// </summary>
        [DataMember(Name = "sorting", EmitDefaultValue = false)]
        public string Sorting
        {
            get{ return _Sorting;}
            set
            {
                _Sorting = value;
                _flagSorting = true;
            }
        }
        private string _Sorting;
        private bool _flagSorting;

        /// <summary>
        /// Returns false as Sorting should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSorting()
        {
            return _flagSorting;
        }
        /// <summary>
        /// Gets or Sets Elements
        /// </summary>
        [DataMember(Name = "elements", EmitDefaultValue = false)]
        public List<Product> Elements
        {
            get{ return _Elements;}
            set
            {
                _Elements = value;
                _flagElements = true;
            }
        }
        private List<Product> _Elements;
        private bool _flagElements;

        /// <summary>
        /// Returns false as Elements should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeElements()
        {
            return _flagElements;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductListingResult {\n");
            sb.Append("  ApiAlias: ").Append(ApiAlias).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Aggregations: ").Append(Aggregations).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  CurrentFilters: ").Append(CurrentFilters).Append("\n");
            sb.Append("  AvailableSortings: ").Append(AvailableSortings).Append("\n");
            sb.Append("  Sorting: ").Append(Sorting).Append("\n");
            sb.Append("  Elements: ").Append(Elements).Append("\n");
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
            return this.Equals(input as ProductListingResult);
        }

        /// <summary>
        /// Returns true if ProductListingResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductListingResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductListingResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApiAlias == input.ApiAlias ||
                    (this.ApiAlias != null &&
                    this.ApiAlias.Equals(input.ApiAlias))
                ) && 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Aggregations == input.Aggregations ||
                    this.Aggregations != null &&
                    input.Aggregations != null &&
                    this.Aggregations.SequenceEqual(input.Aggregations)
                ) && 
                (
                    this.Page == input.Page ||
                    this.Page.Equals(input.Page)
                ) && 
                (
                    this.Limit == input.Limit ||
                    this.Limit.Equals(input.Limit)
                ) && 
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
                if (this.ApiAlias != null)
                {
                    hashCode = (hashCode * 59) + this.ApiAlias.GetHashCode();
                }
                if (this.Entity != null)
                {
                    hashCode = (hashCode * 59) + this.Entity.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
                if (this.Aggregations != null)
                {
                    hashCode = (hashCode * 59) + this.Aggregations.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Page.GetHashCode();
                hashCode = (hashCode * 59) + this.Limit.GetHashCode();
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
