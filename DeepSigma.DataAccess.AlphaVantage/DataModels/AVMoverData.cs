using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    /// <summary>
    /// Data model for the daily gainers/lossers/actively traded endpoint from Alpha Vantage API.
    /// </summary>
    public class AVMoverData
    {
        [JsonPropertyName("ticker")]
        public string Ticker { get; init; } = string.Empty;
        [JsonPropertyName("price")]
        public decimal Price { get; init; }
        [JsonPropertyName("change_amount")]
        public decimal ChangeAmount { get; init; }
        [JsonPropertyName("change_percentage")]
        public string ChangePercentage { get; init; } = string.Empty;
        [JsonPropertyName("volume")]
        public long Volume { get; init; }
    }
}
