namespace Dynatrace.Net.Configuration.Notifications.Models
{
	public class JiraNotificationConfig : NotificationConfig
	{
		public string Username { get; set; }
		public string Password { get; set; }
		public string Url { get; set; }
		public string ProjectKey { get; set; }
		public string IssueType { get; set; }
		public string Summary { get; set; }
		public string Description { get; set; }
	}
}
