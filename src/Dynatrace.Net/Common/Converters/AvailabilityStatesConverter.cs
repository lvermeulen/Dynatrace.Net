using System.Collections.Generic;
using Dynatrace.Net.Environment.OneAgentOnAHost.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class AvailabilityStatesConverter : JsonEnumConverter<AvailabilityStates>
	{
		private static readonly Dictionary<AvailabilityStates, string> s_pairs = new Dictionary<AvailabilityStates, string>
		{
			[AvailabilityStates.Crashed] = "CRASHED",
			[AvailabilityStates.Lost] = "LOST",
			[AvailabilityStates.Monitored] = "MONITORED",
			[AvailabilityStates.PreMonitored] = "PRE_MONITORED",
			[AvailabilityStates.Shutdown] = "SHUTDOWN",
			[AvailabilityStates.UnexpectedShutdown] = "UNEXPECTED_SHUTDOWN",
			[AvailabilityStates.Unknown] = "UNKNOWN",
			[AvailabilityStates.Unmonitored] = "UNMONITORED"
		};

		protected override Dictionary<AvailabilityStates, string> Pairs => s_pairs;

		protected override string EntityString => "availability state";
	}
}
