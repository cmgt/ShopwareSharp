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
    public partial class DocumentBaseConfig : IEquatable<DocumentBaseConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBaseConfig" /> class.
        /// </summary>
        /// <param name="documentTypeId">documentTypeId (required)</param>
        /// <param name="name">name (required)</param>
        /// <param name="global">global (required)</param>
        /// <param name="createdAt">createdAt (required)</param>
        /// <param name="id">id</param>
        /// <param name="logoId">logoId</param>
        /// <param name="filenamePrefix">filenamePrefix</param>
        /// <param name="filenameSuffix">filenameSuffix</param>
        /// <param name="documentNumber">documentNumber</param>
        /// <param name="config">config</param>
        /// <param name="customFields">customFields</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="logo">logo</param>
        public DocumentBaseConfig(string documentTypeId, string name, bool global, DateTime createdAt, string? id = default, string? logoId = default, string? filenamePrefix = default, string? filenameSuffix = default, string? documentNumber = default, Object? config = default, Object? customFields = default, DateTime? updatedAt = default, Media? logo = default)
        {
            if (documentTypeId == null)
                throw new ArgumentNullException("documentTypeId is a required property for DocumentBaseConfig and cannot be null.");

            if (name == null)
                throw new ArgumentNullException("name is a required property for DocumentBaseConfig and cannot be null.");

            if (global == null)
                throw new ArgumentNullException("global is a required property for DocumentBaseConfig and cannot be null.");

            if (createdAt == null)
                throw new ArgumentNullException("createdAt is a required property for DocumentBaseConfig and cannot be null.");

            DocumentTypeId = documentTypeId;
            Name = name;
            Global = global;
            CreatedAt = createdAt;
            Id = id;
            LogoId = logoId;
            FilenamePrefix = filenamePrefix;
            FilenameSuffix = filenameSuffix;
            DocumentNumber = documentNumber;
            Config = config;
            CustomFields = customFields;
            UpdatedAt = updatedAt;
            Logo = logo;
        }

        /// <summary>
        /// Gets or Sets DocumentTypeId
        /// </summary>
        [JsonPropertyName("documentTypeId")]
        public string DocumentTypeId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Global
        /// </summary>
        [JsonPropertyName("global")]
        public bool Global { get; set; }

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
        /// Gets or Sets LogoId
        /// </summary>
        [JsonPropertyName("logoId")]
        public string? LogoId { get; set; }

        /// <summary>
        /// Gets or Sets FilenamePrefix
        /// </summary>
        [JsonPropertyName("filenamePrefix")]
        public string? FilenamePrefix { get; set; }

        /// <summary>
        /// Gets or Sets FilenameSuffix
        /// </summary>
        [JsonPropertyName("filenameSuffix")]
        public string? FilenameSuffix { get; set; }

        /// <summary>
        /// Gets or Sets DocumentNumber
        /// </summary>
        [JsonPropertyName("documentNumber")]
        public string? DocumentNumber { get; set; }

        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [JsonPropertyName("config")]
        public Object? Config { get; set; }

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
        /// Gets or Sets Logo
        /// </summary>
        [JsonPropertyName("logo")]
        public Media? Logo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocumentBaseConfig {\n");
            sb.Append("  DocumentTypeId: ").Append(DocumentTypeId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Global: ").Append(Global).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LogoId: ").Append(LogoId).Append("\n");
            sb.Append("  FilenamePrefix: ").Append(FilenamePrefix).Append("\n");
            sb.Append("  FilenameSuffix: ").Append(FilenameSuffix).Append("\n");
            sb.Append("  DocumentNumber: ").Append(DocumentNumber).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
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
            return this.Equals(input as DocumentBaseConfig);
        }

        /// <summary>
        /// Returns true if DocumentBaseConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentBaseConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentBaseConfig? input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Global == input.Global ||
                    this.Global.Equals(input.Global)
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
                    this.LogoId == input.LogoId ||
                    (this.LogoId != null &&
                    this.LogoId.Equals(input.LogoId))
                ) && 
                (
                    this.FilenamePrefix == input.FilenamePrefix ||
                    (this.FilenamePrefix != null &&
                    this.FilenamePrefix.Equals(input.FilenamePrefix))
                ) && 
                (
                    this.FilenameSuffix == input.FilenameSuffix ||
                    (this.FilenameSuffix != null &&
                    this.FilenameSuffix.Equals(input.FilenameSuffix))
                ) && 
                (
                    this.DocumentNumber == input.DocumentNumber ||
                    (this.DocumentNumber != null &&
                    this.DocumentNumber.Equals(input.DocumentNumber))
                ) && 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
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
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Global.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.LogoId != null)
                {
                    hashCode = (hashCode * 59) + this.LogoId.GetHashCode();
                }
                if (this.FilenamePrefix != null)
                {
                    hashCode = (hashCode * 59) + this.FilenamePrefix.GetHashCode();
                }
                if (this.FilenameSuffix != null)
                {
                    hashCode = (hashCode * 59) + this.FilenameSuffix.GetHashCode();
                }
                if (this.DocumentNumber != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentNumber.GetHashCode();
                }
                if (this.Config != null)
                {
                    hashCode = (hashCode * 59) + this.Config.GetHashCode();
                }
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.Logo != null)
                {
                    hashCode = (hashCode * 59) + this.Logo.GetHashCode();
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

            // Id (string) pattern
            Regex regexId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            // LogoId (string) pattern
            Regex regexLogoId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexLogoId.Match(this.LogoId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LogoId, must match a pattern of " + regexLogoId, new [] { "LogoId" });
            }

            yield break;
        }
    }

}
