using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.CalculatedMetrics.Models
{
	public class CalculatedMetricDefinition
	{
		[JsonConverter(typeof(CalculatedMetricTypesConverter))]
		public CalculatedMetricTypes? Metric { get; set; }
		public string RequestAttribute { get; set; }
	}
}
