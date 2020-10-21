namespace Dynatrace.Net.Configuration.Notifications.Models
{
	public class ServiceNowNotificationConfig : NotificationConfig
	{
		public string InstanceName { get; set; }
		public string Url { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Message { get; set; }
		public bool? SendIncidents { get; set; }
		public bool? SendEvents { get; set; }
	}
}
