using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Extensions.Models
{
	public class ExtensionState
	{
		public string ExtensionId { get; set; }
		public string Version { get; set; }
		public string EndpointId { get; set; }
		[JsonConverter(typeof(ExtensionStatesConverter))]
		public ExtensionStates? State { get; set; }
		public string StateDescription { get; set; }
		public int? Timestamp { get; set; }
		public string HostId { get; set; }
		public string ProcessId { get; set; }
	}
}
