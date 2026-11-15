using DeepSigma.AlphaVantageAPI.Parsers;
using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.APIs.Stock.Models;

public sealed class AVBidAskPrice
{
    public string? Symbol { get; set; }

    [JsonConverter(typeof(CustomDateTimeConverter))]
    public DateTime Timestamp { get; set; }

    [JsonPropertyName("bid_price")]
    public decimal? BidPrice { get; set; }
    
    [JsonPropertyName("ask_price")]
    public decimal? AskPrice { get; set; }

    [JsonPropertyName("bid_size")]
    public long? BidSize { get; set; }

    [JsonPropertyName("ask_size")]
    public long? AskSize { get; set; }

}
