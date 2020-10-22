using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.Events.Models
{
	public class EventRestEntry
	{
		public int? StartTime { get; set; }
		public int? EndTime { get; set; }
		public string EntityId { get; set; }
		public string EntityName { get; set; }
		[JsonConverter(typeof(SeverityLevelsConverter))]
		public SeverityLevels? SeverityLevel { get; set; }
		[JsonConverter(typeof(ImpactLevelsConverter))]
		public ImpactLevels? ImpactLevel { get; set; }
		[JsonConverter(typeof(EventTypesConverter))]
		public EventTypes? EventType { get; set; }
		public string ResourceId { get; set; }
		public string ResourceName { get; set; }
		[JsonConverter(typeof(StatusesConverter))]
		public Statuses? EventStatus { get; set; }
		public IEnumerable<TagInfo> Tags { get; set; }
		public string Id { get; set; }
	}
}
