using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Configuration.FrequentIssueDetection.Models
{
	public class FrequentIssueDetectionConfig
	{
		public ConfigurationMetadata Metadata { get; set; }
		public bool? FrequentIssueDetectionApplicationEnabled { get; set; }
		public bool? FrequentIssueDetectionServiceEnabled { get; set; }
		public bool? FrequentIssueDetectionInfrastructureEnabled { get; set; }
	}
}
