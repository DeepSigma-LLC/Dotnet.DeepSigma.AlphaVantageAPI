using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.DataModels;

/// <summary>
/// The stock split history response from Alpha Vantage API.
/// </summary>
[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
public class AVStockSplitResponse
{
    /// <summary>
    /// The stock symbol for which the split history is provided.
    /// </summary>
    [JsonPropertyName("symbol")]
    public string? Symbol { get; set; }

    /// <summary>
    /// The stock split history data.
    /// </summary>
    [JsonPropertyName("data")]
    public List<AVStockSplitRecord> Data { get; set; } = [];
}
