using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    /// <summary>
    /// Response model for currency exchange rate quote from Alpha Vantage API.
    /// </summary>
    public class AVCurrencyExchangeRateQuoteResponse
    {
        /// <summary>
        /// The currency exchange rate data.
        /// </summary>
        [JsonPropertyName("Realtime Currency Exchange Rate")]
        public AVCurrencyExchangeRateData Quote { get; init; } = new();
    }
}
