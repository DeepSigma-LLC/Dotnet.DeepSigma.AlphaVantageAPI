using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.DataModels
{
    /// <summary>
    /// The class represents option data from the Alpha Vantage API.
    /// </summary>
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVOptionData
    {
        /// <summary>
        /// The unique identifier for the option contract.
        /// </summary>
        [JsonPropertyName("contractID")]
        public string ContractID { get; init; } = string.Empty;

        /// <summary>
        /// The underlying stock symbol for the option.
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; init; } = string.Empty;

        /// <summary>
        /// The expiration date of the option contract.
        /// </summary>
        [JsonPropertyName("expiration")]
        public DateOnly Expiration { get; init; }

        /// <summary>
        /// The strike price of the option contract.
        /// </summary>
        [JsonPropertyName("strike")]
        public decimal Strike { get; init; }

        /// <summary>
        /// The type of the option contract (e.g., call or put).
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; init; } = string.Empty;

        /// <summary>
        /// The last traded price of the option contract.
        /// </summary>
        [JsonPropertyName("last")]
        public decimal Last { get; init; }

        /// <summary>
        /// The size of the last trade.
        /// </summary>
        [JsonPropertyName("mark")]
        public decimal Mark { get; init; }

        /// <summary>
        /// The bid price of the option contract.
        /// </summary>
        [JsonPropertyName("bid")]
        public decimal Bid { get; init; }

        /// <summary>
        /// The size of the bid.
        /// </summary>
        [JsonPropertyName("bid_size")]
        public long BidSize { get; init; }

        /// <summary>
        /// The ask price of the option contract.
        /// </summary>
        [JsonPropertyName("ask")]
        public decimal Ask { get; init; }

        /// <summary>
        /// The size of the ask.
        /// </summary>
        [JsonPropertyName("ask_size")]
        public long AskSize { get; init; }

        /// <summary>
        /// The volume of the option contract traded.
        /// </summary>
        [JsonPropertyName("volume")]
        public long Volume { get; init; }

        /// <summary>
        /// The open interest of the option contract.
        /// </summary>
        [JsonPropertyName("open_interest")]
        public long OpenInterest { get; init; }

        /// <summary>
        /// The date for which the historical option data is relevant.
        /// </summary>
        [JsonPropertyName("date")]
        public DateOnly Date { get; init; }

        /// <summary>
        /// The implied volatility of the option contract.
        /// </summary>
        [JsonPropertyName("implied_volatility")]
        public decimal ImpliedVolatility { get; init; }

        /// <summary>
        /// The delta Greek of the option contract.
        /// </summary>
        [JsonPropertyName("delta")]
        public decimal Delta { get; init; }

        /// <summary>
        /// The gamma Greek of the option contract.
        /// </summary>
        [JsonPropertyName("gamma")]
        public decimal Gamma { get; init; }

        /// <summary>
        /// The theta Greek of the option contract.
        /// </summary>
        [JsonPropertyName("theta")]
        public decimal Theta { get; init; }

        /// <summary>
        /// The vega Greek of the option contract.
        /// </summary>
        [JsonPropertyName("vega")]
        public decimal Vega { get; init; }

        /// <summary>
        /// The rho Greek of the option contract.
        /// </summary>
        [JsonPropertyName("rho")]
        public decimal Rho { get; init; }
    }
}
