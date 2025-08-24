using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeepSigma.DataAccess.API.AlphaVantage.DataModels
{
    public class AVBar : AVGenericObject
    {
        public decimal? Open { get; init; }
        public decimal? High { get; init; }
        public decimal? Low { get; init; }
        public decimal? Close { get; init; }
        public decimal? AdjustedClose { get; init; }
        public decimal? DividendAmount { get; init; }
        public decimal? SplitCoefficient { get; init; }
        public long? Volume { get; init; }
    }
}
