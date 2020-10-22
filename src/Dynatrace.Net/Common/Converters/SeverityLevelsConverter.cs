using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class SeverityLevelsConverter : JsonEnumConverter<SeverityLevels>
	{
		private static readonly Dictionary<SeverityLevels, string> s_pairs = new Dictionary<SeverityLevels, string>
		{
			[SeverityLevels.Availability] = "AVAILABILITY",
			[SeverityLevels.CustomAlert] = "CUSTOM_ALERT",
			[SeverityLevels.Error] = "ERROR",
			[SeverityLevels.MonitoringUnavailable] = "MONITORING_UNAVAILABLE",
			[SeverityLevels.Performance] = "PERFORMANCE",
			[SeverityLevels.ResourceContention] = "RESOURCE_CONTENTION"
		};

		protected override Dictionary<SeverityLevels, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "severityLevel";
	}
}
