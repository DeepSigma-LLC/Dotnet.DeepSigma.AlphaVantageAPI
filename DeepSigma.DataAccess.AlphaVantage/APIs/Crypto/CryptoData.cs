using DeepSigma.AlphaVantageAPI.Models;
using DeepSigma.AlphaVantageAPI.Enums;
using DeepSigma.DataAccess.Web;
using DeepSigma.Core.Extensions;
using DeepSigma.AlphaVantageAPI.APIs.FX.Models;

namespace DeepSigma.AlphaVantageAPI.APIs.Crypto;

/// <summary>
/// This class contains methods to access cryptocurrency data from the Alpha Vantage API.
/// </summary>
public class CryptoData(HttpClient client, ApiOptions options) : AbstractDataAPI(client, options)
{
 
    /// <summary>
    /// This API returns the realtime exchange rate for any pair of digital currency (e.g., Bitcoin) or physical currency (e.g., USD).
    /// </summary>
    /// <param name="base_currency"></param>
    /// <param name="local_currnecy"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVCurrencyExchangeRateQuoteResponse?> GetExchangeRate(string base_currency, string local_currnecy, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=CURRENCY_EXCHANGE_RATE&from_currency={local_currnecy}&to_currency={base_currency}&apikey={Options.APIKey}";
        AVCurrencyExchangeRateQuoteResponse? results = await Utilities.GetAPIData(url, GetExchangeRateFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON string returned by the Alpha Vantage API for exchange rate data.
    /// This API returns the realtime exchange rate for any pair of digital currency (e.g., Bitcoin) or physical currency (e.g., USD).
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVCurrencyExchangeRateQuoteResponse? GetExchangeRateFromJson(string json)
    {
        AVCurrencyExchangeRateQuoteResponse? results = Serializer.LoadFromJson<AVCurrencyExchangeRateQuoteResponse>(json);
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
        string url = $"https://www.alphavantage.co/query?function=CRYPTO_INTRADAY&symbol={symbol}&market={currency}&interval={interval.ToDescriptionString()}&outputsize={output_size.ToDescriptionString()}&apikey={Options.APIKey}";
        AVTimeSeriesResponseGeneric<AVBar>? results = await Utilities.GetAPIData(url, GetExchangeRatesIntradayFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON string returned by the Alpha Vantage API for intraday time series data.
    /// This API returns intraday time series (timestamp, open, high, low, close, volume) of the cryptocurrency specified, updated realtime.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVTimeSeriesResponseGeneric<AVBar>? GetExchangeRatesIntradayFromJson(string json)
    {
        return AlphaVantageAPIUtilities.JsonParserToTimeSeriesResult(json);
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
        string url = $"https://www.alphavantage.co/query?function=DIGITAL_CURRENCY_DAILY&symbol={symbol}&market={currency}&apikey={Options.APIKey}";
        AVTimeSeriesResponseGeneric<AVBar>? results = await Utilities.GetAPIData(url, GetExchangeRatesDailyFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON string returned by the Alpha Vantage API for daily time series data.
    /// This API returns the daily historical time series for a digital currency (e.g., BTC) traded on a specific market (e.g., EUR/Euro), refreshed daily at midnight (UTC). 
    /// Prices and volumes are quoted in both the market-specific currency and USD.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVTimeSeriesResponseGeneric<AVBar>? GetExchangeRatesDailyFromJson(string json)
    {
        return AlphaVantageAPIUtilities.JsonParserToTimeSeriesResult(json);
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
        string url = $"https://www.alphavantage.co/query?function=DIGITAL_CURRENCY_WEEKLY&symbol={symbol}&market={currency}&apikey={Options.APIKey}";
        AVTimeSeriesResponseGeneric<AVBar>? results = await Utilities.GetAPIData(url, GetExchangeRatesWeeklyFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    ///  Parses the JSON string returned by the Alpha Vantage API for weekly time series data.
    /// This API returns the weekly historical time series for a digital currency (e.g., BTC) traded on a specific market (e.g., EUR/Euro), refreshed daily at midnight (UTC). 
    /// Prices and volumes are quoted in both the market-specific currency and USD.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVTimeSeriesResponseGeneric<AVBar>? GetExchangeRatesWeeklyFromJson(string json)
    {
        return AlphaVantageAPIUtilities.JsonParserToTimeSeriesResult(json);
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
        string url = $"https://www.alphavantage.co/query?function=DIGITAL_CURRENCY_MONTHLY&symbol={symbol}&market={currency}&apikey={Options.APIKey}";
        AVTimeSeriesResponseGeneric<AVBar>? results = await Utilities.GetAPIData(url, GetExchangeRatesMonthlyFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON string returned by the Alpha Vantage API for monthly time series data.
    /// This API returns the monthly historical time series for a digital currency (e.g., BTC) traded on a specific market (e.g., EUR/Euro), refreshed daily at midnight (UTC). 
    /// Prices and volumes are quoted in both the market-specific currency and USD.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVTimeSeriesResponseGeneric<AVBar>? GetExchangeRatesMonthlyFromJson(string json)
    {
        return AlphaVantageAPIUtilities.JsonParserToTimeSeriesResult(json);
    }
}
