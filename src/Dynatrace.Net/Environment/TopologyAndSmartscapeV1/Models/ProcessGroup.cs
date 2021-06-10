using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models
{
	public class ProcessGroup
	{
		public string EntityId { get; set; }
		public string DisplayName { get; set; }
		public string CustomizedName { get; set; }
		public string DiscoveredName { get; set; }
		public long? FirstSeenTimestamp { get; set; }
		public long? LastSeenTimestamp { get; set; }
		public IEnumerable<TagInfo> Tags { get; set; }
		public object ToRelationships { get; set; }
		public object Metadata { get; set; }
		public string AzureSiteName { get; set; }
		public IEnumerable<int> ListenPorts { get; set; }
		public IEnumerable<TechnologyInfo> SoftwareTechnologies { get; set; }
		public string AzureHostName { get; set; }
		public IEnumerable<EntityShortRepresentation> ManagementZones { get; set; }
		public object FromRelationships { get; set; }
	}
}
