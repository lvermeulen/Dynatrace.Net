using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Configuration.Plugins.Models
{
	public class RemotePluginEndpoint
	{
		public string Id { get; set; }
		public string PluginId { get; set; }
		public string Name { get; set; }
		public bool? Enabled { get; set; }
		public object Properties { get; set; }
		public EntityShortRepresentation ActiveGatePluginModule { get; set; }
	}
}
