using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.AwsCredentials.Models
{
	public class AwsSupportingServiceConfig
	{
		public string Name { get; set; }
		public IEnumerable<AwsSupportingServiceMetric> MonitoredMetrics { get; set; }
	}
}
