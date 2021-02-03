using System.Collections.Generic;
using Dynatrace.Net.Environment.TimeSeriesV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class TimeSeriesQueryModesConverter : JsonEnumConverter<TimeSeriesQueryModes>
	{
		private static readonly Dictionary<TimeSeriesQueryModes, string> s_pairs = new Dictionary<TimeSeriesQueryModes, string>
		{
			[TimeSeriesQueryModes.Series] = "SERIES",
			[TimeSeriesQueryModes.Total] = "TOTAL"
		};

		protected override Dictionary<TimeSeriesQueryModes, string> Pairs => s_pairs;

		protected override string EntityString => "query mode";
	}
}
