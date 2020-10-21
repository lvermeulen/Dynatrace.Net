using System.Collections.Generic;

namespace Dynatrace.Net.Environment.MetricsV2.Models
{
	public class MetricDescriptorCollection
	{
		public string NextPageKey { get; set; }
		public int? TotalCount { get; set; }
		public IEnumerable<MetricDescriptor> Metrics { get; set; }
	}
}
