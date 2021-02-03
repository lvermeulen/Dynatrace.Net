using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.CloudFoundryCredentials.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetCloudFoundryCredentialsUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/cloudFoundry/credentials");
		}

		public async Task<StubList> GetAllCloudFoundryCredentialsAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetCloudFoundryCredentialsUrl()
				.GetJsonAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<CloudFoundryCredentials> GetCloudFoundryCredentialsAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetCloudFoundryCredentialsUrl()
				.AppendPathSegment(id)
				.GetJsonAsync<CloudFoundryCredentials>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> AddCloudFoundryCredentialsAsync(CloudFoundryCredentials body, CancellationToken cancellationToken = default)
		{
			var response = await GetCloudFoundryCredentialsUrl()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> UpdateCloudFoundryCredentialsAsync(string id, CloudFoundryCredentials body, CancellationToken cancellationToken = default)
		{
			var response = await GetCloudFoundryCredentialsUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> DeleteCloudFoundryCredentialsAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetCloudFoundryCredentialsUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
