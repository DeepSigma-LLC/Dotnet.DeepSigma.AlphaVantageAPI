using CsvHelper;

namespace DeepSigma.AlphaVantageAPI.Models;

/// <summary>
/// The class represents IPO calendar data from Alpha Vantage in CSV format.
/// </summary>
[CsvRecord]
public partial class AVIpoCalandarCSVData
{
    /// <summary>
    /// The stock symbol of the IPO.
    /// </summary>
    [CsvColumn("symbol")]
    public string Symbol { get; init; } = String.Empty;

    /// <summary>
    /// The name of the company going public.
    /// </summary>
    [CsvColumn("name")]
    public string Name { get; init; } = String.Empty;

    /// <summary>
    /// The date of the IPO.
    /// </summary>
    [CsvColumn("ipoDate")]
    public DateTime? IpoDate { get; init; }

    /// <summary>
    /// The price range low for the IPO.
    /// </summary>
    [CsvColumn("priceRangeLow")]
    public decimal? PriceRangeLow { get; init; }

    /// <summary>
    /// The price range high for the IPO.
    /// </summary>
    [CsvColumn("priceRangeHigh")]
    public decimal? PriceRangeHigh { get; init; }

    /// <summary>
    /// The currency in which the IPO is priced.
    /// </summary>
    [CsvColumn("currency")]
    public string Currency { get; init; } = String.Empty;

    /// <summary>
    /// The exchange where the IPO is listed.
    /// </summary>
    [CsvColumn("exchange")]
    public string Exchange { get; init; } = String.Empty;
}
