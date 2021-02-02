using System.Collections.Generic;
using Dynatrace.Net.Environment.SyntheticV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class TestEventTypesConverter : JsonEnumConverter<TestEventTypes>
	{
		private static readonly Dictionary<TestEventTypes, string> s_pairs = new Dictionary<TestEventTypes, string>
		{
			[TestEventTypes.TestOutage] = "testOutage",
			[TestEventTypes.TestSlowdown] = "testSlowdown"
		};

		protected override Dictionary<TestEventTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "event type";
	}
}
