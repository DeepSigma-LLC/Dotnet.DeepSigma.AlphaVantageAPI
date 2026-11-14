using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.APIs.Fundamentals.Models;

/// <summary>
/// The class represents a transcript response from the Alpha Vantage API.
/// </summary>
[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
public class AVTranscriptResponse
{
    /// <summary>
    /// The stock symbol for which the transcript is provided.
    /// </summary>
    [JsonPropertyName("symbol")]
    public string? Symbol { get; set; }

    /// <summary>
    /// The quarter for which the transcript is provided.
    /// </summary>
    [JsonPropertyName("quarter")]
    public string? Quarter { get; set; }

    /// <summary>
    /// The transcript messages.
    /// </summary>
    [JsonPropertyName("transcript")]
    public List<AVTranscriptMessage> Transcript { get; set; } = [];

}
