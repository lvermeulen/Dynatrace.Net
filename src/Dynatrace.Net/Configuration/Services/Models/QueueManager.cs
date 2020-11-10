using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class QueueManager
	{
		public string Name { get; set; }
		public IEnumerable<string> Clusters { get; set; }
		public IEnumerable<AliasQueue> AliasQueues { get; set; }
		public IEnumerable<RemoteQueue> RemoteQueues { get; set; }
		public IEnumerable<ClusterQueue> ClusterQueues { get; set; }
	}
}
