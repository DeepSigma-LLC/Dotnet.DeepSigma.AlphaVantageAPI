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
        internal static AVTimeSeriesResponseGeneric<AVBar>? JsonToResult(string json)
        {
            AVTimeSeriesResponseGenericParser<AVBar>? results = APIUtilities.LoadFromJson<AVTimeSeriesResponseGenericParser<AVBar>>(json);

            if (results is null) return null;
            results.SetParser(AVBarParser.Parse);

            AVTimeSeriesResponseGeneric<AVBar> final_results = new(results.GetSeries(), results.GetMetaData());
            return final_results;
        }

    }
}
