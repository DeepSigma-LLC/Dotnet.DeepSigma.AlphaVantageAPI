using DeepSigma.AlphaVantageAPI.DataModels;
using DeepSigma.AlphaVantageAPI.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeepSigma.DataAccess.API;

namespace DeepSigma.AlphaVantageAPI
{
    internal static class AlphaVantageAPIUtilities
    {
        internal static AVTimeSeriesResponseGeneric<AVBar>? JsonParserToTimeSeriesResult(string json)
        {
            AVTimeSeriesResponseGenericParser<AVBar>? results = APIUtilities.LoadFromJson<AVTimeSeriesResponseGenericParser<AVBar>>(json);

            if (results is null) return null;
            results.SetParser(AVBarParser.Parse);

            AVTimeSeriesResponseGeneric<AVBar> final_results = new(results.GetSeries(), results.GetMetaData());
            return final_results;
        }

        internal static async Task<TResult?> GetAPIData<TResult>(string url, Func<string, TResult> JsonToParser, int timeout_seconds, CancellationToken ct, Action<string>? json_logger = null)
        {
            string? json = await APIUtilities.GetJsonResponseAsync(url, timeout_seconds, ct);

            if (json is null) return default;
            if (json_logger is not null) { json_logger(json); }

            return JsonToParser(json);
        }

        internal static async Task<List<TResult>> GetAPIDataCSVFormat<TResult>(string url, Func<string, List<TResult>> CsvToParser, int timeout_seconds, CancellationToken ct, Action<string>? csv_logger = null)
        {
            string? csv = await APIUtilities.GetCsvDataAsync(url, timeout_seconds, ct);

            if (csv is null) return [];
            if (csv_logger is not null) { csv_logger(csv); }

            return CsvToParser(csv);
        }
    }
}
