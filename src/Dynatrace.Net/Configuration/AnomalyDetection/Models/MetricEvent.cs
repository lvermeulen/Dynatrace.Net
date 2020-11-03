using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class MetricEvent
	{
		public ConfigurationMetadata Metadata { get; set; }
		public string Id { get; set; }
		public string MetricId { get; set; }
		public string Name { get; set; }
		[JsonConverter(typeof(MetricEventAggregationTypesConverter))]
		public MetricEventAggregationTypes? AggregationType { get; set; }
		[JsonConverter(typeof(SeverityLevelsConverter))]
		public SeverityLevels? Severity { get; set; }
		public bool? Enabled { get; set; }
		[JsonConverter(typeof(DisabledReasonsConverter))]
		public DisabledReasons? DisabledReason { get; set; }
		public IEnumerable<MetricEventAlertingScope> AlertingScope { get; set; }
		public IEnumerable<MetricEventDimensions> MetricDimensions { get; set; }
		public MetricEventMonitoringStrategy MonitoringStrategy { get; set; }
	}
}
