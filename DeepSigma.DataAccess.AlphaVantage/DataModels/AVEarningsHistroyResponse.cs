using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVEarningsHistroyResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        [JsonPropertyName("annualEarnings")]
        public List<AVEarningsAnnualData>? AnnualEarnings { get; set; }
        [JsonPropertyName("quarterlyEarnings")]
        public List<AVEarningsQuarterlyData>? QuarterlyEarnings { get; set; }
    }
}
