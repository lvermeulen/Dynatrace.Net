using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Environment.OneAgentOnAHost.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.OneAgentOnAHost.Models
{
	public class MonitoringConfig
	{
		public ConfigurationMetadata Metadata { get; set; }
		public string Id { get; set; }
		public bool? MonitoringEnabled { get; set; }
		[JsonConverter(typeof(MonitoringModesConverter))]
		public MonitoringModes? MonitoringMode { get; set; }
	}
}
