using System.ComponentModel;

namespace DeepSigma.DataAccess.AlphaVantage.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum SortType
    {
        [Description("relevance")]
        Relevance,
        [Description("latest")]
        Latest,
        [Description("earliest")]
        Earliest
    }
}
