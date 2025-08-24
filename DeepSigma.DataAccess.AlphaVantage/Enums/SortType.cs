using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSigma.DataAccess.API.AlphaVantage.Enums
{
    public enum SortType
    {
        [Description("relevance")]
        Relevance,
        [Description("latest")]
        Latest,
        [Description("earliest")]
        Earliest
    }
}
