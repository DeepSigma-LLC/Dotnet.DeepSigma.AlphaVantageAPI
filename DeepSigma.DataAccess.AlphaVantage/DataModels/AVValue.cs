
using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.DataModels
{
    /// <summary>
    /// The class represents a data point with a date and a corresponding numerical value.
    /// </summary>
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVValue
    {
        /// <summary>
        /// The date associated with the value.
        /// </summary>
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// The numerical value associated with the date.
        /// </summary>
        [JsonPropertyName("value")]
        public decimal Value { get; set; }
    }
}
