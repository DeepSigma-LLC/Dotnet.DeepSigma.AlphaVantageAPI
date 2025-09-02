using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVEarningsEstimate
    {
        [JsonPropertyName("date")]
        public DateOnly Date { get; set; }
        [JsonPropertyName("horizon")]
        public string Horizon { get; set; } = string.Empty;
        [JsonPropertyName("eps_estimate_average")]
        public decimal? EpsEstimateAverage { get; set; }
        [JsonPropertyName("eps_estimate_high")]
        public decimal? EpsEstimateHigh { get; set; }
        [JsonPropertyName("eps_estimate_low")]
        public decimal? EpsEstimateLow { get; set; }
        [JsonPropertyName("eps_estimate_analyst_count")]
        public decimal? EpsEstimateAnalystCount { get; set; }
        [JsonPropertyName("eps_estimate_average_7_days_ago")]
        public decimal? EpsEstimateAverage7DaysAgo { get; set; }
        [JsonPropertyName("eps_estimate_average_30_days_ago")]
        public decimal? EpsEstimateAverage30DaysAgo { get; set; }
        [JsonPropertyName("eps_estimate_average_60_days_ago")]
        public decimal? EpsEstimateAverage60DaysAgo { get; set; }
        [JsonPropertyName("eps_estimate_average_90_days_ago")]
        public decimal? EpsEstimateAverage90DaysAgo { get; set; }
        [JsonPropertyName("eps_estimate_revision_up_trailing_7_days")]
        public decimal? EpsEstimateRevisionUpTrailing7Days { get; set; }
        [JsonPropertyName("eps_estimate_revision_down_trailing_7_days")]
        public decimal? EpsEstimateRevisionDownTrailing7Days { get; set; }
        [JsonPropertyName("eps_estimate_revision_up_trailing_30_days")]
        public decimal? EpsEstimateRevisionUpTrailing30Days { get; set; }
        [JsonPropertyName("eps_estimate_revision_down_trailing_30_days")]
        public decimal? EpsEstimateRevisionDownTrailing30Days { get; set; }
        [JsonPropertyName("revenue_estimate_average")]
        public decimal? RevenueEstimateAverage { get; set; }
        [JsonPropertyName("revenue_estimate_high")]
        public decimal? RevenueEstimateHigh { get; set; }
        [JsonPropertyName("revenue_estimate_low")]
        public decimal? RevenueEstimateLow { get; set; }
        [JsonPropertyName("revenue_estimate_analyst_count")]
        public decimal? RevenueEstimateAnalystCount { get; set; }
    }
}
