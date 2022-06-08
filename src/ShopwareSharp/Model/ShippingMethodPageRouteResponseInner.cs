/*
 * Shopware Store API
 *
 * This endpoint reference contains an overview of all endpoints comprising the Shopware Store API
 *
 * The version of the OpenAPI document: 6.4.9999999.9999999-dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = ShopwareSharp.Client.FileParameter;
using OpenAPIDateConverter = ShopwareSharp.Client.OpenAPIDateConverter;

namespace ShopwareSharp.Model
{
    /// <summary>
    /// ShippingMethodPageRouteResponseInner
    /// </summary>
    [DataContract(Name = "ShippingMethodPageRouteResponse_inner")]
    public partial class ShippingMethodPageRouteResponseInner : IEquatable<ShippingMethodPageRouteResponseInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingMethodPageRouteResponseInner" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="active">active.</param>
        /// <param name="description">description.</param>
        /// <param name="deliveryTimeId">deliveryTimeId.</param>
        /// <param name="deliveryTime">deliveryTime.</param>
        /// <param name="translations">translations.</param>
        /// <param name="orderDeliveries">orderDeliveries.</param>
        /// <param name="salesChannelDefaultAssignments">salesChannelDefaultAssignments.</param>
        /// <param name="salesChannels">salesChannels.</param>
        /// <param name="availabilityRule">availabilityRule.</param>
        /// <param name="availabilityRuleId">availabilityRuleId.</param>
        /// <param name="prices">prices.</param>
        /// <param name="mediaId">mediaId.</param>
        /// <param name="media">media.</param>
        /// <param name="tags">tags.</param>
        public ShippingMethodPageRouteResponseInner(string name = default(string), bool active = default(bool), string description = default(string), string deliveryTimeId = default(string), ShippingMethodPageRouteResponseInnerDeliveryTime deliveryTime = default(ShippingMethodPageRouteResponseInnerDeliveryTime), List<ShippingMethodPageRouteResponseInnerTranslationsInner> translations = default(List<ShippingMethodPageRouteResponseInnerTranslationsInner>), List<ShippingMethodPageRouteResponseInnerOrderDeliveriesInner> orderDeliveries = default(List<ShippingMethodPageRouteResponseInnerOrderDeliveriesInner>), List<ShippingMethodPageRouteResponseInnerSalesChannelDefaultAssignmentsInner> salesChannelDefaultAssignments = default(List<ShippingMethodPageRouteResponseInnerSalesChannelDefaultAssignmentsInner>), List<ShippingMethodPageRouteResponseInnerSalesChannelDefaultAssignmentsInner> salesChannels = default(List<ShippingMethodPageRouteResponseInnerSalesChannelDefaultAssignmentsInner>), ShippingMethodPageRouteResponseInnerAvailabilityRule availabilityRule = default(ShippingMethodPageRouteResponseInnerAvailabilityRule), string availabilityRuleId = default(string), List<ShippingMethodPageRouteResponseInnerPricesInner> prices = default(List<ShippingMethodPageRouteResponseInnerPricesInner>), string mediaId = default(string), ShippingMethodPageRouteResponseInnerMedia media = default(ShippingMethodPageRouteResponseInnerMedia), List<ShippingMethodPageRouteResponseInnerTagsInner> tags = default(List<ShippingMethodPageRouteResponseInnerTagsInner>))
        {
            this.Name = name;
            this.Active = active;
            this.Description = description;
            this.DeliveryTimeId = deliveryTimeId;
            this.DeliveryTime = deliveryTime;
            this.Translations = translations;
            this.OrderDeliveries = orderDeliveries;
            this.SalesChannelDefaultAssignments = salesChannelDefaultAssignments;
            this.SalesChannels = salesChannels;
            this.AvailabilityRule = availabilityRule;
            this.AvailabilityRuleId = availabilityRuleId;
            this.Prices = prices;
            this.MediaId = mediaId;
            this.Media = media;
            this.Tags = tags;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryTimeId
        /// </summary>
        [DataMember(Name = "deliveryTimeId", EmitDefaultValue = false)]
        public string DeliveryTimeId { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryTime
        /// </summary>
        [DataMember(Name = "deliveryTime", EmitDefaultValue = false)]
        public ShippingMethodPageRouteResponseInnerDeliveryTime DeliveryTime { get; set; }

        /// <summary>
        /// Gets or Sets Translations
        /// </summary>
        [DataMember(Name = "translations", EmitDefaultValue = false)]
        public List<ShippingMethodPageRouteResponseInnerTranslationsInner> Translations { get; set; }

        /// <summary>
        /// Gets or Sets OrderDeliveries
        /// </summary>
        [DataMember(Name = "orderDeliveries", EmitDefaultValue = false)]
        public List<ShippingMethodPageRouteResponseInnerOrderDeliveriesInner> OrderDeliveries { get; set; }

        /// <summary>
        /// Gets or Sets SalesChannelDefaultAssignments
        /// </summary>
        [DataMember(Name = "salesChannelDefaultAssignments", EmitDefaultValue = false)]
        public List<ShippingMethodPageRouteResponseInnerSalesChannelDefaultAssignmentsInner> SalesChannelDefaultAssignments { get; set; }

        /// <summary>
        /// Gets or Sets SalesChannels
        /// </summary>
        [DataMember(Name = "salesChannels", EmitDefaultValue = false)]
        public List<ShippingMethodPageRouteResponseInnerSalesChannelDefaultAssignmentsInner> SalesChannels { get; set; }

        /// <summary>
        /// Gets or Sets AvailabilityRule
        /// </summary>
        [DataMember(Name = "availabilityRule", EmitDefaultValue = false)]
        public ShippingMethodPageRouteResponseInnerAvailabilityRule AvailabilityRule { get; set; }

        /// <summary>
        /// Gets or Sets AvailabilityRuleId
        /// </summary>
        [DataMember(Name = "availabilityRuleId", EmitDefaultValue = false)]
        public string AvailabilityRuleId { get; set; }

        /// <summary>
        /// Gets or Sets Prices
        /// </summary>
        [DataMember(Name = "prices", EmitDefaultValue = false)]
        public List<ShippingMethodPageRouteResponseInnerPricesInner> Prices { get; set; }

        /// <summary>
        /// Gets or Sets MediaId
        /// </summary>
        [DataMember(Name = "mediaId", EmitDefaultValue = false)]
        public string MediaId { get; set; }

        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [DataMember(Name = "media", EmitDefaultValue = false)]
        public ShippingMethodPageRouteResponseInnerMedia Media { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<ShippingMethodPageRouteResponseInnerTagsInner> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShippingMethodPageRouteResponseInner {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DeliveryTimeId: ").Append(DeliveryTimeId).Append("\n");
            sb.Append("  DeliveryTime: ").Append(DeliveryTime).Append("\n");
            sb.Append("  Translations: ").Append(Translations).Append("\n");
            sb.Append("  OrderDeliveries: ").Append(OrderDeliveries).Append("\n");
            sb.Append("  SalesChannelDefaultAssignments: ").Append(SalesChannelDefaultAssignments).Append("\n");
            sb.Append("  SalesChannels: ").Append(SalesChannels).Append("\n");
            sb.Append("  AvailabilityRule: ").Append(AvailabilityRule).Append("\n");
            sb.Append("  AvailabilityRuleId: ").Append(AvailabilityRuleId).Append("\n");
            sb.Append("  Prices: ").Append(Prices).Append("\n");
            sb.Append("  MediaId: ").Append(MediaId).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShippingMethodPageRouteResponseInner);
        }

        /// <summary>
        /// Returns true if ShippingMethodPageRouteResponseInner instances are equal
        /// </summary>
        /// <param name="input">Instance of ShippingMethodPageRouteResponseInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingMethodPageRouteResponseInner input)
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
                    this.DeliveryTimeId == input.DeliveryTimeId ||
                    (this.DeliveryTimeId != null &&
                    this.DeliveryTimeId.Equals(input.DeliveryTimeId))
                ) && 
                (
                    this.DeliveryTime == input.DeliveryTime ||
                    (this.DeliveryTime != null &&
                    this.DeliveryTime.Equals(input.DeliveryTime))
                ) && 
                (
                    this.Translations == input.Translations ||
                    this.Translations != null &&
                    input.Translations != null &&
                    this.Translations.SequenceEqual(input.Translations)
                ) && 
                (
                    this.OrderDeliveries == input.OrderDeliveries ||
                    this.OrderDeliveries != null &&
                    input.OrderDeliveries != null &&
                    this.OrderDeliveries.SequenceEqual(input.OrderDeliveries)
                ) && 
                (
                    this.SalesChannelDefaultAssignments == input.SalesChannelDefaultAssignments ||
                    this.SalesChannelDefaultAssignments != null &&
                    input.SalesChannelDefaultAssignments != null &&
                    this.SalesChannelDefaultAssignments.SequenceEqual(input.SalesChannelDefaultAssignments)
                ) && 
                (
                    this.SalesChannels == input.SalesChannels ||
                    this.SalesChannels != null &&
                    input.SalesChannels != null &&
                    this.SalesChannels.SequenceEqual(input.SalesChannels)
                ) && 
                (
                    this.AvailabilityRule == input.AvailabilityRule ||
                    (this.AvailabilityRule != null &&
                    this.AvailabilityRule.Equals(input.AvailabilityRule))
                ) && 
                (
                    this.AvailabilityRuleId == input.AvailabilityRuleId ||
                    (this.AvailabilityRuleId != null &&
                    this.AvailabilityRuleId.Equals(input.AvailabilityRuleId))
                ) && 
                (
                    this.Prices == input.Prices ||
                    this.Prices != null &&
                    input.Prices != null &&
                    this.Prices.SequenceEqual(input.Prices)
                ) && 
                (
                    this.MediaId == input.MediaId ||
                    (this.MediaId != null &&
                    this.MediaId.Equals(input.MediaId))
                ) && 
                (
                    this.Media == input.Media ||
                    (this.Media != null &&
                    this.Media.Equals(input.Media))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.DeliveryTimeId != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryTimeId.GetHashCode();
                }
                if (this.DeliveryTime != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryTime.GetHashCode();
                }
                if (this.Translations != null)
                {
                    hashCode = (hashCode * 59) + this.Translations.GetHashCode();
                }
                if (this.OrderDeliveries != null)
                {
                    hashCode = (hashCode * 59) + this.OrderDeliveries.GetHashCode();
                }
                if (this.SalesChannelDefaultAssignments != null)
                {
                    hashCode = (hashCode * 59) + this.SalesChannelDefaultAssignments.GetHashCode();
                }
                if (this.SalesChannels != null)
                {
                    hashCode = (hashCode * 59) + this.SalesChannels.GetHashCode();
                }
                if (this.AvailabilityRule != null)
                {
                    hashCode = (hashCode * 59) + this.AvailabilityRule.GetHashCode();
                }
                if (this.AvailabilityRuleId != null)
                {
                    hashCode = (hashCode * 59) + this.AvailabilityRuleId.GetHashCode();
                }
                if (this.Prices != null)
                {
                    hashCode = (hashCode * 59) + this.Prices.GetHashCode();
                }
                if (this.MediaId != null)
                {
                    hashCode = (hashCode * 59) + this.MediaId.GetHashCode();
                }
                if (this.Media != null)
                {
                    hashCode = (hashCode * 59) + this.Media.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
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