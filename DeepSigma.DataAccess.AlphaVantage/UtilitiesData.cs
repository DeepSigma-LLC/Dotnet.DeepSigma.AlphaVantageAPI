using DeepSigma.AlphaVantageAPI.DataModels;
using DeepSigma.AlphaVantageAPI.Enums;
using DeepSigma.General.Extensions;
using DeepSigma.DataAccess.API;

namespace DeepSigma.AlphaVantageAPI
{
    /// <summary>
    /// This class contains various utility functions provided by Alpha Vantage, such as ticker search, market status, top gainers/losers, news sentiment, ETF profiles, and listings.
    /// </summary>
    public class UtilitiesData
    {
        private string api_key { get; set; }
        private Action<string?>? json_logger { get; set; } = null;
        private Action<string?>? csv_logger { get; set; } = null;
        private int timeout_seconds { get; set; }
        internal UtilitiesData(string api_key, Action<string?>? json_logger, int timeout_seconds = 15)
        {
            this.api_key = api_key;
            this.json_logger = json_logger;
            this.timeout_seconds = timeout_seconds;
        }

        /// <summary>
        /// The Search Endpoint returns the best-matching symbols and market information based on keywords of your choice. 
        /// The search results also contain match scores that provide you with the full flexibility to develop your own search and filtering logic.
        /// </summary>
        /// <param name="keyword"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVTickerSearchResponse?> GetTickerSearch(string keyword, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=SYMBOL_SEARCH&keywords={keyword}&apikey={api_key}";
            AVTickerSearchResponse? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetTickerSearchFromJson, timeout_seconds, ct, json_logger);
            return results;
        }

        /// <summary>
        /// Parses the JSON response returned by the Alpha Vantage API for Ticker Search.
        /// The Search Endpoint returns the best-matching symbols and market information based on keywords of your choice. 
        /// The search results also contain match scores that provide you with the full flexibility to develop your own search and filtering logic.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static AVTickerSearchResponse? GetTickerSearchFromJson(string json)
        {
            AVTickerSearchResponse? results = APIUtilities.LoadFromJson<AVTickerSearchResponse>(json);
            return results;
        }

        /// <summary>
        /// This endpoint returns the current market status (open vs. closed) of major trading venues for equities, forex, and cryptocurrencies around the world.
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVMarketClosureResponse?> GetGlobalMarketStatus(CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=MARKET_STATUS&apikey={api_key}";
            AVMarketClosureResponse? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetGlobalMarketStatusFromJson, timeout_seconds, ct, json_logger);
            return results;
        }

        /// <summary>
        /// Parses the JSON response returned by the Alpha Vantage API for Global Market Status.
        /// This endpoint returns the current market status (open vs. closed) of major trading venues for equities, forex, and cryptocurrencies around the world.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static AVMarketClosureResponse? GetGlobalMarketStatusFromJson(string json)
        {
            AVMarketClosureResponse? results = APIUtilities.LoadFromJson<AVMarketClosureResponse>(json);
            return results;
        }

        /// <summary>
        /// This endpoint returns the top 20 gainers, losers, and the most active traded tickers in the US market.
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVMoverResponse?> GetTopGainersAndLosers(CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=TOP_GAINERS_LOSERS&apikey={api_key}";
            AVMoverResponse? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetTopGainersAndLosersFromJson, timeout_seconds, ct, json_logger);
            return results;
        }

        /// <summary>
        /// Parses the JSON response returned by the Alpha Vantage API for Top Gainers and Losers.
        /// This endpoint returns the top 20 gainers, losers, and the most active traded tickers in the US market.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static AVMoverResponse? GetTopGainersAndLosersFromJson(string json)
        {
            AVMoverResponse? results = APIUtilities.LoadFromJson<AVMoverResponse>(json);
            return results;
        }

        /// <summary>
        /// This API returns live and historical market news and sentiment data from a large and growing selection of premier news outlets around the world, 
        /// covering stocks, cryptocurrencies, forex, and a wide range of topics such as fiscal policy, mergers and acquisitions, IPOs, etc. 
        /// This API, combined with our core stock API, fundamental data, and technical indicator APIs, can provide you with a 360-degree view of the financial market and the broader economy.
        /// </summary>
        /// <param name="symbols"></param>
        /// <param name="StartDate"></param>
        /// <param name="EndDate"></param>
        /// <param name="sort_type"></param>
        /// <param name="topics"></param>
        /// <param name="limit"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<dynamic?> GetHistroicalNews(string[] symbols, DateTime? StartDate = null, DateTime? EndDate = null, SortType sort_type = SortType.Latest, NewsTopicTypes[]? topics = null, int limit = 1000, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=NEWS_SENTIMENT&tickers={string.Join(",", symbols)}&limit={limit}&sort=LATEST&apikey={api_key}";
            
            if(StartDate.HasValue)
            {
                url += $"&time_from={StartDate.Value.ToUniversalTime().ToString()}";
            }

            if(EndDate.HasValue)
            {
                url += $"&time_to={EndDate.Value.ToUniversalTime().ToString()}";
            }

            if(topics is not null && topics.Length > 0)
            {
                url += $"&topics={string.Join(",", topics.Select(t => t.ToDescriptionString()))}";
            }

            var results = await APIUtilities.GetDataFromURLAsync<dynamic>(url, timeout_seconds, json_logger, ct);       
            return results;
        }


        /// <summary>
        /// This API returns key ETF metrics (e.g., net assets, expense ratio, and turnover), along with the corresponding ETF holdings / constituents with allocation by asset types and sectors.
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVETFProfileResponse?> GetETFProfileAndHoldings(string symbol, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=ETF_PROFILE&symbol={symbol}&apikey={api_key}";
            AVETFProfileResponse? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetETFProfileAndHoldingsFromJson, timeout_seconds, ct, json_logger);
            return results;
        }

        /// <summary>
        /// Parses the JSON response returned by the Alpha Vantage API for ETF Profile and Holdings.
        /// This API returns key ETF metrics (e.g., net assets, expense ratio, and turnover), along with the corresponding ETF holdings / constituents with allocation by asset types and sectors.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static AVETFProfileResponse? GetETFProfileAndHoldingsFromJson(string json)
        {
            AVETFProfileResponse? results = APIUtilities.LoadFromJson<AVETFProfileResponse>(json);
            return results;
        }

        /// <summary>
        /// This API returns a list of active or delisted US stocks and ETFs, either as of the latest trading day. 
        /// The endpoint is positioned to facilitate equity research on asset lifecycle and survivorship.
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<List<AVListingStatusCSVData>> GetAllActiveListings(CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=LISTING_STATUS&apikey={api_key}";
            List<AVListingStatusCSVData> results = await AlphaVantageAPIUtilities.GetAPIDataCSVFormat(url, GetListingsFromCSV, timeout_seconds, ct, csv_logger);
            return results;
        }

        /// <summary>
        /// This API returns a list of active or delisted US stocks and ETFs, either as of the latest trading day or at a specific time in history. 
        /// The endpoint is positioned to facilitate equity research on asset lifecycle and survivorship.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="listing_status"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<List<AVListingStatusCSVData>> GetAllListings(DateOnly date, ListingStatus listing_status, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=LISTING_STATUS&date={date.ToString("D")}&state={listing_status.ToDescriptionString()}&apikey={api_key}";
            List<AVListingStatusCSVData> results = await AlphaVantageAPIUtilities.GetAPIDataCSVFormat(url, GetListingsFromCSV, timeout_seconds, ct, csv_logger);
            return results;
        }


        /// <summary>
        /// Parses the CSV response returned by the Alpha Vantage API for Listing Status.
        /// This API returns a list of active or delisted US stocks and ETFs, either as of the latest trading day. 
        /// The endpoint is positioned to facilitate equity research on asset lifecycle and survivorship.
        /// </summary>
        /// <param name="csv"></param>
        /// <returns></returns>
        public static List<AVListingStatusCSVData> GetListingsFromCSV(string csv)
        {
            csv = csv.Replace(",null,", ",,");
            List<AVListingStatusCSVData> results = APIUtilities.LoadFromCSV<AVListingStatusCSVData>(csv);
            return results;
        }

        /// <summary>
        /// This API returns a list of company earnings expected in the next 3, 6, or 12 months.
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="horizon"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<List<AVEarningsCalandarCSVData>> GetEarningsCalandar(string symbol, EarningsHorizon horizon, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=EARNINGS_CALENDAR&symbol={symbol}&horizon={horizon.ToDescriptionString()}&&apikey={api_key}";
            List<AVEarningsCalandarCSVData> results = await AlphaVantageAPIUtilities.GetAPIDataCSVFormat(url, GetEarningsFromCSV, timeout_seconds, ct, csv_logger);
            return results;
        }

        /// <summary>
        /// Parses the CSV response returned by the Alpha Vantage API for Earnings Calendar.
        /// This API returns a list of company earnings expected in the next 3, 6, or 12 months.
        /// </summary>
        /// <param name="csv"></param>
        /// <returns></returns>
        public static List<AVEarningsCalandarCSVData> GetEarningsFromCSV(string csv)
        {
            List<AVEarningsCalandarCSVData> results = APIUtilities.LoadFromCSV<AVEarningsCalandarCSVData>(csv);
            return results;
        }

        /// <summary>
        /// This API returns a list of IPOs expected in the next 3 months.
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<List<AVIpoCalandarCSVData>> GetIPOCalandar(CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=IPO_CALENDAR&apikey={api_key}";
            List<AVIpoCalandarCSVData> results = await AlphaVantageAPIUtilities.GetAPIDataCSVFormat(url, GetIPOCalandarFromCSV, timeout_seconds, ct, csv_logger);
            return results;
        }

        /// <summary>
        /// Parses the CSV response returned by the Alpha Vantage API for IPO Calendar.
        /// This API returns a list of IPOs expected in the next 3 months.
        /// </summary>
        /// <param name="csv"></param>
        /// <returns></returns>
        public static List<AVIpoCalandarCSVData> GetIPOCalandarFromCSV(string csv)
        {
            List<AVIpoCalandarCSVData> results = APIUtilities.LoadFromCSV<AVIpoCalandarCSVData>(csv);
            return results;
        }
    }
}
