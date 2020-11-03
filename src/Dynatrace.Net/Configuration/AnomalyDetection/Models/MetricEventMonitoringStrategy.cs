using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class MetricEventMonitoringStrategy
	{
		[JsonConverter(typeof(MetricEventMonitoringStrategyTypesConverter))]
		public MetricEventMonitoringStrategyTypes? Type { get; set; }
	}
}
