using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.APIs.Utilities.Models;

/// <summary>
/// The class represents the holding weight of a profile in an ETF from the Alpha Vantage API.
/// </summary>
[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
public class AVETFProfileHoldingWeight
{
    /// <summary>
    /// The ticker symbol of the holding.
    /// </summary>
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    /// <summary>
    /// The name of the holding.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; init; } = string.Empty;

    /// <summary>
    /// The weight of the holding in the ETF.
    /// </summary>
    [JsonPropertyName("weight")]
    public decimal Weight { get; init; }
}
