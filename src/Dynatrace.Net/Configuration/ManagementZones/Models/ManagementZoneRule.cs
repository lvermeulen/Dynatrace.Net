using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.ManagementZones.Models
{
	public class ManagementZoneRule
	{
		[JsonConverter(typeof(ManagementZoneRuleTypesConverter))]
		public ManagementZoneRuleTypes? Type { get; set; }
		public bool? Enabled { get; set; }
		[JsonConverter(typeof(PropagationTypesConverter))]
		public IEnumerable<PropagationTypes> PropagationTypes { get; set; }
		public IEnumerable<EntityRuleEngineCondition> Conditions { get; set; }
	}
}
