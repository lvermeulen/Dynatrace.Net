using System.Collections.Generic;
using Dynatrace.Net.Configuration.CredentialVault.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class CredentialTypesConverter : JsonEnumConverter<CredentialTypes>
	{
		private static readonly Dictionary<CredentialTypes, string> s_pairs = new Dictionary<CredentialTypes, string>
		{
			[CredentialTypes.Certificate] = "CERTIFICATE",
			[CredentialTypes.UsernamePassword] = "USERNAME_PASSWORD",
			[CredentialTypes.Token] = "TOKEN",
			[CredentialTypes.Unknown] = "UNKNOWN"
		};

		protected override Dictionary<CredentialTypes, string> Pairs => s_pairs;

		protected override string EntityString => "credential type";
	}
}
