using System.Text.Json.Serialization;

namespace ShopwareSharp.Model;

public class ProductTranslated
{
    [JsonPropertyName("metaDescription")]
    public object MetaDescription { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("keywords")]
    public string[]? Keywords { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("metaTitle")]
    public object MetaTitle { get; set; }

    [JsonPropertyName("packUnit")]
    public object PackUnit { get; set; }

    [JsonPropertyName("packUnitPlural")]
    public object PackUnitPlural { get; set; }

    [JsonPropertyName("customFields")]
    public object CustomFields { get; set; }
}