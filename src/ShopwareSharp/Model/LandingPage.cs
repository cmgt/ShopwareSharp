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
    /// Added since version: 6.4.0.0
    /// </summary>
    public partial class LandingPage : IEquatable<LandingPage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LandingPage" /> class.
        /// </summary>
        /// <param name="name">name (required)</param>
        /// <param name="url">url (required)</param>
        /// <param name="createdAt">createdAt (required)</param>
        /// <param name="id">id</param>
        /// <param name="versionId">versionId</param>
        /// <param name="active">active</param>
        /// <param name="customFields">customFields</param>
        /// <param name="slotConfig">slotConfig</param>
        /// <param name="metaTitle">metaTitle</param>
        /// <param name="metaDescription">metaDescription</param>
        /// <param name="keywords">keywords</param>
        /// <param name="cmsPageId">cmsPageId</param>
        /// <param name="cmsPageVersionId">cmsPageVersionId</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="translated">translated</param>
        /// <param name="cmsPage">cmsPage</param>
        /// <param name="seoUrls">seoUrls</param>
        public LandingPage(string name, string url, DateTime createdAt, string? id = default, string? versionId = default, bool? active = default, Object? customFields = default, Object? slotConfig = default, string? metaTitle = default, string? metaDescription = default, string? keywords = default, string? cmsPageId = default, string? cmsPageVersionId = default, DateTime? updatedAt = default, Object? translated = default, CmsPage? cmsPage = default, SeoUrl? seoUrls = default)
        {
            if (name == null)
                throw new ArgumentNullException("name is a required property for LandingPage and cannot be null.");

            if (url == null)
                throw new ArgumentNullException("url is a required property for LandingPage and cannot be null.");

            if (createdAt == null)
                throw new ArgumentNullException("createdAt is a required property for LandingPage and cannot be null.");

            Name = name;
            Url = url;
            CreatedAt = createdAt;
            Id = id;
            VersionId = versionId;
            Active = active;
            CustomFields = customFields;
            SlotConfig = slotConfig;
            MetaTitle = metaTitle;
            MetaDescription = metaDescription;
            Keywords = keywords;
            CmsPageId = cmsPageId;
            CmsPageVersionId = cmsPageVersionId;
            UpdatedAt = updatedAt;
            Translated = translated;
            CmsPage = cmsPage;
            SeoUrls = seoUrls;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

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
        /// Gets or Sets VersionId
        /// </summary>
        [JsonPropertyName("versionId")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [JsonPropertyName("customFields")]
        public Object? CustomFields { get; set; }

        /// <summary>
        /// Gets or Sets SlotConfig
        /// </summary>
        [JsonPropertyName("slotConfig")]
        public Object? SlotConfig { get; set; }

        /// <summary>
        /// Gets or Sets MetaTitle
        /// </summary>
        [JsonPropertyName("metaTitle")]
        public string? MetaTitle { get; set; }

        /// <summary>
        /// Gets or Sets MetaDescription
        /// </summary>
        [JsonPropertyName("metaDescription")]
        public string? MetaDescription { get; set; }

        /// <summary>
        /// Gets or Sets Keywords
        /// </summary>
        [JsonPropertyName("keywords")]
        public string? Keywords { get; set; }

        /// <summary>
        /// Gets or Sets CmsPageId
        /// </summary>
        [JsonPropertyName("cmsPageId")]
        public string? CmsPageId { get; set; }

        /// <summary>
        /// Gets or Sets CmsPageVersionId
        /// </summary>
        [JsonPropertyName("cmsPageVersionId")]
        public string? CmsPageVersionId { get; set; }

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
        /// Gets or Sets CmsPage
        /// </summary>
        [JsonPropertyName("cmsPage")]
        public CmsPage? CmsPage { get; set; }

        /// <summary>
        /// Gets or Sets SeoUrls
        /// </summary>
        [JsonPropertyName("seoUrls")]
        public SeoUrl? SeoUrls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LandingPage {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VersionId: ").Append(VersionId).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  SlotConfig: ").Append(SlotConfig).Append("\n");
            sb.Append("  MetaTitle: ").Append(MetaTitle).Append("\n");
            sb.Append("  MetaDescription: ").Append(MetaDescription).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  CmsPageId: ").Append(CmsPageId).Append("\n");
            sb.Append("  CmsPageVersionId: ").Append(CmsPageVersionId).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Translated: ").Append(Translated).Append("\n");
            sb.Append("  CmsPage: ").Append(CmsPage).Append("\n");
            sb.Append("  SeoUrls: ").Append(SeoUrls).Append("\n");
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
            return this.Equals(input as LandingPage);
        }

        /// <summary>
        /// Returns true if LandingPage instances are equal
        /// </summary>
        /// <param name="input">Instance of LandingPage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LandingPage? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                    this.VersionId == input.VersionId ||
                    (this.VersionId != null &&
                    this.VersionId.Equals(input.VersionId))
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    (this.CustomFields != null &&
                    this.CustomFields.Equals(input.CustomFields))
                ) && 
                (
                    this.SlotConfig == input.SlotConfig ||
                    (this.SlotConfig != null &&
                    this.SlotConfig.Equals(input.SlotConfig))
                ) && 
                (
                    this.MetaTitle == input.MetaTitle ||
                    (this.MetaTitle != null &&
                    this.MetaTitle.Equals(input.MetaTitle))
                ) && 
                (
                    this.MetaDescription == input.MetaDescription ||
                    (this.MetaDescription != null &&
                    this.MetaDescription.Equals(input.MetaDescription))
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    (this.Keywords != null &&
                    this.Keywords.Equals(input.Keywords))
                ) && 
                (
                    this.CmsPageId == input.CmsPageId ||
                    (this.CmsPageId != null &&
                    this.CmsPageId.Equals(input.CmsPageId))
                ) && 
                (
                    this.CmsPageVersionId == input.CmsPageVersionId ||
                    (this.CmsPageVersionId != null &&
                    this.CmsPageVersionId.Equals(input.CmsPageVersionId))
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
                    this.CmsPage == input.CmsPage ||
                    (this.CmsPage != null &&
                    this.CmsPage.Equals(input.CmsPage))
                ) && 
                (
                    this.SeoUrls == input.SeoUrls ||
                    (this.SeoUrls != null &&
                    this.SeoUrls.Equals(input.SeoUrls))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.VersionId != null)
                {
                    hashCode = (hashCode * 59) + this.VersionId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.SlotConfig != null)
                {
                    hashCode = (hashCode * 59) + this.SlotConfig.GetHashCode();
                }
                if (this.MetaTitle != null)
                {
                    hashCode = (hashCode * 59) + this.MetaTitle.GetHashCode();
                }
                if (this.MetaDescription != null)
                {
                    hashCode = (hashCode * 59) + this.MetaDescription.GetHashCode();
                }
                if (this.Keywords != null)
                {
                    hashCode = (hashCode * 59) + this.Keywords.GetHashCode();
                }
                if (this.CmsPageId != null)
                {
                    hashCode = (hashCode * 59) + this.CmsPageId.GetHashCode();
                }
                if (this.CmsPageVersionId != null)
                {
                    hashCode = (hashCode * 59) + this.CmsPageVersionId.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.Translated != null)
                {
                    hashCode = (hashCode * 59) + this.Translated.GetHashCode();
                }
                if (this.CmsPage != null)
                {
                    hashCode = (hashCode * 59) + this.CmsPage.GetHashCode();
                }
                if (this.SeoUrls != null)
                {
                    hashCode = (hashCode * 59) + this.SeoUrls.GetHashCode();
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

            // VersionId (string) pattern
            Regex regexVersionId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexVersionId.Match(this.VersionId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VersionId, must match a pattern of " + regexVersionId, new [] { "VersionId" });
            }

            // CmsPageId (string) pattern
            Regex regexCmsPageId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexCmsPageId.Match(this.CmsPageId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CmsPageId, must match a pattern of " + regexCmsPageId, new [] { "CmsPageId" });
            }

            // CmsPageVersionId (string) pattern
            Regex regexCmsPageVersionId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexCmsPageVersionId.Match(this.CmsPageVersionId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CmsPageVersionId, must match a pattern of " + regexCmsPageVersionId, new [] { "CmsPageVersionId" });
            }

            yield break;
        }
    }

}
