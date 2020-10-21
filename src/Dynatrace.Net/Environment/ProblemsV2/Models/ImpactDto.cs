namespace Dynatrace.Net.Environment.ProblemsV2.Models
{
	public class ImpactDto
	{
		public int? EstimatedAffectedUsers { get; set; }
		public EntityStub ImpactedEntity { get; set; }
	}
}
