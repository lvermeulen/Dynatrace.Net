namespace Dynatrace.Net.Configuration.AlertingProfiles.Models
{
	public class AlertingCustomEventFilter
	{
		public bool? Enabled { get; set; }
		public string Value { get; set; }
		public string Operator { get; set; }
		public bool? Negate { get; set; }
		public bool? CaseInsensitive { get; set; }
	}
}
