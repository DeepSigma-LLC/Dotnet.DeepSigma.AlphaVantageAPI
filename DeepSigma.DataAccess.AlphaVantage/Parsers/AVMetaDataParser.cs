using DeepSigma.AlphaVantageAPI.DataModels;
using System.Text.Json;

namespace DeepSigma.AlphaVantageAPI.Parsers
{
    /// <summary>
    /// This class parses the metadata section of an Alpha Vantage API response.
    /// </summary>
    internal class AVMetaDataParser : AVResponseParser
    {
        /// <summary>
        /// Parses the metadata section of an Alpha Vantage API response.
        /// </summary>
        /// <param name="json_object"></param>
        /// <returns></returns>
        internal static AVMetaData Parse(JsonElement json_object)
        {
            Dictionary<string, string> map = GetResponseElements(json_object);

            return new AVMetaData
            {
                Information = TryGet<string>(map, null, "information") ?? "",
                Symbol = TryGet<string>(map, null, "symbol") ?? "",
                FromSymbol = TryGet<string>(map, null, "from symbol", "from currency code", "from_currency code") ?? "",
                ToSymbol = TryGet<string>(map, null, "to symbol", "to currency code", "to_currency code") ?? "",
                LastRefreshed = TryGet<string>(map, null, "last refreshed") ?? "",
                Interval = TryGet<string>(map, null, "interval") ?? "",
                OutputSize = TryGet<string>(map, null, "output size") ?? "",
                TimeZone = TryGet<string>(map, null, "time zone", "timezone") ?? "",
                DigitalCurrencyCode = TryGet<string>(map, null, "digital currency code") ?? "",
                DigitalCurrencyName = TryGet<string>(map, null, "digital currency name") ?? "",
                MarketCode = TryGet<string>(map, null, "market code") ?? "",
                MarketName = TryGet<string>(map, null, "market name") ?? "",
                AllFields = map
            };
        }
    }
}
