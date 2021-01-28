using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Configuration.ManagementZones.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.AutoTags.Models
{
	public class AutoTagRule
	{
		[JsonConverter(typeof(AutoTagRuleTypesConverter))]
		public AutoTagRuleTypes? Type { get; set; }
		public bool? Enabled { get; set; }
		public string ValueFormat { get; set; }
		[JsonConverter(typeof(PropagationTypesConverter))]
		public IEnumerable<PropagationTypes> PropagationTypes { get; set; }
		public IEnumerable<EntityRuleEngineCondition> Conditions { get; set; }
	}
}
