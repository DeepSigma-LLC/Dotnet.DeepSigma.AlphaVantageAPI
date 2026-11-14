using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.APIs.Fundamentals.Models;

/// <summary>
/// The response model for the cash flow data from Alpha Vantage API.
/// </summary>
public class AVCashFlowResponse
{
    /// <summary>
    /// The stock symbol for which the cash flow data is provided.
    /// </summary>
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    /// <summary>
    /// The annual cash flow reports.
    /// </summary>
    [JsonPropertyName("annualReports")]
    public List<AVCashFlowData> AnnualReports { get; init; } = [];

    /// <summary>
    /// The quarterly cash flow reports.
    /// </summary>
    [JsonPropertyName("quarterlyReports")]
    public List<AVCashFlowData> QuarterlyReports { get; init; } = [];
}
