using System.Collections.Generic;

namespace Dynatrace.Net.Environment.MetricsV2.Models
{
	public class MetricSeriesCollection
	{
		public string MetricId { get; set; }
		public IEnumerable<MetricSeries> Data { get; set; }
	}
}
