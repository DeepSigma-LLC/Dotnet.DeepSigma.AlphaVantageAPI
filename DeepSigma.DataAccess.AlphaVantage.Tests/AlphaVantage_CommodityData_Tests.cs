using Xunit;
using DeepSigma.DataAccess.AlphaVantage;
using DeepSigma.DataAccess.AlphaVantage.DataModels;
using DeepSigma.DataAccess.AlphaVantage.Tests;

namespace DataAccessTests
{
    public class AlphaVantage_CommodityData_Tests
    {
        

        [Fact]
        public void GetWTIFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Commodity/AVWTIDataRequest.json");
            AVDataRequest<AVValue>? results = api.CommodityData.GetWTIFromJson(json);

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
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Commodity/AVBrentDataRequest.json");
            AVDataRequest<AVValue>? results = api.CommodityData.GetBrentFromJson(json);

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
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Commodity/AVNaturalGasRequest.json");
            AVDataRequest<AVValue>? results = api.CommodityData.GetNaturalGasFromJson(json);

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
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Commodity/AVCopperRequest.json");
            AVDataRequest<AVValue>? results = api.CommodityData.GetCopperFromJson(json);

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
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Commodity/AVAluminumRequest.json");
            AVDataRequest<AVValue>? results = api.CommodityData.GetCopperFromJson(json);

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
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Commodity/AVWheatRequest.json");
            AVDataRequest<AVValue>? results = api.CommodityData.GetWheatFromJson(json);

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
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Commodity/AVCornRequest.json");
            AVDataRequest<AVValue>? results = api.CommodityData.GetCornFromJson(json);

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
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Commodity/AVCottonRequest.json");
            AVDataRequest<AVValue>? results = api.CommodityData.GetCottonFromJson(json);

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
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Commodity/AVSugarRequest.json");
            AVDataRequest<AVValue>? results = api.CommodityData.GetSugarFromJson(json);

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
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Commodity/AVCoffeeRequest.json");
            AVDataRequest<AVValue>? results = api.CommodityData.GetCoffeeFromJson(json);

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
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Commodity/AVCommodityIndexRequest.json");
            AVDataRequest<AVValue>? results = api.CommodityData.GetGlobalCommodityIndexFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count() > 2;
            }
            Assert.True(has_data);
        }
    }
}
