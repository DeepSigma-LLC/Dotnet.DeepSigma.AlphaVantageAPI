
using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.DataModels
{
    /// <summary>
    /// Response model for ticker search results from Alpha Vantage API.
    /// </summary>
    public class AVTickerSearchResponse
    {
        /// <summary>
        /// A list of best matching ticker search results.
        /// </summary>
        [JsonPropertyName("bestMatches")]
        public List<AVTickerSearchMatch> BestMatches { get; init; } = [];
    }
}
