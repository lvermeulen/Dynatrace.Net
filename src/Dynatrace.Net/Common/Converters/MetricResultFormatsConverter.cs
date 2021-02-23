using System.Collections.Generic;
using Dynatrace.Net.Environment.MetricsV2.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MetricResultFormatsConverter : JsonEnumConverter<MetricResultFormats>
	{
		private static readonly Dictionary<MetricResultFormats, string> s_pairs = new Dictionary<MetricResultFormats, string>
		{
			[MetricResultFormats.ApplicationJson] = "application/json",
			[MetricResultFormats.TextCsvHeaderPresent] = "text/csv; header=present",
			[MetricResultFormats.TextCsvHeaderAbsent] = "text/csv; header=absent"
		};

		protected override Dictionary<MetricResultFormats, string> Pairs => s_pairs;

		protected override string EntityString => "request header";
	}
}
