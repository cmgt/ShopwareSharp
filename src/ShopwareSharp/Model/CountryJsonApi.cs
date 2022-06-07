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
    /// Added since version: 6.0.0.0
    /// </summary>
    public partial class CountryJsonApi : IEquatable<CountryJsonApi>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryJsonApi" /> class.
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="countryJsonApiAllOf"></param>
        /// <param name="createdAt">createdAt (required)</param>
        /// <param name="updatedAt">updatedAt</param>
        public CountryJsonApi(Resource resource, CountryJsonApiAllOf countryJsonApiAllOf, DateTime createdAt, DateTime? updatedAt = default)
        {
            if (createdAt == null)
                throw new ArgumentNullException("createdAt is a required property for CountryJsonApi and cannot be null.");

            Resource = resource;
            CountryJsonApiAllOf = countryJsonApiAllOf;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        public Resource Resource { get; set; }

        /// <summary>
        /// Gets or Sets CountryJsonApiAllOf
        /// </summary>
        public CountryJsonApiAllOf CountryJsonApiAllOf { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CountryJsonApi {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as CountryJsonApi);
        }

        /// <summary>
        /// Returns true if CountryJsonApi instances are equal
        /// </summary>
        /// <param name="input">Instance of CountryJsonApi to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CountryJsonApi? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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

    /// <summary>
    /// A Json converter for type CountryJsonApi
    /// </summary>
    public class CountryJsonApiJsonConverter : JsonConverter<CountryJsonApi>
    {
        /// <summary>
        /// Returns a boolean if the type is compatible with this converter.
        /// </summary>
        /// <param name="typeToConvert"></param>
        /// <returns></returns>
        public override bool CanConvert(Type typeToConvert) => typeof(CountryJsonApi).IsAssignableFrom(typeToConvert);

        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CountryJsonApi Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();

            Utf8JsonReader resourceReader = reader;
            bool resourceDeserialized = Client.ClientUtils.TryDeserialize<Resource>(ref resourceReader, options, out Resource? resource);

            Utf8JsonReader countryJsonApiAllOfReader = reader;
            bool countryJsonApiAllOfDeserialized = Client.ClientUtils.TryDeserialize<CountryJsonApiAllOf>(ref countryJsonApiAllOfReader, options, out CountryJsonApiAllOf? countryJsonApiAllOf);

            DateTime? createdAt = default;
            DateTime? updatedAt = default;

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
                        case "createdAt":
                            createdAt = reader.GetDateTime();
                            break;
                        case "updatedAt":
                            updatedAt = reader.GetDateTime();
                            break;
                    }
                }
            }

            return new CountryJsonApi(resource, countryJsonApiAllOf, createdAt, updatedAt);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="countryJsonApi"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CountryJsonApi countryJsonApi, JsonSerializerOptions options) => throw new NotImplementedException();
    }
}
