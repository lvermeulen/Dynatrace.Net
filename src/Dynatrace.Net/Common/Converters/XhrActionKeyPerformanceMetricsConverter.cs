using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class XhrActionKeyPerformanceMetricsConverter : JsonEnumConverter<XhrActionKeyPerformanceMetrics>
	{
		private static readonly Dictionary<XhrActionKeyPerformanceMetrics, string> s_pairs = new Dictionary<XhrActionKeyPerformanceMetrics, string>
		{
			[XhrActionKeyPerformanceMetrics.ActionDuration] = "ACTION_DURATION",
			[XhrActionKeyPerformanceMetrics.ResponseEnd] = "RESPONSE_END",
			[XhrActionKeyPerformanceMetrics.ResponseStart] = "RESPONSE_START",
			[XhrActionKeyPerformanceMetrics.VisuallyComplete] = "VISUALLY_COMPLETE"
		};

		protected override Dictionary<XhrActionKeyPerformanceMetrics, string> Pairs => s_pairs;

		protected override string EntityString => "XHR action key performance metric";
	}
}
