using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.AwsCredentials.Models
{
	public class AwsAuthenticationData
	{
		[JsonConverter(typeof(AwsAuthenticationDataTypesConverter))]
		public AwsAuthenticationDataTypes Type { get; set; }
		public KeyBasedAuthentication KeyBasedAuthentication { get; set; }
		public RoleBasedAuthentication RoleBasedAuthentication { get; set; }
	}
}
