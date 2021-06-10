using System;
using System.Collections.Generic;

namespace Dynatrace.Net.Environment.Events.Models
{
	public class EventStoreResult
	{
		[Obsolete("StoredIds should be used. See https://www.dynatrace.com/support/help/shortlink/api-events-post-event#response-body")]
		public IEnumerable<long> StoredEventIds { get; set; }
		public IEnumerable<string> StoredIds { get; set; }
		public IEnumerable<string> StoredCorrelationIds { get; set; }
	}
}
