using System.Collections.Generic;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MatchersConverter : JsonEnumConverter<Matchers>
	{
		private static readonly Dictionary<Matchers, string> s_pairs = new Dictionary<Matchers, string>
		{
			[Matchers.EndsWith] = "ENDS_WITH",
			[Matchers.Equal] = "EQUALS",
			[Matchers.StartsWith] = "STARTS_WITH"
		};

		protected override Dictionary<Matchers, string> Pairs => s_pairs;

		protected override string EntityString => "matcher";
	}
}
