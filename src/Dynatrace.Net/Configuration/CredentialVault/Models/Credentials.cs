namespace Dynatrace.Net.Configuration.CredentialVault.Models
{
	public class Credentials
	{
		public string Name { get; set; }
		public string Id { get; set; }
		public string Description { get; set; }
		public bool? OwnerAccessOnly { get; set; }
		public CredentialScopes? Scope { get; set; }
		public CredentialTypes? Type { get; set; }
	}
}
