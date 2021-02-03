using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.CredentialVault.Models
{
	public class CredentialsResponseElement
	{
		public string Name { get; set; }
		public string Id { get; set; }
		[JsonConverter(typeof(CredentialTypesConverter))]
		public CredentialTypes? Type { get; set; }
		public string Description { get; set; }
		public string Owner { get; set; }
		public bool? OwnerAccessOnly { get; set; }
		[JsonConverter(typeof(CredentialScopesConverter))]
		public CredentialScopes? Scope { get; set; }
	}
}
