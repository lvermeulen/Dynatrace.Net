using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.ProblemsV1.Models
{
	public class Problem
	{
		public string Id { get; set; }
		public int? StartTime { get; set; }
		public int? EndTime { get; set; }
		public string DisplayName { get; set; }
		[JsonConverter(typeof(ImpactLevelsConverter))]
		public ImpactLevels? ImpactLevel { get; set; }
		[JsonConverter(typeof(StatusesConverter))]
		public Statuses? Status { get; set; }
		[JsonConverter(typeof(SeverityLevelsConverter))]
		public SeverityLevels? SeverityLevel { get; set; }
		public int? CommentCount { get; set; }
		public IEnumerable<TagInfo> TagsOfAffectedEntities { get; set; }
		public IEnumerable<Event> RankedEvents { get; set; }
		public IEnumerable<EventRestImpact> RankedImpacts { get; set; }
		public object AffectedCounts { get; set; }
		public object RecoveredCounts { get; set; }
		public bool? HasRootCause { get; set; }
	}
}
