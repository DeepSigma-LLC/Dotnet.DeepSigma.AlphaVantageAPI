

namespace DeepSigma.AlphaVantageAPI.DataModels
{
    /// <summary>
    /// The generic time series response from Alpha Vantage API.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AVTimeSeriesResponseGeneric<T>
    {
        /// <summary>
        /// The metadata associated with the time series data.
        /// </summary>
        public AVMetaData MetaData { get; init; } = new();

        /// <summary>
        /// The time series data, with DateTime as the key and a generic type T as the value.
        /// </summary>
        public SortedDictionary<DateTime, T> Data{ get; init; } = [];

        /// <summary>
        /// Initializes a new instance of the AVTimeSeriesResponseGeneric class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="meta_data"></param>
        public AVTimeSeriesResponseGeneric(SortedDictionary<DateTime, T> data, AVMetaData meta_data)
        {
            MetaData = meta_data;
            Data = data;
        }
    }
}
