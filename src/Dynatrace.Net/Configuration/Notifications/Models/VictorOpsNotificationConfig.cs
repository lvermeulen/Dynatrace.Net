namespace Dynatrace.Net.Configuration.Notifications.Models
{
	public class VictorOpsNotificationConfig : NotificationConfig
	{
		public string ApiKey { get; set; }
		public string RoutingKey { get; set; }
		public string Message { get; set; }
	}
}
