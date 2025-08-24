using System.ComponentModel;

namespace DeepSigma.DataAccess.AlphaVantage.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum TimeSeriesIntradayInterval
    {
        [Description("1Min")]
        One,
        [Description("5Min")]
        Five,
        [Description("10Min")]
        Ten,
        [Description("15Min")]
        Fifteen,
        [Description("30Min")]
        Thirty,
        [Description("60Min")]
        Sixty
    }
}
