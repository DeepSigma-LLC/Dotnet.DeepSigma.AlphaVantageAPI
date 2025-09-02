using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.DataModels
{
    /// <summary>
    /// The class represents a transcript message from the Alpha Vantage API.
    /// </summary>
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVTranscriptMessage
    {
        /// <summary>
        /// The speaker of the message.
        /// </summary>
        [JsonPropertyName("speaker")]
        public string Speaker { get; set; } = string.Empty;

        /// <summary>
        /// The title.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// The content of the message.
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// The sentiment score of the message.
        /// </summary>
        [JsonPropertyName("sentiment")]
        public decimal Sentiment { get; set; }

    }
}
