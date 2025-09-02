using Xunit;
using DeepSigma.DataAccess.AlphaVantage;
using DeepSigma.DataAccess.AlphaVantage.DataModels;


namespace DeepSigma.DataAccess.AlphaVantage.Tests
{
    public class AlphaVantage_Fundamental_Tests
    {
        [Fact]
        public void GetCompanyOverviewFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Fundamental/AVCompanyOverview.json");
            AVComanyOverview? results = api.FundamentalData.GetCompanyOverviewFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Description.Length > 0;
            }
            Assert.True(has_data);
        }

        [Fact]
        public void GetInsiderTransactionsFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Fundamental/AVInsiderTransactions.json");
            AVDataRequest<AVInsiderTransactionData>? results = api.FundamentalData.GetInsiderTransactionsFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count > 0;
            }
            Assert.True(has_data);
        }

        [Fact]
        public void GetEarningsTranscriptFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Fundamental/AVEarningsTranscript.json");
            AVTranscriptResponse? results = api.FundamentalData.GetEarningsTranscriptFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Transcript.Count > 0;
            }
            Assert.True(has_data);
        }

        [Fact]
        public void GetDividendsFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Fundamental/AVDividends.json");
            AVDividendHistoryResponse? results = api.FundamentalData.GetDividendsFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.DividendHistory.Count > 0;
            }
            Assert.True(has_data);
        }

        [Fact]
        public void GetStockSplitsFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Fundamental/AVStockSplit.json");
            AVStockSplitResponse? results = api.FundamentalData.GetStockSplitsFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Data.Count > 0;
            }
            Assert.True(has_data);
        }

        [Fact]
        public void GetIncomeStatementFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Fundamental/AVIncomeStatement.json");
            AVIncomeStatementResponse? results = api.FundamentalData.GetIncomeStatementFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.QuarterlyReports.Count > 0;
            }
            Assert.True(has_data);
        }

        [Fact]
        public void GetBalanceSheetFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Fundamental/AVBalanceSheet.json");
            AVBalanceSheetResponse? results = api.FundamentalData.GetBalanceSheetFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.QuarterlyReports.Count > 0;
            }
            Assert.True(has_data);
        }

        [Fact]
        public void GetCashFlowFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Fundamental/AVCashFlow.json");
            AVCashFlowResponse? results = api.FundamentalData.GetCashFlowFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.QuarterlyReports.Count > 0;
            }
            Assert.True(has_data);
        }


        [Fact]
        public void GetEarningsHistoryFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Fundamental/AVEarningsHistory.json");
            AVEarningsHistroyResponse? results = api.FundamentalData.GetEarningsHistoryFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.QuarterlyEarnings.Count > 0;
            }
            Assert.True(has_data);
        }


        [Fact]
        public void GetEarningsEstimateFromJson_ResultsShouldReturnValues()
        {
            AlphaVantageAPI api = new("demo");
            string json = File.ReadAllText(TestConfig.data_path + "/Fundamental/AVEarningsEstimate.json");
            AVEarningsEstimateResponse? results = api.FundamentalData.GetEarningsEstimateFromJson(json);

            bool has_data = false;
            if (results is not null)
            {
                has_data = results.Estimates.Count > 0;
            }
            Assert.True(has_data);
        }



    }
}
