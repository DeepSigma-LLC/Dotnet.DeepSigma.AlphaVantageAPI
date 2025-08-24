using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVDividendRecord
    {
        [JsonPropertyName("ex_dividend_date")]
        public DateOnly ExDividendDate { get; set; }
        [JsonPropertyName("declaration_date")]
        public DateOnly DeclarationDate { get; set; }
        [JsonPropertyName("record_date")]
        public DateOnly RecordDate { get; set; }
        [JsonPropertyName("payment_date")]
        public DateOnly PaymentDate { get; set; }
        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }
    }
}
