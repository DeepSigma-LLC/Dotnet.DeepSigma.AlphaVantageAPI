using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.APIs.Utilities.Models;

/// <summary>
/// The response model for the market movers information from Alpha Vantage API.
/// </summary>
public class AVMoverResponse
{
    /// <summary>
    /// The metadata information about the market movers response.
    /// </summary>
    [JsonPropertyName("metadata")]
    public string Metadata { get; init; } = string.Empty;

    /// <summary>
    /// The time stamp of the last update.
    /// As string, since format may vary.
    /// </summary>
    [JsonPropertyName("last_updated")]
    public string LastUpdated { get; init; } = string.Empty;

    /// <summary>
    /// Data of top gainers.
    /// </summary>
    [JsonPropertyName("top_gainers")]
    public List<AVMoverData> TopGainers { get; init; } = [];

    /// <summary>
    /// Data of top losers.
    /// </summary>
    [JsonPropertyName("top_losers")]
    public List<AVMoverData> TopLosers { get; init; } = [];

    /// <summary>
    /// Data of most actively traded stocks.
    /// </summary>
    [JsonPropertyName("most_actively_traded")]
    public List<AVMoverData> MostActivelyTraded { get; init; } = [];
}
