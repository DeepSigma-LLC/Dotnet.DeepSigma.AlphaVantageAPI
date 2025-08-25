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
            AVComanyOverview? results = await APIUtilities.GetDataFromURLAsync<AVComanyOverview>(url, timeout_seconds, json_logger, ct);
            return results;
        }

        /// <summary>
        /// This API returns the latest and historical insider transactions made by key stakeholders (e.g., founders, executives, board members, etc.) of a specific company.
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVInsiderTransactionData>?> GetInsiderTransactions<T>(string symbol, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=INSIDER_TRANSACTIONS&symbol={symbol}&apikey={api_key}";
            AVDataRequest<AVInsiderTransactionData>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVInsiderTransactionData>>(url, timeout_seconds, json_logger, ct);
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
            AVTranscriptResponse? results = await APIUtilities.GetDataFromURLAsync<AVTranscriptResponse>(url, timeout_seconds, json_logger, ct);
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
            AVDividendHistoryResponse? results = await APIUtilities.GetDataFromURLAsync<AVDividendHistoryResponse>(url, timeout_seconds, json_logger, ct);
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
            AVStockSplitResponse? results = await APIUtilities.GetDataFromURLAsync<AVStockSplitResponse>(url, timeout_seconds, json_logger, ct);
            return results;
        }

        /// <summary>
        /// This API returns the annual and quarterly income statements for the company of interest, with normalized fields mapped to GAAP and IFRS taxonomies of the SEC. 
        /// Data is generally refreshed on the same day a company reports its latest earnings and financials.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="symbol"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVIncomeStatementResponse?> GetIncomeStatement(string symbol, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=INCOME_STATEMENT&symbol={symbol}&apikey={api_key}";
            AVIncomeStatementResponse? results = await APIUtilities.GetDataFromURLAsync<AVIncomeStatementResponse>(url, timeout_seconds, json_logger, ct);
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
            AVBalanceSheetResponse? results = await APIUtilities.GetDataFromURLAsync<AVBalanceSheetResponse>(url, timeout_seconds, json_logger, ct);
            return results;
        }

        /// <summary>
        /// This API returns the annual and quarterly cash flow for the company of interest, with normalized fields mapped to GAAP and IFRS taxonomies of the SEC. 
        /// Data is generally refreshed on the same day a company reports its latest earnings and financials.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="symbol"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVCashFlowResponse?> GetCashFlow<T>(string symbol, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=CASH_FLOW&symbol={symbol}&apikey={api_key}";
            AVCashFlowResponse? results = await APIUtilities.GetDataFromURLAsync<AVCashFlowResponse?>(url, timeout_seconds, json_logger, ct);
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
            AVEarningsHistroyResponse? results = await APIUtilities.GetDataFromURLAsync<AVEarningsHistroyResponse>(url, timeout_seconds, json_logger, ct);
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
            AVEarningsEstimateResponse? results = await APIUtilities.GetDataFromURLAsync<AVEarningsEstimateResponse>(url, timeout_seconds, json_logger, ct);
            return results;
        }


    }
}
