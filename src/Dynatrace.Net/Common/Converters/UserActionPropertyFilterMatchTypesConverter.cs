using System.Collections.Generic;
using Dynatrace.Net.Configuration.CalculatedMetrics.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class UserActionPropertyFilterMatchTypesConverter : JsonEnumConverter<UserActionPropertyFilterMatchTypes>
	{
		private static readonly Dictionary<UserActionPropertyFilterMatchTypes, string> s_pairs = new Dictionary<UserActionPropertyFilterMatchTypes, string>
		{
			[UserActionPropertyFilterMatchTypes.Contains] = "Contains",
			[UserActionPropertyFilterMatchTypes.Equals] = "Equals"
		};

		protected override Dictionary<UserActionPropertyFilterMatchTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "match type";
	}
}
