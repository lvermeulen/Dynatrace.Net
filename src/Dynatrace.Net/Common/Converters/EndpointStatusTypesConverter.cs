using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class EndpointStatusTypesConverter : JsonEnumConverter<EndpointStatusTypes>
	{
		private static readonly Dictionary<EndpointStatusTypes, string> s_pairs = new Dictionary<EndpointStatusTypes, string>
		{
			[EndpointStatusTypes.Assigned] = "ASSIGNED",
			[EndpointStatusTypes.Disabled] = "DISABLED",
			[EndpointStatusTypes.FastcheckAuthError] = "FASTCHECK_AUTH_ERROR",
			[EndpointStatusTypes.FastcheckAuthLocked] = "FASTCHECK_AUTH_LOCKED",
			[EndpointStatusTypes.FastcheckInvalidEndpoint] = "FASTCHECK_INVALID_ENDPOINT",
			[EndpointStatusTypes.FastcheckLowMemoryError] = "FASTCHECK_LOW_MEMORY_ERROR",
			[EndpointStatusTypes.FastcheckNoResponse] = "FASTCHECK_NO_RESPONSE",
			[EndpointStatusTypes.FastcheckTlsError] = "FASTCHECK_TLS_ERROR",
			[EndpointStatusTypes.Unassigned] = "UNASSIGNED",
			[EndpointStatusTypes.Unknown] = "UNKNOWN"
		};

		protected override Dictionary<EndpointStatusTypes, string> Pairs => s_pairs;

		protected override string EntityString => "Kubernetes endpoint status";
	}
}
