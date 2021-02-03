using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.ManagementZones.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.ConditionalNaming.Models
{
	public class ConditionalNamingRule
	{
		public ConfigurationMetadata Metadata { get; set; }
		public string Id { get; set; }
		public string Order { get; set; }
		[JsonConverter(typeof(ConditionalNamingTypesConverter))]
		public ConditionalNamingTypes? Type { get; set; }
		public string NameFormat { get; set; }
		public string DisplayName { get; set; }
		public bool? Enabled { get; set; }
		public IEnumerable<EntityRuleEngineCondition> Rules { get; set; }
	}
}
