using DeepSigma.AlphaVantageAPI.Parsers;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.DataModels
{
    internal class AVTimeSeriesResponseGenericParser<T>
    {
        /// <summary>
        /// Note: JSON elements must be public with getters and setters to be deserialized properly.
        /// </summary>
        [JsonPropertyName("Meta Data")]
        public JsonElement MetaDataRaw { get; init; }
        internal AVMetaData GetMetaData() => AVMetaDataParser.Parse(MetaDataRaw);
        // Keys are dates like "2025-08-12"; we'll keep them as strings or post-convert.

        /// <summary>
        /// Note: JSON elements must be public with getters and setters to be deserialized properly.
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> ExtensionData { get; init; } = [];

        private Func<JsonElement, T>? _parser { get; set; }

        /// <summary>
        /// Extracts the time series data from the response using the provided parser function.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        internal SortedDictionary<DateTime, T> GetSeries(JsonSerializerOptions? options = null)
        {
            var kvp = ExtensionData.FirstOrDefault(p => p.Key.Contains("Time Series", StringComparison.OrdinalIgnoreCase));

            if (string.IsNullOrEmpty(kvp.Key)) return [];

            var seriesObj = kvp.Value;
            SortedDictionary<DateTime, T> result = [];

            // Iterate each timestamp entry: "2025-08-22 15:55:00": { "1. open": "...", ... }
            foreach (var entry in seriesObj.EnumerateObject())
            {
                var bar_data = entry.Value;
                T bar = ParseData(bar_data);
                DateTime dateTime = DateTime.Parse(entry.Name, null, System.Globalization.DateTimeStyles.AssumeLocal);
                result[dateTime] = bar;
            }

            return result;
        }

        /// <summary>
        /// Set a custom parser function to convert JsonElement to type T.
        /// </summary>
        /// <param name="parser"></param>
        /// <exception cref="ArgumentNullException"></exception>
        internal void SetParser(Func<JsonElement, T> parser)
        {
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
        }

        /// <summary>
        /// Wrapper to parse the JsonElement data into type T using the provided parser function.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        private T ParseData(JsonElement data)
        {
            if (_parser == null)
            {
                throw new InvalidOperationException("Parser function is not set. Please set it using SetParser method.");
            }
            return _parser(data);
        }
    }
}
