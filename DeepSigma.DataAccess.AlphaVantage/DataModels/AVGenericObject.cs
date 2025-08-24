using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSigma.DataAccess.API.AlphaVantage.DataModels
{
    public class AVGenericObject
    {
        /// <summary>
        /// Any fields that were not mapped to properties in this object
        /// </summary>
        public IReadOnlyDictionary<string, string> UnmappedFields { get; init; } = new Dictionary<string, string>();
    }
}
