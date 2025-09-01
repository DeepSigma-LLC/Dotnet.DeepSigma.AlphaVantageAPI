using Xunit;
using DeepSigma.DataAccess.AlphaVantage;
using DeepSigma.DataAccess.AlphaVantage.DataModels;

namespace DeepSigma.DataAccess.AlphaVantage.Tests
{
    public class AlphaVantage_StockData_Tests
    {
        [Fact]
        public void GetIntradayTimeSeriesDataFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Stock/AVStockDataIntraday.json");
            AVTimeSeriesResponseGeneric<AVBar>? results = api.StockData.GetIntradayTimeSeriesDataFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count > 0;
            }
            Assert.True(has_data);
        }


        [Fact]
        public void GetDailyTimeSeriesDataFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Stock/AVStockDataAdjustedDaily.json");
            AVTimeSeriesResponseGeneric<AVBar>? results = api.StockData.GetDailyTimeSeriesDataFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count > 0;
            }
            Assert.True(has_data);
        }

        [Fact]
        public void GetWeeklyTimeSeriesDataFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Stock/AVStockDataAdjustedWeekly.json");
            AVTimeSeriesResponseGeneric<AVBar>? results = api.StockData.GetWeeklyTimeSeriesDataFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count > 0;
            }
            Assert.True(has_data);
        }

        [Fact]
        public void GetMonthlyTimeSeriesDataFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Stock/AVStockDataAdjustedMonthly.json");
            AVTimeSeriesResponseGeneric<AVBar>? results = api.StockData.GetMonthlyTimeSeriesDataFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count > 0;
            }
            Assert.True(has_data);
        }

        [Fact]
        public void GetBulkDataRequestFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Stock/AVBulkDataRequest.json");
            AVDataRequest<AVBulkQuoteData>? results = api.StockData.GetBulkRealTimeQuoteDataFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count > 0;
            }
            Assert.True(has_data);
        }
    }
}
