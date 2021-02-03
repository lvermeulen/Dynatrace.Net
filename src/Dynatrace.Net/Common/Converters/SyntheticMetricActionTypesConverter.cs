using System.Collections.Generic;
using Dynatrace.Net.Configuration.CalculatedMetrics.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class SyntheticMetricActionTypesConverter : JsonEnumConverter<SyntheticMetricActionTypes>
	{
		private static readonly Dictionary<SyntheticMetricActionTypes, string> s_pairs = new Dictionary<SyntheticMetricActionTypes, string>
		{
			[SyntheticMetricActionTypes.Custom] = "Custom",
			[SyntheticMetricActionTypes.Load] = "Load",
			[SyntheticMetricActionTypes.Xhr] = "Xhr"
		};

		protected override Dictionary<SyntheticMetricActionTypes, string> Pairs => s_pairs;

		protected override string EntityString => "action type";
	}
}
