using System.Collections.Generic;
using System.Linq;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Environment.ProblemsV2.Models
{
	public class EntitySelector
	{
		private static readonly HealthStatesConverter s_healthStatesConverter = new HealthStatesConverter();

		public string EntityType { get; set; }
		public IEnumerable<string> DynatraceEntityId { get; set; }
		public IEnumerable<KeyValuePair<string, string>> Tag { get; set; }
		public string ManagementZoneId { get; set; }
		public string ManagementZoneName { get; set; }
		public string DynatraceEntityName { get; set; }
		public HealthStates? HealthState { get; set; }

		public override string ToString()
		{
			return string.Join(",", new List<string>
			{
				EntityType?.WithPrefixAndParentheses("type", true),
				string.Join(",", DynatraceEntityId.Select(x => x.WithQuotes())).WithPrefixAndParentheses("entityId"),
				string.Join(",", Tag.Select(kvp => $"{kvp.Key}:{kvp.Value}")).WithPrefixAndParentheses("tag"),
				ManagementZoneId?.WithPrefixAndParentheses("mzId", true),
				ManagementZoneName?.WithPrefixAndParentheses("mzName", true),
				DynatraceEntityName?.WithPrefixAndParentheses("entityName", true),
				s_healthStatesConverter.ConvertToString(HealthState).WithPrefixAndParentheses("healthState", true)
			});
		}
	}
}
