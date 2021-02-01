namespace Dynatrace.Net.Configuration.KubernetesCredentials.Models
{
	public enum KubernetesEndpointStatusTypes
	{
		Assigned,
		Disabled,
		FastcheckAuthError,
		FastcheckAuthLocked,
		FastcheckInvalidEndpoint,
		FastcheckLowMemoryError,
		FastcheckNoResponse,
		FastcheckTlsError,
		Unassigned,
		Unknown
	}
}
