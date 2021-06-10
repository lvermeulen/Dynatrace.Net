using System.Collections.Generic;

namespace Dynatrace.Net.Environment.Events.Models
{
	public class EventQueryResult
	{
		public long? NextEventStartTms { get; set; }
		public long? NextEventId { get; set; }
		public string NextCursor { get; set; }
		public long? From { get; set; }
		public long? To { get; set; }
		public long? TotalEventCount { get; set; }
		public IEnumerable<EventRestEntry> Events { get; set; }
	}
}
