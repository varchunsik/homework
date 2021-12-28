using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report
{
	public class MeanAndStdMarkdownReportMaker : ReportMaker
	{
		public override string Caption
		{
			get
			{
				return "Mean and Std";
			}
		}

		public override string BeginList()
		{
			return "";
		}

		public override string EndList()
		{
			return "";
		}

		public override string MakeCaption(string caption)
		{
			return $"## {caption}\n\n";
		}

		public override string MakeItem(string valueType, string entry)
		{
			return $" * **{valueType}**: {entry}\n\n";
		}

		public override object MakeStatistics(IEnumerable<double> data)
		{
			return StatisticsMakerHelper.MeanAndStdStatistics(data);
		}
	}
}
