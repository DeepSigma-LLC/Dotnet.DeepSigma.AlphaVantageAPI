using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVETFProfileHoldingWeight
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; init; } = string.Empty;
        [JsonPropertyName("description")]
        public string Description { get; init; } = string.Empty;
        [JsonPropertyName("weight")]
        public decimal Weight { get; init; }
    }
}
