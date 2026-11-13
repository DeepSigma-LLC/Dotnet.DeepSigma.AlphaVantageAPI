using CsvHelper;

namespace DeepSigma.AlphaVantageAPI.DataModels;

/// <summary>
/// Data model for OHLC (Open, High, Low, Close) data from Alpha Vantage CSV output.
/// </summary>
[CsvRecord]
public partial class AlphaVantageCsvOHLC
{
    /// <summary>
    /// The timestamp of the OHLC data point.
    /// </summary>
    [CsvColumn("timestamp")]
    public DateTime Timestamp { get; init; }

    /// <summary>
    /// The opening price.
    /// </summary>
    [CsvColumn("open")]
    public decimal Open { get; init; }

    /// <summary>
    /// The highest price.
    /// </summary>
    [CsvColumn("high")]
    public decimal High { get; init; }

    /// <summary>
    /// The lowest price.
    /// </summary>
    [CsvColumn("low")]
    public decimal Low { get; init; }
    /// <summary>
    /// The closing price.
    /// </summary>
    [CsvColumn("close")]
    public decimal Close { get; init;}
    /// <summary>
    /// The trading volume.
    /// </summary>
    [CsvColumn("volume")]
    public long Volume { get; init; }
}
