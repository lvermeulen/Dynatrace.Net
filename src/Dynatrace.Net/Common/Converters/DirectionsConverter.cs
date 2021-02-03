using System.Collections.Generic;
using Dynatrace.Net.Configuration.CalculatedMetrics.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class DirectionsConverter : JsonEnumConverter<Directions>
	{
		private static readonly Dictionary<Directions, string> s_pairs = new Dictionary<Directions, string>
		{
			[Directions.Ascending] = "ASCENDING",
			[Directions.Descending] = "DESCENDING"
		};

		protected override Dictionary<Directions, string> Pairs => s_pairs;

		protected override string EntityString => "direction";
	}
}
