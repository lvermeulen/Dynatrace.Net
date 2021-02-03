using System.Collections.Generic;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class PlaceHolderAggregationTypesConverter : JsonEnumConverter<PlaceHolderAggregationTypes>
	{
		private static readonly Dictionary<PlaceHolderAggregationTypes, string> s_pairs = new Dictionary<PlaceHolderAggregationTypes, string>
		{
			[PlaceHolderAggregationTypes.Count] = "COUNT",
			[PlaceHolderAggregationTypes.First] = "FIRST",
			[PlaceHolderAggregationTypes.Last] = "LAST"
		};

		protected override Dictionary<PlaceHolderAggregationTypes, string> Pairs => s_pairs;

		protected override string EntityString => "aggregation type";
	}
}
