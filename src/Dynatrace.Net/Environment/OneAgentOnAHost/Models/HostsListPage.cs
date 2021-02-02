using System.Collections.Generic;

namespace Dynatrace.Net.Environment.OneAgentOnAHost.Models
{
	public class HostsListPage
	{
		public decimal? PercentageOfEnvironmentSearched { get; set; }
		public string NextPageKey { get; set; }
		public IEnumerable<HostAgentInfo> Hosts { get; set; }
	}
}
