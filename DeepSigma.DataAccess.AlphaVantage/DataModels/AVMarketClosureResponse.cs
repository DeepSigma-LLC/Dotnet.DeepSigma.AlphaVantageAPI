using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    public class AVMarketClosureResponse
    {
        [JsonPropertyName("endpoint")]
        public string Endpoint { get; init; } = string.Empty;
        [JsonPropertyName("markets")]
        public List<AVMarketClosureData> Markets { get; init; } = [];
    }
}
