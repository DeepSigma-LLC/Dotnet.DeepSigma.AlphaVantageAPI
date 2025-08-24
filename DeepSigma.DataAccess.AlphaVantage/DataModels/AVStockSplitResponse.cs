using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVStockSplitResponse
    {
       [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }
        [JsonPropertyName("data")]
        public List<AVStockSplitRecord> Data { get; set; } = [];
    }
}
