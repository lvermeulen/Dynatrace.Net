using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models
{
	public class WithTopologyAndSmartscapeV1ResponseHeaders<T> : WithResponseHeaders<T>
	{
		public int? TotalCount { get; set; }
		public string NextPageKey { get; set; }
		public string PageSize { get; set; }
	}
}
