using DeepSigma.AlphaVantageAPI.DataModels;
using DeepSigma.AlphaVantageAPI.Enums;
using DeepSigma.DataAccess.API;
using DeepSigma.General.Extensions;

namespace DeepSigma.AlphaVantageAPI;

/// <summary>
/// This class contains methods to access foreign exchange (FX) data from the Alpha Vantage API.
/// </summary>
public class FXData
{
    private string api_key { get; set; }
    private Action<string?>? json_logger { get; set; } = null;
    private int timeout_seconds { get; set; }
    internal FXData(string api_key, Action<string?>? json_logger, int timeout_seconds = 15)
    {
        this.api_key = api_key;
        this.json_logger = json_logger;
        this.timeout_seconds = timeout_seconds;
    }

    /// <summary>
    /// This API returns the realtime exchange rate for any pair of 2 currencies. For example, USD vs JPY or digital currency (e.g., Bitcoin) vs physical currency (e.g., USD).
    /// </summary>
    /// <param name="base_currency"></param>
    /// <param name="local_currnecy"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVCurrencyExchangeRateQuoteResponse?> GetExchangeRate(string base_currency, string local_currnecy, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=CURRENCY_EXCHANGE_RATE&from_currency={local_currnecy}&to_currency={base_currency}&apikey={api_key}";
        AVCurrencyExchangeRateQuoteResponse? results = await APIUtilities.GetDataFromURLAsync<AVCurrencyExchangeRateQuoteResponse>(url, timeout_seconds, json_logger, ct);
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
        AVCurrencyExchangeRateQuoteResponse? results = APIUtilities.LoadFromJson<AVCurrencyExchangeRateQuoteResponse>(json);
        return results;
    }

    /// <summary>
    /// This API returns intraday time series (timestamp, open, high, low, close) of the FX currency pair specified, updated realtime.
    /// </summary>
    /// <param name="base_currency"></param>
    /// <param name="local_currnecy"></param>
    /// <param name="interval"></param>
    /// <param name="output_size"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVTimeSeriesResponseGeneric<AVBar>?> GetExchangeRatesIntraday(string base_currency, string local_currnecy, TimeSeriesIntradayInterval interval = TimeSeriesIntradayInterval.Fifteen, OutputSize output_size = OutputSize.Full, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=FX_INTRADAY&from_currency={local_currnecy}&to_currency={base_currency}&interval={interval.ToDescriptionString()}&outputsize={output_size.ToDescriptionString()}&apikey={api_key}";
        AVTimeSeriesResponseGeneric<AVBar>? results = await AlphaVantageAPIUtilities.GetAPIData(url, AlphaVantageAPIUtilities.JsonParserToTimeSeriesResult, timeout_seconds, ct, json_logger);
        return results;
    }

    /// <summary>
    /// Parses the JSON string returned by the Alpha Vantage API for intraday time series data.
    /// This API returns intraday time series (timestamp, open, high, low, close) of the FX currency pair specified, updated realtime.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVTimeSeriesResponseGeneric<AVBar>? GetExchangeRatesIntradayFromJson(string json)
    {
        return AlphaVantageAPIUtilities.JsonParserToTimeSeriesResult(json);
    }


    /// <summary>
    /// This API returns the daily time series (timestamp, open, high, low, close) of the FX currency pair specified, updated realtime.
    /// </summary>
    /// <param name="base_currency"></param>
    /// <param name="local_currnecy"></param>
    /// <param name="output_size"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVTimeSeriesResponseGeneric<AVBar>?> GetExchangeRatesDaily(string base_currency, string local_currnecy, OutputSize output_size = OutputSize.Full, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=FX_DAILY&from_currency={local_currnecy}&to_currency={base_currency}&outputsize={output_size.ToDescriptionString()}&apikey={api_key}";
        AVTimeSeriesResponseGeneric<AVBar>? results = await AlphaVantageAPIUtilities.GetAPIData(url, AlphaVantageAPIUtilities.JsonParserToTimeSeriesResult, timeout_seconds, ct, json_logger);
        return results;
    }


    /// <summary>
    /// Parses the JSON string returned by the Alpha Vantage API for daily time series data.
    /// This API returns the daily time series (timestamp, open, high, low, close) of the FX currency pair specified, updated realtime.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVTimeSeriesResponseGeneric<AVBar>? GetExchangeRatesDailyFromJson(string json)
    {
        return AlphaVantageAPIUtilities.JsonParserToTimeSeriesResult(json);
    }

    /// <summary>
    /// This API returns the weekly time series (timestamp, open, high, low, close) of the FX currency pair specified, updated realtime.
    /// The latest data point is the price information for the week(or partial week) containing the current trading day, updated realtime.
    /// </summary>
    /// <param name="base_currency"></param>
    /// <param name="local_currnecy"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVTimeSeriesResponseGeneric<AVBar>?> GetExchangeRatesWeekly(string base_currency, string local_currnecy, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=FX_WEEKLY&from_currency={local_currnecy}&to_currency={base_currency}&apikey={api_key}";
        AVTimeSeriesResponseGeneric<AVBar>? results = await AlphaVantageAPIUtilities.GetAPIData(url, AlphaVantageAPIUtilities.JsonParserToTimeSeriesResult, timeout_seconds, ct, json_logger);
        return results;
    }

    /// <summary>
    /// Parses the JSON string returned by the Alpha Vantage API for weekly time series data.
    /// This API returns the weekly time series (timestamp, open, high, low, close) of the FX currency pair specified, updated realtime.
    /// The latest data point is the price information for the week(or partial week) containing the current trading day, updated realtime.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVTimeSeriesResponseGeneric<AVBar>? GetExchangeRatesWeeklyFromJson(string json)
    {
        return AlphaVantageAPIUtilities.JsonParserToTimeSeriesResult(json);
    }

    /// <summary>
    /// This API returns the monthly time series (timestamp, open, high, low, close) of the FX currency pair specified, updated realtime.
    /// The latest data point is the prices information for the month(or partial month) containing the current trading day, updated realtime.
    /// </summary>
    /// <param name="base_currency"></param>
    /// <param name="local_currnecy"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVTimeSeriesResponseGeneric<AVBar>?> GetExchangeRatesMonthly(string base_currency, string local_currnecy,  CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=FX_MONTHLY&from_currency={local_currnecy}&to_currency={base_currency}&apikey={api_key}";
        AVTimeSeriesResponseGeneric<AVBar>? results = await AlphaVantageAPIUtilities.GetAPIData(url, AlphaVantageAPIUtilities.JsonParserToTimeSeriesResult, timeout_seconds, ct, json_logger);
        return results;
    }

    /// <summary>
    /// Parses the JSON string returned by the Alpha Vantage API for monthly time series data.
    /// This API returns the monthly time series (timestamp, open, high, low, close) of the FX currency pair specified, updated realtime.
    /// The latest data point is the prices information for the month(or partial month) containing the current trading day, updated realtime.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVTimeSeriesResponseGeneric<AVBar>? GetExchangeRatesMonthlyFromJson(string json)
    {
        return AlphaVantageAPIUtilities.JsonParserToTimeSeriesResult(json);
    }
}
