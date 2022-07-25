using System.Text.Json.Serialization;

namespace ShopwareSharp.Model;

public class CalculatedTax
{
    [JsonPropertyName("tax")]
    public double Tax { get; set; }

    [JsonPropertyName("taxRate")]
    public int TaxRate { get; set; }

    [JsonPropertyName("price")]
    public double Price { get; set; }
}