namespace Dynatrace.Net.Configuration.Notifications.Models
{
	public class PagerDutyNotificationConfig : NotificationConfig
	{
		public string Account { get; set; }
		public string ServiceApiKey { get; set; }
		public string ServiceName { get; set; }
	}
}
