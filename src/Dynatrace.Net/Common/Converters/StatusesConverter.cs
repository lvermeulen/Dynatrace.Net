using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class StatusesConverter : JsonEnumConverter<Statuses>
	{
		private static readonly Dictionary<Statuses, string> s_pairs = new Dictionary<Statuses, string>
		{
			[Statuses.Closed] = "CLOSED",
			[Statuses.Open] = "OPEN"
		};

		protected override Dictionary<Statuses, string> Pairs => s_pairs;

		protected override string EntityString => "status";
	}
}
