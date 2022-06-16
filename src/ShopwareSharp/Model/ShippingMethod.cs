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
    public partial class ShippingMethod : IEquatable<ShippingMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingMethod" /> class.
        /// </summary>
        /// <param name="name">name (required)</param>
        /// <param name="deliveryTimeId">deliveryTimeId (required)</param>
        /// <param name="taxType">taxType (required)</param>
        /// <param name="createdAt">createdAt (required)</param>
        /// <param name="id">id</param>
        /// <param name="active">active</param>
        /// <param name="customFields">customFields</param>
        /// <param name="mediaId">mediaId</param>
        /// <param name="description">description</param>
        /// <param name="trackingUrl">trackingUrl</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="translated">translated</param>
        /// <param name="deliveryTime">deliveryTime</param>
        /// <param name="availabilityRule">availabilityRule</param>
        /// <param name="prices">prices</param>
        /// <param name="media">media</param>
        /// <param name="tags">tags</param>
        /// <param name="tax">tax</param>
        public ShippingMethod(string name, string deliveryTimeId, string taxType, DateTime createdAt,
            string? id = default, bool? active = default, Object? customFields = default, string? mediaId = default,
            string? description = default, string? trackingUrl = default, DateTime? updatedAt = default,
            Object? translated = default, DeliveryTime? deliveryTime = default, Rule? availabilityRule = default,
            ShippingMethodPrice[]? prices = default, Media? media = default, Tag? tags = default, Tax? tax = default)
        {
            if (name == null)
                throw new ArgumentNullException("name is a required property for ShippingMethod and cannot be null.");

            if (deliveryTimeId == null)
                throw new ArgumentNullException(
                    "deliveryTimeId is a required property for ShippingMethod and cannot be null.");

            if (taxType == null)
                throw new ArgumentNullException(
                    "taxType is a required property for ShippingMethod and cannot be null.");

            Name = name;
            DeliveryTimeId = deliveryTimeId;
            TaxType = taxType;
            CreatedAt = createdAt;
            Id = id;
            Active = active;
            CustomFields = customFields;
            MediaId = mediaId;
            Description = description;
            TrackingUrl = trackingUrl;
            UpdatedAt = updatedAt;
            Translated = translated;
            DeliveryTime = deliveryTime;
            AvailabilityRule = availabilityRule;
            Prices = prices;
            Media = media;
            Tags = tags;
            Tax = tax;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryTimeId
        /// </summary>
        [JsonPropertyName("deliveryTimeId")]
        public string DeliveryTimeId { get; set; }

        /// <summary>
        /// Gets or Sets TaxType
        /// </summary>
        [JsonPropertyName("taxType")]
        public string TaxType { get; set; }

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
        /// Gets or Sets MediaId
        /// </summary>
        [JsonPropertyName("mediaId")]
        public string? MediaId { get; set; }

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
        /// Gets or Sets DeliveryTime
        /// </summary>
        [JsonPropertyName("deliveryTime")]
        public DeliveryTime? DeliveryTime { get; set; }

        /// <summary>
        /// Gets or Sets AvailabilityRule
        /// </summary>
        [JsonPropertyName("availabilityRule")]
        public Rule? AvailabilityRule { get; set; }

        /// <summary>
        /// Gets or Sets Prices
        /// </summary>
        [JsonPropertyName("prices")]
        public ShippingMethodPrice[]? Prices { get; set; }

        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [JsonPropertyName("media")]
        public Media? Media { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [JsonPropertyName("tags")]
        public Tag? Tags { get; set; }

        /// <summary>
        /// Gets or Sets Tax
        /// </summary>
        [JsonPropertyName("tax")]
        public Tax? Tax { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShippingMethod {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DeliveryTimeId: ").Append(DeliveryTimeId).Append("\n");
            sb.Append("  TaxType: ").Append(TaxType).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  MediaId: ").Append(MediaId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TrackingUrl: ").Append(TrackingUrl).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Translated: ").Append(Translated).Append("\n");
            sb.Append("  DeliveryTime: ").Append(DeliveryTime).Append("\n");
            sb.Append("  AvailabilityRule: ").Append(AvailabilityRule).Append("\n");
            sb.Append("  Prices: ").Append(Prices).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
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
            return this.Equals(input as ShippingMethod);
        }

        /// <summary>
        /// Returns true if ShippingMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of ShippingMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingMethod? input)
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
                    this.DeliveryTimeId == input.DeliveryTimeId ||
                    (this.DeliveryTimeId != null &&
                    this.DeliveryTimeId.Equals(input.DeliveryTimeId))
                ) && 
                (
                    this.TaxType == input.TaxType ||
                    (this.TaxType != null &&
                    this.TaxType.Equals(input.TaxType))
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
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    (this.CustomFields != null &&
                    this.CustomFields.Equals(input.CustomFields))
                ) && 
                (
                    this.MediaId == input.MediaId ||
                    (this.MediaId != null &&
                    this.MediaId.Equals(input.MediaId))
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
                    this.DeliveryTime == input.DeliveryTime ||
                    (this.DeliveryTime != null &&
                    this.DeliveryTime.Equals(input.DeliveryTime))
                ) && 
                (
                    this.AvailabilityRule == input.AvailabilityRule ||
                    (this.AvailabilityRule != null &&
                    this.AvailabilityRule.Equals(input.AvailabilityRule))
                ) && 
                (
                    this.Prices == input.Prices ||
                    (this.Prices != null &&
                    this.Prices.Equals(input.Prices))
                ) && 
                (
                    this.Media == input.Media ||
                    (this.Media != null &&
                    this.Media.Equals(input.Media))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.Tax == input.Tax ||
                    (this.Tax != null &&
                    this.Tax.Equals(input.Tax))
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
                if (this.DeliveryTimeId != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryTimeId.GetHashCode();
                }
                if (this.TaxType != null)
                {
                    hashCode = (hashCode * 59) + this.TaxType.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.MediaId != null)
                {
                    hashCode = (hashCode * 59) + this.MediaId.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.TrackingUrl != null)
                {
                    hashCode = (hashCode * 59) + this.TrackingUrl.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.Translated != null)
                {
                    hashCode = (hashCode * 59) + this.Translated.GetHashCode();
                }
                if (this.DeliveryTime != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryTime.GetHashCode();
                }
                if (this.AvailabilityRule != null)
                {
                    hashCode = (hashCode * 59) + this.AvailabilityRule.GetHashCode();
                }
                if (this.Prices != null)
                {
                    hashCode = (hashCode * 59) + this.Prices.GetHashCode();
                }
                if (this.Media != null)
                {
                    hashCode = (hashCode * 59) + this.Media.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.Tax != null)
                {
                    hashCode = (hashCode * 59) + this.Tax.GetHashCode();
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
            // DeliveryTimeId (string) pattern
            Regex regexDeliveryTimeId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexDeliveryTimeId.Match(this.DeliveryTimeId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeliveryTimeId, must match a pattern of " + regexDeliveryTimeId, new [] { "DeliveryTimeId" });
            }

            // Id (string) pattern
            Regex regexId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            // MediaId (string) pattern
            Regex regexMediaId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexMediaId.Match(this.MediaId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MediaId, must match a pattern of " + regexMediaId, new [] { "MediaId" });
            }

            yield break;
        }
    }

}
