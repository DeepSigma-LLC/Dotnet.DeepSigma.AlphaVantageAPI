using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVEarningsEstimateResponse
    {
        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }
        [JsonPropertyName("estimates")]
        public List<AVEarningsEstimate> Estimates { get; set; } = [];
    }
}
