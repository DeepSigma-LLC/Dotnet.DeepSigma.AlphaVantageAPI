using DeepSigma.AlphaVantageAPI.Models;
using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.APIs.Option.Models;

public sealed class AVPutToCallRatioResponse
{
    public string Symbol { get; set; } = "";
    public DateTime Date { get; set; }

    [JsonPropertyName("put_call_ratio_full_chain")]
    public decimal PutCallRatioFullChain { get; set; }

    [JsonPropertyName("put_call_ratio_by_expiration")]
    public List<AVValue> PutCallRatioByExpiration { get; set; } = [];

}
