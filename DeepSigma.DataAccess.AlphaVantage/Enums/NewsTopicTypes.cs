using System.ComponentModel;

namespace DeepSigma.AlphaVantageAPI.Enums
{
    /// <summary>
    /// Available news topic types for Alpha Vantage news and sentiment API.
    /// </summary>
    public enum NewsTopicTypes
    {
        /// <summary>
        /// Blockchain news topic.
        /// </summary>
        [Description("blockchain")]
        Blockchain,
        /// <summary>
        /// Earnings news topic.
        /// </summary>
        [Description("earnings")]
        Earnings,
        /// <summary>
        /// IPO news topic.
        /// </summary>
        [Description("ipo")]
        IPO,
        /// <summary>
        /// Mergers and acquisitions news topic.
        /// </summary>
        [Description("mergers_and_acquisitions")]
        MergersAndAcquisitions,
        /// <summary>
        /// Financial markets news topic.
        /// </summary>
        [Description("financial_markets")]
        FinancialMarkets,
        /// <summary>
        /// Economy fiscal news topic.
        /// </summary>
        [Description("economy_fiscal")]
        EconomyFiscal,
        /// <summary>
        /// Economy monetary news topic.
        /// </summary>
        [Description("economy_monetary")]
        EconomyMonetary,
        /// <summary>
        /// Economy macro news topic.
        /// </summary>
        [Description("economy_macro")]
        EconomyMacro,
        /// <summary>
        /// Energy and transportation news topic.
        /// </summary>
        [Description("energy_transportation")]
        EnergyAndTransportation,
        /// <summary>
        /// Finance news topic.
        /// </summary>
        [Description("finance")]
        Finance,
        /// <summary>
        /// Life sciences news topic.
        /// </summary>
        [Description("life_sciences")]
        LifeSciences,
        /// <summary>
        /// Manufacturing news topic.
        /// </summary>
        [Description("manufacturing")]
        Manufacturing,
        /// <summary>
        /// Real estate and construction news topic.
        /// </summary>
        [Description("real_estate")]
        RealEstateAndConstruction,
        /// <summary>
        /// Retail and wholesale news topic.
        /// </summary>
        [Description("retail_wholesale")]
        RetailAndWholesale,
        /// <summary>
        /// Technology news topic.
        /// </summary>
        [Description("technology")]
        Technology
    }
}
