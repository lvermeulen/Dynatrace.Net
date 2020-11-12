using System.Collections.Generic;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Configuration.CalculatedMetrics.Models
{
	public class CalculatedServiceMetric
	{
		public ConfigurationMetadata Metadata { get; set; }
		public string TsmMetricKey { get; set; }
		public string Name { get; set; }
		public bool? Enabled { get; set; }
		public CalculatedMetricDefinition MetricDefinition { get; set; }
		public string Unit { get; set; }
		public string UnitDisplayName { get; set; }
		public string EntityId { get; set; }
		public IEnumerable<string> ManagementZones { get; set; }
		public IEnumerable<Condition> Conditions { get; set; }
		public DimensionDefinition DimensionDefinition { get; set; }
	}
}
