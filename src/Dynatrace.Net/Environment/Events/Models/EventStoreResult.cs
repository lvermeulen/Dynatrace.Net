using System.Collections.Generic;

namespace Dynatrace.Net.Environment.Events.Models
{
	public class EventStoreResult
	{
		public IEnumerable<int> StoredEventIds { get; set; }
		public IEnumerable<string> StoredIds { get; set; }
		public IEnumerable<string> StoredCorrelationIds { get; set; }
	}
}
