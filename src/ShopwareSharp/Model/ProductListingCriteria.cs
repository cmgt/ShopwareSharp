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
    /// ProductListingCriteria
    /// </summary>
    public partial class ProductListingCriteria : IEquatable<ProductListingCriteria>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductListingCriteria" /> class.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="productListingCriteriaAllOf"></param>
        public ProductListingCriteria(Criteria criteria, ProductListingCriteriaAllOf productListingCriteriaAllOf)
        {
            Criteria = criteria;
            ProductListingCriteriaAllOf = productListingCriteriaAllOf;
        }

        /// <summary>
        /// Gets or Sets Criteria
        /// </summary>
        public Criteria Criteria { get; set; }

        /// <summary>
        /// Gets or Sets ProductListingCriteriaAllOf
        /// </summary>
        public ProductListingCriteriaAllOf ProductListingCriteriaAllOf { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductListingCriteria {\n");
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
            return this.Equals(input as ProductListingCriteria);
        }

        /// <summary>
        /// Returns true if ProductListingCriteria instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductListingCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductListingCriteria? input)
        {
            if (input == null)
            {
                return false;
            }
            return false;
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
    /// A Json converter for type ProductListingCriteria
    /// </summary>
    public class ProductListingCriteriaJsonConverter : JsonConverter<ProductListingCriteria>
    {
        /// <summary>
        /// Returns a boolean if the type is compatible with this converter.
        /// </summary>
        /// <param name="typeToConvert"></param>
        /// <returns></returns>
        public override bool CanConvert(Type typeToConvert) => typeof(ProductListingCriteria).IsAssignableFrom(typeToConvert);

        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ProductListingCriteria Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();

            Utf8JsonReader criteriaReader = reader;
            bool criteriaDeserialized = Client.ClientUtils.TryDeserialize<Criteria>(ref criteriaReader, options, out Criteria? criteria);

            Utf8JsonReader productListingCriteriaAllOfReader = reader;
            bool productListingCriteriaAllOfDeserialized = Client.ClientUtils.TryDeserialize<ProductListingCriteriaAllOf>(ref productListingCriteriaAllOfReader, options, out ProductListingCriteriaAllOf? productListingCriteriaAllOf);


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
                    }
                }
            }

            return new ProductListingCriteria(criteria, productListingCriteriaAllOf);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="productListingCriteria"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ProductListingCriteria productListingCriteria, JsonSerializerOptions options) => throw new NotImplementedException();
    }
}
