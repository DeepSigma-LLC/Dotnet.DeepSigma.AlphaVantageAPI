using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSigma.DataAccess.API.AlphaVantage.Enums
{
    public enum TimeSeriesInterval
    {
        [Description("daily")]
        Daily,
        [Description("weekly")]
        Weekly,
        [Description("monthly")]
        Monthly,
        [Description("quarterly")]
        Quarterly,
        [Description("semiannual")]
        Semiannual,
        [Description("annual")]
        Annual
    }
}
