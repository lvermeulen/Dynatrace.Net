using System.Collections.Generic;

namespace Dynatrace.Net.Environment.SyntheticV1.Models
{
	public class PrivateSyntheticLocation : SyntheticLocation
	{
		public IEnumerable<string> Nodes { get; set; }
		public bool? AvailabilityLocationOutage { get; set; }
		public bool? AvailabilityNodeOutage { get; set; }
		public int? LocationNodeOutageDelayInMinutes { get; set; }
		public bool? AvailabilityNotificationsEnabled { get; set; }
	}
}
