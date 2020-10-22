using System.Collections.Generic;
using System.Linq;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Environment.ProblemsV2.Models
{
	public class ProblemSelector
	{
		private static readonly StatusesConverter s_statusesConverter = new StatusesConverter();
		private static readonly SeverityLevelsConverter s_severityLevelsConverter = new SeverityLevelsConverter();
		private static readonly ImpactLevelsConverter s_impactLevelsConverter = new ImpactLevelsConverter();

		public Statuses? Status { get; set; }
		public IEnumerable<SeverityLevels> SeverityLevel { get; set; }
		public IEnumerable<ImpactLevels> ImpactLevel { get; set; }
		public IEnumerable<string> RootCauseEntities { get; set; }
		public IEnumerable<string> ManagementZoneIds { get; set; }
		public IEnumerable<string> ManagementZoneNames { get; set; }
		public IEnumerable<string> ImpactedEntities { get; set; }
		public IEnumerable<string> AffectedEntities { get; set; }
		public IEnumerable<string> AffectedEntityTypes { get; set; }
		public IEnumerable<string> ProblemIds { get; set; }
		public IEnumerable<string> ProblemFilterIds { get; set; }
		public IEnumerable<string> ProblemFilterNames { get; set; }
		public IEnumerable<KeyValuePair<string, string>> EntityTags { get; set; }
		public IEnumerable<string> DisplayIds { get; set; }

		public override string ToString()
		{
			return string.Join(",", new List<string>
			{
				s_statusesConverter.ConvertToString(Status).ToLowerInvariant().WithPrefixAndParentheses("status"),
				string.Join(",", SeverityLevel.Select(x => s_severityLevelsConverter.ConvertToString(x).ToLowerInvariant())).WithPrefixAndParentheses("severityLevel"),
				string.Join(",", ImpactLevel.Select(x => s_impactLevelsConverter.ConvertToString(x).ToLowerInvariant())).WithPrefixAndParentheses("impactLevel"),
				string.Join(",", RootCauseEntities).WithPrefixAndParentheses("rootCauseEntity"),
				string.Join(",", ManagementZoneIds).WithPrefixAndParentheses("managementZoneIds"),
				string.Join(",", ManagementZoneNames).WithPrefixAndParentheses("managementZones"),
				string.Join(",", ImpactedEntities).WithPrefixAndParentheses("impactedEntities"),
				string.Join(",", AffectedEntities).WithPrefixAndParentheses("affectedEntities"),
				string.Join(",", AffectedEntityTypes).WithPrefixAndParentheses("affectedEntityTypes"),
				string.Join(",", ProblemIds).WithPrefixAndParentheses("problemId"),
				string.Join(",", ProblemFilterIds).WithPrefixAndParentheses("problemFilterIds"),
				string.Join(",", ProblemFilterNames).WithPrefixAndParentheses("problemFilterNames"),
				string.Join(",", EntityTags.Select(kvp => $"{kvp.Key}:{kvp.Value}")).WithPrefixAndParentheses("entityTags"),
				string.Join(",", DisplayIds).WithPrefixAndParentheses("displayId")
			});
		}
	}
}
