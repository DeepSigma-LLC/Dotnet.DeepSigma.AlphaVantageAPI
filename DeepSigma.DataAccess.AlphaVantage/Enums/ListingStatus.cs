using System.ComponentModel;

namespace DeepSigma.DataAccess.AlphaVantage.Enums
{
    /// <summary>
    /// The listing status of a security.
    /// </summary>
    public enum ListingStatus
    {
        /// <summary>
        /// The security is currently active and trading.
        /// </summary>
        [Description("active")]
        Active,
        /// <summary>
        /// The security has been delisted and is no longer trading.
        /// </summary>
        [Description("delisted")]
        Delisted
    }
}
