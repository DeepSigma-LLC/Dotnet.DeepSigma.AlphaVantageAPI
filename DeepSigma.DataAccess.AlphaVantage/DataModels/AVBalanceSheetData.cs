using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVBalanceSheetData
    {
        [JsonPropertyName("fiscalDateEnding")]
        public DateTime FiscalDateEnding { get; init; }

        [JsonPropertyName("reportedCurrency")]
        public string ReportedCurrency { get; init; }
        [JsonPropertyName("totalAssets")]
        public decimal TotalAssets { get; init; }
        [JsonPropertyName("totalCurrentAssets")]
        public decimal TotalCurrentAssets { get; init; } 
        [JsonPropertyName("cashAndCashEquivalentsAtCarryingValue")]
        public decimal CashAndCashEquivalentsAtCarryingValue { get; init; }
        [JsonPropertyName("cashAndShortTermInvestments")]
        public decimal CashAndShortTermInvestments { get; init; }
        [JsonPropertyName("inventory")]
        public decimal Inventory { get; init; }
        [JsonPropertyName("currentNetReceivables")]
        public decimal CurrentNetReceivables { get; init; }
        [JsonPropertyName("totalNonCurrentAssets")]
        public decimal TotalNonCurrentAssets { get; init; }
        [JsonPropertyName("propertyPlantEquipment")]
        public decimal PropertyPlantEquipment { get; init; }
        [JsonPropertyName("accumulatedDepreciationAmortizationPPE")]
        public decimal? AccumulatedDepreciationAmortizationPPE { get; init; }

        [JsonPropertyName("intangibleAssets")]
        public decimal IntangibleAssets { get; init; }
        [JsonPropertyName("intangibleAssetsExcludingGoodwill")]
        public decimal IntangibleAssetsExcludingGoodwill { get; init; }
        [JsonPropertyName("goodwill")]
        public decimal Goodwill { get; init; }
        [JsonPropertyName("investments")]
        public decimal? Investments { get; init; }
        [JsonPropertyName("longTermInvestments")]
        public decimal? LongTermInvestments { get; init; }
        [JsonPropertyName("shortTermInvestments")]
        public decimal ShortTermInvestments { get; init; }
        [JsonPropertyName("otherCurrentAssets")]
        public decimal OtherCurrentAssets { get; init; }
        [JsonPropertyName("otherNonCurrentAssets")]
        public decimal? OtherNonCurrentAssets { get; init; }
        [JsonPropertyName("totalLiabilities")]

        public decimal TotalLiabilities { get; init; }
        [JsonPropertyName("totalCurrentLiabilities")]
        public decimal TotalCurrentLiabilities { get; init; }
        [JsonPropertyName("currentAccountsPayable")]
        public decimal CurrentAccountsPayable { get; init; }
        [JsonPropertyName("deferredRevenue")]
        public decimal? DeferredRevenue { get; init; }
        [JsonPropertyName("currentDebt")]
        public decimal? CurrentDebt { get; init; }
        [JsonPropertyName("shortTermDebt")]
        public decimal ShortTermDebt { get; init; }
        [JsonPropertyName("totalNonCurrentLiabilities")]
        public decimal TotalNonCurrentLiabilities { get; init; }
        [JsonPropertyName("capitalLeaseObligations")]
        public decimal CapitalLeaseObligations { get; init; }
        [JsonPropertyName("longTermDebt")]
        public decimal LongTermDebt { get; init; }
        [JsonPropertyName("currentLongTermDebt")]
        public decimal CurrentLongTermDebt { get; init; }
        [JsonPropertyName("longTermDebtNoncurrent")]
        public decimal? LongTermDebtNoncurrent { get; init; }
        [JsonPropertyName("shortLongTermDebtTotal")]
        public decimal ShortLongTermDebtTotal { get; init; }
        [JsonPropertyName("otherCurrentLiabilities")]
        public decimal OtherCurrentLiabilities { get; init; }
        [JsonPropertyName("otherNonCurrentLiabilities")]
        public decimal? OtherNonCurrentLiabilities { get; init; }
        [JsonPropertyName("totalShareholderEquity")]
        public decimal TotalShareholderEquity { get; init; }
        [JsonPropertyName("treasuryStock")]
        public decimal? TreasuryStock { get; init; }
        [JsonPropertyName("retainedEarnings")]
        public decimal RetainedEarnings { get; init; }
        [JsonPropertyName("commonStock")]
        public decimal CommonStock { get; init; }
        [JsonPropertyName("commonStockSharesOutstanding")]
        public decimal CommonStockSharesOutstanding { get; init; }

        }
}
