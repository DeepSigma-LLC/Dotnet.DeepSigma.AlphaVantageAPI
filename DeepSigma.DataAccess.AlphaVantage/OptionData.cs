using DeepSigma.AlphaVantageAPI.DataModels;
using DeepSigma.DataAccess.Web;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DeepSigma.AlphaVantageAPI;

/// <summary>
/// This class contains methods to access option data from the Alpha Vantage API.
/// </summary>
public class OptionData(HttpClient client, ApiOptions options) : AbstractDataAPI(client, options)
{

    /// <summary>
    /// This API returns realtime US options data with full market coverage. 
    /// Option chains are sorted by expiration dates in chronological order. 
    /// Within the same expiration date, contracts are sorted by strike prices from low to high.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="ct"></param>
    /// <param name="specific_option_contract"></param>
    /// <returns></returns>
    public async Task<AVDataRequest<AVOptionData>?> GetRealTimeOptionData(string symbol, CancellationToken ct = default, string? specific_option_contract = null)
    {
        string contract_paramater = string.Empty;
        if (specific_option_contract is not null)
        {
            contract_paramater = $"&contract={specific_option_contract}";
        }
        string url = $"https://www.alphavantage.co/query?function=REALTIME_OPTIONS&symbol={symbol}&require_greeks=true{contract_paramater}&apikey={Options.APIKey}";
        AVDataRequest<AVOptionData>? results = await Utilities.GetAPIData(url, GetRealTimeOptionDataFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON response returned by the Alpha Vantage API for Real-Time Options Data.
    /// This API returns realtime US options data with full market coverage. 
    /// Option chains are sorted by expiration dates in chronological order. 
    /// Within the same expiration date, contracts are sorted by strike prices from low to high.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVDataRequest<AVOptionData>? GetRealTimeOptionDataFromJson(string json) => Serializer.LoadFromJson<AVDataRequest<AVOptionData>>(json);

    /// <summary>
    /// This API returns the full historical options chain for a specific symbol on a specific date, covering 15+ years of history. 
    /// Implied volatility (IV) and common Greeks (e.g., delta, gamma, theta, vega, rho) are also returned. 
    /// Option chains are sorted by expiration dates in chronological order. Within the same expiration date, contracts are sorted by strike prices from low to high.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="date"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVDataRequest<AVOptionData>?> GetHistoricalOptionData(string symbol, DateOnly date, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=HISTORICAL_OPTIONS&symbol={symbol}&date={date.ToString("D")}&apikey={Options.APIKey}";
        AVDataRequest<AVOptionData>? results = await Utilities.GetAPIData(url, GetHistoricalOptionDataFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON response returned by the Alpha Vantage API for Historical Options Data.
    /// This API returns the full historical options chain for a specific symbol on a specific date, covering 15+ years of history. 
    /// Implied volatility (IV) and common Greeks (e.g., delta, gamma, theta, vega, rho) are also returned. 
    /// Option chains are sorted by expiration dates in chronological order. Within the same expiration date, contracts are sorted by strike prices from low to high. 
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVDataRequest<AVOptionData>? GetHistoricalOptionDataFromJson(string json) => Serializer.LoadFromJson<AVDataRequest<AVOptionData>>(json);


    /// <summary>
    /// This API returns realtime put - call ratios for both the entire option chain and for specific expiration dates. 
    /// A lower put-call ratio(less than or equal to 0.6) typically signals bullish sentiment, as investors are purchasing more call options in expectation of rising prices. 
    /// On the other hand, a higher ratio (greater than or equal to 1.0) suggests bearish sentiment.
    /// However, because this metric is often used as a contrarian indicator, extreme values can imply the opposite - e.g., readings much higher than 1.0 
    /// may actually indicate a bullish outlook, while very low readings close to zero can point to potential bearish conditions.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVPutToCallRatioResponse?> GetRealTimePutToCallRatio(string symbol, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=REALTIME_PUT_CALL_RATIO&symbol={symbol}&apikey={Options.APIKey}";
        AVPutToCallRatioResponse? results = await Utilities.GetAPIData(url.ToString(), GetPutToCallRatioFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// This API returns historical put-call ratios for both the entire option chain and for specific expiration dates. 
    /// A lower put-call ratio (less than our equal to 0.6) typically signals bullish sentiment, as investors are purchasing more call options in expectation of rising prices.
    /// On the other hand, a higher ratio (greater than or equal to 1.0) suggests bearish sentiment. 
    /// However, because this metric is often used as a contrarian indicator, extreme values can imply the opposite - e.g., readings much higher than 1.0 
    /// may actually indicate a bullish outlook, while very low readings close to zero can point to potential bearish conditions.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="date"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVPutToCallRatioResponse?> GetHistoricalPutToCallRatio(string symbol, DateOnly? date = null, CancellationToken ct = default)
    {
        StringBuilder url = new($"https://www.alphavantage.co/query?function=HISTORICAL_PUT_CALL_RATIO&symbol={symbol}");
        if(date.HasValue)
        {
            url.Append($"&date={date.Value.ToString("D")}");
        }
        url.Append($"&apikey={Options.APIKey}");
        AVPutToCallRatioResponse? results = await Utilities.GetAPIData(url.ToString(), GetPutToCallRatioFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }


    /// <summary>
    /// Parses the JSON response returned by the Alpha Vantage API for Historical Put-Call Ratio.
    /// This API returns historical put-call ratios for both the entire option chain and for specific expiration dates. 
    /// A lower put-call ratio (less than our equal to 0.6) typically signals bullish sentiment, as investors are purchasing more call options in expectation of rising prices.
    /// On the other hand, a higher ratio (greater than or equal to 1.0) suggests bearish sentiment. 
    /// However, because this metric is often used as a contrarian indicator, extreme values can imply the opposite - e.g., readings much higher than 1.0 
    /// may actually indicate a bullish outlook, while very low readings close to zero can point to potential bearish conditions.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVPutToCallRatioResponse? GetPutToCallRatioFromJson(string json) => Serializer.LoadFromJson<AVPutToCallRatioResponse>(json);



    /// <summary>
    /// This API returns realtime put - call ratios for both the entire option chain and for specific expiration dates. 
    /// A lower put-call ratio(less than or equal to 0.6) typically signals bullish sentiment, as investors are purchasing more call options in expectation of rising prices. 
    /// On the other hand, a higher ratio (greater than or equal to 1.0) suggests bearish sentiment.
    /// However, because this metric is often used as a contrarian indicator, extreme values can imply the opposite - e.g., readings much higher than 1.0 
    /// may actually indicate a bullish outlook, while very low readings close to zero can point to potential bearish conditions.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVVolumeToOpenInterestRatioResponse?> GetRealTimeVolumeToOpenInterestRatio(string symbol, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=REALTIME_VOLUME_OPEN_INTEREST_RATIO&symbol={symbol}&apikey={Options.APIKey}";
        AVVolumeToOpenInterestRatioResponse? results = await Utilities.GetAPIData(url.ToString(), GetVolumeToOpenInterestRatioFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Gets historical volume-to-open-interest ratios within an option chain.
    /// This API returns historical volume-to-open-interest ratios within an option chain. 
    /// A high ratio (volume much larger than open interest) often suggests heavy trading activity relative to existing positions, which can indicate short-term speculation, increased liquidity, 
    /// or possible trend changes. A low ratio (volume small compared to open interest) implies that most positions are being held rather than actively traded, signaling more stable or less volatile conditions. 
    /// Traders use this ratio to understand whether price moves are driven by new participation (potentially stronger signals) or just minor adjustments within existing positions.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="date"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVVolumeToOpenInterestRatioResponse?> GetHistoricalVolumeToOpenInterestRatio(string symbol, DateOnly? date = null, CancellationToken ct = default)
    {
        StringBuilder url = new($"https://www.alphavantage.co/query?function=HISTORICAL_VOLUME_OPEN_INTEREST_RATIO&symbol={symbol}");
        if (date.HasValue)
        {
            url.Append($"&date={date.Value.ToString("D")}");
        }
        url.Append($"&apikey={Options.APIKey}");
        AVVolumeToOpenInterestRatioResponse? results = await Utilities.GetAPIData(url.ToString(), GetVolumeToOpenInterestRatioFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON response returned by the Alpha Vantage API for Volume to Open Interest Ratio.
    /// This API returns historical volume-to-open-interest ratios within an option chain. 
    /// A high ratio (volume much larger than open interest) often suggests heavy trading activity relative to existing positions, 
    /// which can indicate short-term speculation, increased liquidity, or possible trend changes. 
    /// A low ratio (volume small compared to open interest) implies that most positions are being held rather than actively traded, signaling more stable or less volatile conditions. 
    /// Traders use this ratio to understand whether price moves are driven by new participation (potentially stronger signals) or just minor adjustments within existing positions.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVVolumeToOpenInterestRatioResponse? GetVolumeToOpenInterestRatioFromJson(string json) => Serializer.LoadFromJson<AVVolumeToOpenInterestRatioResponse>(json);

}
