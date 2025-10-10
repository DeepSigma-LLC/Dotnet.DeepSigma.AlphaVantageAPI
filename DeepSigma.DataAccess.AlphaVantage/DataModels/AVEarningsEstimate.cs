using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.DataModels;

/// <summary>
/// The class represents earnings estimate data from the Alpha Vantage API.
/// </summary>
[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
public class AVEarningsEstimate
{
    /// <summary>
    /// The date of the earnings estimate.
    /// </summary>
    [JsonPropertyName("date")]
    public DateOnly Date { get; set; }

    /// <summary>
    /// The time horizon for the earnings time estimate.
    /// </summary>
    [JsonPropertyName("horizon")]
    public string Horizon { get; set; } = string.Empty;

    /// <summary>
    /// The average earnings per share (EPS) estimate.
    /// </summary>
    [JsonPropertyName("eps_estimate_average")]
    public decimal? EpsEstimateAverage { get; set; }

    /// <summary>
    /// The high earnings per share (EPS) estimate.
    /// </summary>
    [JsonPropertyName("eps_estimate_high")]
    public decimal? EpsEstimateHigh { get; set; }

    /// <summary>
    /// The low earnings per share (EPS) estimate.
    /// </summary>
    [JsonPropertyName("eps_estimate_low")]
    public decimal? EpsEstimateLow { get; set; }

    /// <summary>
    /// The number of analysts contributing to the EPS estimate.
    /// </summary>
    [JsonPropertyName("eps_estimate_analyst_count")]
    public decimal? EpsEstimateAnalystCount { get; set; }

    /// <summary>
    /// The average EPS estimate from 7 days ago.
    /// </summary>
    [JsonPropertyName("eps_estimate_average_7_days_ago")]
    public decimal? EpsEstimateAverage7DaysAgo { get; set; }

    /// <summary>
    /// The average EPS estimate from 30 days ago.
    /// </summary>
    [JsonPropertyName("eps_estimate_average_30_days_ago")]
    public decimal? EpsEstimateAverage30DaysAgo { get; set; }

    /// <summary>
    /// The average EPS estimate from 60 days ago.
    /// </summary>
    [JsonPropertyName("eps_estimate_average_60_days_ago")]
    public decimal? EpsEstimateAverage60DaysAgo { get; set; }

    /// <summary>
    /// The average EPS estimate from 90 days ago.
    /// </summary>
    [JsonPropertyName("eps_estimate_average_90_days_ago")]
    public decimal? EpsEstimateAverage90DaysAgo { get; set; }

    /// <summary>
    /// The number of analysts contributing to the EPS estimate from 7 days ago.
    /// </summary>
    [JsonPropertyName("eps_estimate_revision_up_trailing_7_days")]
    public decimal? EpsEstimateRevisionUpTrailing7Days { get; set; }

    /// <summary>
    /// The number of analysts contributing to the EPS estimate from 7 days ago.
    /// </summary>
    [JsonPropertyName("eps_estimate_revision_down_trailing_7_days")]
    public decimal? EpsEstimateRevisionDownTrailing7Days { get; set; }

    /// <summary>
    /// The number of analysts contributing to the EPS estimate from 30 days ago.
    /// </summary>
    [JsonPropertyName("eps_estimate_revision_up_trailing_30_days")]
    public decimal? EpsEstimateRevisionUpTrailing30Days { get; set; }

    /// <summary>
    /// The number of analysts contributing to the EPS estimate from 30 days ago.
    /// </summary>
    [JsonPropertyName("eps_estimate_revision_down_trailing_30_days")]
    public decimal? EpsEstimateRevisionDownTrailing30Days { get; set; }

    /// <summary>
    /// The number of analysts contributing to the EPS estimate from 60 days ago.
    /// </summary>
    [JsonPropertyName("revenue_estimate_average")]
    public decimal? RevenueEstimateAverage { get; set; }

    /// <summary>
    /// The high revenue estimate.
    /// </summary>
    [JsonPropertyName("revenue_estimate_high")]
    public decimal? RevenueEstimateHigh { get; set; }

    /// <summary>
    /// The low revenue estimate.
    /// </summary>
    [JsonPropertyName("revenue_estimate_low")]
    public decimal? RevenueEstimateLow { get; set; }

    /// <summary>
    /// The number of analysts contributing to the revenue estimate.
    /// </summary>
    [JsonPropertyName("revenue_estimate_analyst_count")]
    public decimal? RevenueEstimateAnalystCount { get; set; }
}
