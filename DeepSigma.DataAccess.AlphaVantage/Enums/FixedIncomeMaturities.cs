using System.ComponentModel;

namespace DeepSigma.DataAccess.AlphaVantage.Enums
{
    public enum FixedIncomeMaturities
    {
        [Description("3month")]
        ThreeMonth, 
        [Description("2year")]
        TwoYear,
        [Description("5year")]
        FiveYear,
        [Description("7year")]
        SevenYear,
        [Description("10year")]
        TenYear,
        [Description("30year")]
        ThirtyYear
    }
}
