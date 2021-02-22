using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models
{
	public class ProcessMonitoringState
	{
		[JsonConverter(typeof(ProcessMonitoringStatesConverter))]
		public ProcessMonitoringStates? ActualMonitoringState { get; set; }
		[JsonConverter(typeof(ProcessMonitoringStatesConverter))]
		public ProcessMonitoringStates? ExpectedMonitoringState { get; set; }
		public bool? RestartRequired { get; set; }
	}
}
