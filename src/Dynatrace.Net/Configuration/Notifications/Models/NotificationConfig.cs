using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Notifications.Models
{
	public class NotificationConfig
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string AlertingProfile { get; set; }
		public bool? Active { get; set; }
		[JsonConverter(typeof(NotificationConfigTypesConverter))]
		public NotificationConfigTypes? Type { get; set; }
	}
}
