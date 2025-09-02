using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    public class AVMoverResponse
    {
        [JsonPropertyName("metadata")]
        public string Metadata { get; init; } = string.Empty;

        [JsonPropertyName("last_updated")]
        public string LastUpdated { get; init; } = string.Empty;

        [JsonPropertyName("top_gainers")]
        public List<AVMoverData> TopGainers { get; init; } = [];

        [JsonPropertyName("top_losers")]
        public List<AVMoverData> TopLosers { get; init; } = [];

        [JsonPropertyName("most_actively_traded")]
        public List<AVMoverData> MostActivelyTraded { get; init; } = [];
    }
}
