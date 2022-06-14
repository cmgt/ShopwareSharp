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
    public partial class SystemConfig : IEquatable<SystemConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfig" /> class.
        /// </summary>
        /// <param name="configurationKey">configurationKey (required)</param>
        /// <param name="configurationValue">configurationValue (required)</param>
        /// <param name="createdAt">createdAt (required)</param>
        /// <param name="id">id</param>
        /// <param name="salesChannelId">salesChannelId</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="salesChannel">salesChannel</param>
        public SystemConfig(string configurationKey, SystemConfigConfigurationValue configurationValue, DateTime createdAt, string? id = default, string? salesChannelId = default, DateTime? updatedAt = default, SalesChannel? salesChannel = default)
        {
            if (configurationKey == null)
                throw new ArgumentNullException("configurationKey is a required property for SystemConfig and cannot be null.");

            if (configurationValue == null)
                throw new ArgumentNullException("configurationValue is a required property for SystemConfig and cannot be null.");

            if (createdAt == null)
                throw new ArgumentNullException("createdAt is a required property for SystemConfig and cannot be null.");

            ConfigurationKey = configurationKey;
            ConfigurationValue = configurationValue;
            CreatedAt = createdAt;
            Id = id;
            SalesChannelId = salesChannelId;
            UpdatedAt = updatedAt;
            SalesChannel = salesChannel;
        }

        /// <summary>
        /// Gets or Sets ConfigurationKey
        /// </summary>
        [JsonPropertyName("configurationKey")]
        public string ConfigurationKey { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationValue
        /// </summary>
        [JsonPropertyName("configurationValue")]
        public SystemConfigConfigurationValue ConfigurationValue { get; set; }

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
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets SalesChannel
        /// </summary>
        [JsonPropertyName("salesChannel")]
        public SalesChannel? SalesChannel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SystemConfig {\n");
            sb.Append("  ConfigurationKey: ").Append(ConfigurationKey).Append("\n");
            sb.Append("  ConfigurationValue: ").Append(ConfigurationValue).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SalesChannelId: ").Append(SalesChannelId).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  SalesChannel: ").Append(SalesChannel).Append("\n");
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
            return this.Equals(input as SystemConfig);
        }

        /// <summary>
        /// Returns true if SystemConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemConfig? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConfigurationKey == input.ConfigurationKey ||
                    (this.ConfigurationKey != null &&
                    this.ConfigurationKey.Equals(input.ConfigurationKey))
                ) && 
                (
                    this.ConfigurationValue == input.ConfigurationValue ||
                    (this.ConfigurationValue != null &&
                    this.ConfigurationValue.Equals(input.ConfigurationValue))
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
                    this.SalesChannelId == input.SalesChannelId ||
                    (this.SalesChannelId != null &&
                    this.SalesChannelId.Equals(input.SalesChannelId))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.SalesChannel == input.SalesChannel ||
                    (this.SalesChannel != null &&
                    this.SalesChannel.Equals(input.SalesChannel))
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
                if (this.ConfigurationKey != null)
                {
                    hashCode = (hashCode * 59) + this.ConfigurationKey.GetHashCode();
                }
                if (this.ConfigurationValue != null)
                {
                    hashCode = (hashCode * 59) + this.ConfigurationValue.GetHashCode();
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
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.SalesChannel != null)
                {
                    hashCode = (hashCode * 59) + this.SalesChannel.GetHashCode();
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

            // SalesChannelId (string) pattern
            Regex regexSalesChannelId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexSalesChannelId.Match(this.SalesChannelId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SalesChannelId, must match a pattern of " + regexSalesChannelId, new [] { "SalesChannelId" });
            }

            yield break;
        }
    }

}
