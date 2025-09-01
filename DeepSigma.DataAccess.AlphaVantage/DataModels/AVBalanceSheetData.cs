using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    /// <summary>
    /// Data model for the balance sheet data from Alpha Vantage API.
    /// </summary>
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVBalanceSheetData
    {
        /// <summary>
        /// The fiscal date ending for the balance sheet data.
        /// </summary>
        [JsonPropertyName("fiscalDateEnding")]
        public DateTime FiscalDateEnding { get; init; }

        /// <summary>
        /// The reported currency for the balance sheet data.
        /// </summary>
        [JsonPropertyName("reportedCurrency")]
        public string ReportedCurrency { get; init; }

        /// <summary>
        /// Total assets reported on the balance sheet.
        /// </summary>
        [JsonPropertyName("totalAssets")]
        public decimal TotalAssets { get; init; }

        /// <summary>
        /// Total current assets reported on the balance sheet.
        /// </summary>
        [JsonPropertyName("totalCurrentAssets")]
        public decimal TotalCurrentAssets { get; init; }

        /// <summary>
        /// Cash and cash equivalents at carrying value.
        /// </summary>
        [JsonPropertyName("cashAndCashEquivalentsAtCarryingValue")]
        public decimal CashAndCashEquivalentsAtCarryingValue { get; init; }

        /// <summary>
        /// Cash and short-term investments.
        /// </summary>
        [JsonPropertyName("cashAndShortTermInvestments")]
        public decimal CashAndShortTermInvestments { get; init; }

        /// <summary>
        /// Inventory value.
        /// </summary>
        [JsonPropertyName("inventory")]
        public decimal Inventory { get; init; }

        /// <summary>
        /// Current net receivables.
        /// </summary>
        [JsonPropertyName("currentNetReceivables")]
        public decimal CurrentNetReceivables { get; init; }

        /// <summary>
        /// Total non-current assets.
        /// </summary>
        [JsonPropertyName("totalNonCurrentAssets")]
        public decimal TotalNonCurrentAssets { get; init; }

        /// <summary>
        /// Property, plant, and equipment value.
        /// </summary>
        [JsonPropertyName("propertyPlantEquipment")]
        public decimal PropertyPlantEquipment { get; init; }

        /// <summary>
        /// Accumulated depreciation and amortization for PPE (nullable).
        /// </summary>
        [JsonPropertyName("accumulatedDepreciationAmortizationPPE")]
        public decimal? AccumulatedDepreciationAmortizationPPE { get; init; }

        /// <summary>
        /// Intangible assets value.
        /// </summary>
        [JsonPropertyName("intangibleAssets")]
        public decimal IntangibleAssets { get; init; }

        /// <summary>
        /// Intangible assets excluding goodwill.
        /// </summary>
        [JsonPropertyName("intangibleAssetsExcludingGoodwill")]
        public decimal IntangibleAssetsExcludingGoodwill { get; init; }

        /// <summary>
        /// Goodwill value.
        /// </summary>
        [JsonPropertyName("goodwill")]
        public decimal Goodwill { get; init; }

        /// <summary>
        /// Investments value (nullable).
        /// </summary>
        [JsonPropertyName("investments")]
        public decimal? Investments { get; init; }

        /// <summary>
        /// Long-term investments value (nullable).
        /// </summary>
        [JsonPropertyName("longTermInvestments")]
        public decimal? LongTermInvestments { get; init; }

        /// <summary>
        /// Short-term investments value.
        /// </summary>
        [JsonPropertyName("shortTermInvestments")]
        public decimal ShortTermInvestments { get; init; }

        /// <summary>
        /// Other current assets value.
        /// </summary>
        [JsonPropertyName("otherCurrentAssets")]
        public decimal OtherCurrentAssets { get; init; }

        /// <summary>
        /// Other non-current assets value (nullable).
        /// </summary>
        [JsonPropertyName("otherNonCurrentAssets")]
        public decimal? OtherNonCurrentAssets { get; init; }

        /// <summary>
        /// Total liabilities reported on the balance sheet.
        /// </summary>
        [JsonPropertyName("totalLiabilities")]
        public decimal TotalLiabilities { get; init; }

        /// <summary>
        /// Total current liabilities.
        /// </summary>
        [JsonPropertyName("totalCurrentLiabilities")]
        public decimal TotalCurrentLiabilities { get; init; }

        /// <summary>
        /// Current accounts payable.
        /// </summary>
        [JsonPropertyName("currentAccountsPayable")]
        public decimal CurrentAccountsPayable { get; init; }

        /// <summary>
        /// Deferred revenue (nullable).
        /// </summary>
        [JsonPropertyName("deferredRevenue")]
        public decimal? DeferredRevenue { get; init; }

        /// <summary>
        /// Current debt (nullable).
        /// </summary>
        [JsonPropertyName("currentDebt")]
        public decimal? CurrentDebt { get; init; }

        /// <summary>
        /// Short-term debt.
        /// </summary>
        [JsonPropertyName("shortTermDebt")]
        public decimal ShortTermDebt { get; init; }

        /// <summary>
        /// Total non-current liabilities.
        /// </summary>
        [JsonPropertyName("totalNonCurrentLiabilities")]
        public decimal TotalNonCurrentLiabilities { get; init; }

        /// <summary>
        /// Capital lease obligations.
        /// </summary>
        [JsonPropertyName("capitalLeaseObligations")]
        public decimal CapitalLeaseObligations { get; init; }

        /// <summary>
        /// Long-term debt.
        /// </summary>
        [JsonPropertyName("longTermDebt")]
        public decimal LongTermDebt { get; init; }

        /// <summary>
        /// Current portion of long-term debt.
        /// </summary>
        [JsonPropertyName("currentLongTermDebt")]
        public decimal CurrentLongTermDebt { get; init; }

        /// <summary>
        /// Long-term debt, noncurrent (nullable).
        /// </summary>
        [JsonPropertyName("longTermDebtNoncurrent")]
        public decimal? LongTermDebtNoncurrent { get; init; }

        /// <summary>
        /// Total of short and long-term debt.
        /// </summary>
        [JsonPropertyName("shortLongTermDebtTotal")]
        public decimal ShortLongTermDebtTotal { get; init; }

        /// <summary>
        /// Other current liabilities.
        /// </summary>
        [JsonPropertyName("otherCurrentLiabilities")]
        public decimal OtherCurrentLiabilities { get; init; }

        /// <summary>
        /// Other non-current liabilities (nullable).
        /// </summary>
        [JsonPropertyName("otherNonCurrentLiabilities")]
        public decimal? OtherNonCurrentLiabilities { get; init; }

        /// <summary>
        /// Total shareholder equity.
        /// </summary>
        [JsonPropertyName("totalShareholderEquity")]
        public decimal TotalShareholderEquity { get; init; }

        /// <summary>
        /// Treasury stock value (nullable).
        /// </summary>
        [JsonPropertyName("treasuryStock")]
        public decimal? TreasuryStock { get; init; }

        /// <summary>
        /// Retained earnings.
        /// </summary>
        [JsonPropertyName("retainedEarnings")]
        public decimal RetainedEarnings { get; init; }

        /// <summary>
        /// Common stock value.
        /// </summary>
        [JsonPropertyName("commonStock")]
        public decimal CommonStock { get; init; }

        /// <summary>
        /// Common stock shares outstanding.
        /// </summary>
        [JsonPropertyName("commonStockSharesOutstanding")]
        public decimal CommonStockSharesOutstanding { get; init; }
    }
}
