using System.Collections.Generic;
using Dynatrace.Net.Configuration.MaintenanceWindows.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class DaysOfWeekConverter : JsonEnumConverter<DaysOfWeek>
	{
		private static readonly Dictionary<DaysOfWeek, string> s_pairs = new Dictionary<DaysOfWeek, string>
		{
			[DaysOfWeek.Friday] = "FRIDAY",
			[DaysOfWeek.Monday] = "MONDAY",
			[DaysOfWeek.Saturday] = "SATURDAY",
			[DaysOfWeek.Sunday] = "SUNDAY",
			[DaysOfWeek.Thursday] = "THURSDAY",
			[DaysOfWeek.Tuesday] = "TUESDAY",
			[DaysOfWeek.Wednesday] = "WEDNESDAY"
		};

		protected override Dictionary<DaysOfWeek, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "day of week";
	}
}
