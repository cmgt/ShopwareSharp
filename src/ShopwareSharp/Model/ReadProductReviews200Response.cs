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
    /// ReadProductReviews200Response
    /// </summary>
    [DataContract(Name = "readProductReviews_200_response")]
    public partial class ReadProductReviews200Response : IEquatable<ReadProductReviews200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadProductReviews200Response" /> class.
        /// </summary>
        /// <param name="apiAlias">Alias which can be used to restrict response fields. For more information see [includes](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#includes-apialias)..</param>
        /// <param name="entity">entity.</param>
        /// <param name="total">The total number of found entities.</param>
        /// <param name="aggregations">Contains aggregated data. A simple example is the determination of the average price from a product search query..</param>
        /// <param name="page">The actual page. This can be used for pagination..</param>
        /// <param name="limit">The actual limit. This is used for pagination and goes together with the page..</param>
        /// <param name="elements">elements.</param>
        public ReadProductReviews200Response(string apiAlias = default(string), string entity = default(string), int total = default(int), List<Object> aggregations = default(List<Object>), int page = default(int), int limit = default(int), List<ProductReview> elements = default(List<ProductReview>))
        {
            this.ApiAlias = apiAlias;
            this.Entity = entity;
            this.Total = total;
            this.Aggregations = aggregations;
            this.Page = page;
            this.Limit = limit;
            this.Elements = elements;
        }

        /// <summary>
        /// Alias which can be used to restrict response fields. For more information see [includes](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#includes-apialias).
        /// </summary>
        /// <value>Alias which can be used to restrict response fields. For more information see [includes](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#includes-apialias).</value>
        [DataMember(Name = "apiAlias", EmitDefaultValue = false)]
        public string ApiAlias { get; set; }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name = "entity", EmitDefaultValue = false)]
        public string Entity { get; set; }

        /// <summary>
        /// The total number of found entities
        /// </summary>
        /// <value>The total number of found entities</value>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// Contains aggregated data. A simple example is the determination of the average price from a product search query.
        /// </summary>
        /// <value>Contains aggregated data. A simple example is the determination of the average price from a product search query.</value>
        [DataMember(Name = "aggregations", EmitDefaultValue = false)]
        public List<Object> Aggregations { get; set; }

        /// <summary>
        /// The actual page. This can be used for pagination.
        /// </summary>
        /// <value>The actual page. This can be used for pagination.</value>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public int Page { get; set; }

        /// <summary>
        /// The actual limit. This is used for pagination and goes together with the page.
        /// </summary>
        /// <value>The actual limit. This is used for pagination and goes together with the page.</value>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int Limit { get; set; }

        /// <summary>
        /// Gets or Sets Elements
        /// </summary>
        [DataMember(Name = "elements", EmitDefaultValue = false)]
        public List<ProductReview> Elements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReadProductReviews200Response {\n");
            sb.Append("  ApiAlias: ").Append(ApiAlias).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Aggregations: ").Append(Aggregations).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
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
            return this.Equals(input as ReadProductReviews200Response);
        }

        /// <summary>
        /// Returns true if ReadProductReviews200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of ReadProductReviews200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReadProductReviews200Response input)
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
