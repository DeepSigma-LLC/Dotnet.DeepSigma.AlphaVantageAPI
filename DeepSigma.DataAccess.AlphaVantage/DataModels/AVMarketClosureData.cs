using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    public class AVMarketClosureData
    {
        [JsonPropertyName("market_type")]
        public string MarketType { get; init; } = string.Empty;
        [JsonPropertyName("region")]
        public string Region { get; init; } = string.Empty;
        [JsonPropertyName("primary_exchanges")]
        public string PrimaryExchanges { get; init; } = string.Empty;
        [JsonPropertyName("local_open")]
        public string LocalOpen { get; init; } = string.Empty;
        [JsonPropertyName("local_close")]
        public string LocalClose { get; init; } = string.Empty;

        [JsonPropertyName("current_status")]
        public string CurrentStatus { get; init; } = string.Empty;
        [JsonPropertyName("notes")]
        public string Notes { get; init; } = string.Empty;
    }
}
