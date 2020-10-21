namespace Dynatrace.Net.Configuration.AlertingProfiles.Models
{
	public class AlertingProfileSeverityRule
	{
		public string SeverityLevel { get; set; }
		public AlertingProfileTagFilter TagFilter { get; set; }
		public int? DelayInMinutes { get; set; }
	}
}
