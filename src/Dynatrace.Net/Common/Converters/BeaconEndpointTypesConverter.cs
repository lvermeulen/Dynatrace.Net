using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class BeaconEndpointTypesConverter : JsonEnumConverter<BeaconEndpointTypes>
	{
		private static readonly Dictionary<BeaconEndpointTypes, string> s_pairs = new Dictionary<BeaconEndpointTypes, string>
		{
			[BeaconEndpointTypes.ClusterActiveGate] = "CLUSTER_ACTIVE_GATE",
			[BeaconEndpointTypes.EnvironmentActiveGate] = "ENVIRONMENT_ACTIVE_GATE",
			[BeaconEndpointTypes.InstrumentedWebServer] = "INSTRUMENTED_WEB_SERVER"
		};

		protected override Dictionary<BeaconEndpointTypes, string> Pairs => s_pairs;

		protected override string EntityString => "beacon endpoint type";
	}
}
