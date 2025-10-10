using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.DataModels;

/// <summary>
/// Data model for the bulk quote endpoint from Alpha Vantage API.
/// </summary>
[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
public sealed class AVBulkQuoteData
{
    /// <summary>
    /// The stock symbol for the quote data.
    /// </summary>
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    /// <summary>
    /// The timestamp of the quote data. 
    /// </summary>
    [JsonPropertyName("timestamp")]
    public string Timestamp { get; init; } = string.Empty;

    /// <summary>
    /// The opening price.
    /// </summary>
    [JsonPropertyName("open")]
    public decimal Open { get; init; }

    /// <summary>
    /// The high price.
    /// </summary>
    [JsonPropertyName("high")]
    public decimal High { get; init; }

    /// <summary>
    /// The low price.
    /// </summary>
    [JsonPropertyName("low")]
    public decimal Low { get; init; }

    /// <summary>
    /// The closing price.
    /// </summary>
    [JsonPropertyName("close")]
    public decimal Close { get; init; }

    /// <summary>
    /// The adjusted closing price.
    /// </summary>
    [JsonPropertyName("adjusted close")]
    public decimal AdjustedClose { get; init; }

    /// <summary>
    /// The trading volume.
    /// </summary>
    [JsonPropertyName("volume")]
    public long Volume { get; init; }

    /// <summary>
    /// The previous closing price.
    /// </summary>
    [JsonPropertyName("previous_close")]
    public decimal PreviousClose { get; init; }

    /// <summary>
    /// The price change.
    /// </summary>
    [JsonPropertyName("change")]
    public decimal Change { get; init; }

    /// <summary>
    /// The percentage change.
    /// </summary>
    [JsonPropertyName("change_percent")]
    public decimal ChangePercent { get; init; }

    /// <summary>
    /// The quote price during extended hours trading.
    /// </summary>
    [JsonPropertyName("extended_hours_quote")]
    public decimal ExtendedHoursQuote { get; init; }

    /// <summary>
    /// The price change during extended hours trading.
    /// </summary>
    [JsonPropertyName("extended_hours_change")]
    public decimal ExtendedHoursChange { get; init; }

    /// <summary>
    /// The percentage change during extended hours trading.
    /// </summary>
    [JsonPropertyName("extended_hours_change_percent")]
    public decimal ExtendedHoursChangePercent { get; init; }
}
