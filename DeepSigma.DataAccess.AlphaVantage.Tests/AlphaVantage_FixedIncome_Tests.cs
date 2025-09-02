using Xunit;
using DeepSigma.DataAccess.AlphaVantage;
using DeepSigma.DataAccess.AlphaVantage.DataModels;
using DeepSigma.DataAccess.AlphaVantage.Tests;

namespace DeepSigma.DataAccess.AlphaVantage.Tests
{
    public class AlphaVantage_FixedIncome_Tests
    {
        [Fact]
        public void GetFedFundsRateFromJson_ResultsShouldReturnValues()
        {
            string json = File.ReadAllText(TestConfig.data_path + "/FixedIncome/AVFedFundsRate.json");
            AVDataRequest<AVValue>? results = FixedIncomeData.GetFedFundsFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count() > 2;
            }
            Assert.True(has_data);
        }

        [Fact]
        public void GetUSTreasuryYieldsFromJson_ResultsShouldReturnValues()
        {
            string json = File.ReadAllText(TestConfig.data_path + "/FixedIncome/AVTreasuryYields.json");
            AVDataRequest<AVValue>? results = FixedIncomeData.GetUSTreasuryYieldFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count() > 2;
            }
            Assert.True(has_data);
        }
    }
}
