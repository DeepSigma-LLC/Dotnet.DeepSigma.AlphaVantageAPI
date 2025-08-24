using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeepSigma.DataAccess.API.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVStockSplitResponse
    {
       [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }
        [JsonPropertyName("data")]
        public List<AVStockSplitRecord> Data { get; set; } = [];
    }
}
