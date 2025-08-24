
using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVValue
    {
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("value")]
        public decimal Value { get; set; }
        }
}
