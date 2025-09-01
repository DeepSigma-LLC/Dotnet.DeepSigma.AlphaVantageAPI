using Xunit;
using DeepSigma.DataAccess.AlphaVantage;
using DeepSigma.DataAccess.AlphaVantage.DataModels;
namespace DeepSigma.DataAccess.AlphaVantage.Tests
{
    public class AlphaVantage_FXData_Tests
    {
        [Fact]
        public void GetExchangeRateFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/FX/AVFXExchangeRateQuote.json");
            AVCurrencyExchangeRateQuoteResponse? results = api.FXData.GetExchangeRateFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Quote.ExchangeRate > 0;
            }
            Assert.True(has_data);
        }

        [Fact]
        public void GetExchangeRateIntradayFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/FX/AVFXExchangeRateIntraday.json");
            AVTimeSeriesResponseGeneric<AVBar>? results = api.FXData.GetExchangeRatesIntradayFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count > 0;
            }
            Assert.True(has_data);
        }

        [Fact]
        public void GetExchangeRateDailyFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/FX/AVFXExchangeRateDaily.json");
            AVTimeSeriesResponseGeneric<AVBar>? results = api.FXData.GetExchangeRatesDailyFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                SortedDictionary<DateTime, AVBar> data = results.Data;
                has_data = data.Count > 0;
            }
            Assert.True(has_data);
        }

        [Fact]
        public void GetExchangeRateWeeklyFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/FX/AVFXExchangeRateWeekly.json");
            AVTimeSeriesResponseGeneric<AVBar>? results = api.FXData.GetExchangeRatesWeeklyFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                SortedDictionary<DateTime, AVBar> data = results.Data;
                has_data = data.Count > 0;
            }
            Assert.True(has_data);
        }

        [Fact]
        public void GetExchangeRateMonthlyFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/FX/AVFXExchangeRateMonthly.json");
            AVTimeSeriesResponseGeneric<AVBar>? results = api.FXData.GetExchangeRatesMonthlyFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                SortedDictionary<DateTime, AVBar> data = results.Data;
                has_data = data.Count > 0;
            }
            Assert.True(has_data);
        }

    }
}
