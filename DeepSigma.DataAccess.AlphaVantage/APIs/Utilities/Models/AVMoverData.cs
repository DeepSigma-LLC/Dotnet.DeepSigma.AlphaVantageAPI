using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.APIs.Utilities.Models;

/// <summary>
/// Data model for the daily gainers/lossers/actively traded endpoint from Alpha Vantage API.
/// </summary>
public class AVMoverData
{
    /// <summary>
    /// The stock ticker symbol.
    /// </summary>
    [JsonPropertyName("ticker")]
    public string Ticker { get; init; } = string.Empty;

    /// <summary>
    /// The price of the stock.
    /// </summary>
    [JsonPropertyName("price")]
    public decimal Price { get; init; }

    /// <summary>
    /// The stock's change amount.
    /// </summary>
    [JsonPropertyName("change_amount")]
    public decimal ChangeAmount { get; init; }

    /// <summary>
    /// The change percentage of the stock.
    /// </summary>
    [JsonPropertyName("change_percentage")]
    public string ChangePercentage { get; init; } = string.Empty;

    /// <summary>
    /// The volume of shares traded.
    /// </summary>
    [JsonPropertyName("volume")]
    public long Volume { get; init; }
}
