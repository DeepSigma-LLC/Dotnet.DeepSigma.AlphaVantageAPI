using CsvHelper.Configuration.Attributes;


namespace DeepSigma.AlphaVantageAPI.DataModels
{
    /// <summary>
    /// The class represents the structure of CSV data returned by the Alpha Vantage API for listing and delisting status of securities.
    /// </summary>
    public class AVListingStatusCSVData
    {
        /// <summary>
        /// The stock symbol of the security.
        /// </summary>
        [Name("symbol")]
        public string Symbol { get; init; } = String.Empty;

        /// <summary>
        /// The name of the security.
        /// </summary>
        [Name("name")]
        public string Name { get; init; } = String.Empty;

        /// <summary>
        /// The exchange where the security is listed.
        /// </summary>
        [Name("exchange")]
        public string Exchange { get; init; } = String.Empty;

        /// <summary>
        /// The type of asset (e.g., stock, ETF).
        /// </summary>
        [Name("assetType")]
        public string AssetType { get; init; } = String.Empty;

        /// <summary>
        /// The IPO date of the security.
        /// </summary>
        [Name("ipoDate")]
        public DateTime? IpoDate { get; init; }

        /// <summary>
        /// The delisting date of the security, if applicable.
        /// </summary>
        [Name("delistingDate")]
        public DateTime? DelistingDate { get; init; }

        /// <summary>
        /// The current status of the security (e.g., active, delisted).
        /// </summary>
        [Name("status")]
        public string Status { get; init; } = String.Empty;
    }
}
