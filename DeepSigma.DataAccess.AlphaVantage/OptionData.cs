using DeepSigma.DataAccess.AlphaVantage.DataModels;
using DeepSigma.DataAccess.AlphaVantage.Enums;
using DeepSigma.DataAccess.API;

namespace DeepSigma.DataAccess.AlphaVantage
{
    /// <summary>
    /// This class contains methods to access option data from the Alpha Vantage API.
    /// </summary>
    public class OptionData
    {
        private string api_key { get; set; }
        private Action<string?>? json_logger { get; set; } = null;
        private int timeout_seconds { get; set; }
        internal OptionData(string api_key, Action<string?>? json_logger, int timeout_seconds = 15)
        {
            this.api_key = api_key;
            this.json_logger = json_logger;
            this.timeout_seconds = timeout_seconds;
        }

        /// <summary>
        /// This API returns realtime US options data with full market coverage. 
        /// Option chains are sorted by expiration dates in chronological order. 
        /// Within the same expiration date, contracts are sorted by strike prices from low to high.
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="return_type"></param>
        /// <param name="ct"></param>
        /// <param name="specific_option_contract"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVOptionData>?> GetRealTimeOptionData(string symbol, DataReturnType return_type = DataReturnType.Json, CancellationToken ct = default, string? specific_option_contract = null)
        {
            string contract_paramater = string.Empty;
            if (specific_option_contract is not null)
            {
                contract_paramater = $"&contract={specific_option_contract}";
            }
            string url = $"https://www.alphavantage.co/query?function=REALTIME_OPTIONS&symbol={symbol}&require_greeks=true{contract_paramater}&apikey={api_key}";
            AVDataRequest<AVOptionData>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVOptionData>>(url, timeout_seconds, json_logger, ct);
            return results;
        }

        /// <summary>
        /// This API returns the full historical options chain for a specific symbol on a specific date, covering 15+ years of history. 
        /// Implied volatility (IV) and common Greeks (e.g., delta, gamma, theta, vega, rho) are also returned. 
        /// Option chains are sorted by expiration dates in chronological order. Within the same expiration date, contracts are sorted by strike prices from low to high.
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="date"></param>
        /// <param name="return_type"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVOptionData>?> GetHistoricalOptionData(string symbol, DateOnly date, DataReturnType return_type = DataReturnType.Json, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=HISTORICAL_OPTIONS&symbol={symbol}&date={date.ToString("D")}&apikey={api_key}";
            AVDataRequest<AVOptionData>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVOptionData>>(url, timeout_seconds, json_logger, ct);
            return results;
        }

    }
}
