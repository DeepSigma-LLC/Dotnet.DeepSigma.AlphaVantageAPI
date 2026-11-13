using DeepSigma.AlphaVantageAPI.DataModels;
using DeepSigma.DataAccess.Web;

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
    public static AVDataRequest<AVOptionData>? GetRealTimeOptionDataFromJson(string json)
    {
        AVDataRequest<AVOptionData>? results = Serializer.LoadFromJson<AVDataRequest<AVOptionData>>(json);
        return results;
    }

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
    public static AVDataRequest<AVOptionData>? GetHistoricalOptionDataFromJson(string json)
    {
        AVDataRequest<AVOptionData>? results = Serializer.LoadFromJson<AVDataRequest<AVOptionData>>(json);
        return results;
    }

}
