using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Environment.Deployment.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetDeploymentBoshReleaseUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("v1/deployment/boshrelease");
		}

		public async Task<bool> DownloadBoshTarballsSpecificVersionAsync(WindowsUnixDeploymentOsTypes osType, string version, bool? skipMetadata = false, CancellationToken cancellationToken = default)
		{
			var response = await GetDeploymentBoshReleaseUrl()
				.AppendPathSegment("agent")
				.AppendPathSegment(s_deploymentOsTypesConverter.ConvertToString(osType))
				.AppendPathSegment("version")
				.AppendPathSegment(version)
				.SetQueryParam(nameof(skipMetadata), skipMetadata)
				.GetAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<Versions> ListBoshReleaseAvailableVersionsAsync(WindowsUnixDeploymentOsTypes osType, CancellationToken cancellationToken = default)
		{
			var response = await GetDeploymentBoshReleaseUrl()
				.AppendPathSegment("versions")
				.AppendPathSegment(s_deploymentOsTypesConverter.ConvertToString(osType))
				.GetJsonAsync<Versions>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<BoshReleaseChecksum> GetBoshTarballChecksumAsync(WindowsUnixDeploymentOsTypes osType, string version, bool? skipMetadata = false, CancellationToken cancellationToken = default)
		{
			var response = await GetDeploymentBoshReleaseUrl()
				.AppendPathSegment("agent")
				.AppendPathSegment(s_deploymentOsTypesConverter.ConvertToString(osType))
				.AppendPathSegment("version")
				.AppendPathSegment(version)
				.AppendPathSegment("checksum")
				.SetQueryParam(nameof(skipMetadata), skipMetadata)
				.GetJsonAsync<BoshReleaseChecksum>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}
	}
}
