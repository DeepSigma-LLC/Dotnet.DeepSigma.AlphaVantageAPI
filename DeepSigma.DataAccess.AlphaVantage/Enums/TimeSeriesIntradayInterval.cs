using System.ComponentModel;

namespace DeepSigma.DataAccess.AlphaVantage.Enums
{
    /// <summary>
    /// Intraday time intervals for Alpha Vantage Time Series API calls. 
    /// </summary>
    public enum TimeSeriesIntradayInterval
    {
        /// <summary>
        /// 1 minute interval.
        /// </summary>
        [Description("1Min")]
        One,
        /// <summary>
        /// 5 minute interval.
        /// </summary>
        [Description("5Min")]
        Five,
        /// <summary>
        /// 10 minute interval.
        /// </summary>
        [Description("10Min")]
        Ten,
        /// <summary>
        /// 15 minute interval.
        /// </summary>
        [Description("15Min")]
        Fifteen,
        /// <summary>
        /// 30 minute interval.
        /// </summary>
        [Description("30Min")]
        Thirty,
        /// <summary>
        /// 60 minute interval.
        /// </summary>
        [Description("60Min")]
        Sixty
    }
}
