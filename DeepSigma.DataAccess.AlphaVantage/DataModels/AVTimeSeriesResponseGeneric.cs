using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    public class AVTimeSeriesResponseGeneric<T>
    {
        public AVMetaData MetaData { get; init; } = new();
        public SortedDictionary<DateTime, T> Data{ get; init; } = [];

        public AVTimeSeriesResponseGeneric(SortedDictionary<DateTime, T> data, AVMetaData meta_data)
        {
            MetaData = meta_data;
            Data = data;
        }
    }
}
