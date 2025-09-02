using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    /// <summary>
    /// The response model for the market closure information from Alpha Vantage API.
    /// </summary>
    public class AVMarketClosureResponse
    {
        /// <summary>
        /// The API endpoint that was called.
        /// </summary>
        [JsonPropertyName("endpoint")]
        public string Endpoint { get; init; } = string.Empty;

        /// <summary>
        /// The market closure data.
        /// </summary>
        [JsonPropertyName("markets")]
        public List<AVMarketClosureData> Markets { get; init; } = [];
    }
}
