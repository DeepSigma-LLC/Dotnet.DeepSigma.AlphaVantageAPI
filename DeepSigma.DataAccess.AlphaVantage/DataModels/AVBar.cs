
namespace DeepSigma.AlphaVantageAPI.DataModels;

/// <summary>
/// Data model representing a single bar of market data (OHLCV) from Alpha Vantage API.
/// </summary>
public class AVBar : AVGenericObject
{
    /// <summary>
    /// The open price.
    /// </summary>
    public decimal? Open { get; init; }
    /// <summary>
    /// The high price.
    /// </summary>
    public decimal? High { get; init; }
    /// <summary>
    /// The low price.
    /// </summary>
    public decimal? Low { get; init; }
    /// <summary>
    /// The close price.
    /// </summary>
    public decimal? Close { get; init; }
    /// <summary>
    /// Adjusted close price, accounting for dividends and splits.
    /// </summary>
    public decimal? AdjustedClose { get; init; }
    /// <summary>
    /// The dividend amount.
    /// </summary>
    public decimal? DividendAmount { get; init; }
    /// <summary>
    /// The split coefficient.
    /// </summary>
    public decimal? SplitCoefficient { get; init; }
    /// <summary>
    /// The trading volume.
    /// </summary>
    public decimal? Volume { get; init; }
}
