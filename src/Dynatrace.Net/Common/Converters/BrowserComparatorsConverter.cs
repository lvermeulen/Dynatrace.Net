using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class BrowserComparatorsConverter : JsonEnumConverter<BrowserComparators>
	{
		private static readonly Dictionary<BrowserComparators, string> s_pairs = new Dictionary<BrowserComparators, string>
		{
			[BrowserComparators.Equal] = "EQUALS",
			[BrowserComparators.GreaterThanOrEqual] = "GREATER_THAN_OR_EQUAL",
			[BrowserComparators.LowerThanOrEqual] = "LOWER_THAN_OR_EQUAL"
		};

		protected override Dictionary<BrowserComparators, string> Pairs => s_pairs;

		protected override string EntityString => "browser comparator";
	}
}
