using System.Collections.Generic;
using Dynatrace.Net.Configuration.Reports.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ReportSchedulesConverter : JsonEnumConverter<ReportSchedules>
	{
		private static readonly Dictionary<ReportSchedules, string> s_pairs = new Dictionary<ReportSchedules, string>
		{
			[ReportSchedules.Month] = "MONTH",
			[ReportSchedules.Week] = "WEEK"
		};

		protected override Dictionary<ReportSchedules, string> Pairs => s_pairs;

		protected override string EntityString => "report schedule";
	}
}
