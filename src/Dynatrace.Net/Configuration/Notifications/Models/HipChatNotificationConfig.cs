namespace Dynatrace.Net.Configuration.Notifications.Models
{
	public class HipChatNotificationConfig : NotificationConfig
	{
		public string Url { get; set; }
		public string Message { get; set; }
	}
}
