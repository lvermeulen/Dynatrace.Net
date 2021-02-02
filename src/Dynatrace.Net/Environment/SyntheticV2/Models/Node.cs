using System.Collections.Generic;

namespace Dynatrace.Net.Environment.SyntheticV2.Models
{
	public class Node
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
		public string BrowserType { get; set; }
		public string BrowserVersion { get; set; }
	}
}
