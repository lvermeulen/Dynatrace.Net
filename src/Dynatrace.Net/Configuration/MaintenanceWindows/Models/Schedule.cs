using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.MaintenanceWindows.Models
{
	public class Schedule
	{
		[JsonConverter(typeof(RecurrenceTypesConverter))]
		public RecurrenceTypes? RecurrenceType { get; set; }
		public Recurrence Recurrence { get; set; }
		public string Start { get; set; }
		public string End { get; set; }
		public string ZoneId { get; set; }
	}
}
