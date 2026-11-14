using DeepSigma.AlphaVantageAPI.Models;
using DeepSigma.AlphaVantageAPI.Parsers;
using DeepSigma.DataAccess.Web;

namespace DeepSigma.AlphaVantageAPI;

internal class AlphaVantageAPIUtilities(HttpClient client)
{
    private HttpClient _client = client;
    private HttpApi _httpApi = new(client);

    internal static AVTimeSeriesResponseGeneric<AVBar>? JsonParserToTimeSeriesResult(string json)
    {
        AVTimeSeriesResponseGenericParser<AVBar>? results = Serializer.LoadFromJson<AVTimeSeriesResponseGenericParser<AVBar>>(json);

        if (results is null) return null;
        results.SetParser(AVBarParser.Parse);

        AVTimeSeriesResponseGeneric<AVBar> final_results = new(results.GetSeries(), results.GetMetaData());
        return final_results;
    }

    internal async Task<TResult?> GetAPIData<TResult>(string url, Func<string, TResult> JsonToParser, int timeout_seconds, CancellationToken ct, Action<string>? json_logger = null)
    {
        string? json = await _httpApi.GetJsonResponseAsync(url, timeout_seconds, ct);

        if (json is null) return default;
        if (json_logger is not null) { json_logger(json); }

        return JsonToParser(json);
    }

    internal async Task<List<TResult>?> GetAPIDataCSVFormat<TResult>(string url, Func<string, List<TResult>?> CsvToParser, int timeout_seconds, CancellationToken ct, Action<string>? csv_logger = null)
    {
        string? csv = await _httpApi.GetCsvDataAsync(url, timeout_seconds, ct);

        if (csv is null) return default;
        if (csv_logger is not null) { csv_logger(csv); }

        return CsvToParser(csv);
    }
}
