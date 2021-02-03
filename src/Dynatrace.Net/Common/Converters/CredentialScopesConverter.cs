using System.Collections.Generic;
using Dynatrace.Net.Configuration.CredentialVault.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class CredentialScopesConverter : JsonEnumConverter<CredentialScopes>
	{
		private static readonly Dictionary<CredentialScopes, string> s_pairs = new Dictionary<CredentialScopes, string>
		{
			[CredentialScopes.All] = "ALL",
			[CredentialScopes.Extension] = "EXTENSION",
			[CredentialScopes.Synthetic] = "SYNTHETIC"
		};

		protected override Dictionary<CredentialScopes, string> Pairs => s_pairs;

		protected override string EntityString => "credential scope";
	}
}
