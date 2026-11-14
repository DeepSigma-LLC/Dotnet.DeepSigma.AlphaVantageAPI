using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.Models;

/// <summary>
///  The generic data request model for Alpha Vantage API responses.
/// </summary>
/// <typeparam name="T"></typeparam>
public class AVDataRequest<T>
{
    /// <summary>
    /// The 
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The interval of the data (e.g., daily, weekly, monthly).
    /// </summary>
    [JsonPropertyName("interval")]
    public string Interval { get; set; } = string.Empty;

    /// <summary>
    /// The unit of the data (e.g., minutes, days).
    /// </summary>
    [JsonPropertyName("unit")]
    public string Unit { get; set; } = string.Empty;

    /// <summary>
    /// The API endpoint that was called.
    /// </summary>
    [JsonPropertyName("endpoint")]
    public string Endpoint { get; init; } = string.Empty;

    /// <summary>
    /// The message returned by the API, if any.
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; init; } = string.Empty;

    /// <summary>
    /// The data returned by the API, as a list of type T.
    /// </summary>
    [JsonPropertyName("data")]
    public List<T> Data { get; set; } = [];
}
