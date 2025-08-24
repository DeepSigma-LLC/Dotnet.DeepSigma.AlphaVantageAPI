using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeepSigma.DataAccess.API.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVOptionData
    {
        [JsonPropertyName("contractID")]
        public string ContractID { get; init; } = string.Empty;
        [JsonPropertyName("symbol")]
        public string Symbol { get; init; } = string.Empty;
        [JsonPropertyName("expiration")]
        public DateOnly Expiration { get; init; }
        [JsonPropertyName("strike")]
        public decimal Strike { get; init; }
        [JsonPropertyName("type")]
        public string Type { get; init; } = string.Empty; 
        [JsonPropertyName("last")]
        public decimal Last { get; init; }
        [JsonPropertyName("mark")]
        public decimal Mark { get; init; }
        
        [JsonPropertyName("bid")]
        public decimal Bid { get; init; }
        [JsonPropertyName("bid_size")]
        public long BidSize { get; init; }
        [JsonPropertyName("ask")]
        public decimal Ask { get; init; }
        [JsonPropertyName("ask_size")]
        public long AskSize { get; init; }
        [JsonPropertyName("volume")]
        public long Volume { get; init; }
        [JsonPropertyName("open_interest")]
        public long OpenInterest { get; init; }
        [JsonPropertyName("date")]
        public DateOnly Date { get; init; }
        [JsonPropertyName("implied_volatility")]
        public decimal ImpliedVolatility { get; init; }
        [JsonPropertyName("delta")]
        public decimal Delta { get; init; }
        [JsonPropertyName("gamma")]
        public decimal Gamma { get; init; }
        [JsonPropertyName("theta")]
        public decimal Theta { get; init; }
        [JsonPropertyName("vega")]
        public decimal Vega { get; init; }
        [JsonPropertyName("rho")]
        public decimal Rho { get; init; }
    }
}
