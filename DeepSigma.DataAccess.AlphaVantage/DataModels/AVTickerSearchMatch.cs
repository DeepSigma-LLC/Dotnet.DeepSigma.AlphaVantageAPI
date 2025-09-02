
using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.DataModels
{
    /// <summary>
    /// Represents a single match result from the Alpha Vantage ticker search API.
    /// </summary>
    public class AVTickerSearchMatch
    {
        /// <summary>
        /// The stock symbol of the matched ticker.
        /// </summary>
        [JsonPropertyName("1. symbol")]
        public string Symbol { get; init; } = string.Empty;

        /// <summary>
        /// The name of the company or asset associated with the ticker.
        /// </summary>
        [JsonPropertyName("2. name")]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// The type of the asset (e.g., equity, ETF, mutual fund).
        /// </summary>
        [JsonPropertyName("3. type")]
        public string Type { get; init; } = string.Empty;

        /// <summary>
        /// The region or market where the asset is traded.
        /// </summary>
        [JsonPropertyName("4. region")]
        public string Region { get; init; } = string.Empty;

        /// <summary>
        /// The market open time for the asset.
        /// </summary>
        [JsonPropertyName("5. marketOpen")]
        public string MarketOpen { get; init; } = string.Empty;

        /// <summary>
        ///  The market close time for the asset.
        /// </summary>
        [JsonPropertyName("6. marketClose")]
        public string MarketClose { get; init; } = string.Empty;

        /// <summary>
        /// The timezone of the market where the asset is traded.
        /// </summary>
        [JsonPropertyName("7. timezone")]
        public string Timezone { get; init; } = string.Empty;

        /// <summary>
        /// The currency in which the asset is traded.
        /// </summary>
        [JsonPropertyName("8. currency")]
        public string Currency { get; init; } = string.Empty;

        /// <summary>
        /// The match score indicating the relevance of the match (higher is better).
        /// </summary>
        [JsonPropertyName("9. matchScore")]
        public decimal? MatchScore { get; init; } 
    }
}
