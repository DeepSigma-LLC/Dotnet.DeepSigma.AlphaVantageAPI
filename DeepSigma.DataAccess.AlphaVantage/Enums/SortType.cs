using System.ComponentModel;

namespace DeepSigma.DataAccess.AlphaVantage.Enums
{
    /// <summary>
    /// Specifies the sort order for  results from the Alpha Vantage API.
    /// </summary>
    public enum SortType
    {
        /// <summary>
        /// Sort by relevance.
        /// </summary>
        [Description("relevance")]
        Relevance,
        /// <summary>
        /// Sort by latest.
        /// </summary>
        [Description("latest")]
        Latest,
        /// <summary>
        /// Sort by earliest.
        /// </summary>
        [Description("earliest")]
        Earliest
    }
}
