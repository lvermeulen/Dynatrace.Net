using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.MetricsV2.Models
{
	public class MetricDescriptor
	{
		public IEnumerable<string> EntityType { get; set; }
		public string MetricId { get; set; }
		[JsonConverter(typeof(MetricDescriptorAggregationTypesConverter))]
		public IEnumerable<MetricDescriptorAggregationTypes> AggregationTypes { get; set; }
		public bool? DduBillable { get; set; }
		public int? LastWritten { get; set; }
		public IEnumerable<MetricDimensionDefinition> DimensionDefinitions { get; set; }
		public MetricDefaultAggregation DefaultAggregation { get; set; }
		public string Description { get; set; }
		public IEnumerable<string> Transformations { get; set; }
		[JsonConverter(typeof(MetricDescriptorUnitsConverter))]
		public MetricDescriptorUnits? Unit { get; set; }
		public int? Created { get; set; }
		public string DisplayName { get; set; }
	}
}
