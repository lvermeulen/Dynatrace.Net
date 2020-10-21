using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.MetricsV2.Models
{
	public class MetricDimensionDefinition
	{
		public int? Index { get; set; }
		public string Name { get; set; }
		public string Key { get; set; }
		[JsonConverter(typeof(MetricDimensionDefinitionTypesConverter))]
		public MetricDimensionDefinitionTypes? Type { get; set; }
		public string DisplayName { get; set; }
	}
}
