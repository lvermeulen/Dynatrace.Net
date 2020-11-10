using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Environment.MetricsV2.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.TimeSeriesV1.Models
{
	public class TimeSeriesDefinition
	{
		public string TimeseriesId { get; set; }
		public string DisplayName { get; set; }
		public IEnumerable<string> Dimensions { get; set; }
		public IEnumerable<string> AggregationTypes { get; set; }
		[JsonConverter(typeof(MetricDescriptorUnitsConverter))]
		public MetricDescriptorUnits? Unit { get; set; }
		[JsonConverter(typeof(TimeSeriesSourcesConverter))]
		public TimeSeriesSources? Filter { get; set; }
		public string DetailedSource { get; set; }
		public string PluginId { get; set; }
		public IEnumerable<string> Types { get; set; }
	}
}
