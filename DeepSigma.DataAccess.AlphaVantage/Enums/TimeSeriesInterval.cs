using System.ComponentModel;

namespace DeepSigma.DataAccess.AlphaVantage.Enums
{
    public enum TimeSeriesInterval
    {
        [Description("daily")]
        Daily,
        [Description("weekly")]
        Weekly,
        [Description("monthly")]
        Monthly,
        [Description("quarterly")]
        Quarterly,
        [Description("semiannual")]
        Semiannual,
        [Description("annual")]
        Annual
    }
}
