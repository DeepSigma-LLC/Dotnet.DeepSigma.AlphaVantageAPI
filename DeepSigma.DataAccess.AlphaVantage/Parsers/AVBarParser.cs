using DeepSigma.DataAccess.AlphaVantage.DataModels;
using System.Text.Json;

namespace DeepSigma.DataAccess.AlphaVantage.Parsers
{
    /// <summary>
    /// This class parses JSON responses from the Alpha Vantage API.
    /// </summary>
    public class AVBarParser : AVResponseParser
    {
        /// <summary>
        /// Parses a JsonElement into an AVBar object.
        /// </summary>
        /// <param name="json_object"></param>
        /// <returns></returns>
        public static AVBar Parse(JsonElement json_object)
        {
            Dictionary<string, string> map = GetResponseElements(json_object);

            return new AVBar
            {
                Open = TryGet<decimal>(map, null, "open"),
                High = TryGet<decimal>(map, null, "high"),
                Low = TryGet<decimal>(map, null, "low"),
                Close = TryGet<decimal>(map, null, "close"),
                Volume = TryGet<long>(map, null, "volume"),
                AdjustedClose = TryGet<decimal>(map, null, "adjusted close", "adjustedclose"),
                DividendAmount = TryGet<decimal>(map, null, "dividend amount", "dividendamount"),
                SplitCoefficient = TryGet<decimal>(map, null, "split coefficient", "splitcoefficient"),
                UnmappedFields = map
            };
        }
    }
}
