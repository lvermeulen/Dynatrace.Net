namespace Dynatrace.Net.Environment.ProblemsV2.Models
{
	public class Evidence
	{
		public string EvidenceType { get; set; }
		public string DisplayName { get; set; }
		public EntityStub Entity { get; set; }
		public EntityStub GroupingEntity { get; set; }
		public bool? RootCauseRelevant { get; set; }
		public int? StartTime { get; set; }
	}
}
