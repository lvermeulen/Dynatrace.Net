namespace Dynatrace.Net.Configuration.Notifications.Models
{
	public class NotificationConfig
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string AlertingProfile { get; set; }
		public bool? Active { get; set; }
		public string Type { get; set; }
	}
}
