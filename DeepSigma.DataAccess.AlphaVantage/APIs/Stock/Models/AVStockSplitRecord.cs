using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.APIs.Stock.Models;

/// <summary>
/// Represents a stock split record from Alpha Vantage API.
/// </summary>
[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
public class AVStockSplitRecord
{
    /// <summary>
    /// The effective date of the stock split.
    /// </summary>
    [JsonPropertyName("effective_date")]
    public DateOnly EffectiveDate { get; set; }

    /// <summary>
    /// The split factor of the stock split (e.g., 2 for a 2-for-1 split).
    /// </summary>
    [JsonPropertyName("split_factor")]
    public decimal SplitFactor { get; set; }
}
