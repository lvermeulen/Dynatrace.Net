namespace Dynatrace.Net.Configuration.Notifications.Models
{
	public class SlackNotificationConfig : NotificationConfig
	{
		public string Url { get; set; }
		public string Channel { get; set; }
		public string Title { get; set; }
	}
}
