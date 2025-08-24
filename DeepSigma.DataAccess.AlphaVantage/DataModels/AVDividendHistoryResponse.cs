using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVDividendHistoryResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;

        [JsonPropertyName("dividend_history")]
        public List<AVDividendRecord> DividendHistory { get; set; } = [];
    }
}
