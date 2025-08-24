using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeepSigma.DataAccess.API.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVInsiderTransactionData
    {
        [JsonPropertyName("transaction_date")]
        public DateOnly TransactionDate { get; set; }
        [JsonPropertyName("ticker")]
        public string Ticker { get; set; } = string.Empty;
        [JsonPropertyName("executive")]
        public string Executive { get; set; } = string.Empty;
        [JsonPropertyName("executive_title")]
        public string ExecutiveTitle { get; set; } = string.Empty;
        [JsonPropertyName("security_type")]
        public string SecurityType { get; set; } = string.Empty;
        [JsonPropertyName("acquisition_or_disposal")]
        public string AcquisitionOrDisposal { get; set; } = string.Empty;
        [JsonPropertyName("shares")]
        public double Shares { get; set; }
        [JsonPropertyName("share_price")]
        public double SharePrice { get; set; }

    }
}
