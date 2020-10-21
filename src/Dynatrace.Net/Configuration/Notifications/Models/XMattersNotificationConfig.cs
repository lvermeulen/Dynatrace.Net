using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.Notifications.Models
{
	public class XMattersNotificationConfig : NotificationConfig
	{
		public string Url { get; set; }
		public bool? AcceptAnyCertificate { get; set; }
		public IEnumerable<HttpHeader> Headers { get; set; }
		public string Payload { get; set; }
	}
}
