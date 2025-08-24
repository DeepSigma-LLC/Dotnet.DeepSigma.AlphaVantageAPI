using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    public class AVCurrencyExchangeRateData
    {
        [JsonPropertyName("1. From_Currency Code")]
        public string FromCurrencyCode { get; init; } = string.Empty;

        [JsonPropertyName("2. From_Currency Name")]
        public string FromCurrencyName { get; init; } = string.Empty;
                
        [JsonPropertyName("3. To_Currency Code")]
        public string ToCurrencyCode { get; init; } = string.Empty;
                    
        [JsonPropertyName("4. To_Currency Name")]
        public string ToCurrencyName { get; init; } = string.Empty;
                        
        [JsonPropertyName("5. Exchange Rate")]
        public decimal ExchangeRate { get; init; }
                        
        [JsonPropertyName("6. Last Refreshed")]
        public DateTime LastRefreshed { get; init; }
                            
        [JsonPropertyName("7. Time Zone")]
        public string TimeZone { get; init; } = string.Empty;
                            
        [JsonPropertyName("8. Bid Price")]
        public decimal BidPrice { get; init; }
                                
        [JsonPropertyName("9. Ask Price")]
        public decimal AskPrice { get; init; }
    }
}
