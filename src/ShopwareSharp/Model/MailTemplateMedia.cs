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
    public partial class MailTemplateMedia : IEquatable<MailTemplateMedia>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailTemplateMedia" /> class.
        /// </summary>
        /// <param name="mailTemplateId">mailTemplateId (required)</param>
        /// <param name="languageId">languageId (required)</param>
        /// <param name="mediaId">mediaId (required)</param>
        /// <param name="id">id</param>
        /// <param name="position">position</param>
        /// <param name="media">media</param>
        public MailTemplateMedia(string mailTemplateId, string languageId, string mediaId, string? id = default, long? position = default, Media? media = default)
        {
            if (mailTemplateId == null)
                throw new ArgumentNullException("mailTemplateId is a required property for MailTemplateMedia and cannot be null.");

            if (languageId == null)
                throw new ArgumentNullException("languageId is a required property for MailTemplateMedia and cannot be null.");

            if (mediaId == null)
                throw new ArgumentNullException("mediaId is a required property for MailTemplateMedia and cannot be null.");

            MailTemplateId = mailTemplateId;
            LanguageId = languageId;
            MediaId = mediaId;
            Id = id;
            Position = position;
            Media = media;
        }

        /// <summary>
        /// Gets or Sets MailTemplateId
        /// </summary>
        [JsonPropertyName("mailTemplateId")]
        public string MailTemplateId { get; set; }

        /// <summary>
        /// Gets or Sets LanguageId
        /// </summary>
        [JsonPropertyName("languageId")]
        public string LanguageId { get; set; }

        /// <summary>
        /// Gets or Sets MediaId
        /// </summary>
        [JsonPropertyName("mediaId")]
        public string MediaId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [JsonPropertyName("position")]
        public long? Position { get; set; }

        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [JsonPropertyName("media")]
        public Media? Media { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MailTemplateMedia {\n");
            sb.Append("  MailTemplateId: ").Append(MailTemplateId).Append("\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
            sb.Append("  MediaId: ").Append(MediaId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
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
            return this.Equals(input as MailTemplateMedia);
        }

        /// <summary>
        /// Returns true if MailTemplateMedia instances are equal
        /// </summary>
        /// <param name="input">Instance of MailTemplateMedia to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MailTemplateMedia? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MailTemplateId == input.MailTemplateId ||
                    (this.MailTemplateId != null &&
                    this.MailTemplateId.Equals(input.MailTemplateId))
                ) && 
                (
                    this.LanguageId == input.LanguageId ||
                    (this.LanguageId != null &&
                    this.LanguageId.Equals(input.LanguageId))
                ) && 
                (
                    this.MediaId == input.MediaId ||
                    (this.MediaId != null &&
                    this.MediaId.Equals(input.MediaId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Position == input.Position ||
                    this.Position.Equals(input.Position)
                ) && 
                (
                    this.Media == input.Media ||
                    (this.Media != null &&
                    this.Media.Equals(input.Media))
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
                if (this.MailTemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.MailTemplateId.GetHashCode();
                }
                if (this.LanguageId != null)
                {
                    hashCode = (hashCode * 59) + this.LanguageId.GetHashCode();
                }
                if (this.MediaId != null)
                {
                    hashCode = (hashCode * 59) + this.MediaId.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Position.GetHashCode();
                if (this.Media != null)
                {
                    hashCode = (hashCode * 59) + this.Media.GetHashCode();
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
            // MailTemplateId (string) pattern
            Regex regexMailTemplateId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexMailTemplateId.Match(this.MailTemplateId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MailTemplateId, must match a pattern of " + regexMailTemplateId, new [] { "MailTemplateId" });
            }

            // LanguageId (string) pattern
            Regex regexLanguageId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexLanguageId.Match(this.LanguageId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LanguageId, must match a pattern of " + regexLanguageId, new [] { "LanguageId" });
            }

            // MediaId (string) pattern
            Regex regexMediaId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexMediaId.Match(this.MediaId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MediaId, must match a pattern of " + regexMediaId, new [] { "MediaId" });
            }

            // Id (string) pattern
            Regex regexId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            yield break;
        }
    }

}
