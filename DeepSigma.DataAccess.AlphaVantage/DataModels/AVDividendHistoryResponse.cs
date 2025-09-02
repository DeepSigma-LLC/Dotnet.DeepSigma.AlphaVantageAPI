using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.DataModels
{
    /// <summary>
    /// The class represents dividend history data from the Alpha Vantage API.
    /// </summary>
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVDividendHistoryResponse
    {
        /// <summary>
        /// The stock symbol for which the dividend history is provided.
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;

        /// <summary>
        /// The dividend history data.
        /// </summary>
        [JsonPropertyName("data")]
        public List<AVDividendRecord> DividendHistory { get; set; } = [];
    }
}
