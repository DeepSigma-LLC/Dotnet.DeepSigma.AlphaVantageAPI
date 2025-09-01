using DeepSigma.DataAccess.AlphaVantage.DataModels;
using DeepSigma.DataAccess.AlphaVantage.Enums;
using DeepSigma.DataAccess.AlphaVantage.Parsers;
using DeepSigma.DataAccess.API;
using DeepSigma.General.Extensions;

namespace DeepSigma.DataAccess.AlphaVantage
{
    /// <summary>
    /// This class contains methods to access cryptocurrency data from the Alpha Vantage API.
    /// </summary>
    public class CryptoData
    {
        private string api_key { get; set; }
        private Action<string?>? json_logger { get; set; } = null;
        private int timeout_seconds { get; set; }
        internal CryptoData(string api_key, Action<string?>? json_logger, int timeout_seconds = 15)
        {
            this.api_key = api_key;
            this.json_logger = json_logger;
            this.timeout_seconds = timeout_seconds;
        }

        /// <summary>
        /// This API returns the realtime exchange rate for any pair of digital currency (e.g., Bitcoin) or physical currency (e.g., USD).
        /// </summary>
        /// <param name="base_currency"></param>
        /// <param name="local_currnecy"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVCurrencyExchangeRateQuoteResponse?> GetExchangeRate(string base_currency, string local_currnecy, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=CURRENCY_EXCHANGE_RATE&from_currency={local_currnecy}&to_currency={base_currency}&apikey={api_key}";
            string? json = await APIUtilities.GetJsonResponseAsync(url, timeout_seconds,  ct);
            if(json_logger is not null)
            {
                json_logger(json);
            }
            AVCurrencyExchangeRateQuoteResponse? results = GetExchangeRateFromJson(json ?? string.Empty);
            return results;
        }

        /// <summary>
        /// Parses the JSON string returned by the Alpha Vantage API for exchange rate data.
        /// This API returns the realtime exchange rate for any pair of digital currency (e.g., Bitcoin) or physical currency (e.g., USD).
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public AVCurrencyExchangeRateQuoteResponse? GetExchangeRateFromJson(string json)
        {
            AVCurrencyExchangeRateQuoteResponse? results = APIUtilities.LoadFromJson<AVCurrencyExchangeRateQuoteResponse>(json);
            return results;
        }


