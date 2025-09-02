using CsvHelper.Configuration.Attributes;

namespace DeepSigma.AlphaVantageAPI.DataModels
{
    /// <summary>
    /// The class represents IPO calendar data from Alpha Vantage in CSV format.
    /// </summary>
    public class AVIpoCalandarCSVData
    {
        /// <summary>
        /// The stock symbol of the IPO.
        /// </summary>
        [Name("symbol")]
        public string Symbol { get; init; } = String.Empty;

        /// <summary>
        /// The name of the company going public.
        /// </summary>
        [Name("name")]
        public string Name { get; init; } = String.Empty;

        /// <summary>
        /// The date of the IPO.
        /// </summary>
        [Name("ipoDate")]
        public DateTime? IpoDate { get; init; }

        /// <summary>
        /// The price range low for the IPO.
        /// </summary>
        [Name("priceRangeLow")]
        public decimal? PriceRangeLow { get; init; }

        /// <summary>
        /// The price range high for the IPO.
        /// </summary>
        [Name("priceRangeHigh")]
        public decimal? PriceRangeHigh { get; init; }

        /// <summary>
        /// The currency in which the IPO is priced.
        /// </summary>
        [Name("currency")]
        public string Currency { get; init; } = String.Empty;

        /// <summary>
        /// The exchange where the IPO is listed.
        /// </summary>
        [Name("exchange")]
        public string Exchange { get; init; } = String.Empty;
    }
}
