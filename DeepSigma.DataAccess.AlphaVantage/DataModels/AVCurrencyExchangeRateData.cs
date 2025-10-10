using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.DataModels;

/// <summary>
/// Represents exchange rate data for a currency pair, including details such as currency codes, names,  exchange
/// rate, and additional metadata.
/// </summary>
/// <remarks>This class is typically used to deserialize JSON data from a currency exchange rate API.  It
/// provides information about the source and target currencies, the current exchange rate,  and other related
/// details such as bid/ask prices and the last refreshed timestamp.</remarks>
[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
public class AVCurrencyExchangeRateData
{
    /// <summary>
    /// The currency code of the source currency (e.g., "USD").
    /// </summary>
    [JsonPropertyName("1. From_Currency Code")]
    public string FromCurrencyCode { get; init; } = string.Empty;

    /// <summary>
    /// The name of the source currency (e.g., "United States Dollar").
    /// </summary>
    [JsonPropertyName("2. From_Currency Name")]
    public string FromCurrencyName { get; init; } = string.Empty;

    /// <summary>
    /// The currency code of the target currency (e.g., "EUR").
    /// </summary>    
    [JsonPropertyName("3. To_Currency Code")]
    public string ToCurrencyCode { get; init; } = string.Empty;

    /// <summary>
    /// The name of the target currency (e.g., "Euro").
    /// </summary>
    [JsonPropertyName("4. To_Currency Name")]
    public string ToCurrencyName { get; init; } = string.Empty;

    /// <summary>
    /// The current exchange rate from the source currency to the target currency.
    /// </summary>
    [JsonPropertyName("5. Exchange Rate")]
    public decimal ExchangeRate { get; init; }

    /// <summary>
    /// The timestamp of the last refresh of the exchange rate data.
    /// Marked as string since System.Text.Json only parses ISO-8601 by default
    /// </summary>
    [JsonPropertyName("6. Last Refreshed")]
    public string LastRefreshed { get; init; } = string.Empty;

    /// <summary>
    /// The time zone of the exchange rate data (e.g., "UTC").
    /// </summary>
    [JsonPropertyName("7. Time Zone")]
    public string TimeZone { get; init; } = string.Empty;

    /// <summary>
    /// The bid price for the currency pair.
    /// </summary>
    [JsonPropertyName("8. Bid Price")]
    public decimal BidPrice { get; init; }

    /// <summary>
    /// The ask price for the currency pair.
    /// </summary>
    [JsonPropertyName("9. Ask Price")]
    public decimal AskPrice { get; init; }
}
