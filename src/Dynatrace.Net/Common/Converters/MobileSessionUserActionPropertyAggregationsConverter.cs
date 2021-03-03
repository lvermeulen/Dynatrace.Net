using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MobileSessionUserActionPropertyAggregationsConverter : JsonEnumConverter<MobileSessionUserActionPropertyAggregations>
	{
		private static readonly Dictionary<MobileSessionUserActionPropertyAggregations, string> s_pairs = new Dictionary<MobileSessionUserActionPropertyAggregations, string>
		{
			[MobileSessionUserActionPropertyAggregations.Last] = "LAST"
		};

		protected override Dictionary<MobileSessionUserActionPropertyAggregations, string> Pairs => s_pairs;

		protected override string EntityString => "mobile session user action property aggregation";
	}
}
