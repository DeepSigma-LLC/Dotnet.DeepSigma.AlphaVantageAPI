using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeepSigma.DataAccess.API.AlphaVantage.DataModels
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
