using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.DataModels;

/// <summary>
/// Data model for the company overview endpoint from Alpha Vantage API.
/// </summary>
[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
public class AVComanyOverview
{
    /// <summary>
    /// The stock symbol of the company.
    /// </summary>
    [JsonPropertyName("Symbol")]
    public string Symbol { get; init; } = string.Empty;

    /// <summary>
    /// The type of asset (e.g., "Common Stock").
    /// </summary>
    [JsonPropertyName("AssetType")]
    public string AssetType { get; init; } = string.Empty;

    /// <summary>
    /// The name of the company.
    /// </summary>
    [JsonPropertyName("Name")]
    public string Name { get; init; } = string.Empty;

    /// <summary>
    /// A brief description of the company.
    /// </summary>
    [JsonPropertyName("Description")]
    public string Description { get; init; } = string.Empty;

    /// <summary>
    /// The Central Index Key (CIK) assigned by the SEC.
    /// </summary>
    [JsonPropertyName("CIK")]
    public string CIK { get; init; } = string.Empty;

    /// <summary>
    /// The stock exchange where the company is listed.
    /// </summary>
    [JsonPropertyName("Exchange")]
    public string Exchange { get; init; } = string.Empty;

    /// <summary>
    /// The currency in which the company's stock is traded.
    /// </summary>
    [JsonPropertyName("Currency")]
    public string Currency { get; init; } = string.Empty;

    /// <summary>
    /// The country where the company is headquartered.
    /// </summary>
    [JsonPropertyName("Country")]
    public string Country { get; init; } = string.Empty;

    /// <summary>
    /// The sector in which the company operates.
    /// </summary>
    [JsonPropertyName("Sector")]
    public string Sector { get; init; } = string.Empty;
    /// <summary>
    /// The industry in which the company operates.
    /// </summary>
    [JsonPropertyName("Industry")]
    public string Industry { get; init; } = string.Empty;

    /// <summary>
    /// The full address of the company's headquarters.
    /// </summary>
    [JsonPropertyName("Address")]
    public string Address { get; init; } = string.Empty;

    /// <summary>
    /// The official website of the company.
    /// </summary>
    [JsonPropertyName("OfficialSite")]
    public string OfficialSite { get; init; } = string.Empty;

    /// <summary>
    /// The fiscal year end date of the company.
    /// </summary>
    [JsonPropertyName("FiscalYearEnd")]
    public string FiscalYearEnd { get; init; } = string.Empty;

    /// <summary>
    /// The date of the latest fiscal quarter.
    /// </summary>
    [JsonPropertyName("LatestQuarter")]
    public DateOnly LatestQuarter { get; init; }

    /// <summary>
    /// The market capitalization of the company.
    /// </summary>
    [JsonPropertyName("MarketCapitalization")]
    public decimal MarketCapitalization { get; init; }

    /// <summary>
    /// The EBITDA (Earnings Before Interest, Taxes, Depreciation, and Amortization) of the company.
    /// </summary>
    [JsonPropertyName("EBITDA")]
    public decimal EBITDA { get; init; }

    /// <summary>
    /// The price-to-earnings (P/E) ratio of the company.
    /// </summary>
    [JsonPropertyName("PERatio")]
    public decimal PERatio { get; init; }

    /// <summary>
    /// The price-to-earnings-growth (PEG) ratio of the company.
    /// </summary>
    [JsonPropertyName("PEGRatio")]
    public decimal PEGRatio { get; init; }

    /// <summary>
    /// The book value per share of the company.
    /// </summary>
    [JsonPropertyName("BookValue")]
    public decimal BookValue { get; init; }

    /// <summary>
    /// The dividend per share of the company.
    /// </summary>
    [JsonPropertyName("DividendPerShare")]
    public decimal DividendPerShare { get; init; }

    /// <summary>
    /// The dividend yield of the company.
    /// </summary>
    [JsonPropertyName("DividendYield")]
    public decimal DividendYield { get; init; }

    /// <summary>
    /// The earnings per share (EPS) of the company.
    /// </summary>
    [JsonPropertyName("EPS")]
    public decimal EPS { get; init; }

    /// <summary>
    /// The revenue per share of the company over the trailing tweleve months (TTM).
    /// </summary>
    [JsonPropertyName("RevenuePerShareTTM")]
    public decimal RevenuePerShareTTM { get; init; }

    /// <summary>
    /// The profit margin of the company.
    /// </summary>
    [JsonPropertyName("ProfitMargin")]
    public decimal ProfitMargin { get; init; }

    /// <summary>
    /// The operating margin of the company over the trailing tweleve months (TTM).
    /// </summary>
    [JsonPropertyName("OperatingMarginTTM")]
    public decimal OperatingMarginTTM { get; init; }

    /// <summary>
    /// The return on assets (ROA) of the company over the trailing tweleve months (TTM).
    /// </summary>
    [JsonPropertyName("ReturnOnAssetsTTM")]
    public decimal ReturnOnAssetsTTM { get; init; }

    /// <summary>
    /// The return on equity (ROE) of the company over the trailing tweleve months (TTM).
    /// </summary>
    [JsonPropertyName("ReturnOnEquityTTM")]
    public decimal ReturnOnEquityTTM { get; init; }

    /// <summary>
    /// The revenue of the company over the trailing twelve months (TTM).
    /// </summary>
    [JsonPropertyName("RevenueTTM")]
    public decimal RevenueTTM { get; init; }

    /// <summary>
    /// The gross profit of the company over the trailing twelve months (TTM).
    /// </summary>
    [JsonPropertyName("GrossProfitTTM")]
    public decimal GrossProfitTTM { get; init; }

    /// <summary>
    /// The diluted earnings per share (EPS) of the company over the trailing twelve months (TTM).
    /// </summary>
    [JsonPropertyName("DilutedEPSTTM")]
    public decimal DilutedEPSTTM { get; init; }

    /// <summary>
    /// The quarterly earnings growth year-over-year (YOY) of the company.
    /// </summary>
    [JsonPropertyName("QuarterlyEarningsGrowthYOY")]
    public decimal QuarterlyEarningsGrowthYOY { get; init; }

    /// <summary>
    /// The quarterly revenue growth year-over-year (YOY) of the company.
    /// </summary>
    [JsonPropertyName("QuarterlyRevenueGrowthYOY")]
    public decimal QuarterlyRevenueGrowthYOY { get; init; }

    /// <summary>
    /// The analyst target price for the company's stock.
    /// </summary>
    [JsonPropertyName("AnalystTargetPrice")]
    public decimal AnalystTargetPrice { get; init; }

    /// <summary>
    /// The number of analysts rating the stock as a strong buy.
    /// </summary>
    [JsonPropertyName("AnalystRatingStrongBuy")]
    public int AnalystRatingStrongBuy { get; init; }

    /// <summary>
    /// The number of analysts rating the stock as a buy.
    /// </summary>
    [JsonPropertyName("AnalystRatingBuy")]
    public int AnalystRatingBuy { get; init; }

    /// <summary>
    /// The number of analysts rating the stock as a hold.
    /// </summary>
    [JsonPropertyName("AnalystRatingHold")]
    public int AnalystRatingHold { get; init; }

    /// <summary>
    /// The number of analysts rating the stock as a sell.
    /// </summary>
    [JsonPropertyName("AnalystRatingSell")]
    public int AnalystRatingSell { get; init; }

    /// <summary>
    /// The number of analysts rating the stock as a strong sell.
    /// </summary>
    [JsonPropertyName("AnalystRatingStrongSell")]
    public int AnalystRatingStrongSell { get; init; }

    /// <summary>
    /// The trailing price-to-earnings (P/E) ratio of the company.
    /// </summary>
    [JsonPropertyName("TrailingPE")]
    public decimal TrailingPE { get; init; }

    /// <summary>
    /// The forward price-to-earnings (P/E) ratio of the company.
    /// </summary>
    [JsonPropertyName("ForwardPE")]
    public decimal ForwardPE { get; init; }

    /// <summary>
    /// The price-to-sales ratio of the company over the trailing twelve months (TTM).
    /// </summary>
    [JsonPropertyName("PriceToSalesRatioTTM")]
    public decimal PriceToSalesRatioTTM { get; init; }

    /// <summary>
    /// The price-to-book ratio of the company.
    /// </summary>
    [JsonPropertyName("PriceToBookRatio")]
    public decimal PriceToBookRatio { get; init; }

    /// <summary>
    /// The enterprise value (EV) of the company to its revenue.
    /// </summary>
    [JsonPropertyName("EVToRevenue")]
    public decimal EVToRevenue { get; init; }

    /// <summary>
    /// The enterprise value (EV) of the company to its EBITDA.
    /// </summary>
    [JsonPropertyName("EVToEBITDA")]
    public decimal EVToEBITDA { get; init; }

    /// <summary>
    /// The beta value of the company's stock, indicating its volatility relative to the market.
    /// </summary>
    [JsonPropertyName("Beta")]
    public decimal Beta { get; init; }

    /// <summary>
    /// The 52-week high price of the company's stock.
    /// </summary>
    [JsonPropertyName("52WeekHigh")]
    public decimal Week52High { get; init; }

    /// <summary>
    /// The 52-week low price of the company's stock.
    /// </summary>
    [JsonPropertyName("52WeekLow")]
    public decimal Week52Low { get; init; }

    /// <summary>
    /// The 50-day moving average of the stock price.
    /// </summary>
    [JsonPropertyName("50DayMovingAverage")]
    public decimal Day50MovingAverage { get; init; }

    /// <summary>
    /// The 200-day moving average of the stock price.
    /// </summary>
    [JsonPropertyName("200DayMovingAverage")]
    public decimal Day200MovingAverage { get; init; }

    /// <summary>
    /// The shares outstanding of the company. 
    /// Shares outstanding are the total shares currently held by all shareholders, including share blocks held by institutional investors and restricted shares owned by the company’s officers and insiders.
    /// </summary>
    [JsonPropertyName("SharesOutstanding")]
    public long SharesOutstanding { get; init; }

    /// <summary>
    /// The float shares of the company. 
    /// Float shares are the shares available for trading by the public and exclude closely held shares by insiders and employees.
    /// </summary>
    [JsonPropertyName("SharesFloat")]
    public long SharesFloat { get; init; }

    /// <summary>
    /// The percentage of shares held by insiders.
    /// </summary>
    [JsonPropertyName("PercentInsiders")]
    public decimal PercentInsiders { get; init; }

    /// <summary>
    /// The percentage of shares held by institutions.
    /// </summary>
    [JsonPropertyName("PercentInstitutions")]
    public decimal PercentInstitutions { get; init; }

    /// <summary>
    /// The dividend date of the company common stock. 
    /// The dividend date is the date on which a declared dividend is scheduled to be paid to shareholders of record.
    /// </summary>
    [JsonPropertyName("DividendDate")]
    public DateOnly DividendDate { get; init; }

    /// <summary>
    /// The ex-dividend date of the company common stock. 
    /// The ex-dividend date is the date on which the stock starts trading without the value of its next dividend payment. Investors who purchase the stock on or after this date are not entitled to receive the upcoming dividend.
    /// </summary>
    [JsonPropertyName("ExDividendDate")]
    public DateOnly ExDividendDate { get; init; }
}
