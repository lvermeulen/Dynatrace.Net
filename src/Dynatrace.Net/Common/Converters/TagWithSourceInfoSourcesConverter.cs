using System.Collections.Generic;
using Dynatrace.Net.Environment.SyntheticV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class TagWithSourceInfoSourcesConverter : JsonEnumConverter<TagWithSourceInfoSources>
	{
		private static readonly Dictionary<TagWithSourceInfoSources, string> s_pairs = new Dictionary<TagWithSourceInfoSources, string>
		{
			[TagWithSourceInfoSources.Auto] = "AUTO",
			[TagWithSourceInfoSources.RuleBased] = "RULE_BASED",
			[TagWithSourceInfoSources.User] = "USER"
		};

		protected override Dictionary<TagWithSourceInfoSources, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "tag with source info source";
	}
}
