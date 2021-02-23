using System.Collections.Generic;
using Dynatrace.Net.Configuration.OneAgentOnAHost.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class TechnologyScopesConverter : JsonEnumConverter<TechnologyScopes>
	{
		private static readonly Dictionary<TechnologyScopes, string> s_pairs = new Dictionary<TechnologyScopes, string>
		{
			[TechnologyScopes.Environment] = "ENVIRONMENT",
			[TechnologyScopes.Host] = "HOST"
		};

		protected override Dictionary<TechnologyScopes, string> Pairs => s_pairs;
		protected override string EntityString => "technology scope";
	}
}
