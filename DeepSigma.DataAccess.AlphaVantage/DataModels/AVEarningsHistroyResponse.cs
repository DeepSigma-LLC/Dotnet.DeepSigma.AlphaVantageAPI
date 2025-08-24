using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeepSigma.DataAccess.API.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVEarningsHistroyResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        [JsonPropertyName("annualEarnings")]
        public List<AVEarningsAnnualData>? AnnualEarnings { get; set; }
        [JsonPropertyName("quarterlyEarnings")]
        public List<AVEarningsQuarterlyData>? QuarterlyEarnings { get; set; }
    }
}
