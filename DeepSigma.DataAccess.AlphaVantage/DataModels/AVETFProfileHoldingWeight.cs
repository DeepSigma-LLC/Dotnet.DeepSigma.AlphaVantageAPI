using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeepSigma.DataAccess.API.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVETFProfileHoldingWeight
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; init; } = string.Empty;
        [JsonPropertyName("description")]
        public string Description { get; init; } = string.Empty;
        [JsonPropertyName("weight")]
        public decimal Weight { get; init; }
    }
}
