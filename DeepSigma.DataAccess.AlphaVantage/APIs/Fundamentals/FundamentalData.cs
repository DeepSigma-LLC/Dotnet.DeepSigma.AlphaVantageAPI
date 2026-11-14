using DeepSigma.AlphaVantageAPI.APIs.Fundamentals.Models;
using DeepSigma.AlphaVantageAPI.APIs.Stock.Models;
using DeepSigma.AlphaVantageAPI.Models;
using DeepSigma.DataAccess.Web;

namespace DeepSigma.AlphaVantageAPI.APIs.Fundamentals;

/// <summary>
/// This class contains methods to access fundamental data from the Alpha Vantage API.
/// </summary>
public class FundamentalData(HttpClient client, ApiOptions options) : AbstractDataAPI(client, options)
{
    /// <summary>
    /// This API returns the company information, financial ratios, and other key metrics for the equity specified. 
    /// Data is generally refreshed on the same day a company reports its latest earnings and financials.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVComanyOverview?> GetCompanyOverview(string symbol, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=OVERVIEW&symbol={symbol}&apikey={Options.APIKey}";
        AVComanyOverview? results = await Utilities.GetAPIData(url, GetCompanyOverviewFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON response returned by the Alpha Vantage API for Company Overview.
    /// This API returns the company information, financial ratios, and other key metrics for the equity specified. 
    /// Data is generally refreshed on the same day a company reports its latest earnings and financials.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVComanyOverview? GetCompanyOverviewFromJson(string json) => Serializer.LoadFromJson<AVComanyOverview?>(json);


    /// <summary>
    /// This API returns the company information, financial ratios, and other key metrics for the equity specified. 
    /// Data is generally refreshed on the same day a company reports its latest earnings and financials.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVCompanyLogoResponse?> GetCompanyLogo(string symbol, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=COMPANY_LOGO&symbol={symbol}&apikey={Options.APIKey}";
        AVCompanyLogoResponse? results = await Utilities.GetAPIData(url, GetCompanyLogoFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON response returned by the Alpha Vantage API for Company Overview.
    /// This API returns the company information, financial ratios, and other key metrics for the equity specified. 
    /// Data is generally refreshed on the same day a company reports its latest earnings and financials.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVCompanyLogoResponse? GetCompanyLogoFromJson(string json) => Serializer.LoadFromJson<AVCompanyLogoResponse?>(json);



    /// <summary>
    /// This API returns the latest and historical insider transactions made by key stakeholders (e.g., founders, executives, board members, etc.) of a specific company.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVDataRequest<AVInsiderTransactionData>?> GetInsiderTransactions(string symbol, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=INSIDER_TRANSACTIONS&symbol={symbol}&apikey={Options.APIKey}";
        AVDataRequest<AVInsiderTransactionData>? results = await Utilities.GetAPIData(url, GetInsiderTransactionsFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON response returned by the Alpha Vantage API for Insider Transactions.
    /// This API returns the latest and historical insider transactions made by key stakeholders (e.g., founders, executives, board members, etc.) of a specific company.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVDataRequest<AVInsiderTransactionData>? GetInsiderTransactionsFromJson(string json) => Serializer.LoadFromJson<AVDataRequest<AVInsiderTransactionData>>(json);

    /// <summary>
    /// This API returns the earnings call transcript for a given company in a specific quarter, covering over 15 years of history and enriched with LLM-based sentiment signals.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="year"></param>
    /// <param name="quarter"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVTranscriptResponse?> GetEarningsTranscript(string symbol, int year, byte quarter, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=EARNINGS_CALL_TRANSCRIPT&symbol={symbol}&quarter={year}Q{quarter}&apikey={Options.APIKey}";
        AVTranscriptResponse? results = await Utilities.GetAPIData(url, GetEarningsTranscriptFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON response returned by the Alpha Vantage API for Earnings Call Transcript.
    /// This API returns the earnings call transcript for a given company in a specific quarter, covering over 15 years of history and enriched with LLM-based sentiment signals.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVTranscriptResponse? GetEarningsTranscriptFromJson(string json) => Serializer.LoadFromJson<AVTranscriptResponse?>(json);

    /// <summary>
    /// This API returns historical and future (declared) dividend distributions.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVDividendHistoryResponse?> GetDividends(string symbol, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=DIVIDENDS&symbol={symbol}&apikey={Options.APIKey}";
        AVDividendHistoryResponse? results = await Utilities.GetAPIData(url, GetDividendsFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON response returned by the Alpha Vantage API for Dividends.
    /// This API returns historical and future (declared) dividend distributions.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVDividendHistoryResponse? GetDividendsFromJson(string json) => Serializer.LoadFromJson<AVDividendHistoryResponse?>(json);

    /// <summary>
    /// This API returns historical split events.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVStockSplitResponse?> GetStockSplits(string symbol, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=SPLITS&symbol={symbol}&apikey={Options.APIKey}";
        AVStockSplitResponse? results = await Utilities.GetAPIData(url, GetStockSplitsFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON response returned by the Alpha Vantage API for Stock Splits.
    /// This API returns historical split events.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVStockSplitResponse? GetStockSplitsFromJson(string json) => Serializer.LoadFromJson<AVStockSplitResponse?>(json);

    /// <summary>
    /// This API returns the annual and quarterly income statements for the company of interest, with normalized fields mapped to GAAP and IFRS taxonomies of the SEC. 
    /// Data is generally refreshed on the same day a company reports its latest earnings and financials.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVIncomeStatementResponse?> GetIncomeStatement(string symbol, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=INCOME_STATEMENT&symbol={symbol}&apikey={Options.APIKey}";
        AVIncomeStatementResponse? results = await Utilities.GetAPIData(url, GetIncomeStatementFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON response returned by the Alpha Vantage API for Income Statement.
    /// This API returns the annual and quarterly income statements for the company of interest, with normalized fields mapped to GAAP and IFRS taxonomies of the SEC. 
    /// Data is generally refreshed on the same day a company reports its latest earnings and financials.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVIncomeStatementResponse? GetIncomeStatementFromJson(string json)
    {
        json = json.Replace("\"None\"", "null");
        AVIncomeStatementResponse? results = Serializer.LoadFromJson<AVIncomeStatementResponse?>(json);
        return results;
    }

    /// <summary>
    /// This API returns the annual and quarterly balance sheets for the company of interest, with normalized fields mapped to GAAP and IFRS taxonomies of the SEC. 
    /// Data is generally refreshed on the same day a company reports its latest earnings and financials.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVBalanceSheetResponse?> GetBalanceSheet(string symbol, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=BALANCE_SHEET&symbol={symbol}&apikey={Options.APIKey}";
        AVBalanceSheetResponse? results = await Utilities.GetAPIData(url, GetBalanceSheetFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON response returned by the Alpha Vantage API for Balance Sheet.
    /// This API returns the annual and quarterly balance sheets for the company of interest, with normalized fields mapped to GAAP and IFRS taxonomies of the SEC. 
    /// Data is generally refreshed on the same day a company reports its latest earnings and financials.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVBalanceSheetResponse? GetBalanceSheetFromJson(string json)
    {
        json = json.Replace("\"None\"", "null");
        AVBalanceSheetResponse? results = Serializer.LoadFromJson<AVBalanceSheetResponse?>(json);
        return results;
    }

    /// <summary>
    /// This API returns the annual and quarterly cash flow for the company of interest, with normalized fields mapped to GAAP and IFRS taxonomies of the SEC. 
    /// Data is generally refreshed on the same day a company reports its latest earnings and financials.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVCashFlowResponse?> GetCashFlow(string symbol, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=CASH_FLOW&symbol={symbol}&apikey={Options.APIKey}";
        AVCashFlowResponse? results = await Utilities.GetAPIData(url, GetCashFlowFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON response returned by the Alpha Vantage API for Cash Flow.
    /// This API returns the annual and quarterly cash flow for the company of interest, with normalized fields mapped to GAAP and IFRS taxonomies of the SEC. 
    /// Data is generally refreshed on the same day a company reports its latest earnings and financials.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVCashFlowResponse? GetCashFlowFromJson(string json)
    {
        json = json.Replace("\"None\"", "null");
        AVCashFlowResponse? results = Serializer.LoadFromJson<AVCashFlowResponse?>(json);
        return results;
    }

    /// <summary>
    /// This API returns the annual and quarterly earnings (EPS) for the company of interest. 
    /// Quarterly data also includes analyst estimates and surprise metrics.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVEarningsHistroyResponse?> GetEarningsHistory(string symbol, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=EARNINGS&symbol={symbol}&apikey={Options.APIKey}";
        AVEarningsHistroyResponse? results = await Utilities.GetAPIData(url, GetEarningsHistoryFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON response returned by the Alpha Vantage API for Earnings History.
    /// This API returns the annual and quarterly earnings (EPS) for the company of interest. 
    /// Quarterly data also includes analyst estimates and surprise metrics.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVEarningsHistroyResponse? GetEarningsHistoryFromJson(string json) => Serializer.LoadFromJson<AVEarningsHistroyResponse?>(json);

    /// <summary>
    /// This API returns the annual and quarterly EPS and revenue estimates for the company of interest, along with analyst count and revision history.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVEarningsEstimateResponse?> GetEarningsEstimate(string symbol, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=EARNINGS_ESTIMATES&symbol={symbol}&apikey={Options.APIKey}";
        AVEarningsEstimateResponse? results = await Utilities.GetAPIData(url, GetEarningsEstimateFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON response returned by the Alpha Vantage API for Earnings Estimate.
    /// This API returns the annual and quarterly EPS and revenue estimates for the company of interest, along with analyst count and revision history.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVEarningsEstimateResponse? GetEarningsEstimateFromJson(string json) => Serializer.LoadFromJson<AVEarningsEstimateResponse?>(json);


    /// <summary>
    /// This API returns the annual and quarterly EPS and revenue estimates for the company of interest, along with analyst count and revision history.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVSharesOutstandingResponse?> GetSharesOutstanding(string symbol, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=SHARES_OUTSTANDING&symbol={symbol}&apikey={Options.APIKey}";
        AVSharesOutstandingResponse? results = await Utilities.GetAPIData(url, GetSharesOutstandingFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON response returned by the Alpha Vantage API for Shares Outstanding.
    /// This API returns the quarterly numbers of shares outstanding for the company of interest, with both diluted and basic shares outstanding values returned. 
    /// Data is generally refreshed on the same day a company reports its latest earnings and financials.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVSharesOutstandingResponse? GetSharesOutstandingFromJson(string json) => Serializer.LoadFromJson<AVSharesOutstandingResponse?>(json);
}
