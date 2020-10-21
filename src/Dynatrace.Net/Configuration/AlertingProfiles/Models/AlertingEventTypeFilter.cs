namespace Dynatrace.Net.Configuration.AlertingProfiles.Models
{
	public class AlertingEventTypeFilter
	{
		public AlertingPredefinedEventFilter PredefinedEventFilter { get; set; }
		public AlertingCustomEventFilter CustomEventFilter { get; set; }
	}
}
