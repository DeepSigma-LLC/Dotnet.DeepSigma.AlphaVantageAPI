using CsvHelper.Configuration.Attributes;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    /// <summary>
    /// Data model for OHLC (Open, High, Low, Close) data from Alpha Vantage CSV output.
    /// </summary>
    public class AlphaVantageCsvOHLC
    {
        /// <summary>
        /// The timestamp of the OHLC data point.
        /// </summary>
        [Name("timestamp")]
        public DateTime Timestamp { get; init; }

        /// <summary>
        /// The opening price.
        /// </summary>
        [Name("open")]
        public decimal Open { get; init; }

        /// <summary>
        /// The highest price.
        /// </summary>
        [Name("high")]
        public decimal High { get; init; }

        /// <summary>
        /// The lowest price.
        /// </summary>
        [Name("low")]
        public decimal Low { get; init; }
        /// <summary>
        /// The closing price.
        /// </summary>
        [Name("close")]
        public decimal Close { get; init;}
        /// <summary>
        /// The trading volume.
        /// </summary>
        [Name("volume")]
        public long Volume { get; init; }
    }
}
