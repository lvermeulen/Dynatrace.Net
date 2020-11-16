using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.MaintenanceWindows.Models
{
	public class Recurrence
	{
		[JsonConverter(typeof(DaysOfWeekConverter))]
		public DaysOfWeek? DayOfWeek { get; set; }
		public int? DayOfMonth { get; set; }
		public string StartTime { get; set; }
		public int? DurationMinutes { get; set; }
	}
}
