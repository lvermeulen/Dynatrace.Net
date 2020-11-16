using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Extensions.Models
{
	public class Extension
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Version { get; set; }
		[JsonConverter(typeof(ExtensionTypesConverter))]
		public ExtensionTypes? Type { get; set; }
		public string MetricGroup { get; set; }
		public ConfigurationMetadata Metadata { get; set; }
		public IEnumerable<ExtensionProperty> Properties { get; set; }
	}
}
