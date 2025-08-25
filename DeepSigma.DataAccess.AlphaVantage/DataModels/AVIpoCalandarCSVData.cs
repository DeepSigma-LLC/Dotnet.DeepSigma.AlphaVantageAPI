using CsvHelper.Configuration.Attributes;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    public class AVIpoCalandarCSVData
    {
            [Name("symbol")]
            public string Symbol { get; init; } = String.Empty;
            [Name("name")]
            public string Name { get; init; } = String.Empty;
            [Name("ipoDate")]
            public DateTime? IpoDate { get; init; }
            [Name("priceRangeLow")]
            public decimal? PriceRangeLow { get; init; }
            [Name("priceRangeHigh")]
            public decimal? PriceRangeHigh { get; init; }
            [Name("currency")]
            public string Currency { get; init; } = String.Empty;
            [Name("exchange")]
            public string Exchange { get; init; } = String.Empty;
    }
}
