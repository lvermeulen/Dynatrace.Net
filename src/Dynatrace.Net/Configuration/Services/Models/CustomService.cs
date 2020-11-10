using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class CustomService
	{
		public ConfigurationMetadata Metadata { get; set; }
		public string Id { get; set; }
		public string Name { get; set; }
		public string Order { get; set; }
		public bool? Enabled { get; set; }
		public IEnumerable<DetectionRule> Rules { get; set; }
		public bool? QueueEntryPoint { get; set; }
		[JsonConverter(typeof(QueueEntryPointTypesConverter))]
		public QueueEntryPointTypes QueueEntryPointType { get; set; }
		public IEnumerable<string> ProcessGroups { get; set; }
	}
}
