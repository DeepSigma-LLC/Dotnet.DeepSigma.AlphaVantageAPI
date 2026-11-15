using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.APIs.Utilities.Models;

public class AVPolitician
{
    [JsonPropertyName("bioguide_id")]
    public string? BioguideId { get; set; } 

    [JsonPropertyName("display_name")]
    public string? DisplayName { get; set; }

    public List<string> Aliases { get; set; } = [];

    public string? Chamber { get; set; }

    public string? State { get; set; }

    public string? District { get; set; }

    public string? Party { get; set; }

    [JsonPropertyName("terms")]
    public List<AVPoliticalTerm> Terms { get; set; } = [];

}