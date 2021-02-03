using System.Collections.Generic;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class FileNameMatchersConverter : JsonEnumConverter<FileNameMatchers>
	{
		private static readonly Dictionary<FileNameMatchers, string> s_pairs = new Dictionary<FileNameMatchers, string>
		{
			[FileNameMatchers.EndsWith] = "ENDS_WITH",
			[FileNameMatchers.Equal] = "EQUALS",
			[FileNameMatchers.StartsWith] = "STARTS_WITH"
		};

		protected override Dictionary<FileNameMatchers, string> Pairs => s_pairs;

		protected override string EntityString => "matcher";
	}
}
