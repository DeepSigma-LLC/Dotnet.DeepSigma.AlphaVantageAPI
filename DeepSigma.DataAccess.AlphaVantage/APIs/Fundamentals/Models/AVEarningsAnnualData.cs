using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.APIs.Fundamentals.Models;

/// <summary>
/// The class represents annual earnings data from the Alpha Vantage API.
/// </summary>
[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
public class AVEarningsAnnualData
{
    /// <summary>
    /// The fiscal date ending for the earnings report.
    /// </summary>
    [JsonPropertyName("fiscalDateEnding")]
    public DateOnly FiscalDateEnding { get; set; }

    /// <summary>
    /// The date the earnings were reported.
    /// </summary>
    [JsonPropertyName("reportedDate")]
    public DateOnly ReportedDate { get; set; }

    /// <summary>
    /// The reported earnings per share (EPS).
    /// </summary>
    [JsonPropertyName("reportedEPS")]
    public decimal ReportedEPS { get; set; }

    /// <summary>
    /// The estimated earnings per share (EPS).
    /// </summary>
    [JsonPropertyName("estimatedEPS")]
    public decimal EstimatedEPS { get; set; }

    /// <summary>
    /// The surprise amount in earnings per share (EPS).
    /// </summary>
    [JsonPropertyName("surprise")]
    public decimal Surprise { get; set; }

    /// <summary>
    /// The surprise percentage in earnings per share (EPS).
    /// </summary>
    [JsonPropertyName("surprisePercentage")]
    public decimal SurprisePercentage { get; set; }

    /// <summary>
    /// The time the earnings report was released.
    /// </summary>
    [JsonPropertyName("reportTime")]
    public string ReportTime { get; set; } = string.Empty;
}
