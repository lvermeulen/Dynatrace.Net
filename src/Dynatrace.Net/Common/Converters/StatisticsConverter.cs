using System.Collections.Generic;
using Dynatrace.Net.Configuration.AwsCredentials.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class StatisticsConverter : JsonEnumConverter<Statistics>
	{
		private static readonly Dictionary<Statistics, string> s_pairs = new Dictionary<Statistics, string>
		{
			[Statistics.Average] = "AVERAGE",
			[Statistics.AvgMinMax] = "AVG_MIN_MAX",
			[Statistics.Maximum] = "MAXIMUM",
			[Statistics.Minimum] = "MINIMUM",
			[Statistics.SampleCount] = "SAMPLE_COUNT",
			[Statistics.Sum] = "SUM"
		};

		protected override Dictionary<Statistics, string> Pairs => s_pairs;

		protected override string EntityString => "statistic";
	}
}
