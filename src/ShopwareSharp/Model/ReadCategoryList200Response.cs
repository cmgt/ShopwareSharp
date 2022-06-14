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
    /// ReadCategoryList200Response
    /// </summary>
    public partial class ReadCategoryList200Response : IEquatable<ReadCategoryList200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadCategoryList200Response" /> class.
        /// </summary>
        /// <param name="entitySearchResult"></param>
        /// <param name="readCategoryList200ResponseAllOf"></param>
        /// <param name="apiAlias">Alias which can be used to restrict response fields. For more information see [includes](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#includes-apialias).</param>
        /// <param name="entity">entity</param>
        /// <param name="total">The total number of found entities</param>
        /// <param name="aggregations">Contains aggregated data. A simple example is the determination of the average price from a product search query.</param>
        /// <param name="page">The actual page. This can be used for pagination.</param>
        /// <param name="limit">The actual limit. This is used for pagination and goes together with the page.</param>
        public ReadCategoryList200Response(EntitySearchResult entitySearchResult, ReadCategoryList200ResponseAllOf readCategoryList200ResponseAllOf, string? apiAlias = default, string? entity = default, int? total = default, List<Object>? aggregations = default, int? page = default, int? limit = default)
        {
            EntitySearchResult = entitySearchResult;
            ReadCategoryList200ResponseAllOf = readCategoryList200ResponseAllOf;
            ApiAlias = apiAlias;
            Entity = entity;
            Total = total;
            Aggregations = aggregations;
            Page = page;
            Limit = limit;
        }

        /// <summary>
        /// Gets or Sets EntitySearchResult
        /// </summary>
        public EntitySearchResult EntitySearchResult { get; set; }

        /// <summary>
        /// Gets or Sets ReadCategoryList200ResponseAllOf
        /// </summary>
        public ReadCategoryList200ResponseAllOf ReadCategoryList200ResponseAllOf { get; set; }

        /// <summary>
        /// Alias which can be used to restrict response fields. For more information see [includes](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#includes-apialias).
        /// </summary>
        /// <value>Alias which can be used to restrict response fields. For more information see [includes](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#includes-apialias).</value>
        [JsonPropertyName("apiAlias")]
        public string? ApiAlias { get; set; }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [JsonPropertyName("entity")]
        public string? Entity { get; set; }

        /// <summary>
        /// The total number of found entities
        /// </summary>
        /// <value>The total number of found entities</value>
        [JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Contains aggregated data. A simple example is the determination of the average price from a product search query.
        /// </summary>
        /// <value>Contains aggregated data. A simple example is the determination of the average price from a product search query.</value>
        [JsonPropertyName("aggregations")]
        public List<Object>? Aggregations { get; set; }

        /// <summary>
        /// The actual page. This can be used for pagination.
        /// </summary>
        /// <value>The actual page. This can be used for pagination.</value>
        [JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// The actual limit. This is used for pagination and goes together with the page.
        /// </summary>
        /// <value>The actual limit. This is used for pagination and goes together with the page.</value>
        [JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReadCategoryList200Response {\n");
            sb.Append("  ApiAlias: ").Append(ApiAlias).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Aggregations: ").Append(Aggregations).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
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
            return this.Equals(input as ReadCategoryList200Response);
        }

        /// <summary>
        /// Returns true if ReadCategoryList200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of ReadCategoryList200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReadCategoryList200Response? input)
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

    /// <summary>
    /// A Json converter for type ReadCategoryList200Response
    /// </summary>
    public class ReadCategoryList200ResponseJsonConverter : JsonConverter<ReadCategoryList200Response>
    {
        /// <summary>
        /// Returns a boolean if the type is compatible with this converter.
        /// </summary>
        /// <param name="typeToConvert"></param>
        /// <returns></returns>
        public override bool CanConvert(Type typeToConvert) => typeof(ReadCategoryList200Response).IsAssignableFrom(typeToConvert);

        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ReadCategoryList200Response Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();

            Utf8JsonReader entitySearchResultReader = reader;
            bool entitySearchResultDeserialized = Client.ClientUtils.TryDeserialize<EntitySearchResult>(ref entitySearchResultReader, options, out EntitySearchResult? entitySearchResult);

            Utf8JsonReader readCategoryList200ResponseAllOfReader = reader;
            bool readCategoryList200ResponseAllOfDeserialized = Client.ClientUtils.TryDeserialize<ReadCategoryList200ResponseAllOf>(ref readCategoryList200ResponseAllOfReader, options, out ReadCategoryList200ResponseAllOf? readCategoryList200ResponseAllOf);

            string? apiAlias = default;
            string? entity = default;
            int? total = default;
            List<Object>? aggregations = default;
            int? page = default;
            int? limit = default;

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
                        case "apiAlias":
                            apiAlias = reader.GetString();
                            break;
                        case "entity":
                            entity = reader.GetString();
                            break;
                        case "total":
                            total = reader.GetInt32();
                            break;
                        case "aggregations":
                            aggregations = JsonSerializer.Deserialize<List<Object>>(ref reader, options);
                            break;
                        case "page":
                            page = reader.GetInt32();
                            break;
                        case "limit":
                            limit = reader.GetInt32();
                            break;
                    }
                }
            }

            return new ReadCategoryList200Response(entitySearchResult, readCategoryList200ResponseAllOf, apiAlias, entity, total, aggregations, page, limit);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="readCategoryList200Response"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ReadCategoryList200Response readCategoryList200Response, JsonSerializerOptions options) => throw new NotImplementedException();
    }
}
