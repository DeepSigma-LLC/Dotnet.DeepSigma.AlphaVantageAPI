using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
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
