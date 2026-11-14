using Xunit;
using DeepSigma.AlphaVantageAPI.Models;
using DeepSigma.AlphaVantageAPI.APIs.FX;
using DeepSigma.AlphaVantageAPI.APIs.FX.Models;

namespace DeepSigma.AlphaVantageAPI.Tests;

public class AlphaVantage_FXData_Tests
{
    [Fact]
    public void GetExchangeRateFromJson_ResultsShouldReturnValues()
    {
        string json = File.ReadAllText(TestConfig.data_path + "/FX/AVFXExchangeRateQuote.json");
        AVCurrencyExchangeRateQuoteResponse? results = FXData.GetExchangeRateFromJson(json);

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
        string json = File.ReadAllText(TestConfig.data_path + "/FX/AVFXExchangeRateIntraday.json");
        AVTimeSeriesResponseGeneric<AVBar>? results = FXData.GetExchangeRatesIntradayFromJson(json);

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
        string json = File.ReadAllText(TestConfig.data_path + "/FX/AVFXExchangeRateDaily.json");
        AVTimeSeriesResponseGeneric<AVBar>? results = FXData.GetExchangeRatesDailyFromJson(json);

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
        string json = File.ReadAllText(TestConfig.data_path + "/FX/AVFXExchangeRateWeekly.json");
        AVTimeSeriesResponseGeneric<AVBar>? results = FXData.GetExchangeRatesWeeklyFromJson(json);

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
        string json = File.ReadAllText(TestConfig.data_path + "/FX/AVFXExchangeRateMonthly.json");
        AVTimeSeriesResponseGeneric<AVBar>? results = FXData.GetExchangeRatesMonthlyFromJson(json);

        bool has_data = false;
        if (results is not null)
        {
            SortedDictionary<DateTime, AVBar> data = results.Data;
            has_data = data.Count > 0;
        }
        Assert.True(has_data);
    }

}
