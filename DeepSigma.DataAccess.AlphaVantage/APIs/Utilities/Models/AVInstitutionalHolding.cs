using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.APIs.Utilities.Models;

public sealed class AVInstitutionalHolding
{

    [JsonPropertyName("holder_name")]
    public string HolderName { get; set; } = string.Empty;

    [JsonPropertyName("shares_held")]
    public long? SharesHeld { get; set; }

    [JsonPropertyName("shares_changed")]
    public long? SharesChanged { get; set; }

    [JsonPropertyName("shares_changed_percentage")]
    public string SharesChangedPercentage { get; set; } = string.Empty;

    [JsonPropertyName("change_type")]
    public string ChangeType { get; set; } = string.Empty;

    [JsonPropertyName("last_reported")]
    public DateTime? LastReported { get; set; }

}