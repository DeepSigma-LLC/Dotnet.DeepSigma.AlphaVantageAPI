using DeepSigma.AlphaVantageAPI.DataModels;
using DeepSigma.AlphaVantageAPI.Enums;
using DeepSigma.DataAccess.API;
using DeepSigma.General.Extensions;

namespace DeepSigma.AlphaVantageAPI
{
    /// <summary>
    /// This class contains methods to access commodity data from the Alpha Vantage API.
    /// </summary>
    public class CommodityData
    {
        private string api_key { get; set; }
        private Action<string>? json_logger { get; set; } = null;
        private int timeout_seconds { get; set; }
        internal CommodityData(string api_key, Action<string>? json_logger, int timeout_seconds = 15)
        {
            this.api_key = api_key;
            this.json_logger = json_logger;
            this.timeout_seconds = timeout_seconds;
        }

        /// <summary>
        /// This API returns the West Texas Intermediate (WTI) crude oil prices in daily, weekly, and monthly horizons.
        /// Source: U.S.Energy Information Administration, Crude Oil Prices: West Texas Intermediate(WTI) - Cushing, Oklahoma, retrieved from FRED, Federal Reserve Bank of St.Louis. 
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis. By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// /// <param name="interval"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetWTI(TimeSeriesInterval interval = TimeSeriesInterval.Daily, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=WTI&interval={interval.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetWTIFromJson, timeout_seconds, ct, json_logger);
            return results;
        }

        /// <summary>
        /// Parses the JSON string returned by the Alpha Vantage API for WTI crude oil prices.
        /// Returns the West Texas Intermediate (WTI) crude oil prices from the Alpha Vantage JSON string.
        /// Source: U.S.Energy Information Administration, Crude Oil Prices: West Texas Intermediate(WTI) - Cushing, Oklahoma, retrieved from FRED, Federal Reserve Bank of St.Louis. 
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis. By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static AVDataRequest<AVValue>? GetWTIFromJson(string json)
        {
            AVDataRequest<AVValue>? results = APIUtilities.LoadFromJson<AVDataRequest<AVValue>>(json);
            return results;
        }

