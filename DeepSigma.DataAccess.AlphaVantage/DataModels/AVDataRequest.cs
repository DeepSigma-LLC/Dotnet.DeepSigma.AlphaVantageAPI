using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    public class AVDataRequest<T>
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("interval")]
        public string Interval { get; set; } = string.Empty;
        
        [JsonPropertyName("unit")]
        public string Unit { get; set; } = string.Empty;

        [JsonPropertyName("endpoint")]
        public string Endpoint { get; init; } = "";

        [JsonPropertyName("message")]
        public string Message { get; init; } = "";

        [JsonPropertyName("data")]
        public List<T> Data { get; set; } = [];
    }
}
