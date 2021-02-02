using System.Collections.Generic;

namespace Dynatrace.Net.Environment.SyntheticV1.Models
{
	public class ThirdPartySyntheticEvents
	{
		public string SyntheticEngineName { get; set; }
		public IEnumerable<ThirdPartyEventOpenNotification> Open { get; set; }
		public IEnumerable<ThirdPartyEventResolvedNotification> Resolved { get; set; }
	}
}
