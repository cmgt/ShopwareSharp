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
    public partial class CmsSection : IEquatable<CmsSection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CmsSection" /> class.
        /// </summary>
        /// <param name="position">position (required)</param>
        /// <param name="type">type (required)</param>
        /// <param name="pageId">pageId (required)</param>
        /// <param name="createdAt">createdAt (required)</param>
        /// <param name="id">id</param>
        /// <param name="name">name</param>
        /// <param name="sizingMode">sizingMode</param>
        /// <param name="mobileBehavior">mobileBehavior</param>
        /// <param name="backgroundColor">backgroundColor</param>
        /// <param name="backgroundMediaId">backgroundMediaId</param>
        /// <param name="backgroundMediaMode">backgroundMediaMode</param>
        /// <param name="cssClass">cssClass</param>
        /// <param name="customFields">customFields</param>
        /// <param name="cmsPageVersionId">cmsPageVersionId</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="page">page</param>
        /// <param name="backgroundMedia">backgroundMedia</param>
        /// <param name="blocks">blocks</param>
        public CmsSection(long position, string type, string pageId, DateTime createdAt, string? id = default, string? name = default, string? sizingMode = default, string? mobileBehavior = default, string? backgroundColor = default, string? backgroundMediaId = default, string? backgroundMediaMode = default, string? cssClass = default, Object? customFields = default, string? cmsPageVersionId = default, DateTime? updatedAt = default, CmsPage? page = default, Media? backgroundMedia = default, CmsBlock? blocks = default)
        {
            if (position == null)
                throw new ArgumentNullException("position is a required property for CmsSection and cannot be null.");

            if (type == null)
                throw new ArgumentNullException("type is a required property for CmsSection and cannot be null.");

            if (pageId == null)
                throw new ArgumentNullException("pageId is a required property for CmsSection and cannot be null.");

            if (createdAt == null)
                throw new ArgumentNullException("createdAt is a required property for CmsSection and cannot be null.");

            Position = position;
            Type = type;
            PageId = pageId;
            CreatedAt = createdAt;
            Id = id;
            Name = name;
            SizingMode = sizingMode;
            MobileBehavior = mobileBehavior;
            BackgroundColor = backgroundColor;
            BackgroundMediaId = backgroundMediaId;
            BackgroundMediaMode = backgroundMediaMode;
            CssClass = cssClass;
            CustomFields = customFields;
            CmsPageVersionId = cmsPageVersionId;
            UpdatedAt = updatedAt;
            Page = page;
            BackgroundMedia = backgroundMedia;
            Blocks = blocks;
        }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [JsonPropertyName("position")]
        public long Position { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets PageId
        /// </summary>
        [JsonPropertyName("pageId")]
        public string PageId { get; set; }

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
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or Sets SizingMode
        /// </summary>
        [JsonPropertyName("sizingMode")]
        public string? SizingMode { get; set; }

        /// <summary>
        /// Gets or Sets MobileBehavior
        /// </summary>
        [JsonPropertyName("mobileBehavior")]
        public string? MobileBehavior { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundColor
        /// </summary>
        [JsonPropertyName("backgroundColor")]
        public string? BackgroundColor { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundMediaId
        /// </summary>
        [JsonPropertyName("backgroundMediaId")]
        public string? BackgroundMediaId { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundMediaMode
        /// </summary>
        [JsonPropertyName("backgroundMediaMode")]
        public string? BackgroundMediaMode { get; set; }

        /// <summary>
        /// Gets or Sets CssClass
        /// </summary>
        [JsonPropertyName("cssClass")]
        public string? CssClass { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [JsonPropertyName("customFields")]
        public Object? CustomFields { get; set; }

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
        /// Gets or Sets Page
        /// </summary>
        [JsonPropertyName("page")]
        public CmsPage? Page { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundMedia
        /// </summary>
        [JsonPropertyName("backgroundMedia")]
        public Media? BackgroundMedia { get; set; }

        /// <summary>
        /// Gets or Sets Blocks
        /// </summary>
        [JsonPropertyName("blocks")]
        public CmsBlock? Blocks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CmsSection {\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  PageId: ").Append(PageId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SizingMode: ").Append(SizingMode).Append("\n");
            sb.Append("  MobileBehavior: ").Append(MobileBehavior).Append("\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  BackgroundMediaId: ").Append(BackgroundMediaId).Append("\n");
            sb.Append("  BackgroundMediaMode: ").Append(BackgroundMediaMode).Append("\n");
            sb.Append("  CssClass: ").Append(CssClass).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CmsPageVersionId: ").Append(CmsPageVersionId).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  BackgroundMedia: ").Append(BackgroundMedia).Append("\n");
            sb.Append("  Blocks: ").Append(Blocks).Append("\n");
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
            return this.Equals(input as CmsSection);
        }

        /// <summary>
        /// Returns true if CmsSection instances are equal
        /// </summary>
        /// <param name="input">Instance of CmsSection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CmsSection? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Position == input.Position ||
                    this.Position.Equals(input.Position)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.PageId == input.PageId ||
                    (this.PageId != null &&
                    this.PageId.Equals(input.PageId))
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SizingMode == input.SizingMode ||
                    (this.SizingMode != null &&
                    this.SizingMode.Equals(input.SizingMode))
                ) && 
                (
                    this.MobileBehavior == input.MobileBehavior ||
                    (this.MobileBehavior != null &&
                    this.MobileBehavior.Equals(input.MobileBehavior))
                ) && 
                (
                    this.BackgroundColor == input.BackgroundColor ||
                    (this.BackgroundColor != null &&
                    this.BackgroundColor.Equals(input.BackgroundColor))
                ) && 
                (
                    this.BackgroundMediaId == input.BackgroundMediaId ||
                    (this.BackgroundMediaId != null &&
                    this.BackgroundMediaId.Equals(input.BackgroundMediaId))
                ) && 
                (
                    this.BackgroundMediaMode == input.BackgroundMediaMode ||
                    (this.BackgroundMediaMode != null &&
                    this.BackgroundMediaMode.Equals(input.BackgroundMediaMode))
                ) && 
                (
                    this.CssClass == input.CssClass ||
                    (this.CssClass != null &&
                    this.CssClass.Equals(input.CssClass))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    (this.CustomFields != null &&
                    this.CustomFields.Equals(input.CustomFields))
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
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.BackgroundMedia == input.BackgroundMedia ||
                    (this.BackgroundMedia != null &&
                    this.BackgroundMedia.Equals(input.BackgroundMedia))
                ) && 
                (
                    this.Blocks == input.Blocks ||
                    (this.Blocks != null &&
                    this.Blocks.Equals(input.Blocks))
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
                hashCode = (hashCode * 59) + this.Position.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.PageId != null)
                {
                    hashCode = (hashCode * 59) + this.PageId.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.SizingMode != null)
                {
                    hashCode = (hashCode * 59) + this.SizingMode.GetHashCode();
                }
                if (this.MobileBehavior != null)
                {
                    hashCode = (hashCode * 59) + this.MobileBehavior.GetHashCode();
                }
                if (this.BackgroundColor != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundColor.GetHashCode();
                }
                if (this.BackgroundMediaId != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundMediaId.GetHashCode();
                }
                if (this.BackgroundMediaMode != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundMediaMode.GetHashCode();
                }
                if (this.CssClass != null)
                {
                    hashCode = (hashCode * 59) + this.CssClass.GetHashCode();
                }
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.CmsPageVersionId != null)
                {
                    hashCode = (hashCode * 59) + this.CmsPageVersionId.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.Page != null)
                {
                    hashCode = (hashCode * 59) + this.Page.GetHashCode();
                }
                if (this.BackgroundMedia != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundMedia.GetHashCode();
                }
                if (this.Blocks != null)
                {
                    hashCode = (hashCode * 59) + this.Blocks.GetHashCode();
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
            // PageId (string) pattern
            Regex regexPageId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexPageId.Match(this.PageId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PageId, must match a pattern of " + regexPageId, new [] { "PageId" });
            }

            // Id (string) pattern
            Regex regexId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            // BackgroundMediaId (string) pattern
            Regex regexBackgroundMediaId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexBackgroundMediaId.Match(this.BackgroundMediaId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BackgroundMediaId, must match a pattern of " + regexBackgroundMediaId, new [] { "BackgroundMediaId" });
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
