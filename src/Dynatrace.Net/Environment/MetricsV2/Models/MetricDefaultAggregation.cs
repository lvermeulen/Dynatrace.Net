using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.MetricsV2.Models
{
	public class MetricDefaultAggregation
	{
		public decimal? Parameter { get; set; }
		[JsonConverter(typeof(MetricDescriptorAggregationTypesConverter))]
		public MetricDescriptorAggregationTypes? Type { get; set; }
	}
}
