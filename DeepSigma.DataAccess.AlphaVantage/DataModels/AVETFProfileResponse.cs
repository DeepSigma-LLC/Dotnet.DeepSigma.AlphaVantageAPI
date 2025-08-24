using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVETFProfileResponse
    {
        [JsonPropertyName("net_assets")]
        public long NetAssets { get; set; }

        [JsonPropertyName("net_expense_ratio")]
        public decimal NetExpenseRatio { get; set; }
        [JsonPropertyName("portfolio_turnover")]

        public decimal PortfolioTurnover { get; set; }
        [JsonPropertyName("dividend_yield")]
        public decimal DividendYield { get; set; }
        [JsonPropertyName("inception_date")]
        public DateOnly InceptionDate { get; set; }
        [JsonPropertyName("leveraged")]
        public string Leveraged { get; set; } = string.Empty;
        [JsonPropertyName("sectors")]
        public List<AVETFProfileSectorWeight> Sectors { get; set; } = [];
        [JsonPropertyName("holdings")]
        public List<AVETFProfileHoldingWeight> Holdings { get; set; } = [];

    }

}
