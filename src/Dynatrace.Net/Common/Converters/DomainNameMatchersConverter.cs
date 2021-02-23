using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class DomainNameMatchersConverter : JsonEnumConverter<DomainNameMatchers>
	{
		private static readonly Dictionary<DomainNameMatchers, string> s_pairs = new Dictionary<DomainNameMatchers, string>
		{
			[DomainNameMatchers.Contains] = "CONTAINS",
			[DomainNameMatchers.EndsWith] = "ENDS_WITH",
			[DomainNameMatchers.Equal] = "EQUALS",
			[DomainNameMatchers.StartsWith] = "STARTS_WITH"
		};

		protected override Dictionary<DomainNameMatchers, string> Pairs => s_pairs;

		protected override string EntityString => "domain name matcher";
	}
}
