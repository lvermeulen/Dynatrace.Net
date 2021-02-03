using System.Collections.Generic;
using Dynatrace.Net.Environment.OneAgentOnAHost.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MonitoringModesConverter : JsonEnumConverter<MonitoringModes>
	{
		private static readonly Dictionary<MonitoringModes, string> s_pairs = new Dictionary<MonitoringModes, string>
		{
			[MonitoringModes.CloudInfrastructure] = "CLOUD_INFRASTRUCTURE",
			[MonitoringModes.FullStack] = "FULL_STACK"
		};

		protected override Dictionary<MonitoringModes, string> Pairs => s_pairs;
		protected override string EntityString => "monitoring mode";
	}
}
