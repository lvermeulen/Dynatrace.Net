using System.Collections.Generic;
using Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ProcessMonitoringStatesConverter : JsonEnumConverter<ProcessMonitoringStates>
	{
		private static readonly Dictionary<ProcessMonitoringStates, string> s_pairs = new Dictionary<ProcessMonitoringStates, string>
		{
			[ProcessMonitoringStates.Off] = "OFF",
			[ProcessMonitoringStates.On] = "ON"
		};

		protected override Dictionary<ProcessMonitoringStates, string> Pairs => s_pairs;

		protected override string EntityString => "process monitoring state";
	}
}
