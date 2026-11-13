using CsvHelper;

namespace DeepSigma.AlphaVantageAPI.DataModels;

/// <summary>
/// The class represents the earnings calendar data retrieved from Alpha Vantage in CSV format.
/// </summary>
[CsvRecord]
public partial class AVEarningsCalandarCSVData
{
    /// <summary>
    /// The stock symbol.
    /// </summary>
    [CsvColumn("symbol")]
    public string Symbol { get; init; } = string.Empty;

    /// <summary>
    /// The name of the company.
    /// </summary>
    [CsvColumn("name")]
        public string Name { get; init; } = string.Empty;

    /// <summary>
    /// The date the earnings report is scheduled.
    /// </summary>
    [CsvColumn("reportDate")]
    public DateTime? ReportDate { get; init; }

    /// <summary>
    /// The fiscal date ending for the earnings report.
    /// </summary>
    [CsvColumn("fiscalDateEnding")]
    public DateTime? FiscalDateEnding { get; init; }

    /// <summary>
    /// The estimated earnings per share (EPS).
    /// </summary>
    [CsvColumn("estimate")]
    public decimal? Estimate { get; init; }

    /// <summary>
    /// The currency of the earnings report.
    /// </summary>
    [CsvColumn("currency")]
    public string Currency { get; init; } = string.Empty;
}
