using Xunit;
using DeepSigma.DataAccess.AlphaVantage;
using DeepSigma.DataAccess.AlphaVantage.DataModels;

namespace DeepSigma.DataAccess.AlphaVantage.Tests
{
    public class AlphaVantage_CryptoData_Tests
    {

        [Fact]
        public void GetExchangeRateFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Crypto/AVCryptoExchangeRate.json");
            AVCurrencyExchangeRateQuoteResponse? results = api.CryptoData.GetExchangeRateFromJson(json);

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
            string json = File.ReadAllText(TestConfig.data_path + "/Crypto/AVCryptoExchangeRateIntraday.json");
            AVTimeSeriesResponseGeneric<AVBar>? results = api.CryptoData.GetExchangeRatesIntradayFromJson(json);

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
            string json = File.ReadAllText(TestConfig.data_path + "/Crypto/AVCryptoExchangeRateDaily.json");
            AVTimeSeriesResponseGeneric<AVBar>? results = api.CryptoData.GetExchangeRatesDailyFromJson(json);

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
            string json = File.ReadAllText(TestConfig.data_path + "/Crypto/AVCryptoExchangeRateWeekly.json");
            AVTimeSeriesResponseGeneric<AVBar>? results = api.CryptoData.GetExchangeRatesWeeklyFromJson(json);

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
            string json = File.ReadAllText(TestConfig.data_path + "/Crypto/AVCryptoExchangeRateMonthly.json");
            AVTimeSeriesResponseGeneric<AVBar>? results = api.CryptoData.GetExchangeRatesMonthlyFromJson(json);

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
