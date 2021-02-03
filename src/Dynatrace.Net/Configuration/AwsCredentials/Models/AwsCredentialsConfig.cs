using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.AwsCredentials.Models
{
	public class AwsCredentialsConfig
	{
		public ConfigurationMetadata Metadata { get; set; }
		public string Id { get; set; }
		[JsonConverter(typeof(ConnectionStatusTypesConverter))]
		public ConnectionStatusTypes? ConnectionStatus { get; set; }
		public string Label { get; set; }
		[JsonConverter(typeof(PartitionTypesConverter))]
		public PartitionTypes? PartitionType { get; set; }
		public AwsAuthenticationData AuthenticationData { get; set; }
		public bool? TaggedOnly { get; set; }
		public IEnumerable<AwsConfigTag> TagsToMonitor { get; set; }
		public IEnumerable<AwsSupportingServiceConfig> SupportingServicesToMonitor { get; set; }
	}
}
