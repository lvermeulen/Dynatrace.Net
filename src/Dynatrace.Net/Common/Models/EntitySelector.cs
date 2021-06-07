using System.Collections.Generic;
using System.Linq;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Extensions;

namespace Dynatrace.Net.Common.Models
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
			var list = new List<string>(7);
			if (EntityType is not null)
			{
				list.Add(EntityType.WithPrefixAndParentheses("type", true));
			}

			if (DynatraceEntityId is not null)
			{
				list.Add(string.Join(",", DynatraceEntityId.Select(x => x.WithQuotes())).WithPrefixAndParentheses("entityId"));
			}

			if (Tag is not null)
			{
				list.Add(string.Join(",", Tag.Select(kvp => $"{kvp.Key}:{kvp.Value}")).WithPrefixAndParentheses("tag"));
			}

			if (ManagementZoneId is not null)
			{
				list.Add(ManagementZoneId.WithPrefixAndParentheses("mzId", true));
			}

			if (ManagementZoneName is not null)
			{
				list.Add(ManagementZoneName?.WithPrefixAndParentheses("mzName", true));
			}

			if (DynatraceEntityName is not null)
			{
				list.Add(DynatraceEntityName?.WithPrefixAndParentheses("entityName", true));
			}

			if (HealthState is not null)
			{
				list.Add(s_healthStatesConverter.ConvertToString(HealthState).WithPrefixAndParentheses("healthState", true));
			}

			return string.Join(",", list);
		}
	}
}
