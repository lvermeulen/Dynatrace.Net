using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class ApplicationDetectionRuleConfig
	{
		public ConfigurationMetadata Metadata { get; set; }
		public string Id { get; set; }
		public string Order { get; set; }
		public string ApplicationIdentifier { get; set; }
		public ApplicationFilter FilterConfig { get; set; }
		public string Name { get; set; }
	}
}
