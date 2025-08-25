using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    public class AVCashFlowResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; init; }
        [JsonPropertyName("annualReports")]
        public List<AVCashFlowData> AnnualReports { get; init; } = [];
        [JsonPropertyName("quarterlyReports")]
        public List<AVCashFlowData> QuarterlyReports { get; init; } = [];
    }
}
