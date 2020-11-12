using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.CalculatedMetrics.Models
{
	public class CalculatedMobileMetric
	{
		public string ApplicationIdentifier { get; set; }
		public string Name { get; set; }
		public string MetricKey { get; set; }
		public bool? Enabled { get; set; }
		[JsonConverter(typeof(MetricTypesConverter))]
		public MetricTypes? MetricType { get; set; }
		public IEnumerable<CalculatedMobileMetricDimension> Dimensions { get; set; }
		public CalculatedMobileMetricUserActionFilter UserActionFilter { get; set; }
	}
}
