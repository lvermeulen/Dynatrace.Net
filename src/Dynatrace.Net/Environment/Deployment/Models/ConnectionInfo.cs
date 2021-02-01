using System.Collections.Generic;

namespace Dynatrace.Net.Environment.Deployment.Models
{
	public class ConnectionInfo
	{
		public string TenantUuid { get; set; }
		public string TenantToken { get; set; }
		public IEnumerable<string> CommunicationEndpoints { get; set; }
	}
}
