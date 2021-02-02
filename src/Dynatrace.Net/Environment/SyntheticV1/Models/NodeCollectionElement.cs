using System.Collections.Generic;

namespace Dynatrace.Net.Environment.SyntheticV1.Models
{
	public class NodeCollectionElement
	{
		public string EntityId { get; set; }
		public string Hostname { get; set; }
		public IEnumerable<string> Ips { get; set; }
		public string Version { get; set; }
		public bool? BrowserMonitorsEnabled { get; set; }
		public string ActiveGateVersion { get; set; }
		public bool? OneAgentRoutingEnabled { get; set; }
		public string OperatingSystem { get; set; }
		public bool? AutoUpdateEnabled { get; set; }
		public string Status { get; set; }
		public string PlayerVersion { get; set; }
		public string HealthCheckStatus { get; set; }
	}
}
