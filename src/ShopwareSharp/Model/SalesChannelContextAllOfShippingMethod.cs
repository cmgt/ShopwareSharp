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
    /// Selected shipping method
    /// </summary>
    public partial class SalesChannelContextAllOfShippingMethod : IEquatable<SalesChannelContextAllOfShippingMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesChannelContextAllOfShippingMethod" /> class.
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="active">active</param>
        /// <param name="description">description</param>
        /// <param name="trackingUrl">trackingUrl</param>
        /// <param name="deliveryTimeId">deliveryTimeId</param>
        /// <param name="availabilityRuleId">availabilityRuleId</param>
        /// <param name="mediaId">mediaId</param>
        public SalesChannelContextAllOfShippingMethod(string? name = default, bool? active = default, string? description = default, string? trackingUrl = default, string? deliveryTimeId = default, string? availabilityRuleId = default, string? mediaId = default)
        {
            Name = name;
            Active = active;
            Description = description;
            TrackingUrl = trackingUrl;
            DeliveryTimeId = deliveryTimeId;
            AvailabilityRuleId = availabilityRuleId;
            MediaId = mediaId;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or Sets TrackingUrl
        /// </summary>
        [JsonPropertyName("trackingUrl")]
        public string? TrackingUrl { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryTimeId
        /// </summary>
        [JsonPropertyName("deliveryTimeId")]
        public string? DeliveryTimeId { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SalesChannelContextAllOfShippingMethod {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TrackingUrl: ").Append(TrackingUrl).Append("\n");
            sb.Append("  DeliveryTimeId: ").Append(DeliveryTimeId).Append("\n");
            sb.Append("  AvailabilityRuleId: ").Append(AvailabilityRuleId).Append("\n");
            sb.Append("  MediaId: ").Append(MediaId).Append("\n");
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
            return this.Equals(input as SalesChannelContextAllOfShippingMethod);
        }

        /// <summary>
        /// Returns true if SalesChannelContextAllOfShippingMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesChannelContextAllOfShippingMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesChannelContextAllOfShippingMethod? input)
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
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.TrackingUrl == input.TrackingUrl ||
                    (this.TrackingUrl != null &&
                    this.TrackingUrl.Equals(input.TrackingUrl))
                ) && 
                (
                    this.DeliveryTimeId == input.DeliveryTimeId ||
                    (this.DeliveryTimeId != null &&
                    this.DeliveryTimeId.Equals(input.DeliveryTimeId))
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
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.TrackingUrl != null)
                {
                    hashCode = (hashCode * 59) + this.TrackingUrl.GetHashCode();
                }
                if (this.DeliveryTimeId != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryTimeId.GetHashCode();
                }
                if (this.AvailabilityRuleId != null)
                {
                    hashCode = (hashCode * 59) + this.AvailabilityRuleId.GetHashCode();
                }
                if (this.MediaId != null)
                {
                    hashCode = (hashCode * 59) + this.MediaId.GetHashCode();
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
