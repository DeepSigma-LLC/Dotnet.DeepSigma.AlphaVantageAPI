using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeepSigma.DataAccess.API.AlphaVantage.DataModels
{
    public class AVCurrencyExchangeRateQuoteResponse
    {
        [JsonPropertyName("Realtime Currency Exchange Rate")]
        public AVCurrencyExchangeRateData Quote { get; init; } = new();
    }
}
