namespace Dynatrace.Net.Configuration.Notifications.Models
{
	public class OpsGenieNotificationConfig : NotificationConfig
	{
		public string ApiKey { get; set; }
		public string Domain { get; set; }
		public string Message { get; set; }
	}
}
