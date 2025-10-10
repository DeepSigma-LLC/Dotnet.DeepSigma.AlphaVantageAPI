using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.DataModels;

/// <summary>
/// The class represents the response for earnings estimates from the Alpha Vantage API.
/// </summary>
[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
public class AVEarningsEstimateResponse
{
    /// <summary>
    /// The stock symbol for which the earnings estimates are provided.
    /// </summary>
    [JsonPropertyName("symbol")]
    public string? Symbol { get; set; }

    /// <summary>
    /// A list of earnings estimates.
    /// </summary>
    [JsonPropertyName("estimates")]
    public List<AVEarningsEstimate> Estimates { get; set; } = [];
}
