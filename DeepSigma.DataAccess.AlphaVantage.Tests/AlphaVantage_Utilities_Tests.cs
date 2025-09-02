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
            string json = File.ReadAllText(TestConfig.data_path + "/Utilities/AVGlobalMarketStatus.json");
            AVMarketClosureResponse? results = UtilitiesData.GetGlobalMarketStatusFromJson(json);

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
            string json = File.ReadAllText(TestConfig.data_path + "/Utilities/AVTopGainLosersActive.json");
            AVMoverResponse? results = UtilitiesData.GetTopGainersAndLosersFromJson(json);

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
            string json = File.ReadAllText(TestConfig.data_path + "/Utilities/AVETFProfile.json");
            AVETFProfileResponse? results = UtilitiesData.GetETFProfileAndHoldingsFromJson(json);

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
            string json = File.ReadAllText(TestConfig.data_path + "/Utilities/AVTickerSearch.json");
            AVTickerSearchResponse? results = UtilitiesData.GetTickerSearchFromJson(json);

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
            string json = File.ReadAllText(TestConfig.data_path + "/Utilities/earnings_calendar.csv");
            List<AVEarningsCalandarCSVData>? results = UtilitiesData.GetEarningsFromCSV(json);

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
            string data = File.ReadAllText(TestConfig.data_path + "/Utilities/ipo_calendar.csv");
            List<AVIpoCalandarCSVData>? results = UtilitiesData.GetIPOCalandarFromCSV(data);

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
            string data = File.ReadAllText(TestConfig.data_path + "/Utilities/listing_status_active_today.csv");
            List<AVListingStatusCSVData>? results = UtilitiesData.GetListingsFromCSV(data);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Count > 0;
            }
            Assert.True(has_data);
        }
    }
}
