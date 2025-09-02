using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVCashFlowData
    {
        [JsonPropertyName("fiscalDateEnding")]
        public DateTime FiscalDateEnding { get; init; }
        [JsonPropertyName("reportedCurrency")]
        public string ReportedCurrency { get; init; } = string.Empty;
        [JsonPropertyName("operatingCashflow")]
        public decimal? OperatingCashflow { get; init; }
        [JsonPropertyName("paymentsForOperatingActivities")]
        public decimal? PaymentsForOperatingActivities { get; init; }
        [JsonPropertyName("proceedsFromOperatingActivities")]
        public decimal? ProceedsFromOperatingActivities { get; init; }
        [JsonPropertyName("changeInOperatingLiabilities")]
        public decimal? ChangeInOperatingLiabilities { get; init; }
        [JsonPropertyName("changeInOperatingAssets")]
        public decimal? ChangeInOperatingAssets { get; init; }
        [JsonPropertyName("depreciationDepletionAndAmortization")]
        public decimal? DepreciationDepletionAndAmortization { get; init; }
        [JsonPropertyName("capitalExpenditures")]
        public decimal? CapitalExpenditures { get; init; }
        [JsonPropertyName("changeInReceivables")]
        public decimal? ChangeInReceivables { get; init; }
        [JsonPropertyName("changeInInventory")]
        public decimal? ChangeInInventory { get; init; }
        [JsonPropertyName("profitLoss")]
        public decimal? ProfitLoss { get; init; }
        [JsonPropertyName("cashflowFromInvestment")]
        public decimal? CashflowFromInvestment { get; init; }
        [JsonPropertyName("cashflowFromFinancing")]
        public decimal? CashflowFromFinancing { get; init; }
        [JsonPropertyName("proceedsFromRepaymentsOfShortTermDebt")]
        public decimal? ProceedsFromRepaymentsOfShortTermDebt { get; init; }
        [JsonPropertyName("paymentsForRepurchaseOfCommonStock")]
        public decimal? PaymentsForRepurchaseOfCommonStock { get; init; }
        [JsonPropertyName("paymentsForRepurchaseOfEquity")]
        public decimal? PaymentsForRepurchaseOfEquity { get; init; }
        [JsonPropertyName("paymentsForRepurchaseOfPreferredStock")]
        public decimal? PaymentsForRepurchaseOfPreferredStock { get; init; }
        [JsonPropertyName("dividendPayout")]
        public decimal? DividendPayout { get; init; }
        [JsonPropertyName("dividendPayoutCommonStock")]
        public decimal? DividendPayoutCommonStock { get; init; }
        [JsonPropertyName("dividendPayoutPreferredStock")]
        public decimal? DividendPayoutPreferredStock { get; init; }
        [JsonPropertyName("proceedsFromIssuanceOfCommonStock")]
        public decimal? ProceedsFromIssuanceOfCommonStock { get; init; }
        [JsonPropertyName("proceedsFromIssuanceOfLongTermDebtAndCapitalSecuritiesNet")]
        public decimal? ProceedsFromIssuanceOfLongTermDebtAndCapitalSecuritiesNet { get; init; }
        [JsonPropertyName("proceedsFromIssuanceOfPreferredStock")]
        public decimal? ProceedsFromIssuanceOfPreferredStock { get; init; }
        [JsonPropertyName("proceedsFromRepurchaseOfEquity")]
        public decimal? ProceedsFromRepurchaseOfEquity { get; init; }
        [JsonPropertyName("proceedsFromSaleOfTreasuryStock")]
        public decimal? ProceedsFromSaleOfTreasuryStock { get; init; }

        [JsonPropertyName("changeInCashAndCashEquivalents")]
        public decimal? ChangeInCashAndCashEquivalents { get; init; }
        [JsonPropertyName("changeInExchangeRate")]
        public decimal? ChangeInExchangeRate { get; init; }
        [JsonPropertyName("netIncome")]
        public decimal? NetIncome { get; init; }

    }
}
