using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.Notifications.Models
{
	public class EmailNotificationConfig : NotificationConfig
	{
		public string Subject { get; set; }
		public string Body { get; set; }
		public IEnumerable<string> Receivers { get; set; }
		public IEnumerable<string> CcReceivers { get; set; }
		public IEnumerable<string> BccReceivers { get; set; }
	}
}
