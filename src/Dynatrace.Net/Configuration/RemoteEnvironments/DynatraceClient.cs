using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Configuration.RemoteEnvironments.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetRemoteEnvironmentsUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/remoteEnvironments");
		}

		public async Task<RemoteEnvironmentConfigListDto> GetAllRemoteEnvironmentsAsync(CancellationToken cancellationToken = default)
		{
			var result = await GetRemoteEnvironmentsUrl()
				.GetJsonIfNotEmptyAsync(new RemoteEnvironmentConfigListDto(), cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<RemoteEnvironmentConfigDto> GetRemoteEnvironmentAsync(string id, CancellationToken cancellationToken = default)
		{
			var result = await GetRemoteEnvironmentsUrl()
				.AppendPathSegment(id)
				.GetJsonWithErrorCheckingAsync<RemoteEnvironmentConfigDto>(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<RemoteEnvironmentConfigStub> CreateRemoteEnvironmentAsync(RemoteEnvironmentConfigDto body, CancellationToken cancellationToken = default)
		{
			var result = await GetRemoteEnvironmentsUrl()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<RemoteEnvironmentConfigStub>()
				.ConfigureAwait(false);

			return result;
		}

		public async Task<RemoteEnvironmentConfigStub> UpdateRemoteEnvironmentAsync(string id, RemoteEnvironmentConfigDto body, CancellationToken cancellationToken = default)
		{
			var result = await GetRemoteEnvironmentsUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<RemoteEnvironmentConfigStub>()
				.ConfigureAwait(false);

			return result;
		}

		public async Task<bool> DeleteRemoteEnvironmentAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetRemoteEnvironmentsUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
