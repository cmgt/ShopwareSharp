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
    public partial class DocumentBaseConfigSalesChannel : IEquatable<DocumentBaseConfigSalesChannel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBaseConfigSalesChannel" /> class.
        /// </summary>
        /// <param name="documentBaseConfigId">documentBaseConfigId (required)</param>
        /// <param name="createdAt">createdAt (required)</param>
        /// <param name="id">id</param>
        /// <param name="salesChannelId">salesChannelId</param>
        /// <param name="documentTypeId">documentTypeId</param>
        /// <param name="updatedAt">updatedAt</param>
        public DocumentBaseConfigSalesChannel(string documentBaseConfigId, DateTime createdAt, string? id = default, string? salesChannelId = default, string? documentTypeId = default, DateTime? updatedAt = default)
        {
            if (documentBaseConfigId == null)
                throw new ArgumentNullException("documentBaseConfigId is a required property for DocumentBaseConfigSalesChannel and cannot be null.");

            if (createdAt == null)
                throw new ArgumentNullException("createdAt is a required property for DocumentBaseConfigSalesChannel and cannot be null.");

            DocumentBaseConfigId = documentBaseConfigId;
            CreatedAt = createdAt;
            Id = id;
            SalesChannelId = salesChannelId;
            DocumentTypeId = documentTypeId;
            UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets DocumentBaseConfigId
        /// </summary>
        [JsonPropertyName("documentBaseConfigId")]
        public string DocumentBaseConfigId { get; set; }

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
        /// Gets or Sets SalesChannelId
        /// </summary>
        [JsonPropertyName("salesChannelId")]
        public string? SalesChannelId { get; set; }

        /// <summary>
        /// Gets or Sets DocumentTypeId
        /// </summary>
        [JsonPropertyName("documentTypeId")]
        public string? DocumentTypeId { get; set; }

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
            sb.Append("class DocumentBaseConfigSalesChannel {\n");
            sb.Append("  DocumentBaseConfigId: ").Append(DocumentBaseConfigId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SalesChannelId: ").Append(SalesChannelId).Append("\n");
            sb.Append("  DocumentTypeId: ").Append(DocumentTypeId).Append("\n");
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
            return this.Equals(input as DocumentBaseConfigSalesChannel);
        }

        /// <summary>
        /// Returns true if DocumentBaseConfigSalesChannel instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentBaseConfigSalesChannel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentBaseConfigSalesChannel? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DocumentBaseConfigId == input.DocumentBaseConfigId ||
                    (this.DocumentBaseConfigId != null &&
                    this.DocumentBaseConfigId.Equals(input.DocumentBaseConfigId))
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
                    this.SalesChannelId == input.SalesChannelId ||
                    (this.SalesChannelId != null &&
                    this.SalesChannelId.Equals(input.SalesChannelId))
                ) && 
                (
                    this.DocumentTypeId == input.DocumentTypeId ||
                    (this.DocumentTypeId != null &&
                    this.DocumentTypeId.Equals(input.DocumentTypeId))
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
                if (this.DocumentBaseConfigId != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentBaseConfigId.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.SalesChannelId != null)
                {
                    hashCode = (hashCode * 59) + this.SalesChannelId.GetHashCode();
                }
                if (this.DocumentTypeId != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentTypeId.GetHashCode();
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
            // DocumentBaseConfigId (string) pattern
            Regex regexDocumentBaseConfigId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexDocumentBaseConfigId.Match(this.DocumentBaseConfigId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DocumentBaseConfigId, must match a pattern of " + regexDocumentBaseConfigId, new [] { "DocumentBaseConfigId" });
            }

            // Id (string) pattern
            Regex regexId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            // SalesChannelId (string) pattern
            Regex regexSalesChannelId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexSalesChannelId.Match(this.SalesChannelId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SalesChannelId, must match a pattern of " + regexSalesChannelId, new [] { "SalesChannelId" });
            }

            // DocumentTypeId (string) pattern
            Regex regexDocumentTypeId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexDocumentTypeId.Match(this.DocumentTypeId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DocumentTypeId, must match a pattern of " + regexDocumentTypeId, new [] { "DocumentTypeId" });
            }

            yield break;
        }
    }

}
