using System.Collections.Generic;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ValueConditionOperatorsConverter : JsonEnumConverter<ValueConditionOperators>
	{
		private static readonly Dictionary<ValueConditionOperators, string> s_pairs = new Dictionary<ValueConditionOperators, string>
		{
			[ValueConditionOperators.BeginsWith] = "BEGINS_WITH",
			[ValueConditionOperators.Contains] = "CONTAINS",
			[ValueConditionOperators.EndsWith] = "ENDS_WITH",
			[ValueConditionOperators.Equal] = "EQUALS"
		};

		protected override Dictionary<ValueConditionOperators, string> Pairs => s_pairs;

		protected override string EntityString => "operator";
	}
}
