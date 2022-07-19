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
    public partial class Category : IEquatable<Category>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Category" /> class.
        /// </summary>
        /// <param name="displayNestedProducts">displayNestedProducts (required)</param>
        /// <param name="type">type (required)</param>
        /// <param name="productAssignmentType">productAssignmentType (required)</param>
        /// <param name="name">name (required)</param>
        /// <param name="createdAt">createdAt (required)</param>
        /// <param name="id">id</param>
        /// <param name="versionId">versionId</param>
        /// <param name="parentId">parentId</param>
        /// <param name="parentVersionId">parentVersionId</param>
        /// <param name="afterCategoryId">afterCategoryId</param>
        /// <param name="afterCategoryVersionId">afterCategoryVersionId</param>
        /// <param name="mediaId">mediaId</param>
        /// <param name="breadcrumb">breadcrumb</param>
        /// <param name="level">level</param>
        /// <param name="path">path</param>
        /// <param name="childCount">childCount</param>
        /// <param name="visible">visible</param>
        /// <param name="active">active</param>
        /// <param name="customFields">customFields</param>
        /// <param name="linkType">linkType</param>
        /// <param name="internalLink">internalLink</param>
        /// <param name="externalLink">externalLink</param>
        /// <param name="linkNewTab">linkNewTab</param>
        /// <param name="description">description</param>
        /// <param name="metaTitle">metaTitle</param>
        /// <param name="metaDescription">metaDescription</param>
        /// <param name="keywords">keywords</param>
        /// <param name="cmsPageId">cmsPageId</param>
        /// <param name="cmsPageVersionId">cmsPageVersionId</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="translated">translated</param>
        /// <param name="parent">parent</param>
        /// <param name="children">children</param>
        /// <param name="media">media</param>
        /// <param name="cmsPage">cmsPage</param>
        /// <param name="seoUrls">seoUrls</param>
        public Category(bool displayNestedProducts, string type, string productAssignmentType, string name, DateTime createdAt, string? id = default, string? versionId = default, string? parentId = default, string? parentVersionId = default, string? afterCategoryId = default, string? afterCategoryVersionId = default, string? mediaId = default, List<string>? breadcrumb = default, long? level = default, string? path = default, long? childCount = default, bool? visible = default, bool? active = default, Object? customFields = default, string? linkType = default, string? internalLink = default, string? externalLink = default, bool? linkNewTab = default, string? description = default, string? metaTitle = default, string? metaDescription = default, string? keywords = default, string? cmsPageId = default, string? cmsPageVersionId = default, DateTime? updatedAt = default, Object? translated = default, Category? parent = default, Category? children = default, Media? media = default, CmsPage? cmsPage = default, SeoUrl? seoUrls = default)
        {
            if (type == null)
                throw new ArgumentNullException("type is a required property for Category and cannot be null.");

            if (productAssignmentType == null)
                throw new ArgumentNullException("productAssignmentType is a required property for Category and cannot be null.");

            if (name == null)
                throw new ArgumentNullException("name is a required property for Category and cannot be null.");

            DisplayNestedProducts = displayNestedProducts;
            Type = type;
            ProductAssignmentType = productAssignmentType;
            Name = name;
            CreatedAt = createdAt;
            Id = id;
            VersionId = versionId;
            ParentId = parentId;
            ParentVersionId = parentVersionId;
            AfterCategoryId = afterCategoryId;
            AfterCategoryVersionId = afterCategoryVersionId;
            MediaId = mediaId;
            Breadcrumb = breadcrumb;
            Level = level;
            Path = path;
            ChildCount = childCount;
            Visible = visible;
            Active = active;
            CustomFields = customFields;
            LinkType = linkType;
            InternalLink = internalLink;
            ExternalLink = externalLink;
            LinkNewTab = linkNewTab;
            Description = description;
            MetaTitle = metaTitle;
            MetaDescription = metaDescription;
            Keywords = keywords;
            CmsPageId = cmsPageId;
            CmsPageVersionId = cmsPageVersionId;
            UpdatedAt = updatedAt;
            Translated = translated;
            Parent = parent;
            Children = children;
            Media = media;
            CmsPage = cmsPage;
            SeoUrls = seoUrls;
        }

        [JsonConstructor]
        public Category()
        {}

        /// <summary>
        /// Gets or Sets DisplayNestedProducts
        /// </summary>
        [JsonPropertyName("displayNestedProducts")]
        public bool DisplayNestedProducts { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets ProductAssignmentType
        /// </summary>
        [JsonPropertyName("productAssignmentType")]
        public string ProductAssignmentType { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

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
        /// Gets or Sets ParentId
        /// </summary>
        [JsonPropertyName("parentId")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Gets or Sets ParentVersionId
        /// </summary>
        [JsonPropertyName("parentVersionId")]
        public string? ParentVersionId { get; set; }

        /// <summary>
        /// Gets or Sets AfterCategoryId
        /// </summary>
        [JsonPropertyName("afterCategoryId")]
        public string? AfterCategoryId { get; set; }

        /// <summary>
        /// Gets or Sets AfterCategoryVersionId
        /// </summary>
        [JsonPropertyName("afterCategoryVersionId")]
        public string? AfterCategoryVersionId { get; set; }

        /// <summary>
        /// Gets or Sets MediaId
        /// </summary>
        [JsonPropertyName("mediaId")]
        public string? MediaId { get; set; }

        /// <summary>
        /// Gets or Sets Breadcrumb
        /// </summary>
        [JsonPropertyName("breadcrumb")]
        public List<string>? Breadcrumb { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [JsonPropertyName("level")]
        public long? Level { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Gets or Sets ChildCount
        /// </summary>
        [JsonPropertyName("childCount")]
        public long? ChildCount { get; set; }

        /// <summary>
        /// Gets or Sets Visible
        /// </summary>
        [JsonPropertyName("visible")]
        public bool? Visible { get; set; }

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
        /// Gets or Sets LinkType
        /// </summary>
        [JsonPropertyName("linkType")]
        public string? LinkType { get; set; }

        /// <summary>
        /// Gets or Sets InternalLink
        /// </summary>
        [JsonPropertyName("internalLink")]
        public string? InternalLink { get; set; }

        /// <summary>
        /// Gets or Sets ExternalLink
        /// </summary>
        [JsonPropertyName("externalLink")]
        public string? ExternalLink { get; set; }

        /// <summary>
        /// Gets or Sets LinkNewTab
        /// </summary>
        [JsonPropertyName("linkNewTab")]
        public bool? LinkNewTab { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

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
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Translated
        /// </summary>
        [JsonPropertyName("translated")]
        public Object? Translated { get; set; }

        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [JsonPropertyName("parent")]
        public Category? Parent { get; set; }

        /// <summary>
        /// Gets or Sets Children
        /// </summary>
        [JsonPropertyName("children")]
        public Category? Children { get; set; }

        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [JsonPropertyName("media")]
        public Media? Media { get; set; }

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
            sb.Append("class Category {\n");
            sb.Append("  DisplayNestedProducts: ").Append(DisplayNestedProducts).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ProductAssignmentType: ").Append(ProductAssignmentType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VersionId: ").Append(VersionId).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  ParentVersionId: ").Append(ParentVersionId).Append("\n");
            sb.Append("  AfterCategoryId: ").Append(AfterCategoryId).Append("\n");
            sb.Append("  AfterCategoryVersionId: ").Append(AfterCategoryVersionId).Append("\n");
            sb.Append("  MediaId: ").Append(MediaId).Append("\n");
            sb.Append("  Breadcrumb: ").Append(Breadcrumb).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  ChildCount: ").Append(ChildCount).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  LinkType: ").Append(LinkType).Append("\n");
            sb.Append("  InternalLink: ").Append(InternalLink).Append("\n");
            sb.Append("  ExternalLink: ").Append(ExternalLink).Append("\n");
            sb.Append("  LinkNewTab: ").Append(LinkNewTab).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MetaTitle: ").Append(MetaTitle).Append("\n");
            sb.Append("  MetaDescription: ").Append(MetaDescription).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  CmsPageId: ").Append(CmsPageId).Append("\n");
            sb.Append("  CmsPageVersionId: ").Append(CmsPageVersionId).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Translated: ").Append(Translated).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
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
            return this.Equals(input as Category);
        }

        /// <summary>
        /// Returns true if Category instances are equal
        /// </summary>
        /// <param name="input">Instance of Category to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Category? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisplayNestedProducts == input.DisplayNestedProducts ||
                    this.DisplayNestedProducts.Equals(input.DisplayNestedProducts)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ProductAssignmentType == input.ProductAssignmentType ||
                    (this.ProductAssignmentType != null &&
                    this.ProductAssignmentType.Equals(input.ProductAssignmentType))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                    this.VersionId == input.VersionId ||
                    (this.VersionId != null &&
                    this.VersionId.Equals(input.VersionId))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.ParentVersionId == input.ParentVersionId ||
                    (this.ParentVersionId != null &&
                    this.ParentVersionId.Equals(input.ParentVersionId))
                ) && 
                (
                    this.AfterCategoryId == input.AfterCategoryId ||
                    (this.AfterCategoryId != null &&
                    this.AfterCategoryId.Equals(input.AfterCategoryId))
                ) && 
                (
                    this.AfterCategoryVersionId == input.AfterCategoryVersionId ||
                    (this.AfterCategoryVersionId != null &&
                    this.AfterCategoryVersionId.Equals(input.AfterCategoryVersionId))
                ) && 
                (
                    this.MediaId == input.MediaId ||
                    (this.MediaId != null &&
                    this.MediaId.Equals(input.MediaId))
                ) && 
                (
                    this.Breadcrumb == input.Breadcrumb ||
                    this.Breadcrumb != null &&
                    input.Breadcrumb != null &&
                    this.Breadcrumb.SequenceEqual(input.Breadcrumb)
                ) && 
                (
                    this.Level == input.Level ||
                    this.Level.Equals(input.Level)
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.ChildCount == input.ChildCount ||
                    this.ChildCount.Equals(input.ChildCount)
                ) && 
                (
                    this.Visible == input.Visible ||
                    this.Visible.Equals(input.Visible)
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
                    this.LinkType == input.LinkType ||
                    (this.LinkType != null &&
                    this.LinkType.Equals(input.LinkType))
                ) && 
                (
                    this.InternalLink == input.InternalLink ||
                    (this.InternalLink != null &&
                    this.InternalLink.Equals(input.InternalLink))
                ) && 
                (
                    this.ExternalLink == input.ExternalLink ||
                    (this.ExternalLink != null &&
                    this.ExternalLink.Equals(input.ExternalLink))
                ) && 
                (
                    this.LinkNewTab == input.LinkNewTab ||
                    this.LinkNewTab.Equals(input.LinkNewTab)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                    this.Parent == input.Parent ||
                    (this.Parent != null &&
                    this.Parent.Equals(input.Parent))
                ) && 
                (
                    this.Children == input.Children ||
                    (this.Children != null &&
                    this.Children.Equals(input.Children))
                ) && 
                (
                    this.Media == input.Media ||
                    (this.Media != null &&
                    this.Media.Equals(input.Media))
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
                hashCode = (hashCode * 59) + this.DisplayNestedProducts.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.ProductAssignmentType != null)
                {
                    hashCode = (hashCode * 59) + this.ProductAssignmentType.GetHashCode();
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
                if (this.VersionId != null)
                {
                    hashCode = (hashCode * 59) + this.VersionId.GetHashCode();
                }
                if (this.ParentId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentId.GetHashCode();
                }
                if (this.ParentVersionId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentVersionId.GetHashCode();
                }
                if (this.AfterCategoryId != null)
                {
                    hashCode = (hashCode * 59) + this.AfterCategoryId.GetHashCode();
                }
                if (this.AfterCategoryVersionId != null)
                {
                    hashCode = (hashCode * 59) + this.AfterCategoryVersionId.GetHashCode();
                }
                if (this.MediaId != null)
                {
                    hashCode = (hashCode * 59) + this.MediaId.GetHashCode();
                }
                if (this.Breadcrumb != null)
                {
                    hashCode = (hashCode * 59) + this.Breadcrumb.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Level.GetHashCode();
                if (this.Path != null)
                {
                    hashCode = (hashCode * 59) + this.Path.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ChildCount.GetHashCode();
                hashCode = (hashCode * 59) + this.Visible.GetHashCode();
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.LinkType != null)
                {
                    hashCode = (hashCode * 59) + this.LinkType.GetHashCode();
                }
                if (this.InternalLink != null)
                {
                    hashCode = (hashCode * 59) + this.InternalLink.GetHashCode();
                }
                if (this.ExternalLink != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalLink.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LinkNewTab.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
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
                if (this.Parent != null)
                {
                    hashCode = (hashCode * 59) + this.Parent.GetHashCode();
                }
                if (this.Children != null)
                {
                    hashCode = (hashCode * 59) + this.Children.GetHashCode();
                }
                if (this.Media != null)
                {
                    hashCode = (hashCode * 59) + this.Media.GetHashCode();
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

            // ParentId (string) pattern
            Regex regexParentId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexParentId.Match(this.ParentId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ParentId, must match a pattern of " + regexParentId, new [] { "ParentId" });
            }

            // ParentVersionId (string) pattern
            Regex regexParentVersionId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexParentVersionId.Match(this.ParentVersionId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ParentVersionId, must match a pattern of " + regexParentVersionId, new [] { "ParentVersionId" });
            }

            // AfterCategoryId (string) pattern
            Regex regexAfterCategoryId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexAfterCategoryId.Match(this.AfterCategoryId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AfterCategoryId, must match a pattern of " + regexAfterCategoryId, new [] { "AfterCategoryId" });
            }

            // AfterCategoryVersionId (string) pattern
            Regex regexAfterCategoryVersionId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexAfterCategoryVersionId.Match(this.AfterCategoryVersionId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AfterCategoryVersionId, must match a pattern of " + regexAfterCategoryVersionId, new [] { "AfterCategoryVersionId" });
            }

            // MediaId (string) pattern
            Regex regexMediaId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexMediaId.Match(this.MediaId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MediaId, must match a pattern of " + regexMediaId, new [] { "MediaId" });
            }

            // InternalLink (string) pattern
            Regex regexInternalLink = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexInternalLink.Match(this.InternalLink).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InternalLink, must match a pattern of " + regexInternalLink, new [] { "InternalLink" });
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
