using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    /// <summary>
    /// Data model for the balance sheet endpoint from Alpha Vantage API.
    /// </summary>
    public class AVBalanceSheetResponse
    {
        /// <summary>
        /// The stock symbol for which the balance sheet data is provided.
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; init; } = string.Empty;

        /// <summary>
        /// List of annual balance sheet reports.
        /// </summary>
        [JsonPropertyName("annualReports")]
        public List<AVBalanceSheetData> AnnualReports { get; init; } = [];

        /// <summary>
        /// List of quarterly balance sheet reports.
        /// </summary>
        [JsonPropertyName("quarterlyReports")]
        public List<AVBalanceSheetData> QuarterlyReports { get; init; } = [];
    }
}