        /// <summary>
        /// This API returns the Brent (Europe) crude oil prices in daily, weekly, and monthly horizons.
        /// Source: U.S.Energy Information Administration, Crude Oil Prices: Brent - Europe, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis. By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetBrent(TimeSeriesInterval interval = TimeSeriesInterval.Daily, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=BRENT&interval={interval.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetBrentFromJson, timeout_seconds, ct, json_logger);
            return results;
        }

        /// <summary>
        /// Parses the JSON string returned by the Alpha Vantage API for Brent crude oil prices.
        /// This API returns the Brent (Europe) crude oil prices from the Alpha Vantage JSON string.
        /// Source: U.S.Energy Information Administration, Crude Oil Prices: Brent - Europe, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis. By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static AVDataRequest<AVValue>? GetBrentFromJson(string json)
        {
            AVDataRequest<AVValue>? results = APIUtilities.LoadFromJson<AVDataRequest<AVValue>>(json);
            return results;
        }


        /// <summary>
        /// This API returns the Henry Hub natural gas spot prices in daily, weekly, and monthly horizons.
        /// Source: U.S.Energy Information Administration, Henry Hub Natural Gas Spot Price, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetNaturalGas(TimeSeriesInterval interval = TimeSeriesInterval.Daily, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=NATURAL_GAS&interval={interval.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetNaturalGasFromJson, timeout_seconds, ct, json_logger);
            return results;
        }


        /// <summary>
        /// Parses the JSON string returned by the Alpha Vantage API for Henry Hub natural gas spot prices.
        /// This API returns the Henry Hub natural gas spot prices from the Alpha Vantage JSON string.
        /// Source: U.S.Energy Information Administration, Henry Hub Natural Gas Spot Price, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static AVDataRequest<AVValue>? GetNaturalGasFromJson(string json)
        {
            AVDataRequest<AVValue>? results = APIUtilities.LoadFromJson<AVDataRequest<AVValue>>(json);
            return results;
        }



        /// <summary>
        /// This API returns the global price of copper in monthly, quarterly, and annual horizons.
        /// Source: International Monetary Fund(IMF Terms of Use), Global price of Copper, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetCopper(TimeSeriesInterval interval = TimeSeriesInterval.Daily, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=COPPER&interval={interval.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetCopperFromJson, timeout_seconds, ct, json_logger);
            return results;
        }

        /// <summary>
        /// Parses the JSON string returned by the Alpha Vantage API for global copper prices.
        /// This API returns the global price of copper prices from the Alpha Vantage JSON string.
        /// Source: International Monetary Fund(IMF Terms of Use), Global price of Copper, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static AVDataRequest<AVValue>? GetCopperFromJson(string json)
        {
            AVDataRequest<AVValue>? results = APIUtilities.LoadFromJson<AVDataRequest<AVValue>>(json);
            return results;
        }


        /// <summary>
        /// This API returns the global price of aluminum in monthly, quarterly, and annual horizons.
        /// Source: International Monetary Fund(IMF Terms of Use), Global price of Aluminum, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetAluminum(TimeSeriesInterval interval = TimeSeriesInterval.Daily, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=ALUMINUM&interval={interval.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetAluminumFromJson, timeout_seconds, ct, json_logger);
            return results;
        }


        /// <summary>
        /// Parses the JSON string returned by the Alpha Vantage API for global aluminum prices.
        /// This API returns the global price of aluminum from the Alpha Vantage JSON string.
        /// Source: International Monetary Fund(IMF Terms of Use), Global price of Aluminum, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static AVDataRequest<AVValue>? GetAluminumFromJson(string json)
        {
            AVDataRequest<AVValue>? results = APIUtilities.LoadFromJson<AVDataRequest<AVValue>>(json);
            return results;
        }


        /// <summary>
        /// This API returns the global price of wheat in monthly, quarterly, and annual horizons.
        /// Source: International Monetary Fund(IMF Terms of Use), Global price of Wheat, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetWheat(TimeSeriesInterval interval = TimeSeriesInterval.Daily, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=WHEAT&interval={interval.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetWheatFromJson, timeout_seconds, ct, json_logger);
            return results;
        }

        /// <summary>
        /// Parses the JSON string returned by the Alpha Vantage API for global wheat prices.
        /// This API returns the global price of wheat from the Alpha Vantage JSON string.
        /// Source: International Monetary Fund(IMF Terms of Use), Global price of Wheat, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static AVDataRequest<AVValue>? GetWheatFromJson(string json)
        {
            AVDataRequest<AVValue>? results = APIUtilities.LoadFromJson<AVDataRequest<AVValue>>(json);
            return results;
        }

        /// <summary>
        /// This API returns the global price of corn in monthly, quarterly, and annual horizons.
        /// Source: International Monetary Fund(IMF Terms of Use), Global price of Corn, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetCorn(TimeSeriesInterval interval = TimeSeriesInterval.Daily, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=CORN&interval={interval.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetCornFromJson, timeout_seconds, ct, json_logger);
            return results;
        }

        /// <summary>
        /// Parses the JSON string returned by the Alpha Vantage API for global corn prices.
        /// This API returns the global price of corn from the Alpha Vantage JSON string.
        /// Source: International Monetary Fund(IMF Terms of Use), Global price of Corn, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static AVDataRequest<AVValue>? GetCornFromJson(string json)
        {
            AVDataRequest<AVValue>? results = APIUtilities.LoadFromJson<AVDataRequest<AVValue>>(json);
            return results;
        }

        /// <summary>
        /// This API returns the global price of cotton in monthly, quarterly, and annual horizons.
        /// Source: International Monetary Fund(IMF Terms of Use), Global price of Cotton, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetCotton(TimeSeriesInterval interval = TimeSeriesInterval.Daily, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=COTTON&interval={interval.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetCottonFromJson, timeout_seconds, ct, json_logger);
            return results;
        }

        /// <summary>
        /// Parses the JSON string returned by the Alpha Vantage API for global cotton prices.
        /// This API returns the global price of cotton from the Alpha Vantage JSON string.
        /// Source: International Monetary Fund(IMF Terms of Use), Global price of Cotton, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static AVDataRequest<AVValue>? GetCottonFromJson(string json)
        {
            AVDataRequest<AVValue>? results = APIUtilities.LoadFromJson<AVDataRequest<AVValue>>(json);
            return results;
        }

        /// <summary>
        /// This API returns the global price of sugar in monthly, quarterly, and annual horizons.
        /// Source: International Monetary Fund(IMF Terms of Use), Global price of Sugar, No. 11, World, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetSugar(TimeSeriesInterval interval = TimeSeriesInterval.Daily, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=SUGAR&interval={interval.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetSugarFromJson, timeout_seconds, ct, json_logger);
            return results;
        }

        /// <summary>
        /// Parses the JSON string returned by the Alpha Vantage API for global sugar prices.
        /// This API returns the global price of sugar from the Alpha Vantage JSON string.
        /// Source: International Monetary Fund(IMF Terms of Use), Global price of Sugar, No. 11, World, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static AVDataRequest<AVValue>? GetSugarFromJson(string json)
        {
            AVDataRequest<AVValue>? results = APIUtilities.LoadFromJson<AVDataRequest<AVValue>>(json);
            return results;
        }

        /// <summary>
        /// This API returns the global price of coffee in monthly, quarterly, and annual horizons.
        /// Source: International Monetary Fund(IMF Terms of Use), Global price of Coffee, Other Mild Arabica, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetCoffee(TimeSeriesInterval interval = TimeSeriesInterval.Daily, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=COFFEE&interval={interval.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetCoffeeFromJson, timeout_seconds, ct, json_logger);
            return results;
        }

        /// <summary>
        /// Parses the JSON string returned by the Alpha Vantage API for global coffee prices.
        /// This API returns the global price of coffee from the Alpha Vantage JSON string.
        /// Source: International Monetary Fund(IMF Terms of Use), Global price of Coffee, Other Mild Arabica, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static AVDataRequest<AVValue>? GetCoffeeFromJson(string json)
        {
            AVDataRequest<AVValue>? results = APIUtilities.LoadFromJson<AVDataRequest<AVValue>>(json);
            return results;
        }

        /// <summary>
        /// This API returns the global price index of all commodities in monthly, quarterly, and annual temporal dimensions.
        /// Source: International Monetary Fund(IMF Terms of Use), Global Price Index of All Commodities, retrieved from FRED, Federal Reserve Bank of St.Louis.This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetGlobalCommodityIndex(TimeSeriesInterval interval = TimeSeriesInterval.Daily, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=ALL_COMMODITIES&interval={interval.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetGlobalCommodityIndexFromJson, timeout_seconds, ct, json_logger);
            return results;
        }

        /// <summary>
        /// Parses the JSON string returned by the Alpha Vantage API for global commodity price index.
        /// This API returns the global price index of all commodities  the Alpha Vantage JSON string.
        /// Source: International Monetary Fund(IMF Terms of Use), Global Price Index of All Commodities, retrieved from FRED, Federal Reserve Bank of St.Louis.This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static AVDataRequest<AVValue>? GetGlobalCommodityIndexFromJson(string json)
        {
            AVDataRequest<AVValue>? results = APIUtilities.LoadFromJson<AVDataRequest<AVValue>>(json);
            return results;
        }
    }
}
