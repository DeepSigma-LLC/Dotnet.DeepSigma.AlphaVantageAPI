using System.ComponentModel;

namespace DeepSigma.AlphaVantageAPI.Enums
{
    /// <summary>
    /// The time series interval for the data request.
    /// </summary>
    public enum TimeSeriesInterval
    {
        /// <summary>
        /// Daily time series interval.
        /// </summary>
        [Description("daily")]
        Daily,
        /// <summary>
        /// Weekly time series interval.
        /// </summary>
        [Description("weekly")]
        Weekly,
        /// <summary>
        /// Monthly time series interval.
        /// </summary>
        [Description("monthly")]
        Monthly,
        /// <summary>
        /// Quarterly time series interval.
        /// </summary>
        [Description("quarterly")]
        Quarterly,
        /// <summary>
        /// Semiannual time series interval.
        /// </summary>
        [Description("semiannual")]
        Semiannual,
        /// <summary>
        /// Annual time series interval.
        /// </summary>
        [Description("annual")]
        Annual
    }
}
