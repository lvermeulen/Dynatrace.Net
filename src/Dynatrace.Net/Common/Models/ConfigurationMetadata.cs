using System.Collections.Generic;

namespace Dynatrace.Net.Common.Models
{
	public class ConfigurationMetadata
	{
		public IEnumerable<int> ConfigurationVersions { get; set; }
		public IEnumerable<string> CurrentConfigurationVersions { get; set; }
		public string ClusterVersion { get; set; }
	}
}
