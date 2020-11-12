using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Environment.ProblemsV2.Models
{
	public class Problem
	{
		public string DisplayId { get; set; }
		public IEnumerable<MeTag> EntityTags { get; set; }
		public string ImpactLevel { get; set; }
		public IEnumerable<EntityStub> ImpactedEntities { get; set; }
		public IEnumerable<ProblemFilterStubDto> ProblemFilters { get; set; }
		public EntityStub RootCauseEntity { get; set; }
		public EvidenceDetails EvidenceDetails { get; set; }
		public CommentsList RecentComments { get; set; }
		public ImpactAnalysis ImpactAnalysis { get; set; }
		public string SeverityLevel { get; set; }
		public string ProblemId { get; set; }
		public IEnumerable<ManagementZoneInfo> ManagementZones { get; set; }
		public IEnumerable<EntityStub> AffectedEntities { get; set; }
		public string Title { get; set; }
		public string Status { get; set; }
		public int? StartTime { get; set; }
		public int? EndTime { get; set; }
	}
}
