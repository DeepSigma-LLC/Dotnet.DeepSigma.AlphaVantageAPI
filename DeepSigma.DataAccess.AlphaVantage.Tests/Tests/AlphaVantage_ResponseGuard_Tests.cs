using Xunit;

namespace DeepSigma.AlphaVantageAPI.Tests;

/// <summary>Alpha Vantage's refusals in an HTTP 200, recognised before parsing; data passes.</summary>
public class AlphaVantage_ResponseGuard_Tests
{
    [Theory]
    [InlineData("""{"Information": "We have detected your API key as XXX and our standard API rate limit is 25 requests per day."}""", "information")]
    [InlineData("""{"Note": "Thank you for using Alpha Vantage! Our standard API call frequency is 5 calls per minute."}""", "note")]
    [InlineData("""{"Error Message": "Invalid API call. Please retry or visit the documentation."}""", "error")]
    public void A_refusal_throws_with_its_message(string json, string kind)
    {
        var refused = Assert.Throws<InvalidOperationException>(() => AlphaVantageResponseGuard.Check(json));
        Assert.StartsWith($"Alpha Vantage {kind}:", refused.Message);
    }

    [Fact]
    public void Data_and_text_that_is_not_JSON_pass()
    {
        AlphaVantageResponseGuard.Check(File.ReadAllText(TestConfig.data_path + "/Commodity/AVWTIDataRequest.json"));
        AlphaVantageResponseGuard.Check("""[{"symbol": "IBM"}]""");
        AlphaVantageResponseGuard.Check("symbol,name\nIBM,International Business Machines");
    }

    [Fact]
    public void The_guard_works_with_the_web_packages_deserializer()
    {
        Assert.Throws<InvalidOperationException>(() =>
            DeepSigma.DataAccess.Web.Serializer.LoadFromJson<object>("""{"Information": "rate limit"}""", guard: AlphaVantageResponseGuard.Guard));
    }
}
