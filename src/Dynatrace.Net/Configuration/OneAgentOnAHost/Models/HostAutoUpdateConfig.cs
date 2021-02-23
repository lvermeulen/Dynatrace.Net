using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.OneAgentOnAHost.Models
{
	public class HostAutoUpdateConfig
	{
		public ConfigurationMetadata Metadata { get; set; }
		public string Id { get; set; }
		[JsonConverter(typeof(HostSettingsConverter))]
		public HostSettings? Setting { get; set; }
		public string Version { get; set; }
		[JsonConverter(typeof(HostSettingsConverter))]
		public HostSettings? EffectiveSetting { get; set; }
		public string EffectiveVersion { get; set; }
	}
}
