using DeepSigma.DataAccess.AlphaVantage.DataModels;
using DeepSigma.DataAccess.AlphaVantage.Enums;
using DeepSigma.General.Extensions;
using DeepSigma.DataAccess.API;

namespace DeepSigma.DataAccess.AlphaVantage
{
    public class UtilitiesData
    {
        private string api_key { get; set; }
        private Action<string?>? json_logger { get; set; } = null;
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
        /// <typeparam name="T"></typeparam>
        /// <param name="keyword"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<T?> GetTickerSearch<T>(string keyword, DataReturnType return_type = DataReturnType.Json, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=SYMBOL_SEARCH&keywords={keyword}&datatype={return_type.ToDescriptionString()}&apikey={api_key}";
            var results = await APIUtilities.GetDataAsync<T>(url, cancel_token: ct);
            return results;
        }

        /// <summary>
        /// This endpoint returns the current market status (open vs. closed) of major trading venues for equities, forex, and cryptocurrencies around the world.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<T?> GetGlobalMarketStatus<T>(CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=MARKET_STATUS&apikey={api_key}";
            var results = await APIUtilities.GetDataAsync<T>(url, cancel_token: ct);
            return results;
        }

        /// <summary>
        /// This endpoint returns the top 20 gainers, losers, and the most active traded tickers in the US market.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<T?> GetTopGainersAndLosers<T>(CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=TOP_GAINERS_LOSERS&apikey={api_key}";
            var results = await APIUtilities.GetDataAsync<T>(url, cancel_token: ct);
            return results;
        }

        /// <summary>
        /// This API returns live and historical market news & sentiment data from a large & growing selection of premier news outlets around the world, 
        /// covering stocks, cryptocurrencies, forex, and a wide range of topics such as fiscal policy, mergers & acquisitions, IPOs, etc. 
        /// This API, combined with our core stock API, fundamental data, and technical indicator APIs, can provide you with a 360-degree view of the financial market and the broader economy.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="symbols"></param>
        /// <param name="StartDate"></param>
        /// <param name="EndDate"></param>
        /// <param name="sort_type"></param>
        /// <param name="topics"></param>
        /// <param name="limit"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<T?> GetHistroicalNews<T>(string[] symbols, DateTime? StartDate = null, DateTime? EndDate = null, SortType sort_type = SortType.Latest, NewsTopicTypes[]? topics = null, int limit = 1000, CancellationToken ct = default)
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

            var results = await APIUtilities.GetDataAsync<T>(url, cancel_token: ct);
            return results;
        }


        /// <summary>
        /// This API returns key ETF metrics (e.g., net assets, expense ratio, and turnover), along with the corresponding ETF holdings / constituents with allocation by asset types and sectors.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="symbol"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVETFProfileResponse?> GetETFProfileAndHoldings(string symbol, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=ETF_PROFILE&symbol=symbol&apikey={api_key}";
            AVETFProfileResponse? results = await APIUtilities.GetDataFromURLAsync<AVETFProfileResponse>(url, timeout_seconds, json_logger, ct);
            return results;
        }


        public async Task<List<T>> GetAllActiveListings<T>(CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=LISTING_STATUS&apikey={api_key}";
            var results = await APIUtilities.GetCsvDataAsync<T>(url, cancel_token: ct);
            return results;
        }


        public async Task<List<T>> GetAllListings<T>(DateOnly date, ListingStatus listing_status, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=LISTING_STATUS&date={date.ToString("D")}&state={listing_status.ToDescriptionString()}&apikey={api_key}";
            var results = await APIUtilities.GetCsvDataAsync<T>(url, cancel_token: ct);
            return results;
        }


        public async Task<List<T>> GetEarningsCalandar<T>(string symbol, EarningsHorizon horizon, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=EARNINGS_CALENDAR&symbol={symbol}&horizon={horizon.ToDescriptionString()}&&apikey={api_key}";
            var results = await APIUtilities.GetCsvDataAsync<T>(url, cancel_token: ct);
            return results;
        }


        public async Task<List<T>> GetIPOCalandar<T>(DateOnly date, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=IPO_CALENDAR&apikey={api_key}";
            var results = await APIUtilities.GetCsvDataAsync<T>(url, cancel_token: ct);
            return results;
        }


    }
}
