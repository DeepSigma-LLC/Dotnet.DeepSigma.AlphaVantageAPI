using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.APIs.Utilities.Models;

public sealed class AVPoliticalTerm
{

    public string? Chamber { get; set; }

    public string? State { get; set; }

    public string? District { get; set; }

    [JsonPropertyName("start_date")]
    public DateTime? StartDate { get; set; }

    [JsonPropertyName("end_date")]
    public DateTime? EndDate { get; set; }
}