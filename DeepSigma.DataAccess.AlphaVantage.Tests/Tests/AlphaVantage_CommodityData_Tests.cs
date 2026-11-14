using Xunit;
using DeepSigma.AlphaVantageAPI.Models;
using DeepSigma.AlphaVantageAPI.APIs.Commodities;

namespace DeepSigma.AlphaVantageAPI.Tests;

public class AlphaVantage_CommodityData_Tests
{
    [Fact]
    public void GetWTIFromJson_ResultsShouldReturnValues()
    {
        string json = File.ReadAllText(TestConfig.data_path + "/Commodity/AVWTIDataRequest.json");
        AVDataRequest<AVValue>? results = CommodityData.GetWTIFromJson(json);

        bool has_data = false;
        if (results is not null)
        {
            has_data = results.Data.Count() > 2;
        }
        Assert.True(has_data);
    }

    [Fact]
    public void GetBrentFromJson_ResultsShouldReturnValues()
    {
        string json = File.ReadAllText(TestConfig.data_path + "/Commodity/AVBrentDataRequest.json");
        AVDataRequest<AVValue>? results = CommodityData.GetBrentFromJson(json);

        bool has_data = false;
        if (results is not null)
        {
            has_data = results.Data.Count() > 2;
        }
        Assert.True(has_data);
    }


    [Fact]
    public void GetNaturalGasFromJson_ResultsShouldReturnValues()
    {
        string json = File.ReadAllText(TestConfig.data_path + "/Commodity/AVNaturalGasRequest.json");
        AVDataRequest<AVValue>? results = CommodityData.GetNaturalGasFromJson(json);

        bool has_data = false;
        if (results is not null)
        {
            has_data = results.Data.Count() > 2;
        }
        Assert.True(has_data);
    }



    [Fact]
    public void GetCopperFromJson_ResultsShouldReturnValues()
    {
        string json = File.ReadAllText(TestConfig.data_path + "/Commodity/AVCopperRequest.json");
        AVDataRequest<AVValue>? results = CommodityData.GetCopperFromJson(json);

        bool has_data = false;
        if (results is not null)
        {
            has_data = results.Data.Count() > 2;
        }
        Assert.True(has_data);
    }

    [Fact]
    public void GetAluminumFromJson_ResultsShouldReturnValues()
    {
        string json = File.ReadAllText(TestConfig.data_path + "/Commodity/AVAluminumRequest.json");
        AVDataRequest<AVValue>? results = CommodityData.GetCopperFromJson(json);

        bool has_data = false;
        if (results is not null)
        {
            has_data = results.Data.Count() > 2;
        }
        Assert.True(has_data);
    }

    [Fact]
    public void GetWheatFromJson_ResultsShouldReturnValues()
    {
        string json = File.ReadAllText(TestConfig.data_path + "/Commodity/AVWheatRequest.json");
        AVDataRequest<AVValue>? results = CommodityData.GetWheatFromJson(json);

        bool has_data = false;
        if (results is not null)
        {
            has_data = results.Data.Count() > 2;
        }
        Assert.True(has_data);
    }


    [Fact]
    public void GetCornFromJson_ResultsShouldReturnValues()
    {
        string json = File.ReadAllText(TestConfig.data_path + "/Commodity/AVCornRequest.json");
        AVDataRequest<AVValue>? results = CommodityData.GetCornFromJson(json);

        bool has_data = false;
        if (results is not null)
        {
            has_data = results.Data.Count() > 2;
        }
        Assert.True(has_data);
    }


    [Fact]
    public void GetCottonFromJson_ResultsShouldReturnValues()
    {
        string json = File.ReadAllText(TestConfig.data_path + "/Commodity/AVCottonRequest.json");
        AVDataRequest<AVValue>? results = CommodityData.GetCottonFromJson(json);

        bool has_data = false;
        if (results is not null)
        {
            has_data = results.Data.Count() > 2;
        }
        Assert.True(has_data);
    }


    [Fact]
    public void GetSugarFromJson_ResultsShouldReturnValues()
    {
        string json = File.ReadAllText(TestConfig.data_path + "/Commodity/AVSugarRequest.json");
        AVDataRequest<AVValue>? results = CommodityData.GetSugarFromJson(json);

        bool has_data = false;
        if (results is not null)
        {
            has_data = results.Data.Count() > 2;
        }
        Assert.True(has_data);
    }


    [Fact]
    public void GetCoffeeFromJson_ResultsShouldReturnValues()
    {
        string json = File.ReadAllText(TestConfig.data_path + "/Commodity/AVCoffeeRequest.json");
        AVDataRequest<AVValue>? results = CommodityData.GetCoffeeFromJson(json);

        bool has_data = false;
        if (results is not null)
        {
            has_data = results.Data.Count() > 2;
        }
        Assert.True(has_data);
    }

    [Fact]
    public void GetCommodityIndexFromJson_ResultsShouldReturnValues()
    {
        string json = File.ReadAllText(TestConfig.data_path + "/Commodity/AVCommodityIndexRequest.json");
        AVDataRequest<AVValue>? results = CommodityData.GetGlobalCommodityIndexFromJson(json);

        bool has_data = false;
        if (results is not null)
        {
            has_data = results.Data.Count() > 2;
        }
        Assert.True(has_data);
    }
}
