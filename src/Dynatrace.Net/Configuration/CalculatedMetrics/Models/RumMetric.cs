using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.CalculatedMetrics.Models
{
	public class RumMetric
	{
		public string ApplicationIdentifier { get; set; }
		public string Name { get; set; }
		public string MetricKey { get; set; }
		public bool? Enabled { get; set; }
		public RumMetricDefinition MetricDefinition { get; set; }
		public IEnumerable<RumDimensionDefinition> Dimensions { get; set; }
		public CalculatedRumMetricUserActionFilter UserActionFilter { get; set; }
	}

	public class RumMetricDefinition
	{
		[JsonConverter(typeof(RumMetricsConverter))]
		public RumMetrics? Metric { get; set; }
		public string PropertyKey { get; set; }
	}
}
