using System.Collections.Generic;
using Dynatrace.Net.Environment.Tokens.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class TokenDurationsConverter : JsonEnumConverter<TokenDurations>
	{
		private static readonly Dictionary<TokenDurations, string> s_pairs = new Dictionary<TokenDurations, string>
		{
			[TokenDurations.Days] = "DAYS",
			[TokenDurations.Hours] = "HOURS",
			[TokenDurations.Millis] = "MILLIS",
			[TokenDurations.Minutes] = "MINUTES",
			[TokenDurations.Seconds] = "SECONDS"
		};

		protected override Dictionary<TokenDurations, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "duration";
	}
}
