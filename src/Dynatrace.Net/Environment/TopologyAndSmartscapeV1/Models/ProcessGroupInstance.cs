using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models
{
	public class ProcessGroupInstance : ProcessGroup
	{
		public ProcessMonitoringState MonitoringState { get; set; }
		[JsonConverter(typeof(HostBitnessTypesConverter))]
		public HostBitnessTypes? Bitness { get; set; }
		public IEnumerable<AgentVersion> AgentVersions { get; set; }
		public IEnumerable<string> Modules { get; set; }
		public IEnumerable<ProcessGroupInstanceModule> VersionedModules { get; set; }
	}
}
