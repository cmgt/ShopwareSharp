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
    public partial class Document : IEquatable<Document>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        /// <param name="documentTypeId">documentTypeId (required)</param>
        /// <param name="fileType">fileType (required)</param>
        /// <param name="orderId">orderId (required)</param>
        /// <param name="config">config (required)</param>
        /// <param name="deepLinkCode">deepLinkCode (required)</param>
        /// <param name="createdAt">createdAt (required)</param>
        /// <param name="id">id</param>
        /// <param name="referencedDocumentId">referencedDocumentId</param>
        /// <param name="documentMediaFileId">documentMediaFileId</param>
        /// <param name="orderVersionId">orderVersionId</param>
        /// <param name="sent">sent</param>
        /// <param name="_static">_static</param>
        /// <param name="customFields">customFields</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="documentType">documentType</param>
        /// <param name="order">order</param>
        /// <param name="referencedDocument">referencedDocument</param>
        /// <param name="dependentDocuments">dependentDocuments</param>
        /// <param name="documentMediaFile">documentMediaFile</param>
        public Document(string documentTypeId, string fileType, string orderId, Object config, string deepLinkCode, DateTime createdAt, string? id = default, string? referencedDocumentId = default, string? documentMediaFileId = default, string? orderVersionId = default, bool? sent = default, bool? _static = default, Object? customFields = default, DateTime? updatedAt = default, DocumentType? documentType = default, Order? order = default, Document? referencedDocument = default, Document? dependentDocuments = default, Media? documentMediaFile = default)
        {
            if (documentTypeId == null)
                throw new ArgumentNullException("documentTypeId is a required property for Document and cannot be null.");

            if (fileType == null)
                throw new ArgumentNullException("fileType is a required property for Document and cannot be null.");

            if (orderId == null)
                throw new ArgumentNullException("orderId is a required property for Document and cannot be null.");

            if (config == null)
                throw new ArgumentNullException("config is a required property for Document and cannot be null.");

            if (deepLinkCode == null)
                throw new ArgumentNullException("deepLinkCode is a required property for Document and cannot be null.");

            if (createdAt == null)
                throw new ArgumentNullException("createdAt is a required property for Document and cannot be null.");

            DocumentTypeId = documentTypeId;
            FileType = fileType;
            OrderId = orderId;
            Config = config;
            DeepLinkCode = deepLinkCode;
            CreatedAt = createdAt;
            Id = id;
            ReferencedDocumentId = referencedDocumentId;
            DocumentMediaFileId = documentMediaFileId;
            OrderVersionId = orderVersionId;
            Sent = sent;
            Static = _static;
            CustomFields = customFields;
            UpdatedAt = updatedAt;
            DocumentType = documentType;
            Order = order;
            ReferencedDocument = referencedDocument;
            DependentDocuments = dependentDocuments;
            DocumentMediaFile = documentMediaFile;
        }

        /// <summary>
        /// Gets or Sets DocumentTypeId
        /// </summary>
        [JsonPropertyName("documentTypeId")]
        public string DocumentTypeId { get; set; }

        /// <summary>
        /// Gets or Sets FileType
        /// </summary>
        [JsonPropertyName("fileType")]
        public string FileType { get; set; }

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [JsonPropertyName("orderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [JsonPropertyName("config")]
        public Object Config { get; set; }

        /// <summary>
        /// Gets or Sets DeepLinkCode
        /// </summary>
        [JsonPropertyName("deepLinkCode")]
        public string DeepLinkCode { get; set; }

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
        /// Gets or Sets ReferencedDocumentId
        /// </summary>
        [JsonPropertyName("referencedDocumentId")]
        public string? ReferencedDocumentId { get; set; }

        /// <summary>
        /// Gets or Sets DocumentMediaFileId
        /// </summary>
        [JsonPropertyName("documentMediaFileId")]
        public string? DocumentMediaFileId { get; set; }

        /// <summary>
        /// Gets or Sets OrderVersionId
        /// </summary>
        [JsonPropertyName("orderVersionId")]
        public string? OrderVersionId { get; set; }

        /// <summary>
        /// Gets or Sets Sent
        /// </summary>
        [JsonPropertyName("sent")]
        public bool? Sent { get; set; }

        /// <summary>
        /// Gets or Sets Static
        /// </summary>
        [JsonPropertyName("static")]
        public bool? Static { get; set; }

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
        /// Gets or Sets DocumentType
        /// </summary>
        [JsonPropertyName("documentType")]
        public DocumentType? DocumentType { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [JsonPropertyName("order")]
        public Order? Order { get; set; }

        /// <summary>
        /// Gets or Sets ReferencedDocument
        /// </summary>
        [JsonPropertyName("referencedDocument")]
        public Document? ReferencedDocument { get; set; }

        /// <summary>
        /// Gets or Sets DependentDocuments
        /// </summary>
        [JsonPropertyName("dependentDocuments")]
        public Document? DependentDocuments { get; set; }

        /// <summary>
        /// Gets or Sets DocumentMediaFile
        /// </summary>
        [JsonPropertyName("documentMediaFile")]
        public Media? DocumentMediaFile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Document {\n");
            sb.Append("  DocumentTypeId: ").Append(DocumentTypeId).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  DeepLinkCode: ").Append(DeepLinkCode).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ReferencedDocumentId: ").Append(ReferencedDocumentId).Append("\n");
            sb.Append("  DocumentMediaFileId: ").Append(DocumentMediaFileId).Append("\n");
            sb.Append("  OrderVersionId: ").Append(OrderVersionId).Append("\n");
            sb.Append("  Sent: ").Append(Sent).Append("\n");
            sb.Append("  Static: ").Append(Static).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  ReferencedDocument: ").Append(ReferencedDocument).Append("\n");
            sb.Append("  DependentDocuments: ").Append(DependentDocuments).Append("\n");
            sb.Append("  DocumentMediaFile: ").Append(DocumentMediaFile).Append("\n");
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
            return this.Equals(input as Document);
        }

        /// <summary>
        /// Returns true if Document instances are equal
        /// </summary>
        /// <param name="input">Instance of Document to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Document? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DocumentTypeId == input.DocumentTypeId ||
                    (this.DocumentTypeId != null &&
                    this.DocumentTypeId.Equals(input.DocumentTypeId))
                ) && 
                (
                    this.FileType == input.FileType ||
                    (this.FileType != null &&
                    this.FileType.Equals(input.FileType))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && 
                (
                    this.DeepLinkCode == input.DeepLinkCode ||
                    (this.DeepLinkCode != null &&
                    this.DeepLinkCode.Equals(input.DeepLinkCode))
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
                    this.ReferencedDocumentId == input.ReferencedDocumentId ||
                    (this.ReferencedDocumentId != null &&
                    this.ReferencedDocumentId.Equals(input.ReferencedDocumentId))
                ) && 
                (
                    this.DocumentMediaFileId == input.DocumentMediaFileId ||
                    (this.DocumentMediaFileId != null &&
                    this.DocumentMediaFileId.Equals(input.DocumentMediaFileId))
                ) && 
                (
                    this.OrderVersionId == input.OrderVersionId ||
                    (this.OrderVersionId != null &&
                    this.OrderVersionId.Equals(input.OrderVersionId))
                ) && 
                (
                    this.Sent == input.Sent ||
                    this.Sent.Equals(input.Sent)
                ) && 
                (
                    this.Static == input.Static ||
                    this.Static.Equals(input.Static)
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
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.ReferencedDocument == input.ReferencedDocument ||
                    (this.ReferencedDocument != null &&
                    this.ReferencedDocument.Equals(input.ReferencedDocument))
                ) && 
                (
                    this.DependentDocuments == input.DependentDocuments ||
                    (this.DependentDocuments != null &&
                    this.DependentDocuments.Equals(input.DependentDocuments))
                ) && 
                (
                    this.DocumentMediaFile == input.DocumentMediaFile ||
                    (this.DocumentMediaFile != null &&
                    this.DocumentMediaFile.Equals(input.DocumentMediaFile))
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
                if (this.DocumentTypeId != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentTypeId.GetHashCode();
                }
                if (this.FileType != null)
                {
                    hashCode = (hashCode * 59) + this.FileType.GetHashCode();
                }
                if (this.OrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                }
                if (this.Config != null)
                {
                    hashCode = (hashCode * 59) + this.Config.GetHashCode();
                }
                if (this.DeepLinkCode != null)
                {
                    hashCode = (hashCode * 59) + this.DeepLinkCode.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.ReferencedDocumentId != null)
                {
                    hashCode = (hashCode * 59) + this.ReferencedDocumentId.GetHashCode();
                }
                if (this.DocumentMediaFileId != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentMediaFileId.GetHashCode();
                }
                if (this.OrderVersionId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderVersionId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Sent.GetHashCode();
                hashCode = (hashCode * 59) + this.Static.GetHashCode();
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.DocumentType != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentType.GetHashCode();
                }
                if (this.Order != null)
                {
                    hashCode = (hashCode * 59) + this.Order.GetHashCode();
                }
                if (this.ReferencedDocument != null)
                {
                    hashCode = (hashCode * 59) + this.ReferencedDocument.GetHashCode();
                }
                if (this.DependentDocuments != null)
                {
                    hashCode = (hashCode * 59) + this.DependentDocuments.GetHashCode();
                }
                if (this.DocumentMediaFile != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentMediaFile.GetHashCode();
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
            // DocumentTypeId (string) pattern
            Regex regexDocumentTypeId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexDocumentTypeId.Match(this.DocumentTypeId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DocumentTypeId, must match a pattern of " + regexDocumentTypeId, new [] { "DocumentTypeId" });
            }

            // OrderId (string) pattern
            Regex regexOrderId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexOrderId.Match(this.OrderId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OrderId, must match a pattern of " + regexOrderId, new [] { "OrderId" });
            }

            // Id (string) pattern
            Regex regexId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            // ReferencedDocumentId (string) pattern
            Regex regexReferencedDocumentId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexReferencedDocumentId.Match(this.ReferencedDocumentId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReferencedDocumentId, must match a pattern of " + regexReferencedDocumentId, new [] { "ReferencedDocumentId" });
            }

            // DocumentMediaFileId (string) pattern
            Regex regexDocumentMediaFileId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexDocumentMediaFileId.Match(this.DocumentMediaFileId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DocumentMediaFileId, must match a pattern of " + regexDocumentMediaFileId, new [] { "DocumentMediaFileId" });
            }

            // OrderVersionId (string) pattern
            Regex regexOrderVersionId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexOrderVersionId.Match(this.OrderVersionId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OrderVersionId, must match a pattern of " + regexOrderVersionId, new [] { "OrderVersionId" });
            }

            yield break;
        }
    }

}
