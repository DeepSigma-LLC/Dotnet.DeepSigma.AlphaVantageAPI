using System.ComponentModel;

namespace DeepSigma.DataAccess.AlphaVantage.Enums
{
    public enum EarningsHorizon
    {
        [Description("3month")]
        ThreeMonth,
        [Description("6month")]
        SixMonth,
        [Description("12month")]
        TwelveMonth
    }
}
