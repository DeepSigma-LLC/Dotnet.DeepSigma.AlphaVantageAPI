
namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    public class AVBar : AVGenericObject
    {
        public decimal? Open { get; init; }
        public decimal? High { get; init; }
        public decimal? Low { get; init; }
        public decimal? Close { get; init; }
        public decimal? AdjustedClose { get; init; }
        public decimal? DividendAmount { get; init; }
        public decimal? SplitCoefficient { get; init; }
        public decimal? Volume { get; init; }
    }
}
