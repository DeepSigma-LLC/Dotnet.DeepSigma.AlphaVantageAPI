using DeepSigma.AlphaVantageAPI.DataModels;
using DeepSigma.AlphaVantageAPI.Enums;
using DeepSigma.DataAccess.API;
using DeepSigma.General.Extensions;

namespace DeepSigma.AlphaVantageAPI;

/// <summary>
/// This class contains methods to access fixed income data from the Alpha Vantage API.
/// </summary>
public class FixedIncomeData
{
    private string api_key { get; set; }
    private Action<string?>? json_logger { get; set; } = null;
    private int timeout_seconds { get; set; }
    internal FixedIncomeData(string api_key, Action<string?>? json_logger, int timeout_seconds = 15)
    {
        this.api_key = api_key;
        this.json_logger = json_logger;
        this.timeout_seconds = timeout_seconds;
    }

    /// <summary>
    /// This API returns the daily, weekly, and monthly US treasury yield of a given maturity timeline (e.g., 5 year, 30 year, etc).
    /// Source: Board of Governors of the Federal Reserve System(US), Market Yield on U.S.Treasury Securities at 3-month, 2-year, 5-year, 7-year, 10-year, and 30-year Constant Maturities, 
    /// Quoted on an Investment Basis, retrieved from FRED, Federal Reserve Bank of St.Louis.
    /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St.Louis.
    /// By using this data feed, you agree to be bound by the FRED® API Terms of Use.
    /// </summary>
    /// <param name="maturity"></param>
    /// <param name="interval"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVDataRequest<AVValue>?> GetUSTreasuryYield(FixedIncomeMaturities maturity, TimeSeriesInterval interval = TimeSeriesInterval.Daily, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=TREASURY_YIELD&interval={interval.ToDescriptionString()}&maturity={maturity.ToDescriptionString()}&apikey={api_key}";
        AVDataRequest<AVValue>? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetUSTreasuryYieldFromJson, timeout_seconds, ct, json_logger);
        return results;
    }

    /// <summary>
    /// Parses the JSON response returned by the Alpha Vantage API for US Treasury Yields.
    /// This API returns the daily, weekly, and monthly federal funds rate (interest rate) of the United States.
    /// Source: Board of Governors of the Federal Reserve System(US), Federal Funds Effective Rate, retrieved from FRED, 
    /// Federal Reserve Bank of St.Louis(https://fred.stlouisfed.org/series/FEDFUNDS). 
    /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St. Louis. 
    /// By using this data feed, you agree to be bound by the FRED® API Terms of Use.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVDataRequest<AVValue>? GetUSTreasuryYieldFromJson(string json)
    {
        AVDataRequest<AVValue>? results = APIUtilities.LoadFromJson<AVDataRequest<AVValue>>(json);
        return results;
    }


    /// <summary>
    /// This API returns the daily, weekly, and monthly federal funds rate (interest rate) of the United States.
    /// Source: Board of Governors of the Federal Reserve System(US), Federal Funds Effective Rate, retrieved from FRED, 
    /// Federal Reserve Bank of St.Louis(https://fred.stlouisfed.org/series/FEDFUNDS). 
    /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St. Louis. 
    /// By using this data feed, you agree to be bound by the FRED® API Terms of Use.
    /// </summary>
    /// <param name="interval"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVDataRequest<AVValue>?> GetFedFunds(TimeSeriesInterval interval = TimeSeriesInterval.Daily, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=FEDERAL_FUNDS_RATE&interval={interval.ToDescriptionString()}&apikey={api_key}";
        AVDataRequest<AVValue>? results = await AlphaVantageAPIUtilities.GetAPIData(url, GetFedFundsFromJson, timeout_seconds, ct, json_logger);
        return results;
    }

    /// <summary>
    /// Parses the JSON response returned by the Alpha Vantage API for Fed Funds Rate.
    /// This API returns the daily, weekly, and monthly federal funds rate (interest rate) of the United States.
    /// Source: Board of Governors of the Federal Reserve System(US), Federal Funds Effective Rate, retrieved from FRED, 
    /// Federal Reserve Bank of St.Louis(https://fred.stlouisfed.org/series/FEDFUNDS). 
    /// This data feed uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St. Louis. 
    /// By using this data feed, you agree to be bound by the FRED® API Terms of Use.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVDataRequest<AVValue>? GetFedFundsFromJson(string json)
    {
        AVDataRequest<AVValue>? results = APIUtilities.LoadFromJson<AVDataRequest<AVValue>>(json);
        return results;
    }
}
