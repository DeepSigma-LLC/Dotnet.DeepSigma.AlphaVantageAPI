using System.ComponentModel;

namespace DeepSigma.DataAccess.AlphaVantage.Enums
{
    public enum NewsTopicTypes
    {
        [Description("blockchain")]
        Blockchain,
        [Description("earnings")]
        Earnings,
        [Description("ipo")]
        IPO,
        [Description("mergers_and_acquisitions")]
        MergersAndAcquisitions,
        [Description("financial_markets")]
        FinancialMarkets,
        [Description("economy_fiscal")]
        EconomyFiscal,
        [Description("economy_monetary")]
        EconomyMonetary,
        [Description("economy_macro")]
        EconomyMacro,
        [Description("energy_transportation")]
        EnergyAndTransportation,
        [Description("finance")]
        Finance,
        [Description("life_sciences")]
        LifeSciences,
        [Description("manufacturing")]
        Manufacturing,
        [Description("real_estate")]
        RealEstateAndConstruction,
        [Description("retail_wholesale")]
        RetailAndWholesale,
        [Description("technology")]
        Technology
    }
}
