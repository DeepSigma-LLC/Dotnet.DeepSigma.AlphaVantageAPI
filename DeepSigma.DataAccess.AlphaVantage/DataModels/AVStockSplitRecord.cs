using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public class AVStockSplitRecord
    {
        [JsonPropertyName("effective_date")]
        public DateOnly EffectiveDate { get; set; }
        [JsonPropertyName("split_factor")]
        public decimal SplitFactor { get; set; }
    }
}
