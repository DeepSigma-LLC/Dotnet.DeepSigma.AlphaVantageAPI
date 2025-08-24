using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeepSigma.DataAccess.API.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVETFProfileSectorWeight
    {
        [JsonPropertyName("sector")]
        public string Sector { get; set; } = string.Empty;
        [JsonPropertyName("weight")]
        public decimal Weight { get; set; }
    }
}
