namespace Dynatrace.Net.Configuration.Notifications.Models
{
	public class AnsibleTowerNotificationConfig : NotificationConfig
	{
		// ReSharper disable once InconsistentNaming
		public string JobTemplateURL { get; set; }
		public bool? AcceptAnyCertificate { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public int? JobTemplateId { get; set; }
		public string CustomMessage { get; set; }
	}
}
