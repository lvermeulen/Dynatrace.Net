using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Plugins.Models
{
	public class Plugin
	{
		public ConfigurationMetadata Metadata { get; set; }
		public string Id { get; set; }
		public string Name { get; set; }
		public string Version { get; set; }
		[JsonConverter(typeof(PluginTypesConverter))]
		public PluginTypes? Type { get; set; }
		public string MetricGroup { get; set; }
		public IEnumerable<PluginProperty> Properties { get; set; }
	}
}
