using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeepSigma.DataAccess.API.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVTranscriptMessage
    {
        [JsonPropertyName("speaker")]
        public string Speaker { get; set; } = string.Empty;
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;
        [JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;
        [JsonPropertyName("sentiment")]
        public decimal Sentiment { get; set; }

    }
}
