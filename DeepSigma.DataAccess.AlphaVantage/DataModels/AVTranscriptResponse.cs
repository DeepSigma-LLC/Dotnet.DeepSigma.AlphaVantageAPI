using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVTranscriptResponse
    {
        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }
        [JsonPropertyName("quarter")]
        public string? Quarter { get; set; }
        [JsonPropertyName("transcript")]
        public List<AVTranscriptMessage> Transcript { get; set; } = [];

    }
}
