using DeepSigma.DataAccess.AlphaVantage.DataModels;
using DeepSigma.DataAccess.AlphaVantage.Parsers;
using DeepSigma.DataAccess.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSigma.DataAccess.AlphaVantage
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
    }
}
