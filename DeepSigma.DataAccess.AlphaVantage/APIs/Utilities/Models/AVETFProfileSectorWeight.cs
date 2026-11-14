using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.APIs.Utilities.Models;

/// <summary>
/// The class represents sector weight data from the Alpha Vantage API.
/// </summary>
[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
public class AVETFProfileSectorWeight
{
    /// <summary>
    /// The sector name.
    /// </summary>
    [JsonPropertyName("sector")]
    public string Sector { get; set; } = string.Empty;

    /// <summary>
    /// The weight of the sector in the ETF.
    /// </summary>
    [JsonPropertyName("weight")]
    public decimal Weight { get; set; }
}
