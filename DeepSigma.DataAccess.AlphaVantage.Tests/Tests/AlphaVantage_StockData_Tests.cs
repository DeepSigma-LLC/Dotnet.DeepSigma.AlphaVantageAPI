using Xunit;
using DeepSigma.AlphaVantageAPI.Models;
using DeepSigma.AlphaVantageAPI.APIs.Stock;
using DeepSigma.AlphaVantageAPI.APIs.Stock.Models;

namespace DeepSigma.AlphaVantageAPI.Tests;

public class AlphaVantage_StockData_Tests
{
    [Fact]
    public void GetIntradayTimeSeriesDataFromJson_ResultsShouldReturnValues()
    {
        string json = File.ReadAllText(TestConfig.data_path + "/Stock/AVStockDataIntraday.json");
        AVTimeSeriesResponseGeneric<AVBar>? results = StockData.GetIntradayTimeSeriesDataFromJson(json);

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
        string json = File.ReadAllText(TestConfig.data_path + "/Stock/AVStockDataAdjustedDaily.json");
        AVTimeSeriesResponseGeneric<AVBar>? results = StockData.GetDailyTimeSeriesDataFromJson(json);

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
        string json = File.ReadAllText(TestConfig.data_path + "/Stock/AVStockDataAdjustedWeekly.json");
        AVTimeSeriesResponseGeneric<AVBar>? results = StockData.GetWeeklyTimeSeriesDataFromJson(json);

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
        string json = File.ReadAllText(TestConfig.data_path + "/Stock/AVStockDataAdjustedMonthly.json");
        AVTimeSeriesResponseGeneric<AVBar>? results = StockData.GetMonthlyTimeSeriesDataFromJson(json);

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
        string json = File.ReadAllText(TestConfig.data_path + "/Stock/AVBulkDataRequest.json");
        AVDataRequest<AVBulkQuoteData>? results = StockData.GetBulkRealTimeQuoteDataFromJson(json);

        bool has_data = false;
        if (results is not null)
        {
            has_data = results.Data.Count > 0;
        }
        Assert.True(has_data);
    }
}
