using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.AzureCredentials.Models
{
	public class AzureMonitoredMetric
	{
		public string Name { get; set; }
		public IEnumerable<string> Dimensions { get; set; }
	}
}
