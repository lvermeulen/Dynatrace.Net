using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Environment.MetricsV2.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.CalculatedMetrics.Models
{
	public class LogMetricConfig
	{
		public string MetricKey { get; set; }
		public bool? Active { get; set; }
		public string DisplayName { get; set; }
		[JsonConverter(typeof(MetricDescriptorUnitsConverter))]
		public MetricDescriptorUnits? Unit { get; set; }
		public string UnitDisplayName { get; set; }
		public string SearchString { get; set; }
		[JsonConverter(typeof(MetricValueTypesConverter))]
		public MetricValueTypes? MetricValueType { get; set; }
		public ColumnDefinition ColumnDefiningValue { get; set; }
		public IEnumerable<LogSourceFilter> LogSourceFilters { get; set; }
	}
}
