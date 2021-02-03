using System.Collections.Generic;
using Dynatrace.Net.Environment.SyntheticV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class LoadingTimeThresholdTypesConverter : JsonEnumConverter<LoadingTimeThresholdTypes>
	{
		private static readonly Dictionary<LoadingTimeThresholdTypes, string> s_pairs = new Dictionary<LoadingTimeThresholdTypes, string>
		{
			[LoadingTimeThresholdTypes.Action] = "ACTION",
			[LoadingTimeThresholdTypes.Total] = "TOTAL"
		};

		protected override Dictionary<LoadingTimeThresholdTypes, string> Pairs => s_pairs;

		protected override string EntityString => "loading time threshold type";
	}
}
