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
    /// Selected payment method
    /// </summary>
    public partial class SalesChannelContextAllOfPaymentMethod : IEquatable<SalesChannelContextAllOfPaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesChannelContextAllOfPaymentMethod" /> class.
        /// </summary>
        /// <param name="pluginId">pluginId</param>
        /// <param name="handlerIdentifier">handlerIdentifier</param>
        /// <param name="name">name</param>
        /// <param name="description">description</param>
        /// <param name="position">position</param>
        /// <param name="active">active</param>
        /// <param name="availabilityRuleId">availabilityRuleId</param>
        /// <param name="mediaId">mediaId</param>
        /// <param name="formattedHandlerIdentifier">formattedHandlerIdentifier</param>
        public SalesChannelContextAllOfPaymentMethod(string? pluginId = default, string? handlerIdentifier = default, string? name = default, string? description = default, int? position = default, bool? active = default, string? availabilityRuleId = default, string? mediaId = default, string? formattedHandlerIdentifier = default)
        {
            PluginId = pluginId;
            HandlerIdentifier = handlerIdentifier;
            Name = name;
            Description = description;
            Position = position;
            Active = active;
            AvailabilityRuleId = availabilityRuleId;
            MediaId = mediaId;
            FormattedHandlerIdentifier = formattedHandlerIdentifier;
        }

        /// <summary>
        /// Gets or Sets PluginId
        /// </summary>
        [JsonPropertyName("pluginId")]
        public string? PluginId { get; set; }

        /// <summary>
        /// Gets or Sets HandlerIdentifier
        /// </summary>
        [JsonPropertyName("handlerIdentifier")]
        public string? HandlerIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets AvailabilityRuleId
        /// </summary>
        [JsonPropertyName("availabilityRuleId")]
        public string? AvailabilityRuleId { get; set; }

        /// <summary>
        /// Gets or Sets MediaId
        /// </summary>
        [JsonPropertyName("mediaId")]
        public string? MediaId { get; set; }

        /// <summary>
        /// Gets or Sets FormattedHandlerIdentifier
        /// </summary>
        [JsonPropertyName("formattedHandlerIdentifier")]
        public string? FormattedHandlerIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SalesChannelContextAllOfPaymentMethod {\n");
            sb.Append("  PluginId: ").Append(PluginId).Append("\n");
            sb.Append("  HandlerIdentifier: ").Append(HandlerIdentifier).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  AvailabilityRuleId: ").Append(AvailabilityRuleId).Append("\n");
            sb.Append("  MediaId: ").Append(MediaId).Append("\n");
            sb.Append("  FormattedHandlerIdentifier: ").Append(FormattedHandlerIdentifier).Append("\n");
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
            return this.Equals(input as SalesChannelContextAllOfPaymentMethod);
        }

        /// <summary>
        /// Returns true if SalesChannelContextAllOfPaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesChannelContextAllOfPaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesChannelContextAllOfPaymentMethod? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PluginId == input.PluginId ||
                    (this.PluginId != null &&
                    this.PluginId.Equals(input.PluginId))
                ) && 
                (
                    this.HandlerIdentifier == input.HandlerIdentifier ||
                    (this.HandlerIdentifier != null &&
                    this.HandlerIdentifier.Equals(input.HandlerIdentifier))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Position == input.Position ||
                    this.Position.Equals(input.Position)
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.AvailabilityRuleId == input.AvailabilityRuleId ||
                    (this.AvailabilityRuleId != null &&
                    this.AvailabilityRuleId.Equals(input.AvailabilityRuleId))
                ) && 
                (
                    this.MediaId == input.MediaId ||
                    (this.MediaId != null &&
                    this.MediaId.Equals(input.MediaId))
                ) && 
                (
                    this.FormattedHandlerIdentifier == input.FormattedHandlerIdentifier ||
                    (this.FormattedHandlerIdentifier != null &&
                    this.FormattedHandlerIdentifier.Equals(input.FormattedHandlerIdentifier))
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
                if (this.PluginId != null)
                {
                    hashCode = (hashCode * 59) + this.PluginId.GetHashCode();
                }
                if (this.HandlerIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.HandlerIdentifier.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Position.GetHashCode();
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.AvailabilityRuleId != null)
                {
                    hashCode = (hashCode * 59) + this.AvailabilityRuleId.GetHashCode();
                }
                if (this.MediaId != null)
                {
                    hashCode = (hashCode * 59) + this.MediaId.GetHashCode();
                }
                if (this.FormattedHandlerIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.FormattedHandlerIdentifier.GetHashCode();
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
            yield break;
        }
    }

}
