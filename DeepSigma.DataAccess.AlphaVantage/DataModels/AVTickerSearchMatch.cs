using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    /// <summary>
    /// Represents a single match result from the Alpha Vantage ticker search API.
    /// </summary>
    public class AVTickerSearchMatch
    {
        [JsonPropertyName("1. symbol")]
        public string Symbol { get; init; } = string.Empty;
        [JsonPropertyName("2. name")]
        public string Name { get; init; } = string.Empty;
        [JsonPropertyName("3. type")]
        public string Type { get; init; } = string.Empty;
        [JsonPropertyName("4. region")]
        public string Region { get; init; } = string.Empty;
        [JsonPropertyName("5. marketOpen")]
        public string MarketOpen { get; init; } = string.Empty;
        [JsonPropertyName("6. marketClose")]
        public string MarketClose { get; init; } = string.Empty;

        [JsonPropertyName("7. timezone")]
        public string Timezone { get; init; } = string.Empty;
        [JsonPropertyName("8. currency")]
        public string Currency { get; init; } = string.Empty;
        [JsonPropertyName("9. matchScore")]
        public decimal? MatchScore { get; init; } 
    }
}
