using System.Collections.Generic;
using Dynatrace.Net.Environment.TimeSeriesV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class TimeSeriesSourcesConverter : JsonEnumConverter<TimeSeriesSources>
	{
		private static readonly Dictionary<TimeSeriesSources, string> s_pairs = new Dictionary<TimeSeriesSources, string>
		{
			[TimeSeriesSources.All] = "ALL",
			[TimeSeriesSources.Builtin] = "BUILTIN",
			[TimeSeriesSources.Custom] = "CUSTOM",
			[TimeSeriesSources.Plugin] = "PLUGIN",
			[TimeSeriesSources.RemotePlugin] = "REMOTE_PLUGIN"
		};

		protected override Dictionary<TimeSeriesSources, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "time series source";
	}
}
