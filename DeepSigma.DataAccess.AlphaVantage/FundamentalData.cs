using DeepSigma.DataAccess.AlphaVantage.DataModels;
using DeepSigma.DataAccess.AlphaVantage.Enums;
using DeepSigma.DataAccess.API;
using DeepSigma.General.Extensions;

namespace DeepSigma.DataAccess.AlphaVantage
{
    /// <summary>
    /// This class contains methods to access fundamental data from the Alpha Vantage API.
    /// </summary>
    public class FundamentalData
    {
        private string api_key { get; set; }
        private Action<string?>? json_logger { get; set; } = null;
        private int timeout_seconds { get; set; }
        internal FundamentalData(string api_key, Action<string?>? json_logger, int timeout_seconds = 15)
        {
            this.api_key = api_key;
            this.json_logger = json_logger;
            this.timeout_seconds = timeout_seconds;
        }

        /// <summary>
        /// This API returns the company information, financial ratios, and other key metrics for the equity specified. 
        /// Data is generally refreshed on the same day a company reports its latest earnings and financials.
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVComanyOverview?> GetCompanyOverview(string symbol, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=OVERVIEW&symbol={symbol}&apikey={api_key}";
            AVComanyOverview? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetCompanyOverviewFromJson, timeout_seconds, ct, json_logger);
            return results;
        }

        /// <summary>
        /// Parses the JSON response returned by the Alpha Vantage API for Company Overview.
        /// This API returns the company information, financial ratios, and other key metrics for the equity specified. 
        /// Data is generally refreshed on the same day a company reports its latest earnings and financials.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static AVComanyOverview? GetCompanyOverviewFromJson(string json)
        {
            AVComanyOverview? results = APIUtilities.LoadFromJson<AVComanyOverview?>(json);
            return results;
        }

