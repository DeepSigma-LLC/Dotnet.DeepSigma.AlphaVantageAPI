
using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.APIs.Utilities.Models;

public sealed class AVCongressTradesResponse
{
    public string Symbol { get; set; } = string.Empty;

    [JsonPropertyName("bioguide_id")]
    public string BioguideId { get; set; } = string.Empty;

    public List<AVCongressTrade> Trades { get; set; } = [];

}
