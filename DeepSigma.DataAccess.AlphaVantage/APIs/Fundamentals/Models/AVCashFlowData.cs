using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.APIs.Fundamentals.Models;

/// <summary>
/// The class represents cash flow data from the Alpha Vantage API.
/// </summary>
[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
public class AVCashFlowData
{
    /// <summary>
    /// The fiscal date ending for the cash flow data.
    /// </summary>
    [JsonPropertyName("fiscalDateEnding")]
    public DateTime FiscalDateEnding { get; init; }

    /// <summary>
    /// The reported currency for the cash flow data.
    /// </summary>
    [JsonPropertyName("reportedCurrency")]
    public string ReportedCurrency { get; init; } = string.Empty;

    /// <summary>
    /// The operating cash flow value.
    /// </summary>
    [JsonPropertyName("operatingCashflow")]
    public decimal? OperatingCashflow { get; init; }

    /// <summary>
    /// The payments for operating activities.
    /// </summary>
    [JsonPropertyName("paymentsForOperatingActivities")]
    public decimal? PaymentsForOperatingActivities { get; init; }

    /// <summary>
    /// The proceeds from operating activities.
    /// </summary>
    [JsonPropertyName("proceedsFromOperatingActivities")]
    public decimal? ProceedsFromOperatingActivities { get; init; }

    /// <summary>
    /// The change in operating liabilities.
    /// </summary>
    [JsonPropertyName("changeInOperatingLiabilities")]
    public decimal? ChangeInOperatingLiabilities { get; init; }

    /// <summary>
    /// The change in operating assets.
    /// </summary>
    [JsonPropertyName("changeInOperatingAssets")]
    public decimal? ChangeInOperatingAssets { get; init; }

    /// <summary>
    /// The depreciation, depletion, and amortization value.
    /// </summary>
    [JsonPropertyName("depreciationDepletionAndAmortization")]
    public decimal? DepreciationDepletionAndAmortization { get; init; }

    /// <summary>
    /// The capital expenditures value.
    /// </summary>
    [JsonPropertyName("capitalExpenditures")]
    public decimal? CapitalExpenditures { get; init; }

    /// <summary>
    /// The change in receivables value.
    /// </summary>
    [JsonPropertyName("changeInReceivables")]
    public decimal? ChangeInReceivables { get; init; }

    /// <summary>
    /// The change in inventory value.
    /// </summary>
    [JsonPropertyName("changeInInventory")]
    public decimal? ChangeInInventory { get; init; }

    /// <summary>
    /// The profit and loss value.
    /// </summary>
    [JsonPropertyName("profitLoss")]
    public decimal? ProfitLoss { get; init; }

    /// <summary>
    /// The cash flow from investment activities.
    /// </summary>
    [JsonPropertyName("cashflowFromInvestment")]
    public decimal? CashflowFromInvestment { get; init; }

    /// <summary>
    /// The cash flow from financing activities.
    /// </summary>
    [JsonPropertyName("cashflowFromFinancing")]
    public decimal? CashflowFromFinancing { get; init; }

    /// <summary>
    /// The proceeds from repayments of short-term debt.
    /// </summary>
    [JsonPropertyName("proceedsFromRepaymentsOfShortTermDebt")]
    public decimal? ProceedsFromRepaymentsOfShortTermDebt { get; init; }

    /// <summary>
    /// The payments for repayments of commmon stock.
    /// </summary>
    [JsonPropertyName("paymentsForRepurchaseOfCommonStock")]
    public decimal? PaymentsForRepurchaseOfCommonStock { get; init; }

    /// <summary>
    /// The payments for repurchase of equity.
    /// </summary>
    [JsonPropertyName("paymentsForRepurchaseOfEquity")]
    public decimal? PaymentsForRepurchaseOfEquity { get; init; }

    /// <summary>
    /// The payments for repurchase of preferred stock.
    /// </summary>
    [JsonPropertyName("paymentsForRepurchaseOfPreferredStock")]
    public decimal? PaymentsForRepurchaseOfPreferredStock { get; init; }

    /// <summary>
    /// The dividend payout value.
    /// </summary>
    [JsonPropertyName("dividendPayout")]
    public decimal? DividendPayout { get; init; }

    /// <summary>
    /// The dividend payout for common stock.
    /// </summary>
    [JsonPropertyName("dividendPayoutCommonStock")]
    public decimal? DividendPayoutCommonStock { get; init; }

    /// <summary>
    /// The dividend payout for preferred stock.
    /// </summary>
    [JsonPropertyName("dividendPayoutPreferredStock")]
    public decimal? DividendPayoutPreferredStock { get; init; }

    /// <summary>
    /// The proceeds from issuance of common stock.
    /// </summary>
    [JsonPropertyName("proceedsFromIssuanceOfCommonStock")]
    public decimal? ProceedsFromIssuanceOfCommonStock { get; init; }

    /// <summary>
    /// The proceeds from issuance of long-term debt and capital securities, net.
    /// </summary>
    [JsonPropertyName("proceedsFromIssuanceOfLongTermDebtAndCapitalSecuritiesNet")]
    public decimal? ProceedsFromIssuanceOfLongTermDebtAndCapitalSecuritiesNet { get; init; }

    /// <summary>
    /// The proceeds from issuance of preferred stock.
    /// </summary>
    [JsonPropertyName("proceedsFromIssuanceOfPreferredStock")]
    public decimal? ProceedsFromIssuanceOfPreferredStock { get; init; }

    /// <summary>
    /// The proceeds from repayments of equity.
    /// </summary>
    [JsonPropertyName("proceedsFromRepurchaseOfEquity")]
    public decimal? ProceedsFromRepurchaseOfEquity { get; init; }

    /// <summary>
    /// The proceeds from sale of treasury stock.
    /// </summary>
    [JsonPropertyName("proceedsFromSaleOfTreasuryStock")]
    public decimal? ProceedsFromSaleOfTreasuryStock { get; init; }


    /// <summary>
    /// The change in cash and cash equivalents value.
    /// </summary>
    [JsonPropertyName("changeInCashAndCashEquivalents")]
    public decimal? ChangeInCashAndCashEquivalents { get; init; }

    /// <summary>
    /// The change in exchange rate value.
    /// </summary>
    [JsonPropertyName("changeInExchangeRate")]
    public decimal? ChangeInExchangeRate { get; init; }

    /// <summary>
    /// The net income value.
    /// </summary>
    [JsonPropertyName("netIncome")]
    public decimal? NetIncome { get; init; }

}
