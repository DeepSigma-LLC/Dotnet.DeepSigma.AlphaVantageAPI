
namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    public sealed class AVMetaData : AVGenericObject
    {
        public string Information { get; init; } = "";
        public string Symbol { get; init; } = "";
        public string FromSymbol { get; init; } = "";
        public string ToSymbol { get; init; } = "";
        public string LastRefreshed { get; init; } = "";
        public string Interval { get; init; } = "";
        public string OutputSize { get; init; } = "";
        public string TimeZone { get; init; } = "";

        public string DigitalCurrencyCode { get; init; } = "";
        public string DigitalCurrencyName { get; init; } = "";
        public string MarketCode { get; init; } = "";
        public string MarketName { get; init; } = "";

      
    }

}
