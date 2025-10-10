
namespace DeepSigma.AlphaVantageAPI.DataModels;

/// <summary>
/// Metadata information for Alpha Vantage API responses.
/// </summary>
public sealed class AVMetaData : AVGenericObject
{
    /// <summary>
    /// The type of information provided in the metadata.
    /// </summary>
    public string Information { get; init; } = "";

    /// <summary>
    /// The stock ticker symbol.
    /// </summary>
    public string Symbol { get; init; } = "";

    /// <summary>
    /// The symbol of the currency or asset being converted from.
    /// </summary>
    public string FromSymbol { get; init; } = "";

    /// <summary>
    /// The symbol of the currency or asset being converted to.
    /// </summary>
    public string ToSymbol { get; init; } = "";

    /// <summary>
    /// The last refreshed timestamp of the data.
    /// As string, because formats vary (date only, date time with seconds, date time with minutes)
    /// </summary>
    public string LastRefreshed { get; init; } = "";

    /// <summary>
    /// The interval of the data (e.g., daily, weekly, monthly).
    /// </summary>
    public string Interval { get; init; } = "";

    /// <summary>
    /// The output size of the data (e.g., compact, full).
    /// </summary>
    public string OutputSize { get; init; } = "";

    /// <summary>
    /// The time zone of the data.
    /// </summary>
    public string TimeZone { get; init; } = "";

    /// <summary>
    /// The code of the digital currency (e.g., BTC, ETH).
    /// </summary>
    public string DigitalCurrencyCode { get; init; } = "";

    /// <summary>
    /// The name of the digital currency (e.g., Bitcoin, Ethereum).
    /// </summary>
    public string DigitalCurrencyName { get; init; } = "";

    /// <summary>
    /// The market code where the asset is traded.
    /// </summary>
    public string MarketCode { get; init; } = "";

    /// <summary>
    /// The market name where the asset is traded.
    /// </summary>
    public string MarketName { get; init; } = "";

  
}
