using Xunit;
using DeepSigma.DataAccess.AlphaVantage;
using DeepSigma.DataAccess.AlphaVantage.DataModels;
using DeepSigma.DataAccess.AlphaVantage.Tests;

namespace DeepSigma.DataAccess.AlphaVantage.Tests
{
    public class AlphaVantage_EconomicData_Tests
    {

        [Fact]
        public void GetRealGDPFromJson_ResultsShouldReturnValues()
        {
            string json = File.ReadAllText(TestConfig.data_path + "/Economic/AVRealGDP.json");
            AVDataRequest<AVValue>? results = EconomicData.GetRealGDPFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count() > 2;
            }
            Assert.True(has_data);
        }

        [Fact]
        public void GetRealGDPperCapitaFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Economic/AVRealGDPperCapita.json");
            AVDataRequest<AVValue>? results = EconomicData.GetRealGDPPerCapitaFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count() > 2;
            }
            Assert.True(has_data);
        }


        [Fact]
        public void GetCPIFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Economic/AVCPI.json");
            AVDataRequest<AVValue>? results = EconomicData.GetCPIFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count() > 2;
            }
            Assert.True(has_data);
        }

        [Fact]
        public void GetInflationFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Economic/AVInflation.json");
            AVDataRequest<AVValue>? results = EconomicData.GetInflationFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count() > 2;
            }
            Assert.True(has_data);
        }

        [Fact]
        public void GetRetailSalesFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Economic/AVRetailSales.json");
            AVDataRequest<AVValue>? results = EconomicData.GetRetailSalesFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count() > 2;
            }
            Assert.True(has_data);
        }

        [Fact]
        public void GetDurableGoodsOrdersFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Economic/AVDurableGoodsOrders.json");
            AVDataRequest<AVValue>? results = EconomicData.GetDurableGoodsOrdersFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count() > 2;
            }
            Assert.True(has_data);
        }


        [Fact]
        public void GetUnemploymentRateJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Economic/AVUnemploymentRate.json");
            AVDataRequest<AVValue>? results = EconomicData.GetUnemploymentRateFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count() > 2;
            }
            Assert.True(has_data);
        }


        [Fact]
        public void GetNonfarmPayrollsFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Economic/AVNonFarmPayrolls.json");
            AVDataRequest<AVValue>? results = EconomicData.GetNonFarmPayrollsFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count() > 2;
            }
            Assert.True(has_data);
        }

    }
}
