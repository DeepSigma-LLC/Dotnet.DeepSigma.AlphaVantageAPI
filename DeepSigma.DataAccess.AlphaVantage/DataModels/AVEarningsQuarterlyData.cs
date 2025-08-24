using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVEarningsQuarterlyData
    {
        [JsonPropertyName("fiscalDateEnding")]
        public DateOnly FiscalDateEnding { get; set; }
        [JsonPropertyName("reportedEPS")]
        public decimal ReportedEPS { get; set; }
    }
}
