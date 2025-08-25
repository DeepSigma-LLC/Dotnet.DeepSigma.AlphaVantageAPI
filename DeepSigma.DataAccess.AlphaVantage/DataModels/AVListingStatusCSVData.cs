using CsvHelper.Configuration.Attributes;


namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    public class AVListingStatusCSVData
    {
        [Name("symbol")]
        public string Symbol { get; init; } = String.Empty;
        [Name("name")]
        public string Name { get; init; } = String.Empty;
        [Name("exchange")]
        public string Exchange { get; init; } = String.Empty;
        [Name("assetType")]
        public string AssetType { get; init; } = String.Empty;
        [Name("ipoDate")]
        public DateTime? IpoDate { get; init; }
        [Name("delistingDate")]
        public DateTime? DelistingDate { get; init; }
        [Name("status")]
        public string Status { get; init; } = String.Empty;
    }
}
