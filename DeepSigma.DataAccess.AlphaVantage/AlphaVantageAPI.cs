using DeepSigma.DataAccess.API.AlphaVantage.DataModels;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeepSigma.DataAccess.API.AlphaVantage
{
    public class AlphaVantageAPI
    {
        private string api_key {  get; }
        public UtilitiesData Utilities { get; }
        public StockData StockData { get; }
        public OptionData OptionData { get; }
        public CommodityData CommodityData { get; }
        public FundamentalData FundamentalData { get; }
        public FXData FXData { get; }
        public CryptoData CryptoData { get; }
        public EconomicData EconomicData { get; }
        public FixedIncomeData FixedIncomeData { get; }
        private Action<string?>? json_logger { get; set; } = null;
        public AlphaVantageAPI(string api_key = "demo", Action<string?>? json_logger = null)
        {
            this.api_key = api_key;
            this.json_logger = json_logger;
            Utilities = new UtilitiesData(api_key, json_logger);
            StockData = new StockData(api_key, json_logger);
            OptionData = new OptionData(api_key, json_logger);
            CommodityData = new CommodityData(api_key, json_logger);
            FundamentalData = new FundamentalData(api_key, json_logger);
            FXData = new FXData(api_key, json_logger);
            CryptoData = new CryptoData(api_key, json_logger);
            EconomicData = new EconomicData(api_key, json_logger);
            FixedIncomeData = new FixedIncomeData(api_key, json_logger);
        }


    }
}
