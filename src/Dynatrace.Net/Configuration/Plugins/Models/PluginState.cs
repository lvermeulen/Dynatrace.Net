using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Plugins.Models
{
	public class PluginState
	{
		public string PluginId { get; set; }
		public string Version { get; set; }
		public string EndpointId { get; set; }
		[JsonConverter(typeof(PluginStatesConverter))]
		public PluginStates? State { get; set; }
		public string StateDescription { get; set; }
		public int? Timestamp { get; set; }
		public string HostId { get; set; }
		public string ProcessId { get; set; }
	}
}