        /// <summary>
        /// This API returns intraday time series (timestamp, open, high, low, close, volume) of the cryptocurrency specified, updated realtime.
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="currency"></param>
        /// <param name="interval"></param>
        /// <param name="output_size"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVTimeSeriesResponseGeneric<AVBar>?> GetExchangeRatesIntraday(string symbol, string currency, TimeSeriesIntradayInterval interval = TimeSeriesIntradayInterval.Fifteen, OutputSize output_size = OutputSize.Full, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=CRYPTO_INTRADAY&symbol={symbol}&market={currency}&interval={interval.ToDescriptionString()}&outputsize={output_size.ToDescriptionString()}&apikey={api_key}";
            string? json = await APIUtilities.GetJsonResponseAsync(url, timeout_seconds, ct);
            if (json_logger is not null)
            {
                json_logger(json);
            }
            AVTimeSeriesResponseGeneric<AVBar>? results = GetExchangeRatesIntradayFromJson(json ?? string.Empty);
            return results;
        }

        /// <summary>
        /// Parses the JSON string returned by the Alpha Vantage API for intraday time series data.
        /// This API returns intraday time series (timestamp, open, high, low, close, volume) of the cryptocurrency specified, updated realtime.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public AVTimeSeriesResponseGeneric<AVBar>? GetExchangeRatesIntradayFromJson(string json)
        {
            return AlphaVantageAPIUtilities.JsonToResult(json);
        }

        /// <summary>
        /// This API returns the daily historical time series for a digital currency (e.g., BTC) traded on a specific market (e.g., EUR/Euro), refreshed daily at midnight (UTC). 
        /// Prices and volumes are quoted in both the market-specific currency and USD.
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="currency"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVTimeSeriesResponseGeneric<AVBar>?> GetExchangeRatesDaily(string symbol, string currency, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=DIGITAL_CURRENCY_DAILY&symbol={symbol}&market={currency}&apikey={api_key}";
            AVTimeSeriesResponseGenericParser<AVBar>? results = await APIUtilities.GetDataFromURLAsync<AVTimeSeriesResponseGenericParser<AVBar>>(url, timeout_seconds, json_logger, ct);

            if (results is null) return null;
            results.SetParser(AVBarParser.Parse);

            AVTimeSeriesResponseGeneric<AVBar> final_results = new(results.GetSeries(), results.GetMetaData());
            return final_results;
        }

        /// <summary>
        /// Parses the JSON string returned by the Alpha Vantage API for daily time series data.
        /// This API returns the daily historical time series for a digital currency (e.g., BTC) traded on a specific market (e.g., EUR/Euro), refreshed daily at midnight (UTC). 
        /// Prices and volumes are quoted in both the market-specific currency and USD.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public AVTimeSeriesResponseGeneric<AVBar>? GetExchangeRatesDailyFromJson(string json)
        {
            return AlphaVantageAPIUtilities.JsonToResult(json);
        }

        /// <summary>
        /// This API returns the weekly historical time series for a digital currency (e.g., BTC) traded on a specific market (e.g., EUR/Euro), refreshed daily at midnight (UTC). 
        /// Prices and volumes are quoted in both the market-specific currency and USD.
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="currency"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVTimeSeriesResponseGeneric<AVBar>?> GetExchangeRatesWeekly(string symbol, string currency, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=DIGITAL_CURRENCY_WEEKLY&symbol={symbol}&market={currency}&apikey={api_key}";
            AVTimeSeriesResponseGenericParser<AVBar>? results = await APIUtilities.GetDataFromURLAsync<AVTimeSeriesResponseGenericParser<AVBar>>(url, timeout_seconds, json_logger, ct);

            if (results is null) return null;
            results.SetParser(AVBarParser.Parse);

            AVTimeSeriesResponseGeneric<AVBar> final_results = new(results.GetSeries(), results.GetMetaData());
            return final_results;
        }

        /// <summary>
        ///  Parses the JSON string returned by the Alpha Vantage API for weekly time series data.
        /// This API returns the weekly historical time series for a digital currency (e.g., BTC) traded on a specific market (e.g., EUR/Euro), refreshed daily at midnight (UTC). 
        /// Prices and volumes are quoted in both the market-specific currency and USD.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public AVTimeSeriesResponseGeneric<AVBar>? GetExchangeRatesWeeklyFromJson(string json)
        {
            return AlphaVantageAPIUtilities.JsonToResult(json);
        }

        /// <summary>
        /// This API returns the monthly historical time series for a digital currency (e.g., BTC) traded on a specific market (e.g., EUR/Euro), refreshed daily at midnight (UTC). 
        /// Prices and volumes are quoted in both the market-specific currency and USD.
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="currency"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVTimeSeriesResponseGeneric<AVBar>?> GetExchangeRatesMonthly(string symbol, string currency, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=DIGITAL_CURRENCY_MONTHLY&symbol={symbol}&market={currency}&apikey={api_key}";
            AVTimeSeriesResponseGenericParser<AVBar>? results = await APIUtilities.GetDataFromURLAsync<AVTimeSeriesResponseGenericParser<AVBar>>(url, timeout_seconds, json_logger, ct);

            if (results is null) return null;
            results.SetParser(AVBarParser.Parse);

            AVTimeSeriesResponseGeneric<AVBar> final_results = new(results.GetSeries(), results.GetMetaData());
            return final_results;
        }

        /// <summary>
        /// Parses the JSON string returned by the Alpha Vantage API for monthly time series data.
        /// This API returns the monthly historical time series for a digital currency (e.g., BTC) traded on a specific market (e.g., EUR/Euro), refreshed daily at midnight (UTC). 
        /// Prices and volumes are quoted in both the market-specific currency and USD.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public AVTimeSeriesResponseGeneric<AVBar>? GetExchangeRatesMonthlyFromJson(string json)
        {
            return AlphaVantageAPIUtilities.JsonToResult(json);
        }

    }
}
