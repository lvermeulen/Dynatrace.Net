using System.Collections.Generic;
using Dynatrace.Net.Configuration.Reports.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ReportTypesConverter : JsonEnumConverter<ReportTypes>
	{
		private static readonly Dictionary<ReportTypes, string> s_pairs = new Dictionary<ReportTypes, string>
		{
			[ReportTypes.Dashboard] = "DASHBOARD"
		};

		protected override Dictionary<ReportTypes, string> Pairs => s_pairs;

		protected override string EntityString => "report type";
	}
}
