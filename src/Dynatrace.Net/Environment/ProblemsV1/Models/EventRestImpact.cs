namespace Dynatrace.Net.Environment.ProblemsV1.Models
{
	public class EventRestImpact
	{
		public string EntityId { get; set; }
		public string EntityName { get; set; }
		public string SeverityLevel { get; set; }
		public string ImpactLevel { get; set; }
		public string EventType { get; set; }
		public string ResourceId { get; set; }
		public string ResourceName { get; set; }
	}
}
