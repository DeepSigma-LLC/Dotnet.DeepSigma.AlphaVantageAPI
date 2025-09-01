using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
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
        public string LastRefreshed { get; init; } // Marked as string since System.Text.Json only parses ISO-8601 by default

        [JsonPropertyName("7. Time Zone")]
        public string TimeZone { get; init; } = string.Empty;
                            
        [JsonPropertyName("8. Bid Price")]
        public decimal BidPrice { get; init; }
                                
        [JsonPropertyName("9. Ask Price")]
        public decimal AskPrice { get; init; }
    }
}
