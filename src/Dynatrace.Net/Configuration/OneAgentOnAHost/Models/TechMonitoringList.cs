using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Configuration.OneAgentOnAHost.Models
{
	public class TechMonitoringList
	{
		public ConfigurationMetadata Metadata { get; set; }
		public IEnumerable<Technology> Technologies { get; set; }
	}
}
