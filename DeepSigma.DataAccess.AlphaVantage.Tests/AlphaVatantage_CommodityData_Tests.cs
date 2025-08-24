using Xunit;
using DeepSigma.DataAccess.API.AlphaVantage.Enums;
using DeepSigma.DataAccess.API.AlphaVantage;
using DeepSigma.DataAccess.Utilities;
using DeepSigma.DataAccess.API.AlphaVantage.DataModels;

namespace DataAccessTests
{
    public class AlphaVatantage_CommodityData_Tests
    {
        KeyChainItem api_key = MyKeyChain.GetKeys().GetKey("AlphaVantageFree") ?? throw new ArgumentNullException("API key not found in KeyChain.");

        [Fact]
        public async Task GetWTI_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new(api_key.Key);
            AVDataRequest<AVValue>? results = await api.CommodityData.GetWTI(TimeSeriesInterval.Monthly);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count() > 2;
            }
            Assert.True(has_data);
        }

        [Fact]
        public async Task GetBrent_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new(api_key.Key);
            AVDataRequest<AVValue>? results = await api.CommodityData.GetBrent(TimeSeriesInterval.Monthly);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count() > 2;
            }
            Assert.True(has_data);
        }

        [Fact]
        public async Task GetSugar_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new(api_key.Key);
            AVDataRequest<AVValue>? results = await api.CommodityData.GetSugar(TimeSeriesInterval.Monthly);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count() > 2;
            }
            Assert.True(has_data);
        }

        [Fact]
        public async Task GetCotton_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new(api_key.Key);
            AVDataRequest<AVValue>? results = await api.CommodityData.GetCotton(TimeSeriesInterval.Monthly);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count() > 2;
            }
            Assert.True(has_data);
        }

        [Fact]
        public async Task GetCorn_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new(api_key.Key);
            AVDataRequest<AVValue>? results = await api.CommodityData.GetCorn(TimeSeriesInterval.Monthly);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count() > 2;
            }
            Assert.True(has_data);
        }

        [Fact]
        public async Task GetWheat_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new(api_key.Key);
            AVDataRequest<AVValue>? results = await api.CommodityData.GetWheat(TimeSeriesInterval.Monthly);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count() > 2;
            }
            Assert.True(has_data);
        }

        [Fact]
        public async Task GetAluminum_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new(api_key.Key);
            AVDataRequest<AVValue>? results = await api.CommodityData.GetAluminum(TimeSeriesInterval.Monthly);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count() > 2;
            }
            Assert.True(has_data);
        }

        [Fact]
        public async Task GetCopper_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new(api_key.Key);
            AVDataRequest<AVValue>? results = await api.CommodityData.GetCopper(TimeSeriesInterval.Monthly);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count() > 2;
            }
            Assert.True(has_data);
        }

        [Fact]
        public async Task GetCoffee_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new(api_key.Key);
            AVDataRequest<AVValue>? results = await api.CommodityData.GetCoffee(TimeSeriesInterval.Monthly);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count() > 2;
            }
            Assert.True(has_data);
        }

        [Fact]
        public async Task GetCommodityIndex_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new(api_key.Key);
            AVDataRequest<AVValue>? results = await api.CommodityData.GetGlobalCommodityIndex(TimeSeriesInterval.Monthly);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count() > 2;
            }
            Assert.True(has_data);
        }

        [Fact]
        public async Task GetNaturalGas_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new(api_key.Key);
            AVDataRequest<AVValue>? results = await api.CommodityData.GetNaturalGas(TimeSeriesInterval.Monthly);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count() > 2;
            }
            Assert.True(has_data);
        }
    }
}
