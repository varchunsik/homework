using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report
{
    public abstract class StatisticsMakerHelper
    {
		public static object MeanAndStdStatistics(IEnumerable<double> data)
		{
			return new MeanAndStdStatisticsMaker().Make(data);
		}

		public static object MedianStatistics(IEnumerable<double> data)
		{
			return new MedianStatisticsMaker().Make(data);
		}
	}
}
