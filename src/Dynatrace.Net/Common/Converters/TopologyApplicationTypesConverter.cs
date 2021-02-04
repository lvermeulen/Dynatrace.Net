using System.Collections.Generic;
using Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class TopologyApplicationTypesConverter : JsonEnumConverter<TopologyApplicationTypes>
	{
		private static readonly Dictionary<TopologyApplicationTypes, string> s_pairs = new Dictionary<TopologyApplicationTypes, string>
		{
			[TopologyApplicationTypes.AgentlessMonitoring] = "AGENTLESS_MONITORING",
			[TopologyApplicationTypes.Amp] = "AMP",
			[TopologyApplicationTypes.AutoInjected] = "AUTO_INJECTED",
			[TopologyApplicationTypes.Default] = "DEFAULT",
			[TopologyApplicationTypes.SaasVendor] = "SAAS_VENDOR"
		};

		protected override Dictionary<TopologyApplicationTypes, string> Pairs => s_pairs;

		protected override string EntityString => "application type";
	}
}
