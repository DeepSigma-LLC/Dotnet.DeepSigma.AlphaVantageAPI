using DeepSigma.DataAccess.AlphaVantage.DataModels;
using DeepSigma.DataAccess.AlphaVantage.Enums;
using DeepSigma.DataAccess.API;
using DeepSigma.General.Extensions;

namespace DeepSigma.DataAccess.AlphaVantage
{
    public class EconomicData
    {
        private string api_key { get; set; }
        private Action<string?>? json_logger { get; set; } = null;
        private int timeout_seconds { get; set; }
        internal EconomicData(string api_key, Action<string?>? json_logger, int timeout_seconds = 15)
        {
            this.api_key = api_key;
            this.json_logger = json_logger;
            this.timeout_seconds = timeout_seconds;
        }

        /// <summary>
        /// This API returns the annual and quarterly Real GDP of the United States.
        /// Source: U.S.Bureau of Economic Analysis, Real Gross Domestic Product, retrieved from FRED, Federal Reserve Bank of St.Louis. 
        /// This data feed uses the FRED API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED API Terms of Use.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="interval"></param>
        /// <param name="return_type"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetRealGDP(TimeSeriesInterval interval = TimeSeriesInterval.Daily, DataReturnType return_type = DataReturnType.Json, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=REAL_GDP&interval={interval.ToDescriptionString()}&datatype={return_type.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVValue>>(url, timeout_seconds, json_logger, ct);
            return results;
        }

        /// <summary>
        /// This API returns the quarterly Real GDP per Capita data of the United States.
        /// Source: U.S.Bureau of Economic Analysis, Real gross domestic product per capita, retrieved from FRED, Federal Reserve Bank of St.Louis. 
        /// This data feed uses the FRED API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED API Terms of Use.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="interval"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetRealGDPPerCapita(DataReturnType return_type = DataReturnType.Json, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=REAL_GDP_PER_CAPITA&datatype={return_type.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVValue>>(url, timeout_seconds, json_logger, ct);
            return results;
        }

        /// <summary>
        /// This API returns the monthly and semiannual consumer price index (CPI) of the United States. CPI is widely regarded as the barometer of inflation levels in the broader economy.
        /// Source: U.S.Bureau of Labor Statistics, Consumer Price Index for All Urban Consumers: All Items in U.S.City Average, retrieved from FRED, Federal Reserve Bank of St.Louis. 
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="return_type"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetCPI(TimeSeriesInterval interval = TimeSeriesInterval.Daily, DataReturnType return_type = DataReturnType.Json, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=CPI&interval={interval.ToDescriptionString()}&datatype={return_type.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVValue>>(url, timeout_seconds, json_logger, ct);
            return results;
        }


        /// <summary>
        /// This API returns the annual inflation rates (consumer prices) of the United States.
        /// Source: World Bank, Inflation, consumer prices for the United States, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetInflation(DataReturnType return_type = DataReturnType.Json, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=INFLATION&datatype={return_type.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVValue>>(url, timeout_seconds, json_logger, ct);
            return results;
        }

        /// <summary>
        /// This API returns the monthly Advance Retail Sales: Retail Trade data of the United States.
        /// Source: U.S.Census Bureau, Advance Retail Sales: Retail Trade, retrieved from FRED, Federal Reserve Bank of St.Louis(https://fred.stlouisfed.org/series/RSXFSN). 
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St. Louis. By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetRetailSales(CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=RETAIL_SALES&apikey={api_key}";
            AVDataRequest<AVValue>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVValue>>(url, timeout_seconds, json_logger, ct);
            return results;
        }

        /// <summary>
        /// This API returns the monthly manufacturers' new orders of durable goods in the United States.
        /// Source: U.S.Census Bureau, Manufacturers' New Orders: Durable Goods, retrieved from FRED, Federal Reserve Bank of St. Louis (https://fred.stlouisfed.org/series/UMDMNO). 
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St. Louis. By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetDurableGoodsOrders(CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=DURABLES&apikey={api_key}";
            AVDataRequest<AVValue>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVValue>>(url, timeout_seconds, json_logger, ct);
            return results;
        }

        /// <summary>
        /// This API returns the monthly US All Employees: Total Nonfarm (commonly known as Total Nonfarm Payroll), a measure of the number of U.S. workers in the economy that excludes proprietors, private household employees, unpaid volunteers, farm employees, and the unincorporated self-employed.
        /// Source: U.S.Bureau of Labor Statistics, All Employees, Total Nonfarm, retrieved from FRED, Federal Reserve Bank of St.Louis.This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.
        /// By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetNonFarmPayrolls(CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=NONFARM_PAYROLL&apikey={api_key}";
            AVDataRequest<AVValue>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVValue>>(url, timeout_seconds, json_logger, ct);
            return results;
        }

        /// <summary>
        /// This API returns the monthly unemployment data of the United States. 
        /// The unemployment rate represents the number of unemployed as a percentage of the labor force. 
        /// Labor force data are restricted to people 16 years of age and older, who currently reside in 1 of the 50 states or the District of Columbia, 
        /// who do not reside in institutions (e.g., penal and mental facilities, homes for the aged), and who are not on active duty in the Armed Forces (source).
        /// Source: U.S.Bureau of Labor Statistics, Unemployment Rate, retrieved from FRED, Federal Reserve Bank of St.Louis.
        /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetUnemployment(CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=UNEMPLOYMENT&apikey={api_key}";
            AVDataRequest<AVValue>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVValue>>(url, timeout_seconds, json_logger, ct);
            return results;
        }    

    }
}
