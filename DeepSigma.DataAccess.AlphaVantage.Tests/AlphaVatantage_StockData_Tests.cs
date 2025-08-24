using Xunit;
using DeepSigma.DataAccess.API.AlphaVantage.Enums;
using DeepSigma.DataAccess.API.AlphaVantage;
using DeepSigma.DataAccess.Utilities;
using DeepSigma.DataAccess.API.AlphaVantage.DataModels;
using DeepSigma.DataAccess.API.AlphaVantage.Parsers;

namespace DataAccessTests
{
    public class AlphaVatantage_StockData_Tests
    {
        KeyChainItem api_key = MyKeyChain.GetKeys().GetKey("AlphaVantageFree") ?? throw new ArgumentNullException("API key not found in KeyChain.");

        [Fact]
        public async Task GetIntradayTimeSeriesData_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new(api_key.Key);
            AVTimeSeriesResponseGeneric<AVBar>? results = await api.StockData.GetIntradayTimeSeriesData("SPY");
            
            bool has_data = false;
            if (results is not null)
            {
                results.SetParser(AVBarParser.Parse);
                has_data = results.GetSeries().Count() > 2;
            }
            Assert.True(has_data);
        }

        [Fact]
        public async Task GetDailyTimeSeriesData_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new(api_key.Key);
            AVTimeSeriesResponseGeneric<AVBar>? results = await api.StockData.GetDailyTimeSeriesData("SPY", OutputSize.Compact);

            bool has_data = false;
            if(results is not null)
            {
                results.SetParser(AVBarParser.Parse);
                has_data = results.GetSeries().Count() > 2;
            }
            Assert.True(has_data);
        }

        [Fact]
        public async Task GetWeeklyTimeSeriesData_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new(api_key.Key);
            AVTimeSeriesResponseGeneric<AVBar>? results = await api.StockData.GetWeeklyTimeSeriesData("SPY");

            bool has_data = false;
            if (results is not null)
            {
                results.SetParser(AVBarParser.Parse);
                has_data = results.GetSeries().Count() > 2;
            }
            Assert.True(has_data);
        }

        [Fact]
        public async Task GetMonthlyTimeSeriesData_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new(api_key.Key);
            AVTimeSeriesResponseGeneric<AVBar>? results = await api.StockData.GetMonthlyTimeSeriesData("SPY");

            bool has_data = false;
            if (results is not null)
            {
                results.SetParser(AVBarParser.Parse);
                has_data = results.GetSeries().Count() > 2;
            }
            Assert.True(has_data);
        }
    }
}
