using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVIncomeStatementData
    {
        [JsonPropertyName("fiscalDateEnding")]
        public DateTime FiscalDateEnding { get; init; }
        [JsonPropertyName("reportedCurrency")]
        public string ReportedCurrency { get; init; }
        [JsonPropertyName("grossProfit")]
        public decimal? GrossProfit { get; init; }
        [JsonPropertyName("totalRevenue")]
        public decimal? TotalRevenue { get; init; }
        [JsonPropertyName("costOfRevenue")]
        public decimal? CostOfRevenue { get; init; }
        [JsonPropertyName("costofGoodsAndServicesSold")]
        public decimal? CostofGoodsAndServicesSold { get; init; }
        [JsonPropertyName("operatingIncome")]
        public decimal? OperatingIncome { get; init; }
        [JsonPropertyName("sellingGeneralAndAdministrative")]
        public decimal? SellingGeneralAndAdministrative { get; init; }
        [JsonPropertyName("researchAndDevelopment")]
        public decimal? ResearchAndDevelopment { get; init; }
        [JsonPropertyName("operatingExpenses")]
        public decimal? OperatingExpenses { get; init; }
        [JsonPropertyName("investmentIncomeNet")]
        public decimal? InvestmentIncomeNet { get; init; }
        [JsonPropertyName("netInterestIncome")]
        public decimal? NetInterestIncome { get; init; }
        [JsonPropertyName("interestIncome")]
        public decimal? InterestIncome { get; init; }
        [JsonPropertyName("interestExpense")]
        public decimal? InterestExpense { get; init; }
        [JsonPropertyName("nonInterestIncome")]
        public decimal? NonInterestIncome { get; init; }
        [JsonPropertyName("otherNonOperatingIncome")]
        public decimal? OtherNonOperatingIncome { get; init; }
        [JsonPropertyName("depreciation")]
        public decimal? Depreciation { get; init; }
        [JsonPropertyName("depreciationAndAmortization")]
        public decimal? DepreciationAndAmortization { get; init; }
        [JsonPropertyName("incomeBeforeTax")]
        public decimal? IncomeBeforeTax { get; init; }
        [JsonPropertyName("incomeTaxExpense")]
        public decimal? IncomeTaxExpense { get; init; }
        [JsonPropertyName("interestAndDebtExpense")]
        public decimal? InterestAndDebtExpense { get; init; }
        [JsonPropertyName("netIncomeFromContinuingOperations")]
        public decimal? NetIncome { get; init; }
    }
}
