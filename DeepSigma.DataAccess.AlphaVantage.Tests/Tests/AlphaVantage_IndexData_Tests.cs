using DeepSigma.AlphaVantageAPI.APIs.Index;
using DeepSigma.AlphaVantageAPI.APIs.Index.Models;
using DeepSigma.AlphaVantageAPI.Models;
using Xunit;

namespace DeepSigma.AlphaVantageAPI.Tests;

public class AlphaVantage_IndexData_Tests
{
    [Fact]
    public void GetIndexDataFromJson_ResultsShouldReturnValues()
    {
        string json = File.ReadAllText(TestConfig.data_path + "/Index/AVIndexDataWeekly.json");
        AVIndexSeriesResponse<AVBar>? results = IndexData.GetIndexDataFromJson(json);

        bool has_data = false;
        if (results is not null)
        {
            has_data = results.Data.Count > 0;
        }
        Assert.True(has_data);
    }

    [Fact]
    public void GetIndexCatalogFromJson_ResultsShouldReturnValues()
    {
        string json = File.ReadAllText(TestConfig.data_path + "/Index/AVIndexCatalog.json");
        Dictionary<string, string>? results = IndexData.GetIndexCatalogFromJson(json);
        bool has_data = false;
        if (results is not null)
        {
            has_data = results.Count > 0;
        }
        Assert.True(has_data);
    }
}
