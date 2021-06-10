using System.Collections.Generic;

namespace Dynatrace.Net.Environment.MetricsV2.Models
{
	public class MetricSeries
	{
		public IEnumerable<long> Timestamps { get; set; }
		public IEnumerable<string> Dimensions { get; set; }
		public IEnumerable<decimal> Values { get; set; }
	}
}
