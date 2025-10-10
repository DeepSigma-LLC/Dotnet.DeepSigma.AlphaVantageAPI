
using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.DataModels;

/// <summary>
/// The class represents income statement data from the Alpha Vantage API.
/// </summary>
[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
public class AVIncomeStatementData
{
    /// <summary>
    /// The fiscal date ending for the income statement.
    /// </summary>
    [JsonPropertyName("fiscalDateEnding")]
    public DateTime FiscalDateEnding { get; init; }

    /// <summary>
    /// The reported currency for the income statement.
    /// </summary>
    [JsonPropertyName("reportedCurrency")]
    public string ReportedCurrency { get; init; } = string.Empty;

    /// <summary>
    /// The gross profit reported in the income statement.
    /// </summary>
    [JsonPropertyName("grossProfit")]
    public decimal? GrossProfit { get; init; }

    /// <summary>
    /// The total revenue reported in the income statement.
    /// </summary>
    [JsonPropertyName("totalRevenue")]
    public decimal? TotalRevenue { get; init; }

    /// <summary>
    /// The total operating revenue reported in the income statement.
    /// </summary>
    [JsonPropertyName("costOfRevenue")]
    public decimal? CostOfRevenue { get; init; }

    /// <summary>
    /// The cost of goods and services sold reported in the income statement.
    /// </summary>
    [JsonPropertyName("costofGoodsAndServicesSold")]
    public decimal? CostofGoodsAndServicesSold { get; init; }

    /// <summary>
    /// The operating income reported in the income statement.
    /// </summary>
    [JsonPropertyName("operatingIncome")]
    public decimal? OperatingIncome { get; init; }

    /// <summary>
    /// The selling, general and administrative expenses reported in the income statement.
    /// </summary>
    [JsonPropertyName("sellingGeneralAndAdministrative")]
    public decimal? SellingGeneralAndAdministrative { get; init; }

    /// <summary>
    /// The research and development expenses reported in the income statement.
    /// </summary>
    [JsonPropertyName("researchAndDevelopment")]
    public decimal? ResearchAndDevelopment { get; init; }

    /// <summary>
    /// The operating expenses reported in the income statement.
    /// </summary>
    [JsonPropertyName("operatingExpenses")]
    public decimal? OperatingExpenses { get; init; }

    /// <summary>
    /// The investment income net reported in the income statement.
    /// </summary>
    [JsonPropertyName("investmentIncomeNet")]
    public decimal? InvestmentIncomeNet { get; init; }

    /// <summary>
    /// The net interest income reported in the income statement.
    /// </summary>
    [JsonPropertyName("netInterestIncome")]
    public decimal? NetInterestIncome { get; init; }

    /// <summary>
    /// The interest income reported in the income statement.
    /// </summary>
    [JsonPropertyName("interestIncome")]
    public decimal? InterestIncome { get; init; }

    /// <summary>
    /// The interest expense reported in the income statement.
    /// </summary>
    [JsonPropertyName("interestExpense")]
    public decimal? InterestExpense { get; init; }

    /// <summary>
    /// The non-interest income reported in the income statement.
    /// </summary>
    [JsonPropertyName("nonInterestIncome")]
    public decimal? NonInterestIncome { get; init; }

    /// <summary>
    /// The other non-operating income reported in the income statement.
    /// </summary>
    [JsonPropertyName("otherNonOperatingIncome")]
    public decimal? OtherNonOperatingIncome { get; init; }

    /// <summary>
    /// The depreciation reported in the income statement.
    /// </summary>
    [JsonPropertyName("depreciation")]
    public decimal? Depreciation { get; init; }

    /// <summary>
    /// The depreciation and amortization reported in the income statement.
    /// </summary>
    [JsonPropertyName("depreciationAndAmortization")]
    public decimal? DepreciationAndAmortization { get; init; }

    /// <summary>
    /// The income before tax reported in the income statement.
    /// </summary>
    [JsonPropertyName("incomeBeforeTax")]
    public decimal? IncomeBeforeTax { get; init; }

    /// <summary>
    /// The income tax expense reported in the income statement.
    /// </summary>
    [JsonPropertyName("incomeTaxExpense")]
    public decimal? IncomeTaxExpense { get; init; }

    /// <summary>
    /// The interest and debt expense reported in the income statement.
    /// </summary>
    [JsonPropertyName("interestAndDebtExpense")]
    public decimal? InterestAndDebtExpense { get; init; }

    /// <summary>
    /// The net income from continuing operations reported in the income statement.
    /// </summary>
    [JsonPropertyName("netIncomeFromContinuingOperations")]
    public decimal? NetIncome { get; init; }
}
