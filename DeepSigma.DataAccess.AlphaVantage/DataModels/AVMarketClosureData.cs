
using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.DataModels
{
    /// <summary>
    /// The class represents market closure data from the Alpha Vantage API.
    /// </summary>
    public class AVMarketClosureData
    {
        /// <summary>
        /// The market type (e.g., stock, forex, crypto).
        /// </summary>
        [JsonPropertyName("market_type")]
        public string MarketType { get; init; } = string.Empty;

        /// <summary>
        /// The region where the market is located.
        /// </summary>
        [JsonPropertyName("region")]
        public string Region { get; init; } = string.Empty;

        /// <summary>
        /// The primary exchanges associated with the market.
        /// </summary>
        [JsonPropertyName("primary_exchanges")]
        public string PrimaryExchanges { get; init; } = string.Empty;

        /// <summary>
        /// The date time of the market open.
        /// </summary>
        [JsonPropertyName("local_open")]
        public string LocalOpen { get; init; } = string.Empty;

        /// <summary>
        /// The date time of the market close.
        /// </summary>
        [JsonPropertyName("local_close")]
        public string LocalClose { get; init; } = string.Empty;

        /// <summary>
        /// The current status of the market (e.g., open, closed).
        /// </summary>
        [JsonPropertyName("current_status")]
        public string CurrentStatus { get; init; } = string.Empty;

        /// <summary>
        /// The notes regarding the market closure.
        /// </summary>
        [JsonPropertyName("notes")]
        public string Notes { get; init; } = string.Empty;
    }
}
