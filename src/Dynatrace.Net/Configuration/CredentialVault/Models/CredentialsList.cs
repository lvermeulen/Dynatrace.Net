using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.CredentialVault.Models
{
	public class CredentialsList
	{
		public IEnumerable<CredentialsResponseElement> Credentials { get; set; }
	}
}
