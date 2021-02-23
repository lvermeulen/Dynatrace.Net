using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.OneAgentOnAHost.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.OneAgentEnvironmentWideConfiguration.Models
{
	public class EnvironmentAutoUpdateConfig
	{
		public ConfigurationMetadata Metadata { get; set; }
		[JsonConverter(typeof(HostSettingsConverter))]
		public HostSettings? Setting { get; set; }
		public string Version { get; set; }
	}
}
