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
    /// OrderRouteResponse
    /// </summary>
    public partial class OrderRouteResponse : IEquatable<OrderRouteResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRouteResponse" /> class.
        /// </summary>
        /// <param name="orders">orders</param>
        /// <param name="paymentChangeable">The key-value pairs contain the uuid of the order as key and a boolean as value, indicating that the payment method can still be changed.</param>
        public OrderRouteResponse(List<Order>? orders = default, Dictionary<string, bool>? paymentChangeable = default)
        {
            Orders = orders;
            PaymentChangeable = paymentChangeable;
        }

        /// <summary>
        /// Gets or Sets Orders
        /// </summary>
        [JsonPropertyName("orders")]
        public List<Order>? Orders { get; set; }

        /// <summary>
        /// The key-value pairs contain the uuid of the order as key and a boolean as value, indicating that the payment method can still be changed.
        /// </summary>
        /// <value>The key-value pairs contain the uuid of the order as key and a boolean as value, indicating that the payment method can still be changed.</value>
        [JsonPropertyName("paymentChangeable")]
        public Dictionary<string, bool>? PaymentChangeable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderRouteResponse {\n");
            sb.Append("  Orders: ").Append(Orders).Append("\n");
            sb.Append("  PaymentChangeable: ").Append(PaymentChangeable).Append("\n");
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
            return this.Equals(input as OrderRouteResponse);
        }

        /// <summary>
        /// Returns true if OrderRouteResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderRouteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderRouteResponse? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Orders == input.Orders ||
                    this.Orders != null &&
                    input.Orders != null &&
                    this.Orders.SequenceEqual(input.Orders)
                ) && 
                (
                    this.PaymentChangeable == input.PaymentChangeable ||
                    this.PaymentChangeable != null &&
                    input.PaymentChangeable != null &&
                    this.PaymentChangeable.SequenceEqual(input.PaymentChangeable)
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
                if (this.Orders != null)
                {
                    hashCode = (hashCode * 59) + this.Orders.GetHashCode();
                }
                if (this.PaymentChangeable != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentChangeable.GetHashCode();
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
