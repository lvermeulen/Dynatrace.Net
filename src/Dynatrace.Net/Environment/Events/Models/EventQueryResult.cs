using System.Collections.Generic;

namespace Dynatrace.Net.Environment.Events.Models
{
	public class EventQueryResult
	{
		public int? NextEventStartTms { get; set; }
		public int? NextEventId { get; set; }
		public string NextCursor { get; set; }
		public int? From { get; set; }
		public int? To { get; set; }
		public int? TotalEventCount { get; set; }
		public IEnumerable<EventRestEntry> Events { get; set; }
	}
}
