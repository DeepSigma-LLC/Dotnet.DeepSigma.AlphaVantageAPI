using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVEarningsAnnualData
    {
        [JsonPropertyName("fiscalDateEnding")]
        public DateOnly FiscalDateEnding { get; set; }
        [JsonPropertyName("reportedDate")]
        public DateOnly ReportedDate { get; set; }
        [JsonPropertyName("reportedEPS")]
        public decimal ReportedEPS { get; set; }
        [JsonPropertyName("estimatedEPS")]
        public decimal EstimatedEPS { get; set; }
        [JsonPropertyName("surprise")]
        public decimal Surprise { get; set; }
        [JsonPropertyName("surprisePercentage")]
        public decimal SurprisePercentage { get; set; }
        [JsonPropertyName("reportTime")]
        public string ReportTime { get; set; } = string.Empty;
    }
}
