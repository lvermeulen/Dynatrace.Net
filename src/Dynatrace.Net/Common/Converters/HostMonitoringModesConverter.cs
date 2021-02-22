using System.Collections.Generic;
using Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class HostMonitoringModesConverter : JsonEnumConverter<HostMonitoringModes>
	{
		private static readonly Dictionary<HostMonitoringModes, string> s_pairs = new Dictionary<HostMonitoringModes, string>
		{
			[HostMonitoringModes.FullStack] = "FULL_STACK",
			[HostMonitoringModes.Infrastructure] = "INFRASTRUCTURE",
			[HostMonitoringModes.Off] = "OFF"
		};

		protected override Dictionary<HostMonitoringModes, string> Pairs => s_pairs;

		protected override string EntityString => "host monitoring mode";
	}
}
