using CsvHelper.Configuration.Attributes;

namespace DeepSigma.AlphaVantageAPI.DataModels;

/// <summary>
/// The class represents the earnings calendar data retrieved from Alpha Vantage in CSV format.
/// </summary>
public class AVEarningsCalandarCSVData
{
    /// <summary>
    /// The stock symbol.
    /// </summary>
    [Name("symbol")]
    public string Symbol { get; init; } = string.Empty;

    /// <summary>
    /// The name of the company.
    /// </summary>
    [Name("name")]
        public string Name { get; init; } = string.Empty;

    /// <summary>
    /// The date the earnings report is scheduled.
    /// </summary>
    [Name("reportDate")]
    public DateTime? ReportDate { get; init; }

    /// <summary>
    /// The fiscal date ending for the earnings report.
    /// </summary>
    [Name("fiscalDateEnding")]
    public DateTime? FiscalDateEnding { get; init; }

    /// <summary>
    /// The estimated earnings per share (EPS).
    /// </summary>
    [Name("estimate")]
    public decimal? Estimate { get; init; }

    /// <summary>
    /// The currency of the earnings report.
    /// </summary>
    [Name("currency")]
    public string Currency { get; init; } = string.Empty;
}