        /// <summary>
        /// This API returns the latest and historical insider transactions made by key stakeholders (e.g., founders, executives, board members, etc.) of a specific company.
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVInsiderTransactionData>?> GetInsiderTransactions(string symbol, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=INSIDER_TRANSACTIONS&symbol={symbol}&apikey={api_key}";
            AVDataRequest<AVInsiderTransactionData>? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetInsiderTransactionsFromJson, timeout_seconds, ct, json_logger);
            return results;
        }

        /// <summary>
        /// Parses the JSON response returned by the Alpha Vantage API for Insider Transactions.
        /// This API returns the latest and historical insider transactions made by key stakeholders (e.g., founders, executives, board members, etc.) of a specific company.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static AVDataRequest<AVInsiderTransactionData>? GetInsiderTransactionsFromJson(string json)
        {
            AVDataRequest<AVInsiderTransactionData>? results = APIUtilities.LoadFromJson<AVDataRequest<AVInsiderTransactionData>?>(json);
            return results;
        }

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
            string url = $"https://www.alphavantage.co/query?function=EARNINGS_CALL_TRANSCRIPT&symbol={symbol}&quarter={year}Q{quarter}&apikey={api_key}";
            AVTranscriptResponse? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetEarningsTranscriptFromJson, timeout_seconds, ct, json_logger);
            return results;
        }

        /// <summary>
        /// Parses the JSON response returned by the Alpha Vantage API for Earnings Call Transcript.
        /// This API returns the earnings call transcript for a given company in a specific quarter, covering over 15 years of history and enriched with LLM-based sentiment signals.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static AVTranscriptResponse? GetEarningsTranscriptFromJson(string json)
        {
            AVTranscriptResponse? results = APIUtilities.LoadFromJson<AVTranscriptResponse?>(json);
            return results;
        }

        /// <summary>
        /// This API returns historical and future (declared) dividend distributions.
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDividendHistoryResponse?> GetDividends(string symbol, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=DIVIDENDS&symbol={symbol}&apikey={api_key}";
            AVDividendHistoryResponse? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetDividendsFromJson, timeout_seconds, ct, json_logger);
            return results;
        }

        /// <summary>
        /// Parses the JSON response returned by the Alpha Vantage API for Dividends.
        /// This API returns historical and future (declared) dividend distributions.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static AVDividendHistoryResponse? GetDividendsFromJson(string json)
        {
            AVDividendHistoryResponse? results = APIUtilities.LoadFromJson<AVDividendHistoryResponse?>(json);
            return results;
        }

        /// <summary>
        /// This API returns historical split events.
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVStockSplitResponse?> GetStockSplits(string symbol, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=SPLITS&symbol={symbol}&apikey={api_key}";
            AVStockSplitResponse? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetStockSplitsFromJson, timeout_seconds, ct, json_logger);
            return results;
        }

        /// <summary>
        /// Parses the JSON response returned by the Alpha Vantage API for Stock Splits.
        /// This API returns historical split events.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static AVStockSplitResponse? GetStockSplitsFromJson(string json)
        {
            AVStockSplitResponse? results = APIUtilities.LoadFromJson<AVStockSplitResponse?>(json);
            return results;
        }

        /// <summary>
        /// This API returns the annual and quarterly income statements for the company of interest, with normalized fields mapped to GAAP and IFRS taxonomies of the SEC. 
        /// Data is generally refreshed on the same day a company reports its latest earnings and financials.
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVIncomeStatementResponse?> GetIncomeStatement(string symbol, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=INCOME_STATEMENT&symbol={symbol}&apikey={api_key}";
            AVIncomeStatementResponse? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetIncomeStatementFromJson, timeout_seconds, ct, json_logger);
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
            AVIncomeStatementResponse? results = APIUtilities.LoadFromJson<AVIncomeStatementResponse?>(json);
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
            string url = $"https://www.alphavantage.co/query?function=BALANCE_SHEET&symbol={symbol}&apikey={api_key}";
            AVBalanceSheetResponse? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetBalanceSheetFromJson, timeout_seconds, ct, json_logger);
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
            AVBalanceSheetResponse? results = APIUtilities.LoadFromJson<AVBalanceSheetResponse?>(json);
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
            string url = $"https://www.alphavantage.co/query?function=CASH_FLOW&symbol={symbol}&apikey={api_key}";
            AVCashFlowResponse? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetCashFlowFromJson, timeout_seconds, ct, json_logger);
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
            AVCashFlowResponse? results = APIUtilities.LoadFromJson<AVCashFlowResponse?>(json);
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
            string url = $"https://www.alphavantage.co/query?function=EARNINGS&symbol={symbol}&apikey={api_key}";
            AVEarningsHistroyResponse? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetEarningsHistoryFromJson, timeout_seconds, ct, json_logger);
            return results;
        }

        /// <summary>
        /// Parses the JSON response returned by the Alpha Vantage API for Earnings History.
        /// This API returns the annual and quarterly earnings (EPS) for the company of interest. 
        /// Quarterly data also includes analyst estimates and surprise metrics.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static AVEarningsHistroyResponse? GetEarningsHistoryFromJson(string json)
        {
            AVEarningsHistroyResponse? results = APIUtilities.LoadFromJson<AVEarningsHistroyResponse?>(json);
            return results;
        }

        /// <summary>
        /// This API returns the annual and quarterly EPS and revenue estimates for the company of interest, along with analyst count and revision history.
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVEarningsEstimateResponse?> GetEarningsEstimate(string symbol, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=EARNINGS_ESTIMATES&symbol={symbol}&apikey={api_key}";
            AVEarningsEstimateResponse? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetEarningsEstimateFromJson, timeout_seconds, ct, json_logger);
            return results;
        }

        /// <summary>
        /// Parses the JSON response returned by the Alpha Vantage API for Earnings Estimate.
        /// This API returns the annual and quarterly EPS and revenue estimates for the company of interest, along with analyst count and revision history.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static AVEarningsEstimateResponse? GetEarningsEstimateFromJson(string json)
        {
            AVEarningsEstimateResponse? results = APIUtilities.LoadFromJson<AVEarningsEstimateResponse?>(json);
            return results;
        }
    }
}
