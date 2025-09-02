using System.ComponentModel;

namespace DeepSigma.DataAccess.AlphaVantage.Enums
{
    /// <summary>
    /// The fixed income maturities for US Treasury yields.
    /// </summary>
    public enum FixedIncomeMaturities
    {
        /// <summary>
        /// The 3-month maturity.
        /// </summary>
        [Description("3month")]
        ThreeMonth,
        /// <summary>
        /// The 2-year maturity.
        /// </summary>
        [Description("2year")]
        TwoYear,
        /// <summary>
        /// The 5-year maturity.
        /// </summary>
        [Description("5year")]
        FiveYear,
        /// <summary>
        /// The 7-year maturity.
        /// </summary>
        [Description("7year")]
        SevenYear,
        /// <summary>
        /// The 10-year maturity.
        /// </summary>
        [Description("10year")]
        TenYear,
        /// <summary>
        /// The 30-year maturity.
        /// </summary>
        [Description("30year")]
        ThirtyYear
    }
}
