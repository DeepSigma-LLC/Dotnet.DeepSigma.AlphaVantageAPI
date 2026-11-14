using Xunit;
using DeepSigma.AlphaVantageAPI.Models;
using DeepSigma.AlphaVantageAPI.APIs.Option;
using DeepSigma.AlphaVantageAPI.APIs.Option.Models;

namespace DeepSigma.AlphaVantageAPI.Tests;

public class AlphaVantage_OptionData_Tests
{
    [Fact]
    public void GetHistoricalOptionDataFromJson_ResultsShouldReturnValues()
    {
        string json = File.ReadAllText(TestConfig.data_path + "/Option/AVOptionDataHistorical.json");
        AVDataRequest<AVOptionData>? results = OptionData.GetHistoricalOptionDataFromJson(json);

        bool has_data = false;
        if (results is not null)
        {
            has_data = results.Data.Count() > 2;
        }
        Assert.True(has_data);
    }

    [Fact]
    public void GetRealTimeOptionDataFromJson_ResultsShouldReturnValues()
    {
        string json = File.ReadAllText(TestConfig.data_path + "/Option/AVOptionDataRealTime.json");
        AVDataRequest<AVOptionData>? results = OptionData.GetRealTimeOptionDataFromJson(json);

        bool has_data = false;
        if (results is not null)
        {
            has_data = results.Data.Count() > 2;
        }
        Assert.True(has_data);
    }

    [Fact]
    public void GetRealTimeVolumeToOpenInterestRatioFromJson_ResultsShouldReturnValues()
    {
        string json = File.ReadAllText(TestConfig.data_path + "/Option/AVRealTimeVolumeToOpenInterest.json");
        AVVolumeToOpenInterestRatioResponse? results = OptionData.GetVolumeToOpenInterestRatioFromJson(json);
        bool has_data = false;
        if (results is not null)
        {
            has_data = results.Data.Count() > 2;
        }
        Assert.True(has_data);
    }

    [Fact]
    public void GetHistoricalVolumeToOpenInterestRatioFromJson_ResultsShouldReturnValues()
    {
        string json = File.ReadAllText(TestConfig.data_path + "/Option/AVHistoricalVolumeToOpenInterestRatio.json");
        AVVolumeToOpenInterestRatioResponse? results = OptionData.GetVolumeToOpenInterestRatioFromJson(json);
        bool has_data = false;
        if (results is not null)
        {
            has_data = results.Data.Count() > 2;
        }
        Assert.True(has_data);
    }

    [Fact]
    public void GetRealTimePutToCallRatioFromJson_ResultsShouldReturnValues()
    {
        string json = File.ReadAllText(TestConfig.data_path + "/Option/AVRealTimePutToCallRatio.json");
        AVPutToCallRatioResponse? results = OptionData.GetPutToCallRatioFromJson(json);
        bool has_data = false;
        if (results is not null)
        {
            has_data = results.PutCallRatioByExpiration.Count() > 2;
        }
        Assert.True(has_data);
    }

    [Fact]
    public void GetHistoricalPutToCallRatioFromJson_ResultsShouldReturnValues()
    {
        string json = File.ReadAllText(TestConfig.data_path + "/Option/AVHistoricalPutToCallRatio.json");
        AVPutToCallRatioResponse? results = OptionData.GetPutToCallRatioFromJson(json);
        bool has_data = false;
        if (results is not null)
        {
            has_data = results.PutCallRatioByExpiration.Count() > 2;
        }
        Assert.True(has_data);
    }
}
