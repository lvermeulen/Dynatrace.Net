using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.AzureCredentials.Models
{
	public class AzureSupportingService
	{
		public string Name { get; set; }
		public IEnumerable<AzureMonitoredMetric> MonitoredMetrics { get; set; }
	}
}
