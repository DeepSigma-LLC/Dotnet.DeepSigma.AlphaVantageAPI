using System.ComponentModel;

namespace DeepSigma.DataAccess.AlphaVantage.Enums
{
    /// <summary>
    /// The earnings time horizon for data request.
    /// </summary>
    public enum EarningsHorizon
    {
        /// <summary>
        /// The 3 month earnings horizon.
        /// </summary>
        [Description("3month")]
        ThreeMonth,
        /// <summary>
        /// The 6 month earnings horizon.
        /// </summary>
        [Description("6month")]
        SixMonth,
        /// <summary>
        /// The 12 month earnings horizon.
        /// </summary>
        [Description("12month")]
        TwelveMonth
    }
}
