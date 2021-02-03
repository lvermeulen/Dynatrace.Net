using System.Collections.Generic;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class PlaceholderKindsConverter : JsonEnumConverter<PlaceholderKinds>
	{
		private static readonly Dictionary<PlaceholderKinds, string> s_pairs = new Dictionary<PlaceholderKinds, string>
		{
			[PlaceholderKinds.AfterDelimiter] = "AFTER_DELIMITER",
			[PlaceholderKinds.BeforeDelimiter] = "BEFORE_DELIMITER",
			[PlaceholderKinds.BetweenDelimiter] = "BETWEEN_DELIMITER",
			[PlaceholderKinds.OriginalText] = "ORIGINAL_TEXT",
			[PlaceholderKinds.RegexExtraction] = "REGEX_EXTRACTION"
		};
		
		protected override Dictionary<PlaceholderKinds, string> Pairs => s_pairs;

		protected override string EntityString => "placeholder kind";
	}
}
