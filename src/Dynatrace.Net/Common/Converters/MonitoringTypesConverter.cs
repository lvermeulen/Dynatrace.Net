using System.Collections.Generic;
using Dynatrace.Net.Environment.OneAgentOnAHost.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MonitoringTypesConverter : JsonEnumConverter<MonitoringTypes>
	{
		private static readonly Dictionary<MonitoringTypes, string> s_pairs = new Dictionary<MonitoringTypes, string>
		{
			[MonitoringTypes.CloudInfrastructure] = "CLOUD_INFRASTRUCTURE",
			[MonitoringTypes.FullStack] = "FULL_STACK",
			[MonitoringTypes.Standalone] = "STANDALONE"
		};

		protected override Dictionary<MonitoringTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "monitoring type";
	}
}
