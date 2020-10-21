using System.Collections.Generic;

namespace Dynatrace.Net.Environment.MetricsV2.Models
{
	public class MetricData
	{
		public string NextPageKey { get; set; }
		public int? TotalCount { get; set; }
		public IEnumerable<string> Warnings { get; set; }
		public IEnumerable<MetricSeriesCollection> Result { get; set; }
	}
}
