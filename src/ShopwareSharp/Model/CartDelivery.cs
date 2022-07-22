using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ShopwareSharp.Model;


/// <summary>
/// CartDelivery
/// </summary>
public class CartDelivery
{
    /// <summary>
    /// Gets or Sets DeliveryDate
    /// </summary>
    [JsonPropertyName("deliveryDate")]
    public CartDeliveryDate? DeliveryDate { get; set; }

    /// <summary>
    /// Gets or Sets DeliveryDate
    /// </summary>
    [JsonPropertyName("positions")]
    public List<CartDeliveryPosition>? Positions { get; set; }

    /// <summary>
    /// Gets or Sets ShippingCosts
    /// </summary>
    [JsonPropertyName("shippingCosts")]
    public CalculatedPrice? ShippingCosts { get; set; }

    /// <summary>
    /// Gets or Sets ShippingMethod
    /// </summary>
    [JsonPropertyName("shippingMethod")]
    public ShippingMethod? ShippingMethod { get; set; }
}

public class CartDeliveryPosition
{
    /// <summary>
    /// Gets or Sets DeliveryDate
    /// </summary>
    [JsonPropertyName("deliveryDate")]
    public CartDeliveryDate DeliveryDate { get; set; }

    /// <summary>
    /// Gets or Sets Identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public string Identifier { get; set; }

    /// <summary>
    /// Gets or Sets LineItem
    /// </summary>
    [JsonPropertyName("lineItem")]
    public LineItem LineItem { get; set; }

    /// <summary>
    /// Gets or Sets Price
    /// </summary>
    [JsonPropertyName("price")]
    public CalculatedPrice Price { get; set; }

    /// <summary>
    /// Gets or Sets Quantity
    /// </summary>
    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }
}

public class CartDeliveryDate
{
    [JsonPropertyName("earliest")]
    public DateTimeOffset? Earliest { get; set; }

    [JsonPropertyName("latest")]
    public DateTimeOffset? Latest { get; set; }
}