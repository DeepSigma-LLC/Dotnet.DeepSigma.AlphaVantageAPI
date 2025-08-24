using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeepSigma.DataAccess.API.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVComanyOverview
    {
        [JsonPropertyName("Symbol")]
        public string Symbol { get; init; } = string.Empty;
        [JsonPropertyName("AssetType")]
        public string AssetType { get; init; } = string.Empty;
        [JsonPropertyName("Name")]
        public string Name { get; init; } = string.Empty;
        [JsonPropertyName("Description")]
        public string Description { get; init; } = string.Empty;
        [JsonPropertyName("CIK")]
        public string CIK { get; init; } = string.Empty;
        [JsonPropertyName("Exchange")]
        public string Exchange { get; init; } = string.Empty;
        [JsonPropertyName("Currency")]
        public string Currency { get; init; } = string.Empty;
        [JsonPropertyName("Country")]
        public string Country { get; init; } = string.Empty;
        [JsonPropertyName("Sector")]
        public string Sector { get; init; } = string.Empty;
        [JsonPropertyName("Industry")]
        public string Industry { get; init; } = string.Empty;
        [JsonPropertyName("Address")]
        public string Address { get; init; } = string.Empty;
        [JsonPropertyName("OfficialSite")]
        public string OfficialSite { get; init; } = string.Empty;
        [JsonPropertyName("FiscalYearEnd")]
        public string FiscalYearEnd { get; init; } = string.Empty;
        [JsonPropertyName("LatestQuarter")]
        public DateOnly LatestQuarter { get; init; }
        [JsonPropertyName("MarketCapitalization")]
        public decimal MarketCapitalization { get; init; }
        [JsonPropertyName("EBITDA")]
        public decimal EBITDA { get; init; }
        [JsonPropertyName("PERatio")]
        public decimal PERatio { get; init; }
        [JsonPropertyName("PEGRatio")]
        public decimal PEGRatio { get; init; }
        [JsonPropertyName("BookValue")]
        public decimal BookValue { get; init; }
        [JsonPropertyName("DividendPerShare")]
        public decimal DividendPerShare { get; init; }
        [JsonPropertyName("DividendYield")]
        public decimal DividendYield { get; init; }
        [JsonPropertyName("EPS")]
        public decimal EPS { get; init; }
        [JsonPropertyName("RevenuePerShareTTM")]
        public decimal RevenuePerShareTTM { get; init; }
        [JsonPropertyName("ProfitMargin")]
        public decimal ProfitMargin { get; init; }
        [JsonPropertyName("OperatingMarginTTM")]
        public decimal OperatingMarginTTM { get; init; }
        [JsonPropertyName("ReturnOnAssetsTTM")]
        public decimal ReturnOnAssetsTTM { get; init; }
        [JsonPropertyName("ReturnOnEquityTTM")]
        public decimal ReturnOnEquityTTM { get; init; }
        [JsonPropertyName("RevenueTTM")]
        public decimal RevenueTTM { get; init; }
        [JsonPropertyName("GrossProfitTTM")]
        public decimal GrossProfitTTM { get; init; }
        [JsonPropertyName("DilutedEPSTTM")]
        public decimal DilutedEPSTTM { get; init; }
        [JsonPropertyName("QuarterlyEarningsGrowthYOY")]
        public decimal QuarterlyEarningsGrowthYOY { get; init; }
        [JsonPropertyName("QuarterlyRevenueGrowthYOY")]
        public decimal QuarterlyRevenueGrowthYOY { get; init; }
        [JsonPropertyName("AnalystTargetPrice")]
        public decimal AnalystTargetPrice { get; init; }
        [JsonPropertyName("AnalystRatingStrongBuy")]
        public int AnalystRatingStrongBuy { get; init; }
        [JsonPropertyName("AnalystRatingBuy")]
        public int AnalystRatingBuy { get; init; }
        [JsonPropertyName("AnalystRatingHold")]
        public int AnalystRatingHold { get; init; }
        [JsonPropertyName("AnalystRatingSell")]
        public int AnalystRatingSell { get; init; }
        [JsonPropertyName("AnalystRatingStrongSell")]
        public int AnalystRatingStrongSell { get; init; }
        [JsonPropertyName("TrailingPE")]
        public decimal TrailingPE { get; init; }
        [JsonPropertyName("ForwardPE")]
        public decimal ForwardPE { get; init; }
        [JsonPropertyName("PriceToSalesRatioTTM")]
        public decimal PriceToSalesRatioTTM { get; init; }
        [JsonPropertyName("PriceToBookRatio")]
        public decimal PriceToBookRatio { get; init; }
        [JsonPropertyName("EVToRevenue")]
        public decimal EVToRevenue { get; init; }
        [JsonPropertyName("EVToEBITDA")]
        public decimal EVToEBITDA { get; init; }
        [JsonPropertyName("Beta")]
        public decimal Beta { get; init; }
        [JsonPropertyName("52WeekHigh")]
        public decimal Week52High { get; init; }
        [JsonPropertyName("52WeekLow")]
        public decimal Week52Low { get; init; }
        [JsonPropertyName("50DayMovingAverage")]
        public decimal Day50MovingAverage { get; init; }
        [JsonPropertyName("200DayMovingAverage")]
        public decimal Day200MovingAverage { get; init; }
        [JsonPropertyName("SharesOutstanding")]
        public long SharesOutstanding { get; init; }

        [JsonPropertyName("SharesFloat")]
        public long SharesFloat { get; init; }
        [JsonPropertyName("PercentInsiders")]
        public decimal PercentInsiders { get; init; }
        [JsonPropertyName("PercentInstitutions")]
        public decimal PercentInstitutions { get; init; }
        [JsonPropertyName("DividendDate")]
        public DateOnly DividendDate { get; init; }
        [JsonPropertyName("ExDividendDate")]
        public DateOnly ExDividendDate { get; init; }
    }
}
