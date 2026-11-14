using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.APIs.Fundamentals.Models;

/// <summary>
/// The class represents the response from the Alpha Vantage API for income statements.
/// </summary>
public class AVIncomeStatementResponse
{
    /// <summary>
    /// The stock symbol for which the income statement data is provided.
    /// </summary>
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    /// <summary>
    /// A list of annual income statement reports.
    /// </summary>
    [JsonPropertyName("annualReports")]
    public List<AVIncomeStatementData> AnnualReports { get; init; } = [];

    /// <summary>
    /// A list of quarterly income statement reports.
    /// </summary>
    [JsonPropertyName("quarterlyReports")]
    public List<AVIncomeStatementData> QuarterlyReports { get; init; } = [];
}
