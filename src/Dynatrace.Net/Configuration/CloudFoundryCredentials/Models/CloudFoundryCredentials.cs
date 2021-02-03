using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.CloudFoundryCredentials.Models
{
	public class CloudFoundryCredentials
	{
		public ConfigurationMetadata Metadata { get; set; }
		public string Id { get; set; }
		public bool? Active { get; set; }
		[JsonConverter(typeof(EndpointStatusTypesConverter))]
		public EndpointStatusTypes? EndpointStatus { get; set; }
		public string EndpointStatusInfo { get; set; }
		public string Name { get; set; }
		public string ApiUrl { get; set; }
		public string LoginUrl { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
	}
}
