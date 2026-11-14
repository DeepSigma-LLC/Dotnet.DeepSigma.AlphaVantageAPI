using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.APIs.Fundamentals.Models;

/// <summary>
/// The class represents quarterly earnings data from the Alpha Vantage API.
/// </summary>
[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
public class AVEarningsQuarterlyData
{
    /// <summary>
    /// The fiscal date ending for the earnings report.
    /// </summary>
    [JsonPropertyName("fiscalDateEnding")]
    public DateOnly FiscalDateEnding { get; set; }

    /// <summary>
    /// The reported earnings per share (EPS).
    /// </summary>
    [JsonPropertyName("reportedEPS")]
    public decimal ReportedEPS { get; set; }
}
