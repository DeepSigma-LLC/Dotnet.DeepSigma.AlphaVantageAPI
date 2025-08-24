using DeepSigma.DataAccess.API.AlphaVantage.DataModels;
using DeepSigma.DataAccess.API.AlphaVantage.Enums;
using DeepSigma.General.Extensions;

namespace DeepSigma.DataAccess.API.AlphaVantage
{
    public class CommodityData
    {
        private string api_key { get; set; }
        private Action<string?>? json_logger { get; set; } = null;
        private int timeout_seconds { get; set; }
        internal CommodityData(string api_key, Action<string?>? json_logger, int timeout_seconds = 15)
        {
            this.api_key = api_key;
            this.json_logger = json_logger;
            this.timeout_seconds = timeout_seconds;
        }

        /// <summary>
        /// This API returns the West Texas Intermediate (WTI) crude oil prices in daily, weekly, and monthly horizons.
        /// Source: U.S.Energy Information Administration, Crude Oil Prices: West Texas Intermediate(WTI) - Cushing, Oklahoma, retrieved from FRED, Federal Reserve Bank of St.Louis. 
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="interval"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetWTI(TimeSeriesInterval interval = TimeSeriesInterval.Daily, DataReturnType return_type = DataReturnType.Json, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=WTI&interval={interval.ToDescriptionString()}&datatype={return_type.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVValue>>(url, timeout_seconds, json_logger, ct);
            return results;
        }

        /// <summary>
        /// This API returns the Brent (Europe) crude oil prices in daily, weekly, and monthly horizons.
        /// Source: U.S.Energy Information Administration, Crude Oil Prices: Brent - Europe, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="return_type"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetBrent(TimeSeriesInterval interval = TimeSeriesInterval.Daily, DataReturnType return_type = DataReturnType.Json, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=BRENT&interval={interval.ToDescriptionString()}&datatype={return_type.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVValue>>(url, timeout_seconds, json_logger, ct);
            return results;
        }

        /// <summary>
        /// This API returns the Henry Hub natural gas spot prices in daily, weekly, and monthly horizons.
        /// Source: U.S.Energy Information Administration, Henry Hub Natural Gas Spot Price, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="interval"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetNaturalGas(TimeSeriesInterval interval = TimeSeriesInterval.Daily, DataReturnType return_type = DataReturnType.Json, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=NATURAL_GAS&interval={interval.ToDescriptionString()}&datatype={return_type.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVValue>>(url, timeout_seconds, json_logger, ct);
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
        public async Task<AVDataRequest<AVValue>?> GetCopper(TimeSeriesInterval interval = TimeSeriesInterval.Daily, DataReturnType return_type = DataReturnType.Json, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=COPPER&interval={interval.ToDescriptionString()}&datatype={return_type.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVValue>>(url, timeout_seconds, json_logger, ct);
            return results;
        }


        /// <summary>
        /// This API returns the global price of aluminum in monthly, quarterly, and annual horizons.
        /// Source: International Monetary Fund(IMF Terms of Use), Global price of Aluminum, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="interval"></param>
        /// <param name="return_type"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetAluminum(TimeSeriesInterval interval = TimeSeriesInterval.Daily, DataReturnType return_type = DataReturnType.Json, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=ALUMINUM&interval={interval.ToDescriptionString()}&datatype={return_type.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVValue>>(url, timeout_seconds, json_logger, ct);
            return results;
        }

        /// <summary>
        /// This API returns the global price of wheat in monthly, quarterly, and annual horizons.
        /// Source: International Monetary Fund(IMF Terms of Use), Global price of Wheat, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="return_type"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetWheat(TimeSeriesInterval interval = TimeSeriesInterval.Daily, DataReturnType return_type = DataReturnType.Json, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=WHEAT&interval={interval.ToDescriptionString()}&datatype={return_type.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVValue>>(url, timeout_seconds, json_logger, ct);
            return results;
        }

        /// <summary>
        /// This API returns the global price of corn in monthly, quarterly, and annual horizons.
        /// Source: International Monetary Fund(IMF Terms of Use), Global price of Corn, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="return_type"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetCorn(TimeSeriesInterval interval = TimeSeriesInterval.Daily, DataReturnType return_type = DataReturnType.Json, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=CORN&interval={interval.ToDescriptionString()}&datatype={return_type.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVValue>>(url, timeout_seconds, json_logger, ct);
            return results;
        }

        /// <summary>
        /// This API returns the global price of cotton in monthly, quarterly, and annual horizons.
        /// Source: International Monetary Fund(IMF Terms of Use), Global price of Cotton, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="return_type"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetCotton(TimeSeriesInterval interval = TimeSeriesInterval.Daily, DataReturnType return_type = DataReturnType.Json, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=COTTON&interval={interval.ToDescriptionString()}&datatype={return_type.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVValue>>(url, timeout_seconds, json_logger, ct);
            return results;
        }

        /// <summary>
        /// This API returns the global price of sugar in monthly, quarterly, and annual horizons.
        /// Source: International Monetary Fund(IMF Terms of Use), Global price of Sugar, No. 11, World, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="return_type"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetSugar(TimeSeriesInterval interval = TimeSeriesInterval.Daily, DataReturnType return_type = DataReturnType.Json, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=SUGAR&interval={interval.ToDescriptionString()}&datatype={return_type.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVValue>>(url, timeout_seconds, json_logger, ct);
            return results;
        }

        /// <summary>
        /// This API returns the global price of coffee in monthly, quarterly, and annual horizons.
        /// Source: International Monetary Fund(IMF Terms of Use), Global price of Coffee, Other Mild Arabica, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="return_type"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetCoffee(TimeSeriesInterval interval = TimeSeriesInterval.Daily, DataReturnType return_type = DataReturnType.Json, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=COFFEE&interval={interval.ToDescriptionString()}&datatype={return_type.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVValue>>(url, timeout_seconds, json_logger, ct);
            return results;
        }

        /// <summary>
        /// This API returns the global price index of all commodities in monthly, quarterly, and annual temporal dimensions.
        /// Source: International Monetary Fund(IMF Terms of Use), Global Price Index of All Commodities, retrieved from FRED, Federal Reserve Bank of St.Louis.This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="interval"></param>
        /// <param name="return_type"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetGlobalCommodityIndex(TimeSeriesInterval interval = TimeSeriesInterval.Daily, DataReturnType return_type = DataReturnType.Json, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=ALL_COMMODITIES&interval={interval.ToDescriptionString()}&datatype={return_type.ToDescriptionString()}&&apikey={api_key}";
            AVDataRequest<AVValue>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVValue>>(url, timeout_seconds, json_logger, ct);
            return results;
        }

    }
}
