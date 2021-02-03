using System.Collections.Generic;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class PlaceholderNormalizationsConverter : JsonEnumConverter<PlaceholderNormalizations>
	{
		private static readonly Dictionary<PlaceholderNormalizations, string> s_pairs = new Dictionary<PlaceholderNormalizations, string>
		{
			[PlaceholderNormalizations.Original] = "ORIGINAL",
			[PlaceholderNormalizations.ToLowerCase] = "TO_LOWER_CASE",
			[PlaceholderNormalizations.ToUpperCase] = "TO_UPPER_CASE"
		};
		
		protected override Dictionary<PlaceholderNormalizations, string> Pairs => s_pairs;

		protected override string EntityString => "normalization";
	}
}
