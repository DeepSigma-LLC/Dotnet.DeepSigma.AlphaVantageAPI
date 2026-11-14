using System.Text.Json.Serialization;


namespace DeepSigma.AlphaVantageAPI.APIs.Utilities.Models;

/// <summary>
/// The response model for the market closure information from Alpha Vantage API.
/// </summary>
public class AVMarketClosureResponse
{
    /// <summary>
    /// The API endpoint that was called.
    /// </summary>
    [JsonPropertyName("endpoint")]
    public string Endpoint { get; init; } = string.Empty;

    /// <summary>
    /// The market closure data.
    /// </summary>
    [JsonPropertyName("markets")]
    public List<AVMarketClosureData> Markets { get; init; } = [];
}
