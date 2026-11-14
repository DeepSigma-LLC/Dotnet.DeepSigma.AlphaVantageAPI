using DeepSigma.AlphaVantageAPI.Models;
using DeepSigma.AlphaVantageAPI.Enums;
using DeepSigma.DataAccess.Web;
using DeepSigma.Core.Extensions;
using DeepSigma.AlphaVantageAPI.APIs.Stock.Models;

namespace DeepSigma.AlphaVantageAPI.APIs.Stock;

/// <summary>
/// This class contains methods to access stock data from the Alpha Vantage API.
/// </summary>
public class StockData(HttpClient client, ApiOptions options) : AbstractDataAPI(client, options)
{

    /// <summary>
    /// This API returns current and 20+ years of historical intraday OHLCV time series of the equity specified, 
    /// covering pre-market and post-market hours where applicable (e.g., 4:00am to 8:00pm Eastern Time for the US market). 
    /// You can query both raw (as-traded) and split/dividend-adjusted intraday data from this endpoint. The OHLCV data is sometimes called "candles" in finance literature.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="interval"></param>
    /// <param name="output_size"></param>
    /// <param name="extended_hours"></param>
    /// <param name="selected_month"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVTimeSeriesResponseGeneric<AVBar>?> GetIntradayTimeSeriesData(string symbol, TimeSeriesIntradayInterval interval = TimeSeriesIntradayInterval.Fifteen, OutputSize output_size = OutputSize.Full, bool extended_hours = true, DateOnly? selected_month = null, CancellationToken ct = default)
    {
        string parameter = string.Empty;
        if (selected_month.HasValue)
        {
            parameter = $"&month={selected_month.Value.Year}-{selected_month.Value.Month}";
        }
        string url = $"https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol={symbol}&interval={interval.ToDescriptionString()}&outputsize={output_size.ToDescriptionString()}&extended_hours={extended_hours}{parameter}&apikey={Options.APIKey}";
        AVTimeSeriesResponseGeneric<AVBar>? results = await Utilities.GetAPIData(url, AlphaVantageAPIUtilities.JsonParserToTimeSeriesResult, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON string returned by the Alpha Vantage API for intraday time series data.
    /// This API returns current and 20+ years of historical intraday OHLCV time series of the equity specified, 
    /// covering pre-market and post-market hours where applicable (e.g., 4:00am to 8:00pm Eastern Time for the US market). 
    /// You can query both raw (as-traded) and split/dividend-adjusted intraday data from this endpoint. The OHLCV data is sometimes called "candles" in finance literature.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVTimeSeriesResponseGeneric<AVBar>? GetIntradayTimeSeriesDataFromJson(string json)
    {
        return AlphaVantageAPIUtilities.JsonParserToTimeSeriesResult(json);
    }

    /// <summary>
    /// This API returns raw (as-traded) daily time series (date, daily open, daily high, daily low, daily close, daily volume) of the global equity specified, 
    /// covering 20+ years of historical data. The OHLCV data is sometimes called "candles" in finance literature. 
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="output_size"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVTimeSeriesResponseGeneric<AVBar>?> GetDailyTimeSeriesData(string symbol, OutputSize output_size = OutputSize.Full, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=TIME_SERIES_DAILY_ADJUSTED&symbol={symbol}&outputsize={output_size.ToDescriptionString()}&apikey={Options.APIKey}";
        AVTimeSeriesResponseGeneric<AVBar>? results = await Utilities.GetAPIData(url, AlphaVantageAPIUtilities.JsonParserToTimeSeriesResult, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON string returned by the Alpha Vantage API for daily time series data.
    /// This API returns raw (as-traded) daily time series (date, daily open, daily high, daily low, daily close, daily volume) of the global equity specified, 
    /// covering 20+ years of historical data. The OHLCV data is sometimes called "candles" in finance literature.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVTimeSeriesResponseGeneric<AVBar>? GetDailyTimeSeriesDataFromJson(string json)
    {
        return AlphaVantageAPIUtilities.JsonParserToTimeSeriesResult(json);
    }

    /// <summary>
    /// This API returns weekly time series (last trading day of each week, weekly open, weekly high, weekly low, weekly close, weekly volume) of the global equity specified, covering 20+ years of historical data.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVTimeSeriesResponseGeneric<AVBar>?> GetWeeklyTimeSeriesData(string symbol, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=TIME_SERIES_WEEKLY_ADJUSTED&symbol={symbol}&apikey={Options.APIKey}";
        AVTimeSeriesResponseGeneric<AVBar>? results = await Utilities.GetAPIData(url, AlphaVantageAPIUtilities.JsonParserToTimeSeriesResult, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON string returned by the Alpha Vantage API for weekly time series data.
    /// This API returns weekly time series (last trading day of each week, weekly open, weekly high, weekly low, weekly close, weekly volume) of the global equity specified, covering 20+ years of historical data.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVTimeSeriesResponseGeneric<AVBar>? GetWeeklyTimeSeriesDataFromJson(string json)
    {
        return AlphaVantageAPIUtilities.JsonParserToTimeSeriesResult(json);
    }

    /// <summary>
    /// This API returns monthly adjusted time series (last trading day of each month, monthly open, monthly high, monthly low, monthly close, monthly adjusted close, monthly volume, monthly dividend) 
    /// of the equity specified, covering 20+ years of historical data.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVTimeSeriesResponseGeneric<AVBar>?> GetMonthlyTimeSeriesData(string symbol, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=TIME_SERIES_MONTHLY_ADJUSTED&symbol={symbol}&apikey={Options.APIKey}";
        AVTimeSeriesResponseGeneric<AVBar>? results = await Utilities.GetAPIData(url, AlphaVantageAPIUtilities.JsonParserToTimeSeriesResult, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON string returned by the Alpha Vantage API for monthly time series data.
    /// This API returns monthly adjusted time series (last trading day of each month, monthly open, monthly high, monthly low, monthly close, monthly adjusted close, monthly volume, monthly dividend) 
    /// of the equity specified, covering 20+ years of historical data.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVTimeSeriesResponseGeneric<AVBar>? GetMonthlyTimeSeriesDataFromJson(string json)
    {
        return AlphaVantageAPIUtilities.JsonParserToTimeSeriesResult(json);
    }

    /// <summary>
    /// This API returns realtime quotes for US-traded symbols in bulk, accepting up to 100 symbols per API request and covering both regular and extended (pre-market and post-market) trading hours.
    /// You can use this endpoint as a high-throughput alternative to the Global Quote API, which accepts one symbol per API request.
    /// </summary>
    /// <param name="symbols"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVDataRequest<AVBulkQuoteData>?> GetBulkRealTimeQuoteData(string[] symbols, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=REALTIME_BULK_QUOTES&symbol={string.Join(",", symbols)}&apikey={Options.APIKey}";
        AVDataRequest<AVBulkQuoteData>? results = await Utilities.GetAPIData(url, GetBulkRealTimeQuoteDataFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON string returned by the Alpha Vantage API for realtime bulk quote data.
    /// This API returns realtime quotes for US-traded symbols in bulk, accepting up to 100 symbols per API request and covering both regular and extended (pre-market and post-market) trading hours.
    /// You can use this endpoint as a high-throughput alternative to the Global Quote API, which accepts one symbol per API request.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVDataRequest<AVBulkQuoteData>? GetBulkRealTimeQuoteDataFromJson(string json)
    {
        AVDataRequest<AVBulkQuoteData>? results = Serializer.LoadFromJson<AVDataRequest<AVBulkQuoteData>>(json);
        return results;
    }
}
