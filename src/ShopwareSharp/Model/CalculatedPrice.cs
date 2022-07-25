using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ShopwareSharp.Model;

public class CalculatedPrice
{
    [JsonPropertyName("unitPrice")]
    public double UnitPrice { get; set; }

    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }

    [JsonPropertyName("totalPrice")]
    public double TotalPrice { get; set; }

    [JsonPropertyName("calculatedTaxes")]
    public List<CalculatedTax> CalculatedTaxes { get; set; }

    [JsonPropertyName("taxRules")]
    public List<PriceTaxRule> TaxRules { get; set; }

    [JsonPropertyName("referencePrice")]
    public double? ReferencePrice { get; set; }

    [JsonPropertyName("listPrice")]
    public double? ListPrice { get; set; }

    [JsonPropertyName("regulationPrice")]
    public double? RegulationPrice { get; set; }
}

public class PriceTaxRule
{
    [JsonPropertyName("taxRate")]
    public int TaxRate { get; set; }

    [JsonPropertyName("percentage")]
    public int Percentage { get; set; }
}