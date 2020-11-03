using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class MetricEventDimensions
	{
		[JsonConverter(typeof(MetricEventDimensionsFilterTypesConverter))]
		public MetricEventDimensionsFilterTypes? FilterType { get; set; }
		public string Name { get; set; }
		public int? Index { get; set; }
	}
}
