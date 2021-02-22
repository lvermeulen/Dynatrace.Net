using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models
{
	public class ProcessGroupInstance
	{
		public string EntityId { get; set; }
		public string DisplayName { get; set; }
		public string CustomizedName { get; set; }
		public string DiscoveredName { get; set; }
		public int? FirstSeenTimestamp { get; set; }
		public int? LastSeenTimestamp { get; set; }
		public IEnumerable<TagInfo> Tags { get; set; }
		public object ToRelationships { get; set; }
		public object Metadata { get; set; }
		public string AzureSiteName { get; set; }
		public ProcessMonitoringState MonitoringState { get; set; }
		public IEnumerable<int> ListenPorts { get; set; }
		[JsonConverter(typeof(HostBitnessTypesConverter))]
		public HostBitnessTypes? Bitness { get; set; }
		public IEnumerable<TechnologyInfo> SoftwareTechnologies { get; set; }
		public string AzureHostName { get; set; }
		public IEnumerable<EntityShortRepresentation> ManagementZones { get; set; }
		public IEnumerable<AgentVersion> AgentVersions { get; set; }
		public IEnumerable<string> Modules { get; set; }
		public IEnumerable<ProcessGroupInstanceModule> VersionedModules { get; set; }
		public object FromRelationships { get; set; }
	}
}
