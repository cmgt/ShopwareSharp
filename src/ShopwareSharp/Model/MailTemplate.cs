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
    public partial class MailTemplate : IEquatable<MailTemplate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailTemplate" /> class.
        /// </summary>
        /// <param name="contentHtml">contentHtml (required)</param>
        /// <param name="contentPlain">contentPlain (required)</param>
        /// <param name="createdAt">createdAt (required)</param>
        /// <param name="id">id</param>
        /// <param name="systemDefault">systemDefault</param>
        /// <param name="senderName">senderName</param>
        /// <param name="customFields">customFields</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="translated">translated</param>
        /// <param name="mailTemplateType">mailTemplateType</param>
        /// <param name="media">media</param>
        public MailTemplate(string contentHtml, string contentPlain, DateTime createdAt, string? id = default, bool? systemDefault = default, string? senderName = default, Object? customFields = default, DateTime? updatedAt = default, Object? translated = default, MailTemplateType? mailTemplateType = default, MailTemplateMedia? media = default)
        {
            if (contentHtml == null)
                throw new ArgumentNullException("contentHtml is a required property for MailTemplate and cannot be null.");

            if (contentPlain == null)
                throw new ArgumentNullException("contentPlain is a required property for MailTemplate and cannot be null.");

            if (createdAt == null)
                throw new ArgumentNullException("createdAt is a required property for MailTemplate and cannot be null.");

            ContentHtml = contentHtml;
            ContentPlain = contentPlain;
            CreatedAt = createdAt;
            Id = id;
            SystemDefault = systemDefault;
            SenderName = senderName;
            CustomFields = customFields;
            UpdatedAt = updatedAt;
            Translated = translated;
            MailTemplateType = mailTemplateType;
            Media = media;
        }

        /// <summary>
        /// Gets or Sets ContentHtml
        /// </summary>
        [JsonPropertyName("contentHtml")]
        public string ContentHtml { get; set; }

        /// <summary>
        /// Gets or Sets ContentPlain
        /// </summary>
        [JsonPropertyName("contentPlain")]
        public string ContentPlain { get; set; }

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
        /// Gets or Sets SystemDefault
        /// </summary>
        [JsonPropertyName("systemDefault")]
        public bool? SystemDefault { get; set; }

        /// <summary>
        /// Gets or Sets SenderName
        /// </summary>
        [JsonPropertyName("senderName")]
        public string? SenderName { get; set; }

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
        /// Gets or Sets Translated
        /// </summary>
        [JsonPropertyName("translated")]
        public Object? Translated { get; set; }

        /// <summary>
        /// Gets or Sets MailTemplateType
        /// </summary>
        [JsonPropertyName("mailTemplateType")]
        public MailTemplateType? MailTemplateType { get; set; }

        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [JsonPropertyName("media")]
        public MailTemplateMedia? Media { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MailTemplate {\n");
            sb.Append("  ContentHtml: ").Append(ContentHtml).Append("\n");
            sb.Append("  ContentPlain: ").Append(ContentPlain).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SystemDefault: ").Append(SystemDefault).Append("\n");
            sb.Append("  SenderName: ").Append(SenderName).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Translated: ").Append(Translated).Append("\n");
            sb.Append("  MailTemplateType: ").Append(MailTemplateType).Append("\n");
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
            return this.Equals(input as MailTemplate);
        }

        /// <summary>
        /// Returns true if MailTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of MailTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MailTemplate? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContentHtml == input.ContentHtml ||
                    (this.ContentHtml != null &&
                    this.ContentHtml.Equals(input.ContentHtml))
                ) && 
                (
                    this.ContentPlain == input.ContentPlain ||
                    (this.ContentPlain != null &&
                    this.ContentPlain.Equals(input.ContentPlain))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt 
                    
                    
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.SystemDefault == input.SystemDefault ||
                    this.SystemDefault.Equals(input.SystemDefault)
                ) && 
                (
                    this.SenderName == input.SenderName ||
                    (this.SenderName != null &&
                    this.SenderName.Equals(input.SenderName))
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
                    this.Translated == input.Translated ||
                    (this.Translated != null &&
                    this.Translated.Equals(input.Translated))
                ) && 
                (
                    this.MailTemplateType == input.MailTemplateType ||
                    (this.MailTemplateType != null &&
                    this.MailTemplateType.Equals(input.MailTemplateType))
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
                if (this.ContentHtml != null)
                {
                    hashCode = (hashCode * 59) + this.ContentHtml.GetHashCode();
                }
                if (this.ContentPlain != null)
                {
                    hashCode = (hashCode * 59) + this.ContentPlain.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SystemDefault.GetHashCode();
                if (this.SenderName != null)
                {
                    hashCode = (hashCode * 59) + this.SenderName.GetHashCode();
                }
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.Translated != null)
                {
                    hashCode = (hashCode * 59) + this.Translated.GetHashCode();
                }
                if (this.MailTemplateType != null)
                {
                    hashCode = (hashCode * 59) + this.MailTemplateType.GetHashCode();
                }
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
