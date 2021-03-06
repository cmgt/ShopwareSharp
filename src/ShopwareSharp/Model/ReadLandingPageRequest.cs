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
    /// ReadLandingPageRequest
    /// </summary>
    public partial class ReadLandingPageRequest : IEquatable<ReadLandingPageRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadLandingPageRequest" /> class.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="readCmsRequest"></param>
        /// <param name="slots">Resolves only the given slot identifiers. The identifiers have to be seperated by a &#x60;|&#x60; character.</param>
        public ReadLandingPageRequest(Criteria criteria, ReadCmsRequest readCmsRequest, string? slots = default)
        {
            Criteria = criteria;
            ReadCmsRequest = readCmsRequest;
            Slots = slots;
        }

        /// <summary>
        /// Gets or Sets Criteria
        /// </summary>
        public Criteria Criteria { get; set; }

        /// <summary>
        /// Gets or Sets ReadCmsRequest
        /// </summary>
        public ReadCmsRequest ReadCmsRequest { get; set; }

        /// <summary>
        /// Resolves only the given slot identifiers. The identifiers have to be seperated by a &#x60;|&#x60; character.
        /// </summary>
        /// <value>Resolves only the given slot identifiers. The identifiers have to be seperated by a &#x60;|&#x60; character.</value>
        [JsonPropertyName("slots")]
        public string? Slots { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReadLandingPageRequest {\n");
            sb.Append("  Slots: ").Append(Slots).Append("\n");
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
            return this.Equals(input as ReadLandingPageRequest);
        }

        /// <summary>
        /// Returns true if ReadLandingPageRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ReadLandingPageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReadLandingPageRequest? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type ReadLandingPageRequest
    /// </summary>
    public class ReadLandingPageRequestJsonConverter : JsonConverter<ReadLandingPageRequest>
    {
        /// <summary>
        /// Returns a boolean if the type is compatible with this converter.
        /// </summary>
        /// <param name="typeToConvert"></param>
        /// <returns></returns>
        public override bool CanConvert(Type typeToConvert) => typeof(ReadLandingPageRequest).IsAssignableFrom(typeToConvert);

        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ReadLandingPageRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();

            Utf8JsonReader criteriaReader = reader;
            bool criteriaDeserialized = Client.ClientUtils.TryDeserialize<Criteria>(ref criteriaReader, options, out Criteria? criteria);

            Utf8JsonReader readCmsRequestReader = reader;
            bool readCmsRequestDeserialized = Client.ClientUtils.TryDeserialize<ReadCmsRequest>(ref readCmsRequestReader, options, out ReadCmsRequest? readCmsRequest);

            string? slots = default;

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
                        case "slots":
                            slots = reader.GetString();
                            break;
                    }
                }
            }

            return new ReadLandingPageRequest(criteria, readCmsRequest, slots);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="readLandingPageRequest"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ReadLandingPageRequest readLandingPageRequest, JsonSerializerOptions options) => throw new NotImplementedException();
    }
}
