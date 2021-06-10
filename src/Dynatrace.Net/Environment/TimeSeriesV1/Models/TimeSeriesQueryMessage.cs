using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Environment.MetricsV2.Models;
using Dynatrace.Net.Environment.ProblemsV1.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.TimeSeriesV1.Models
{
	public class TimeSeriesQueryMessage
	{
		public string TimeseriesId { get; set; }
		[JsonConverter(typeof(MetricDescriptorAggregationTypesConverter))]
		public MetricDescriptorAggregationTypes? AggregationType { get; set; }
		public long? StartTimestamp { get; set; }
		public long? EndTimestamp { get; set; }
		public bool? Predict { get; set; }
		public RelativeTimes? RelativeTime { get; set; }
		[JsonConverter(typeof(TimeSeriesQueryModesConverter))]
		public TimeSeriesQueryModes QueryMode { get; set; }
		public IEnumerable<string> Entities { get; set; }
		public IEnumerable<string> Tags { get; set; }
		public object Filters { get; set; }
		public int? Percentile { get; set; }
		public bool? IncludeParentIds { get; set; }
		public bool? ConsiderMaintenanceWindowsForAvailability { get; set; }
	}
}
