using DeepSigma.DataAccess.API.AlphaVantage.DataModels;
using DeepSigma.DataAccess.API.AlphaVantage.Enums;
using DeepSigma.General.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DeepSigma.DataAccess.API.AlphaVantage
{
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
        /// <param name="return_type"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetUSTreasuryYield(FixedIncomeMaturities maturity, TimeSeriesInterval interval = TimeSeriesInterval.Daily, DataReturnType return_type = DataReturnType.Json, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=TREASURY_YIELD&interval={interval.ToDescriptionString()}&maturity={maturity.ToDescriptionString()}&datatype={return_type.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVValue>>(url, timeout_seconds, json_logger, ct);
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
        /// <param name="return_type"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<AVDataRequest<AVValue>?> GetFedFunds(TimeSeriesInterval interval = TimeSeriesInterval.Daily, DataReturnType return_type = DataReturnType.Json, CancellationToken ct = default)
        {
            string url = $"https://www.alphavantage.co/query?function=FEDERAL_FUNDS_RATE&interval={interval.ToDescriptionString()}&datatype={return_type.ToDescriptionString()}&apikey={api_key}";
            AVDataRequest<AVValue>? results = await APIUtilities.GetDataFromURLAsync<AVDataRequest<AVValue>>(url, timeout_seconds, json_logger, ct);
            return results;
        }

    }
}
