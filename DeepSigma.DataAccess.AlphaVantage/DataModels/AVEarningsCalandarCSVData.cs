using CsvHelper.Configuration.Attributes;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    public class AVEarningsCalandarCSVData
    {
            [Name("symbol")]
            public string Symbol { get; init; } = string.Empty;
            [Name("name")]
            public string Name { get; init; } = string.Empty;
            [Name("reportDate")]
            public DateTime? ReportDate { get; init; }
            [Name("fiscalDateEnding")]
            public DateTime? FiscalDateEnding { get; init; }
            [Name("estimate")]
            public decimal? Estimate { get; init; }
            [Name("currency")]
            public string Currency { get; init; } = string.Empty;
    }
}
