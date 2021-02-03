using System.Collections.Generic;
using Dynatrace.Net.Environment.Tokens.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class TokenResultFormatsConverter : JsonEnumConverter<TokenResultFormats>
	{
		private static readonly Dictionary<TokenResultFormats, string> s_pairs = new Dictionary<TokenResultFormats, string>
		{
			[TokenResultFormats.ApplicationJson] = "application/json",
			[TokenResultFormats.TextPlain] = "text/plain",
			[TokenResultFormats.TextCsvHeaderPresent] = "text/csv; header=present",
			[TokenResultFormats.TextCsvHeaderAbsent] = "text/csv; header=absent",
		};

		protected override Dictionary<TokenResultFormats, string> Pairs => s_pairs;

		protected override string EntityString => "request header";
	}
}
