using System.Collections.Generic;
using Dynatrace.Net.Environment.Tokens.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ResultFormatsConverter : JsonEnumConverter<ResultFormats>
	{
		private static readonly Dictionary<ResultFormats, string> s_pairs = new Dictionary<ResultFormats, string>
		{
			[ResultFormats.ApplicationJson] = "application/json",
			[ResultFormats.TextPlain] = "text/plain",
			[ResultFormats.TextCsvHeaderPresent] = "accept: text/csv; header=present; charset=utf-8",
			[ResultFormats.TextCsvHeaderAbsent] = "accept: text/csv; header=absent; charset=utf-8",
		};

		protected override Dictionary<ResultFormats, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "request header";
	}
}
