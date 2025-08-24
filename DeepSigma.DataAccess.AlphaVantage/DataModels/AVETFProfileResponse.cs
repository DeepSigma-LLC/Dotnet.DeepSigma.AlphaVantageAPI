using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeepSigma.DataAccess.API.AlphaVantage.DataModels
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
