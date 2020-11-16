using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Configuration.Extensions.Models
{
	public class ExtensionConfigurationDto
	{
		public string ExtensionId { get; set; }
		public bool? Enabled { get; set; }
		public bool? UseGlobal { get; set; }
		public object Properties { get; set; }
		public string HostId { get; set; }
		public EntityShortRepresentation ActiveGate { get; set; }
		public string EndpointId { get; set; }
		public string EndpointName { get; set; }
	}
}
