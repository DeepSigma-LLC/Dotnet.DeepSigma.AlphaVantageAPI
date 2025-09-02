using System.ComponentModel;

namespace DeepSigma.DataAccess.AlphaVantage.Enums
{
    /// <summary>
    /// Specifies the size of the output data from the Alpha Vantage API.
    /// </summary>
    public enum OutputSize
    {
        /// <summary>
        /// Returns an abridged version of the time series.
        /// </summary>
        [Description("compact")]
        Compact,
        /// <summary>
        /// Returns the full-length time series.
        /// </summary>
        [Description("full")]
        Full
    }
}
