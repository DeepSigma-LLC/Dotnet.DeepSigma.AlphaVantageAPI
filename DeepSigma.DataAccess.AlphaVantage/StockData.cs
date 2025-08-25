using DeepSigma.DataAccess.AlphaVantage.DataModels;
using DeepSigma.DataAccess.AlphaVantage.Enums;
using DeepSigma.DataAccess.API;
using DeepSigma.General.Extensions;

namespace DeepSigma.DataAccess.AlphaVantage
{
    /// <summary>
    /// This class contains methods to access stock data from the Alpha Vantage API.
    /// </summary>
    public class StockData
    {
        private string api_key { get; set; }
        private Action<string?>? json_logger { get; set; } = null;
        private int timeout_seconds { get; set; }
        internal StockData(string api_key, Action<string?>? json_logger, int timeout_seconds = 15)
        {
            this.api_key = api_key;
            this.json_logger = json_logger;
            this.timeout_seconds = timeout_seconds;
        }

        /// <summary>
        /// This API returns current and 20+ years of historical intraday OHLCV time series of the equity specified, 
        /// covering pre-market and post-market hours where applicable (e.g., 4:00am to 8:00pm Eastern Time for the US market). 
        /// You can query both raw (as-traded) and split/dividend-adjusted intraday data from this endpoint. The OHLCV data is sometimes called "candles" in finance literature.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="symbol"></param>
        /// <param name="interval"></param>
        /// <param name="output_size"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVTimeSeriesResponseGeneric<AVBar>?> GetIntradayTimeSeriesData(string symbol, TimeSeriesIntradayInterval interval = TimeSeriesIntradayInterval.Fifteen, OutputSize output_size = OutputSize.Full, bool extended_hours = true, DateOnly? selected_month = null, CancellationToken ct = default)
        {
            string parameter = string.Empty;
            if (selected_month.HasValue)
            {
                parameter = $"&month={selected_month.Value.Year}-{selected_month.Value.Month}";
            }
            string url = $"https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol={symbol}&interval={interval.ToDescriptionString()}&outputsize={output_size.ToDescriptionString()}&extended_hours={extended_hours}{parameter}&apikey={api_key}";
            AVTimeSeriesResponseGeneric<AVBar>? results = await APIUtilities.GetDataFromURLAsync<AVTimeSeriesResponseGeneric<AVBar>>(url, timeout_seconds, json_logger, ct);
            return results;
        }

        /// <summary>
        /// This API returns raw (as-traded) daily time series (date, daily open, daily high, daily low, daily close, daily volume) of the global equity specified, 
        /// covering 20+ years of historical data. The OHLCV data is sometimes called "candles" in finance literature. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="symbol"></param>
        /// <param name="output_size"></param>
        /// <param name="return_type"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVTimeSeriesResponseGeneric<AVBar>?> GetDailyTimeSeriesData(string symbol, OutputSize output_size = OutputSize.Full, DataReturnType return_type = DataReturnType.Json, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=TIME_SERIES_DAILY_ADJUSTED&symbol={symbol}&outputsize={output_size.ToDescriptionString()}&datatype={return_type.ToDescriptionString()}&apikey={api_key}";
            AVTimeSeriesResponseGeneric<AVBar>? results = await APIUtilities.GetDataFromURLAsync<AVTimeSeriesResponseGeneric<AVBar>>(url, timeout_seconds, json_logger, ct);
            return results;
        }

        /// <summary>
        /// This API returns weekly time series (last trading day of each week, weekly open, weekly high, weekly low, weekly close, weekly volume) of the global equity specified, covering 20+ years of historical data.
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="return_type"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVTimeSeriesResponseGeneric<AVBar>?> GetWeeklyTimeSeriesData(string symbol, DataReturnType return_type = DataReturnType.Json, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=TIME_SERIES_WEEKLY_ADJUSTED&symbol={symbol}&datatype={return_type.ToDescriptionString()}&apikey={api_key}";
            AVTimeSeriesResponseGeneric<AVBar>? results = await APIUtilities.GetDataFromURLAsync<AVTimeSeriesResponseGeneric<AVBar>>(url, timeout_seconds, json_logger, ct);
            return results;
        }

        /// <summary>
        /// This API returns monthly adjusted time series (last trading day of each month, monthly open, monthly high, monthly low, monthly close, monthly adjusted close, monthly volume, monthly dividend) 
        /// of the equity specified, covering 20+ years of historical data.
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="return_type"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVTimeSeriesResponseGeneric<AVBar>?> GetMonthlyTimeSeriesData(string symbol, DataReturnType return_type = DataReturnType.Json, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=TIME_SERIES_MONTHLY_ADJUSTED&symbol={symbol}&datatype={return_type.ToDescriptionString()}&apikey={api_key}";
            AVTimeSeriesResponseGeneric<AVBar>? results = await APIUtilities.GetDataFromURLAsync<AVTimeSeriesResponseGeneric<AVBar>>(url, timeout_seconds, json_logger, ct);
            return results;
        }

        /// <summary>
        /// This API returns realtime quotes for US-traded symbols in bulk, accepting up to 100 symbols per API request and covering both regular and extended (pre-market and post-market) trading hours.
        /// You can use this endpoint as a high-throughput alternative to the Global Quote API, which accepts one symbol per API request.
        /// </summary>
        /// <param name="symbols"></param>
        /// <param name="return_type"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVBulkQuoteData>?> GetBulkRealTimeQuoteData(string[] symbols, DataReturnType return_type = DataReturnType.Json, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=REALTIME_BULK_QUOTES&symbol={string.Join(",", symbols)}&datatype={return_type.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVBulkQuoteData>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVBulkQuoteData>>(url, timeout_seconds, json_logger, ct);
            return results;
        }
    }
}
