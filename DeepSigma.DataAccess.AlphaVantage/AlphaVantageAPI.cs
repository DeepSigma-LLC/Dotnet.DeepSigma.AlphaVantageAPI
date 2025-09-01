

namespace DeepSigma.DataAccess.AlphaVantage
{
    /// <summary>
    /// Alpha Vantage API Client.
    /// </summary>
    /// <param name="api_key"></param>
    /// <param name="json_logger"></param>
    public class AlphaVantageAPI(string api_key = "demo", Action<string?>? json_logger = null)
    {
        private string api_key {  get; } = api_key; 
        private Action<string?>? json_logger { get; set; } = json_logger;
        /// <summary>
        /// Utilities for Alpha Vantage API.
        /// </summary>
        public UtilitiesData Utilities { get; } = new UtilitiesData(api_key, json_logger);
        /// <summary>
        /// Stock data related APIs.
        /// </summary>
        public StockData StockData { get; } = new StockData(api_key, json_logger);
        /// <summary>
        /// Option data related APIs.
        /// </summary>
        public OptionData OptionData { get; } = new OptionData(api_key, json_logger);
        /// <summary>
        /// Commodity data related APIs.
        /// </summary>
        public CommodityData CommodityData { get; } = new CommodityData(api_key, json_logger);
        /// <summary>
        /// Fundamental data related APIs.
        /// </summary>
        public FundamentalData FundamentalData { get; } = new FundamentalData(api_key, json_logger);
        /// <summary>
        /// Forex data related APIs.
        /// </summary>
        public FXData FXData { get; } = new FXData(api_key, json_logger);
        /// <summary>
        /// Cryptocurrency data related APIs.
        /// </summary>
        public CryptoData CryptoData { get; } = new CryptoData(api_key, json_logger);
        /// <summary>
        /// Economic data related APIs.
        /// </summary>
        public EconomicData EconomicData { get; } = new EconomicData(api_key, json_logger);
        /// <summary>
        /// Fixed income data related APIs.
        /// </summary>
        public FixedIncomeData FixedIncomeData { get; } = new FixedIncomeData(api_key, json_logger);
    }
}
