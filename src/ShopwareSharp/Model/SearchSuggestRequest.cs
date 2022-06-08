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
    /// SearchSuggestRequest
    /// </summary>
    [DataContract(Name = "searchSuggest_request")]
    public partial class SearchSuggestRequest : IEquatable<SearchSuggestRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSuggestRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchSuggestRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSuggestRequest" /> class.
        /// </summary>
        /// <param name="noAggregations">Resets all aggregations in the criteria. This parameter is a flag, the value has no effect..</param>
        /// <param name="onlyAggregations">If this flag is set, no products are fetched. Sorting and associations are also ignored. This parameter is a flag, the value has no effect..</param>
        /// <param name="search">Using the search parameter, the server performs a text search on all records based on their data model and weighting as defined in the entity definition using the SearchRanking flag. (required).</param>
        public SearchSuggestRequest(string noAggregations = default(string), string onlyAggregations = default(string), string search = default(string))
        {
            // to ensure "search" is required (not null)
            if (search == null)
            {
                throw new ArgumentNullException("search is a required property for SearchSuggestRequest and cannot be null");
            }
            this._Search = search;
            this._NoAggregations = noAggregations;
            if (this.NoAggregations != null)
            {
                this._flagNoAggregations = true;
            }
            this._OnlyAggregations = onlyAggregations;
            if (this.OnlyAggregations != null)
            {
                this._flagOnlyAggregations = true;
            }
        }

        /// <summary>
        /// Resets all aggregations in the criteria. This parameter is a flag, the value has no effect.
        /// </summary>
        /// <value>Resets all aggregations in the criteria. This parameter is a flag, the value has no effect.</value>
        [DataMember(Name = "no-aggregations", EmitDefaultValue = true)]
        public string NoAggregations
        {
            get{ return _NoAggregations;}
            set
            {
                _NoAggregations = value;
                _flagNoAggregations = true;
            }
        }
        private string _NoAggregations;
        private bool _flagNoAggregations;

        /// <summary>
        /// Returns false as NoAggregations should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNoAggregations()
        {
            return _flagNoAggregations;
        }
        /// <summary>
        /// If this flag is set, no products are fetched. Sorting and associations are also ignored. This parameter is a flag, the value has no effect.
        /// </summary>
        /// <value>If this flag is set, no products are fetched. Sorting and associations are also ignored. This parameter is a flag, the value has no effect.</value>
        [DataMember(Name = "only-aggregations", EmitDefaultValue = true)]
        public string OnlyAggregations
        {
            get{ return _OnlyAggregations;}
            set
            {
                _OnlyAggregations = value;
                _flagOnlyAggregations = true;
            }
        }
        private string _OnlyAggregations;
        private bool _flagOnlyAggregations;

        /// <summary>
        /// Returns false as OnlyAggregations should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOnlyAggregations()
        {
            return _flagOnlyAggregations;
        }
        /// <summary>
        /// Using the search parameter, the server performs a text search on all records based on their data model and weighting as defined in the entity definition using the SearchRanking flag.
        /// </summary>
        /// <value>Using the search parameter, the server performs a text search on all records based on their data model and weighting as defined in the entity definition using the SearchRanking flag.</value>
        [DataMember(Name = "search", IsRequired = true, EmitDefaultValue = false)]
        public string Search
        {
            get{ return _Search;}
            set
            {
                _Search = value;
                _flagSearch = true;
            }
        }
        private string _Search;
        private bool _flagSearch;

        /// <summary>
        /// Returns false as Search should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSearch()
        {
            return _flagSearch;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchSuggestRequest {\n");
            sb.Append("  NoAggregations: ").Append(NoAggregations).Append("\n");
            sb.Append("  OnlyAggregations: ").Append(OnlyAggregations).Append("\n");
            sb.Append("  Search: ").Append(Search).Append("\n");
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
            return this.Equals(input as SearchSuggestRequest);
        }

        /// <summary>
        /// Returns true if SearchSuggestRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchSuggestRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchSuggestRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NoAggregations == input.NoAggregations ||
                    (this.NoAggregations != null &&
                    this.NoAggregations.Equals(input.NoAggregations))
                ) && 
                (
                    this.OnlyAggregations == input.OnlyAggregations ||
                    (this.OnlyAggregations != null &&
                    this.OnlyAggregations.Equals(input.OnlyAggregations))
                ) && 
                (
                    this.Search == input.Search ||
                    (this.Search != null &&
                    this.Search.Equals(input.Search))
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
                if (this.NoAggregations != null)
                {
                    hashCode = (hashCode * 59) + this.NoAggregations.GetHashCode();
                }
                if (this.OnlyAggregations != null)
                {
                    hashCode = (hashCode * 59) + this.OnlyAggregations.GetHashCode();
                }
                if (this.Search != null)
                {
                    hashCode = (hashCode * 59) + this.Search.GetHashCode();
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
