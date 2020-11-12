using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Configuration.ManagementZones.Models
{
	public class ManagementZone : ManagementZoneInfo
	{
		public ConfigurationMetadata Metadata { get; set; }
		public IEnumerable<ManagementZoneRule> Rules { get; set; }
	}
}
