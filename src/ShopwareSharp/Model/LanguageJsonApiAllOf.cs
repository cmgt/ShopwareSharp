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
    /// LanguageJsonApiAllOf
    /// </summary>
    public partial class LanguageJsonApiAllOf : IEquatable<LanguageJsonApiAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageJsonApiAllOf" /> class.
        /// </summary>
        /// <param name="localeId">localeId (required)</param>
        /// <param name="name">name (required)</param>
        /// <param name="createdAt">createdAt (required)</param>
        /// <param name="id">id</param>
        /// <param name="parentId">parentId</param>
        /// <param name="translationCodeId">translationCodeId</param>
        /// <param name="customFields">customFields</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="relationships">relationships</param>
        public LanguageJsonApiAllOf(string localeId, string name, DateTime createdAt, string? id = default, string? parentId = default, string? translationCodeId = default, Object? customFields = default, DateTime? updatedAt = default, Object? relationships = default)
        {
            if (localeId == null)
                throw new ArgumentNullException("localeId is a required property for LanguageJsonApiAllOf and cannot be null.");

            if (name == null)
                throw new ArgumentNullException("name is a required property for LanguageJsonApiAllOf and cannot be null.");

            if (createdAt == null)
                throw new ArgumentNullException("createdAt is a required property for LanguageJsonApiAllOf and cannot be null.");

            LocaleId = localeId;
            Name = name;
            CreatedAt = createdAt;
            Id = id;
            ParentId = parentId;
            TranslationCodeId = translationCodeId;
            CustomFields = customFields;
            UpdatedAt = updatedAt;
            Relationships = relationships;
        }

        /// <summary>
        /// Gets or Sets LocaleId
        /// </summary>
        [JsonPropertyName("localeId")]
        public string LocaleId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [JsonPropertyName("parentId")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Gets or Sets TranslationCodeId
        /// </summary>
        [JsonPropertyName("translationCodeId")]
        public string? TranslationCodeId { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [JsonPropertyName("customFields")]
        public Object? CustomFields { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets Relationships
        /// </summary>
        [JsonPropertyName("relationships")]
        public Object? Relationships { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LanguageJsonApiAllOf {\n");
            sb.Append("  LocaleId: ").Append(LocaleId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  TranslationCodeId: ").Append(TranslationCodeId).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Relationships: ").Append(Relationships).Append("\n");
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
            return this.Equals(input as LanguageJsonApiAllOf);
        }

        /// <summary>
        /// Returns true if LanguageJsonApiAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of LanguageJsonApiAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LanguageJsonApiAllOf? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LocaleId == input.LocaleId ||
                    (this.LocaleId != null &&
                    this.LocaleId.Equals(input.LocaleId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.TranslationCodeId == input.TranslationCodeId ||
                    (this.TranslationCodeId != null &&
                    this.TranslationCodeId.Equals(input.TranslationCodeId))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    (this.CustomFields != null &&
                    this.CustomFields.Equals(input.CustomFields))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Relationships == input.Relationships ||
                    (this.Relationships != null &&
                    this.Relationships.Equals(input.Relationships))
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
                if (this.LocaleId != null)
                {
                    hashCode = (hashCode * 59) + this.LocaleId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.ParentId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentId.GetHashCode();
                }
                if (this.TranslationCodeId != null)
                {
                    hashCode = (hashCode * 59) + this.TranslationCodeId.GetHashCode();
                }
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.Relationships != null)
                {
                    hashCode = (hashCode * 59) + this.Relationships.GetHashCode();
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
            // LocaleId (string) pattern
            Regex regexLocaleId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexLocaleId.Match(this.LocaleId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LocaleId, must match a pattern of " + regexLocaleId, new [] { "LocaleId" });
            }

            // Id (string) pattern
            Regex regexId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            // ParentId (string) pattern
            Regex regexParentId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexParentId.Match(this.ParentId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ParentId, must match a pattern of " + regexParentId, new [] { "ParentId" });
            }

            // TranslationCodeId (string) pattern
            Regex regexTranslationCodeId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexTranslationCodeId.Match(this.TranslationCodeId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TranslationCodeId, must match a pattern of " + regexTranslationCodeId, new [] { "TranslationCodeId" });
            }

            yield break;
        }
    }

}
