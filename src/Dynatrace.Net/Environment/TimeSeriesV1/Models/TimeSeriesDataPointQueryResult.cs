using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Environment.MetricsV2.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.TimeSeriesV1.Models
{
	public class TimeSeriesDataPointQueryResult
	{
		public object DataPoints { get; set; }
		public string TimeseriesId { get; set; }
		[JsonConverter(typeof(MetricDescriptorUnitsConverter))]
		public MetricDescriptorUnits? Unit { get; set; }
		public int? ResolutionInMillisUtc { get; set; }
		[JsonConverter(typeof(MetricDescriptorAggregationTypesConverter))]
		public MetricDescriptorAggregationTypes? AggregationType { get; set; }
		public object Entities { get; set; }
	}
}
