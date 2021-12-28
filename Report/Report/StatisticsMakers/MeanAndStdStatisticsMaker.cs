using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report
{
    public class MeanAndStdStatisticsMaker : StatisticsMaker
    {
        public override object Make(IEnumerable<double> data)
        {
            var list = data.ToList();
            var mean = list.Average();
            var std = Math.Sqrt(list.Select(z => Math.Pow(z - mean, 2)).Sum() / (list.Count - 1));

            return new MeanAndStd
            {
                Mean = mean,
                Std = std
            };
        }
    }
}
