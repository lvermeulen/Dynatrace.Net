using System.Collections.Generic;
using Dynatrace.Net.Configuration.AnomalyDetection.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class AvailabilityMonitoringPgMethodsConverter : JsonEnumConverter<AvailabilityMonitoringPgMethods>
	{
		private static readonly Dictionary<AvailabilityMonitoringPgMethods, string> s_pairs = new Dictionary<AvailabilityMonitoringPgMethods, string>
		{
			[AvailabilityMonitoringPgMethods.MinimumThreshold] = "MINIMUM_THRESHOLD",
			[AvailabilityMonitoringPgMethods.Off] = "OFF",
			[AvailabilityMonitoringPgMethods.ProcessImpact] = "PROCESS_IMPACT"
		};

		protected override Dictionary<AvailabilityMonitoringPgMethods, string> Pairs => s_pairs;

		protected override string EntityString => "availability monitoring process group method";
	}
}
