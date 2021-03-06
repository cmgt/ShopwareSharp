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
    public partial class ProductReview : IEquatable<ProductReview>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductReview" /> class.
        /// </summary>
        /// <param name="productId">productId (required)</param>
        /// <param name="salesChannelId">salesChannelId (required)</param>
        /// <param name="languageId">languageId (required)</param>
        /// <param name="title">title (required)</param>
        /// <param name="content">content (required)</param>
        /// <param name="createdAt">createdAt (required)</param>
        /// <param name="id">id</param>
        /// <param name="productVersionId">productVersionId</param>
        /// <param name="points">points</param>
        /// <param name="status">status</param>
        /// <param name="comment">comment</param>
        /// <param name="customFields">customFields</param>
        /// <param name="updatedAt">updatedAt</param>
        public ProductReview(string productId, string salesChannelId, string languageId, string title, string content, DateTime createdAt, string? id = default, string? productVersionId = default, float? points = default, bool? status = default, string? comment = default, Object? customFields = default, DateTime? updatedAt = default)
        {
            if (productId == null)
                throw new ArgumentNullException("productId is a required property for ProductReview and cannot be null.");

            if (salesChannelId == null)
                throw new ArgumentNullException("salesChannelId is a required property for ProductReview and cannot be null.");

            if (languageId == null)
                throw new ArgumentNullException("languageId is a required property for ProductReview and cannot be null.");

            if (title == null)
                throw new ArgumentNullException("title is a required property for ProductReview and cannot be null.");

            if (content == null)
                throw new ArgumentNullException("content is a required property for ProductReview and cannot be null.");

            if (createdAt == null)
                throw new ArgumentNullException("createdAt is a required property for ProductReview and cannot be null.");

            ProductId = productId;
            SalesChannelId = salesChannelId;
            LanguageId = languageId;
            Title = title;
            Content = content;
            CreatedAt = createdAt;
            Id = id;
            ProductVersionId = productVersionId;
            Points = points;
            Status = status;
            Comment = comment;
            CustomFields = customFields;
            UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets ProductId
        /// </summary>
        [JsonPropertyName("productId")]
        public string ProductId { get; set; }

        /// <summary>
        /// Gets or Sets SalesChannelId
        /// </summary>
        [JsonPropertyName("salesChannelId")]
        public string SalesChannelId { get; set; }

        /// <summary>
        /// Gets or Sets LanguageId
        /// </summary>
        [JsonPropertyName("languageId")]
        public string LanguageId { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

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
        /// Gets or Sets ProductVersionId
        /// </summary>
        [JsonPropertyName("productVersionId")]
        public string? ProductVersionId { get; set; }

        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [JsonPropertyName("points")]
        public float? Points { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonPropertyName("status")]
        public bool? Status { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductReview {\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  SalesChannelId: ").Append(SalesChannelId).Append("\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProductVersionId: ").Append(ProductVersionId).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
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
            return this.Equals(input as ProductReview);
        }

        /// <summary>
        /// Returns true if ProductReview instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductReview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductReview? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.SalesChannelId == input.SalesChannelId ||
                    (this.SalesChannelId != null &&
                    this.SalesChannelId.Equals(input.SalesChannelId))
                ) && 
                (
                    this.LanguageId == input.LanguageId ||
                    (this.LanguageId != null &&
                    this.LanguageId.Equals(input.LanguageId))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
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
                    this.ProductVersionId == input.ProductVersionId ||
                    (this.ProductVersionId != null &&
                    this.ProductVersionId.Equals(input.ProductVersionId))
                ) && 
                (
                    this.Points == input.Points ||
                    this.Points.Equals(input.Points)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
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
                if (this.ProductId != null)
                {
                    hashCode = (hashCode * 59) + this.ProductId.GetHashCode();
                }
                if (this.SalesChannelId != null)
                {
                    hashCode = (hashCode * 59) + this.SalesChannelId.GetHashCode();
                }
                if (this.LanguageId != null)
                {
                    hashCode = (hashCode * 59) + this.LanguageId.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.ProductVersionId != null)
                {
                    hashCode = (hashCode * 59) + this.ProductVersionId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Points.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Comment != null)
                {
                    hashCode = (hashCode * 59) + this.Comment.GetHashCode();
                }
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
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
            // ProductId (string) pattern
            Regex regexProductId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexProductId.Match(this.ProductId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductId, must match a pattern of " + regexProductId, new [] { "ProductId" });
            }

            // SalesChannelId (string) pattern
            Regex regexSalesChannelId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexSalesChannelId.Match(this.SalesChannelId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SalesChannelId, must match a pattern of " + regexSalesChannelId, new [] { "SalesChannelId" });
            }

            // LanguageId (string) pattern
            Regex regexLanguageId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexLanguageId.Match(this.LanguageId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LanguageId, must match a pattern of " + regexLanguageId, new [] { "LanguageId" });
            }

            // Id (string) pattern
            Regex regexId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            // ProductVersionId (string) pattern
            Regex regexProductVersionId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexProductVersionId.Match(this.ProductVersionId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductVersionId, must match a pattern of " + regexProductVersionId, new [] { "ProductVersionId" });
            }

            yield break;
        }
    }

}
