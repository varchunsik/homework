using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report
{
    public abstract class StatisticsMaker
    {
        public abstract object Make(IEnumerable<double> data);
    }
}
