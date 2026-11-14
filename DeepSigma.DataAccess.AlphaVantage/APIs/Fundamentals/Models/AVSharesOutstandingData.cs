using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.APIs.Fundamentals.Models;

public class AVSharesOutstandingData
{
    public DateTime Date { get; set; }

    [JsonPropertyName("shares_outstanding_basic")]
    public decimal SharesOutstanding { get; set; }

    [JsonPropertyName("shares_outstanding_diluted")]
    public decimal SharesOutstandingDiluted { get; set; }
}