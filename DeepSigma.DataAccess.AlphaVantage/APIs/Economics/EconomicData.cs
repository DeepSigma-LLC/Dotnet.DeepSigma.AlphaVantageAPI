using DeepSigma.AlphaVantageAPI.Models;
using DeepSigma.AlphaVantageAPI.Enums;
using DeepSigma.DataAccess.Web;
using DeepSigma.Core.Extensions;

namespace DeepSigma.AlphaVantageAPI.APIs.Economics;

/// <summary>
/// This class contains methods to access economic data from the Alpha Vantage API.
/// </summary>
public class EconomicData(HttpClient client, ApiOptions options) : AbstractDataAPI(client, options)
{

    /// <summary>
    /// This API returns the annual and quarterly Real GDP of the United States.
    /// Source: U.S.Bureau of Economic Analysis, Real Gross Domestic Product, retrieved from FRED, Federal Reserve Bank of St.Louis. 
    /// This data feed uses the FRED API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED API Terms of Use.
    /// </summary>
    /// <param name="interval"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVDataRequest<AVValue>?> GetRealGDP(TimeSeriesInterval interval = TimeSeriesInterval.Daily, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=REAL_GDP&interval={interval.ToDescriptionString()}&apikey={Options.APIKey}";
        AVDataRequest<AVValue>? results = await Utilities.GetAPIData(url, GetRealGDPFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON string returned by the Alpha Vantage API for Real GDP data.
    /// This API returns the annual and quarterly Real GDP of the United States.
    /// Source: U.S.Bureau of Economic Analysis, Real Gross Domestic Product, retrieved from FRED, Federal Reserve Bank of St.Louis. 
    /// This data feed uses the FRED API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED API Terms of Use.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVDataRequest<AVValue>? GetRealGDPFromJson(string json)
    {
        AVDataRequest<AVValue>? results = Serializer.LoadFromJson<AVDataRequest<AVValue>>(json);
        return results;
    }


    /// <summary>
    /// This API returns the quarterly Real GDP per Capita data of the United States.
    /// Source: U.S.Bureau of Economic Analysis, Real gross domestic product per capita, retrieved from FRED, Federal Reserve Bank of St.Louis. 
    /// This data feed uses the FRED API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED API Terms of Use.
    /// </summary>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVDataRequest<AVValue>?> GetRealGDPPerCapita(CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=REAL_GDP_PER_CAPITA&apikey={Options.APIKey}";
        AVDataRequest<AVValue>? results = await Utilities.GetAPIData(url, GetRealGDPPerCapitaFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON string returned by the Alpha Vantage API for Real GDP Per Capita data.
    /// This API returns the quarterly Real GDP per Capita data of the United States.
    /// Source: U.S.Bureau of Economic Analysis, Real gross domestic product per capita, retrieved from FRED, Federal Reserve Bank of St.Louis. 
    /// This data feed uses the FRED API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED API Terms of Use.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVDataRequest<AVValue>? GetRealGDPPerCapitaFromJson(string json)
    {
        AVDataRequest<AVValue>? results = Serializer.LoadFromJson<AVDataRequest<AVValue>>(json);
        return results;
    }

    /// <summary>
    /// This API returns the monthly and semiannual consumer price index (CPI) of the United States. CPI is widely regarded as the barometer of inflation levels in the broader economy.
    /// Source: U.S.Bureau of Labor Statistics, Consumer Price Index for All Urban Consumers: All Items in U.S.City Average, retrieved from FRED, Federal Reserve Bank of St.Louis. 
    /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
    /// </summary>
    /// <param name="interval"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVDataRequest<AVValue>?> GetCPI(TimeSeriesInterval interval = TimeSeriesInterval.Daily, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=CPI&interval={interval.ToDescriptionString()}&apikey={Options.APIKey}";
        AVDataRequest<AVValue>? results = await Utilities.GetAPIData(url, GetCPIFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON string returned by the Alpha Vantage API for CPI data.
    /// This API returns the monthly and semiannual consumer price index (CPI) of the United States. CPI is widely regarded as the barometer of inflation levels in the broader economy.
    /// Source: U.S.Bureau of Labor Statistics, Consumer Price Index for All Urban Consumers: All Items in U.S.City Average, retrieved from FRED, Federal Reserve Bank of St.Louis. 
    /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVDataRequest<AVValue>? GetCPIFromJson(string json)
    {
        AVDataRequest<AVValue>? results = Serializer.LoadFromJson<AVDataRequest<AVValue>>(json);
        return results;
    }

    /// <summary>
    /// This API returns the annual inflation rates (consumer prices) of the United States.
    /// Source: World Bank, Inflation, consumer prices for the United States, retrieved from FRED, Federal Reserve Bank of St.Louis.
    /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
    /// </summary>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVDataRequest<AVValue>?> GetInflation(CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=INFLATION&apikey={Options.APIKey}";
        AVDataRequest<AVValue>? results = await Utilities.GetAPIData(url, GetInflationFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON string returned by the Alpha Vantage API for Inflation data.
    /// This API returns the annual inflation rates (consumer prices) of the United States.
    /// Source: World Bank, Inflation, consumer prices for the United States, retrieved from FRED, Federal Reserve Bank of St.Louis.
    /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVDataRequest<AVValue>? GetInflationFromJson(string json)
    {
        AVDataRequest<AVValue>? results = Serializer.LoadFromJson<AVDataRequest<AVValue>>(json);
        return results;
    }

    /// <summary>
    /// This API returns the monthly Advance Retail Sales: Retail Trade data of the United States.
    /// Source: U.S.Census Bureau, Advance Retail Sales: Retail Trade, retrieved from FRED, Federal Reserve Bank of St.Louis(https://fred.stlouisfed.org/series/RSXFSN). 
    /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St. Louis. By using this data feed, you agree to be bound by the FRED® API Terms of Use.
    /// </summary>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVDataRequest<AVValue>?> GetRetailSales(CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=RETAIL_SALES&apikey={Options.APIKey}";
        AVDataRequest<AVValue>? results = await Utilities.GetAPIData(url, GetRetailSalesFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON string returned by the Alpha Vantage API for Retail Sales data.
    /// This API returns the monthly Advance Retail Sales: Retail Trade data of the United States.
    /// Source: U.S.Census Bureau, Advance Retail Sales: Retail Trade, retrieved from FRED, Federal Reserve Bank of St.Louis(https://fred.stlouisfed.org/series/RSXFSN). 
    /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St. Louis. By using this data feed, you agree to be bound by the FRED® API Terms of Use.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVDataRequest<AVValue>? GetRetailSalesFromJson(string json)
    {
        AVDataRequest<AVValue>? results = Serializer.LoadFromJson<AVDataRequest<AVValue>>(json);
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
        string url = $"https://www.alphavantage.co/query?function=DURABLES&apikey={Options.APIKey}";
        AVDataRequest<AVValue>? results = await Utilities.GetAPIData(url, GetDurableGoodsOrdersFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON string returned by the Alpha Vantage API for Durable Goods Orders data.
    /// This API returns the monthly manufacturers' new orders of durable goods in the United States.
    /// Source: U.S.Census Bureau, Manufacturers' New Orders: Durable Goods, retrieved from FRED, Federal Reserve Bank of St. Louis (https://fred.stlouisfed.org/series/UMDMNO). 
    /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St. Louis. By using this data feed, you agree to be bound by the FRED® API Terms of Use.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVDataRequest<AVValue>? GetDurableGoodsOrdersFromJson(string json)
    {
        AVDataRequest<AVValue>? results = Serializer.LoadFromJson<AVDataRequest<AVValue>>(json);
        return results;
    }

    /// <summary>
    /// This API returns the monthly US All Employees: Total Nonfarm (commonly known as Total Nonfarm Payroll), a measure of the number of U.S. workers in the economy that excludes proprietors, private household employees, unpaid volunteers, farm employees, and the unincorporated self-employed.
    /// Source: U.S.Bureau of Labor Statistics, All Employees, Total Nonfarm, retrieved from FRED, Federal Reserve Bank of St.Louis.This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.
    /// By using this data feed, you agree to be bound by the FRED® API Terms of Use.
    /// </summary>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVDataRequest<AVValue>?> GetNonFarmPayrolls(CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=NONFARM_PAYROLL&apikey={Options.APIKey}";
        AVDataRequest<AVValue>? results = await Utilities.GetAPIData(url, GetNonFarmPayrollsFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON string returned by the Alpha Vantage API for Non-Farm Payrolls data.
    /// This API returns the monthly US All Employees: Total Nonfarm (commonly known as Total Nonfarm Payroll), a measure of the number of U.S. workers in the economy that excludes proprietors, private household employees, unpaid volunteers, farm employees, and the unincorporated self-employed.
    /// Source: U.S.Bureau of Labor Statistics, All Employees, Total Nonfarm, retrieved from FRED, Federal Reserve Bank of St.Louis.This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.
    /// By using this data feed, you agree to be bound by the FRED® API Terms of Use.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVDataRequest<AVValue>? GetNonFarmPayrollsFromJson(string json)
    {
        AVDataRequest<AVValue>? results = Serializer.LoadFromJson<AVDataRequest<AVValue>>(json);
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
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVDataRequest<AVValue>?> GetUnemploymentRate(CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=UNEMPLOYMENT&apikey={Options.APIKey}";
        AVDataRequest<AVValue>? results = await Utilities.GetAPIData(url, GetUnemploymentRateFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }


    /// <summary>
    /// Parses the JSON string returned by the Alpha Vantage API for Unemployment Rate data.
    /// This API returns the monthly unemployment data of the United States.
    /// The unemployment rate represents the number of unemployed as a percentage of the labor force. 
    /// Labor force data are restricted to people 16 years of age and older, who currently reside in 1 of the 50 states or the District of Columbia, 
    /// who do not reside in institutions (e.g., penal and mental facilities, homes for the aged), and who are not on active duty in the Armed Forces (source).
    /// Source: U.S.Bureau of Labor Statistics, Unemployment Rate, retrieved from FRED, Federal Reserve Bank of St.Louis.
    /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.By using this data feed, you agree to be bound by the FRED® API Terms of Use.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVDataRequest<AVValue>? GetUnemploymentRateFromJson(string json)
    {
        AVDataRequest<AVValue>? results = Serializer.LoadFromJson<AVDataRequest<AVValue>>(json);
        return results;
    }

}
