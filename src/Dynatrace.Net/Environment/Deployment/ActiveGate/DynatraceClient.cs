using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Environment.Deployment.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private static readonly DeploymentOsTypesConverter s_deploymentOsTypesConverter = new DeploymentOsTypesConverter();

		private IFlurlRequest GetDeploymentActiveGateUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("v1/deployment/installer/gateway");
		}

		public async Task<bool> DownloadActiveGateLatestAsync(DeploymentOsTypes osType, string ifNoneMatchEtag = null, CancellationToken cancellationToken = default)
		{
			var response = await GetDeploymentActiveGateUrl()
				.WithHeader("If-None-Match", ifNoneMatchEtag)
				.AppendPathSegment(s_deploymentOsTypesConverter.ConvertToString(osType))
				.AppendPathSegment("latest")
				.GetAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DownloadActiveGateSpecificVersionAsync(DeploymentOsTypes osType, string version, string ifNoneMatchEtag = null, CancellationToken cancellationToken = default)
		{
			var response = await GetDeploymentActiveGateUrl()
				.WithHeader("If-None-Match", ifNoneMatchEtag)
				.AppendPathSegment(s_deploymentOsTypesConverter.ConvertToString(osType))
				.AppendPathSegment("version")
				.AppendPathSegment(version)
				.GetAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<ActiveGateInstallerVersions> ListActiveGateAvailableVersionsAsync(DeploymentOsTypes osType, CancellationToken cancellationToken = default)
		{
			var response = await GetDeploymentActiveGateUrl()
				.AppendPathSegment("versions")
				.AppendPathSegment(s_deploymentOsTypesConverter.ConvertToString(osType))
				.GetJsonAsync<ActiveGateInstallerVersions>(cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			return response;
		}
	}
}
