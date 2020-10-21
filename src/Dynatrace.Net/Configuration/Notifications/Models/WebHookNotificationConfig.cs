using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.Notifications.Models
{
	public class WebHookNotificationConfig : NotificationConfig
	{
		public string Url { get; set; }
		public string Payload { get; set; }
		public IEnumerable<HttpHeader> Headers { get; set; }
	}
}
