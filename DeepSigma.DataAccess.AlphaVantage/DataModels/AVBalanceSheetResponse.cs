using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    public class AVBalanceSheetResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; init; }
        [JsonPropertyName("annualReports")]
        public List<AVBalanceSheetData> AnnualReports { get; init; } = [];
        [JsonPropertyName("quarterlyReports")]
        public List<AVBalanceSheetData> QuarterlyReports { get; init; } = [];
    }
}
