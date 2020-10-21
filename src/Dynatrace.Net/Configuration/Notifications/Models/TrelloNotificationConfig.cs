namespace Dynatrace.Net.Configuration.Notifications.Models
{
	public class TrelloNotificationConfig : NotificationConfig
	{
		public string ApplicationKey { get; set; }
		public string AuthorizationToken { get; set; }
		public string BoardId { get; set; }
		public string ListId { get; set; }
		public string ResolvedListId { get; set; }
		public string Text { get; set; }
		public string Description { get; set; }
	}
}
