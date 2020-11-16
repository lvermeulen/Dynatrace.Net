using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.Extensions.Models
{
	public class HostList
	{
		public int? TotalResults { get; set; }
		public IEnumerable<Host> Hosts { get; set; }
		public string NextPageKey { get; set; }
	}
}
