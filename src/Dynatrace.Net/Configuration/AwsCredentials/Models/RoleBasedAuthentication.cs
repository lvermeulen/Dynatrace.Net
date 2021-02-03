namespace Dynatrace.Net.Configuration.AwsCredentials.Models
{
	public class RoleBasedAuthentication
	{
		public string IamRole { get; set; }
		public string AccountId { get; set; }
		public string ExternalId { get; set; }
	}
}
