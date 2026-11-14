using DeepSigma.AlphaVantageAPI.DataModels;
using DeepSigma.AlphaVantageAPI.Enums;
using DeepSigma.Core.Extensions;
using DeepSigma.DataAccess.Web;

namespace DeepSigma.AlphaVantageAPI;


/// <summary>
/// This class contains methods to access index data from the Alpha Vantage API.
/// </summary>
public class IndexData(HttpClient client, ApiOptions options) : AbstractDataAPI(client, options)
{
    /// <summary>
    /// This API returns decades of daily/weekly/monthly open, high, low, close (OHLC) time series data for over 200+ major market indices. 
    /// For the full list of supported indices, please refer to the Index Catalog.
    /// </summary>
    /// <param name="symbol">The symbol of the index.</param>
    /// <param name="interval">The time series interval.</param>
    /// <param name="ct">The cancellation token.</param>
    /// <returns>The deserialized AVIndexSeriesResponse object.</returns>
    public async Task<AVIndexSeriesResponse<AVBar>?> GetIndexData(string symbol, TimeSeriesInterval interval = TimeSeriesInterval.Daily, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=INDEX_DATA&symbol={symbol}&interval={interval.ToDescriptionString()}&apikey={Options.APIKey}";
        AVIndexSeriesResponse<AVBar>? results = await Utilities.GetAPIData(url, GetIndexDataFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }


    /// <summary>
    /// Parses the JSON response returned by the Alpha Vantage API for Index Data.
    /// This API returns decades of daily/weekly/monthly open, high, low, close (OHLC) time series data for over 200+ major market indices. 
    /// For the full list of supported indices, please refer to the Index Catalog.
    /// </summary>
    /// <param name="json">The JSON string returned by the API.</param>
    /// <returns>The deserialized AVIndexSeriesResponse object.</returns>
    public static AVIndexSeriesResponse<AVBar>? GetIndexDataFromJson(string json) => Serializer.LoadFromJson<AVIndexSeriesResponse<AVBar>>(json);

    /// <summary>
    /// The Index Catalog API returns the full list of supported index symbols, along with the corresponding long-form names.
    /// </summary>
    /// <param name="ct">The cancellation token.</param>
    /// <returns>A dictionary containing the index symbols and their corresponding long-form names.</returns>
    public async Task<Dictionary<string, string>>? GetIndexCatalog(CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=INDEX_CATALOG&apikey={Options.APIKey}";
        Dictionary<string, string>? results = await Utilities.GetAPIData(url, GetIndexCatalogFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }


    /// <summary>
    /// Parses the JSON response returned by the Alpha Vantage API for the Index Catalog.
    /// The Index Catalog API returns the full list of supported index symbols, along with the corresponding long-form names.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static Dictionary<string, string>? GetIndexCatalogFromJson(string json) => Serializer.LoadFromJson<Dictionary<string, string>>(json);

}
