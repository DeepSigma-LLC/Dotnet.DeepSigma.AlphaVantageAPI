using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.APIs.Fundamentals.Models;

/// <summary>
/// The class represents the earnings history response from the Alpha Vantage API.
/// </summary>
[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
public class AVEarningsHistroyResponse
{
    /// <summary>
    /// The stock symbol for which the earnings history is provided.
    /// </summary>
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; } = string.Empty;

    /// <summary>
    /// The list of annual earnings data.
    /// </summary>
    [JsonPropertyName("annualEarnings")]
    public List<AVEarningsAnnualData> AnnualEarnings { get; set; } = [];

    /// <summary>
    /// The list of quarterly earnings data.
    /// </summary>
    [JsonPropertyName("quarterlyEarnings")]
    public List<AVEarningsQuarterlyData> QuarterlyEarnings { get; set; } = [];
}
