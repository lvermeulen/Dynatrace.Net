using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class UrlOperatorsConverter : JsonEnumConverter<UrlOperators>
	{
		private static readonly Dictionary<UrlOperators, string> s_pairs = new Dictionary<UrlOperators, string>
		{
			[UrlOperators.AllPages] = "ALL_PAGES",
			[UrlOperators.Contains] = "CONTAINS",
			[UrlOperators.EndsWith] = "ENDS_WITH",
			[UrlOperators.Equal] = "EQUALS",
			[UrlOperators.StartsWith] = "STARTS_WITH"
		};

		protected override Dictionary<UrlOperators, string> Pairs => s_pairs;

		protected override string EntityString => "URL operator";
	}
}
