using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVETFProfileSectorWeight
    {
        [JsonPropertyName("sector")]
        public string Sector { get; set; } = string.Empty;
        [JsonPropertyName("weight")]
        public decimal Weight { get; set; }
    }
}
