using System.Collections.Generic;
using Dynatrace.Net.Configuration.KubernetesCredentials.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class KubernetesEndpointStatusTypesConverter : JsonEnumConverter<KubernetesEndpointStatusTypes>
	{
		private static readonly Dictionary<KubernetesEndpointStatusTypes, string> s_pairs = new Dictionary<KubernetesEndpointStatusTypes, string>
		{
			[KubernetesEndpointStatusTypes.Assigned] = "ASSIGNED",
			[KubernetesEndpointStatusTypes.Disabled] = "DISABLED",
			[KubernetesEndpointStatusTypes.FastcheckAuthError] = "FASTCHECK_AUTH_ERROR",
			[KubernetesEndpointStatusTypes.FastcheckAuthLocked] = "FASTCHECK_AUTH_LOCKED",
			[KubernetesEndpointStatusTypes.FastcheckInvalidEndpoint] = "FASTCHECK_INVALID_ENDPOINT",
			[KubernetesEndpointStatusTypes.FastcheckLowMemoryError] = "FASTCHECK_LOW_MEMORY_ERROR",
			[KubernetesEndpointStatusTypes.FastcheckNoResponse] = "FASTCHECK_NO_RESPONSE",
			[KubernetesEndpointStatusTypes.FastcheckTlsError] = "FASTCHECK_TLS_ERROR",
			[KubernetesEndpointStatusTypes.Unassigned] = "UNASSIGNED",
			[KubernetesEndpointStatusTypes.Unknown] = "UNKNOWN"
		};

		protected override Dictionary<KubernetesEndpointStatusTypes, string> Pairs => s_pairs;

		protected override string EntityString => "Kubernetes endpoint status";
	}
}
