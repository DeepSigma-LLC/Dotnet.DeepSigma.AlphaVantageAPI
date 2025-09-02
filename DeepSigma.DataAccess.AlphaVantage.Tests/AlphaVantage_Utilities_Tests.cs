using Xunit;
using DeepSigma.DataAccess.AlphaVantage;
using DeepSigma.DataAccess.AlphaVantage.DataModels;

namespace DeepSigma.DataAccess.AlphaVantage.Tests
{
    public class AlphaVantage_Utilities_Tests
    {
        [Fact]
        public void GetGlobalMarketStatusDataFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Utilities/AVGlobalMarketStatus.json");
            AVMarketClosureResponse? results = api.Utilities.GetGlobalMarketStatusFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Markets.Count > 0;
            }
            Assert.True(has_data);
        }

        [Fact]
        public void GetTopMoversFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Utilities/AVTopGainLosersActive.json");
            AVMoverResponse? results = api.Utilities.GetTopGainersAndLosersFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.TopGainers.Count > 0;
            }
            Assert.True(has_data);
        }

        [Fact]
        public void GetETFProfileAndHoldingsFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Utilities/AVETFProfile.json");
            AVETFProfileResponse? results = api.Utilities.GetETFProfileAndHoldingsFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Holdings.Count > 0;
            }
            Assert.True(has_data);
        }


        [Fact]
        public void GetTickerSearchFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Utilities/AVTickerSearch.json");
            AVTickerSearchResponse? results = api.Utilities.GetTickerSearchFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.BestMatches.Count > 0;
            }
            Assert.True(has_data);
        }

        [Fact]
        public void GetEarningsCalendarFromCSV_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Utilities/earnings_calendar.csv");
            List<AVEarningsCalandarCSVData>? results = api.Utilities.GetEarningsFromCSV(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Count > 0;
            }
            Assert.True(has_data);
        }


        [Fact]
        public void GetIPOCalendarFromCSV_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string data = File.ReadAllText(TestConfig.data_path + "/Utilities/ipo_calendar.csv");
            List<AVIpoCalandarCSVData>? results = api.Utilities.GetIPOCalandarFromCSV(data);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Count > 0;
            }
            Assert.True(has_data);
        }


        [Fact]
        public void GetListingStatusFromCSV_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string data = File.ReadAllText(TestConfig.data_path + "/Utilities/listing_status_active_today.csv");
            List<AVListingStatusCSVData>? results = api.Utilities.GetListingsFromCSV(data);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Count > 0;
            }
            Assert.True(has_data);
        }

    }
}
