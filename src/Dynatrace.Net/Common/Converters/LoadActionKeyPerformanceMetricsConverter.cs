using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class LoadActionKeyPerformanceMetricsConverter : JsonEnumConverter<LoadActionKeyPerformanceMetrics>
	{
		private static readonly Dictionary<LoadActionKeyPerformanceMetrics, string> s_pairs = new Dictionary<LoadActionKeyPerformanceMetrics, string>
		{
			[LoadActionKeyPerformanceMetrics.ActionDuration] = "ACTION_DURATION",
			[LoadActionKeyPerformanceMetrics.CumulativeLayoutShift] = "CUMULATIVE_LAYOUT_SHIFT",
			[LoadActionKeyPerformanceMetrics.DomInteractive] = "DOM_INTERACTIVE",
			[LoadActionKeyPerformanceMetrics.FirstInputDelay] = "FIRST_INPUT_DELAY",
			[LoadActionKeyPerformanceMetrics.LargestContentfulPaint] = "LARGEST_CONTENTFUL_PAINT",
			[LoadActionKeyPerformanceMetrics.LoadEventEnd] = "LOAD_EVENT_END",
			[LoadActionKeyPerformanceMetrics.LoadEventStart] = "LOAD_EVENT_START",
			[LoadActionKeyPerformanceMetrics.ResponseEnd] = "RESPONSE_END",
			[LoadActionKeyPerformanceMetrics.ResponseStart] = "RESPONSE_START",
			[LoadActionKeyPerformanceMetrics.SpeedIndex] = "SPEED_INDEX",
			[LoadActionKeyPerformanceMetrics.VisuallyComplete] = "VISUALLY_COMPLETE"
		};

		protected override Dictionary<LoadActionKeyPerformanceMetrics, string> Pairs => s_pairs;

		protected override string EntityString => "load action key performance metric";
	}
}
