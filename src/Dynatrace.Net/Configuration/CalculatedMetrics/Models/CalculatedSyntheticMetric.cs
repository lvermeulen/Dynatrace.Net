using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.CalculatedMetrics.Models
{
	public class CalculatedSyntheticMetric
	{
		public string MonitorIdentifier { get; set; }
		public string Name { get; set; }
		public string MetricKey { get; set; }
		public bool? Enabled { get; set; }
		[JsonConverter(typeof(SyntheticMetricsConverter))]
		public SyntheticMetrics? Metric { get; set; }
		public IEnumerable<SyntheticMetricDimension> Dimensions { get; set; }
		public SyntheticMetricFilter Filter { get; set; }
	}
}
