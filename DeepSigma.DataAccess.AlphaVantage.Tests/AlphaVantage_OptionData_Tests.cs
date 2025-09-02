using Xunit;
using DeepSigma.DataAccess.AlphaVantage;
using DeepSigma.DataAccess.AlphaVantage.DataModels;
using DeepSigma.DataAccess.AlphaVantage.Tests;

namespace DeepSigma.DataAccess.AlphaVantage.Tests
{
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
    }
}
