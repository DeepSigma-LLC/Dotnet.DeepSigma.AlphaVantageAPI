using Xunit;
using DeepSigma.AlphaVantageAPI;
using DeepSigma.AlphaVantageAPI.DataModels;

namespace DeepSigma.AlphaVantageAPI.Tests
{
    public class AlphaVantage_CryptoData_Tests
    {

        [Fact]
        public void GetExchangeRateFromJson_ResultsShouldReturnValues()
        {
            string json = File.ReadAllText(TestConfig.data_path + "/Crypto/AVCryptoExchangeRate.json");
            AVCurrencyExchangeRateQuoteResponse? results = CryptoData.GetExchangeRateFromJson(json);

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
            string json = File.ReadAllText(TestConfig.data_path + "/Crypto/AVCryptoExchangeRateIntraday.json");
            AVTimeSeriesResponseGeneric<AVBar>? results = CryptoData.GetExchangeRatesIntradayFromJson(json);

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
            string json = File.ReadAllText(TestConfig.data_path + "/Crypto/AVCryptoExchangeRateDaily.json");
            AVTimeSeriesResponseGeneric<AVBar>? results = CryptoData.GetExchangeRatesDailyFromJson(json);

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
            string json = File.ReadAllText(TestConfig.data_path + "/Crypto/AVCryptoExchangeRateWeekly.json");
            AVTimeSeriesResponseGeneric<AVBar>? results = CryptoData.GetExchangeRatesWeeklyFromJson(json);

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
            string json = File.ReadAllText(TestConfig.data_path + "/Crypto/AVCryptoExchangeRateMonthly.json");
            AVTimeSeriesResponseGeneric<AVBar>? results = CryptoData.GetExchangeRatesMonthlyFromJson(json);

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
