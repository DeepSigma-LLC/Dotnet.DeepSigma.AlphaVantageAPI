using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    public class AVCurrencyExchangeRateQuoteResponse
    {
        [JsonPropertyName("Realtime Currency Exchange Rate")]
        public AVCurrencyExchangeRateData Quote { get; init; } = new();
    }
}
