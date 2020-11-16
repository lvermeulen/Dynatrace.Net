using System.Collections.Generic;
using Dynatrace.Net.Configuration.MaintenanceWindows.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class RecurrenceTypesConverter : JsonEnumConverter<RecurrenceTypes>
	{
		private static readonly Dictionary<RecurrenceTypes, string> s_pairs = new Dictionary<RecurrenceTypes, string>
		{
			[RecurrenceTypes.Daily] = "DAILY",
			[RecurrenceTypes.Monthly] = "MONTHLY",
			[RecurrenceTypes.Once] = "ONCE",
			[RecurrenceTypes.Weekly] = "WEEKLY"
		};

		protected override Dictionary<RecurrenceTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "recurrence type";
	}
}
