using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.KubernetesCredentials.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetKubernetesCredentialsUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/kubernetes/credentials");
		}

		public async Task<StubList> GetAllKubernetesCredentialsAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetKubernetesCredentialsUrl()
				.GetJsonAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<KubernetesCredentials> GetKubernetesCredentialsAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetKubernetesCredentialsUrl()
				.AppendPathSegment(id)
				.GetJsonAsync<KubernetesCredentials>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> AddKubernetesCredentialsAsync(KubernetesCredentials body, CancellationToken cancellationToken = default)
		{
			var response = await GetKubernetesCredentialsUrl()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> UpdateKubernetesCredentialsAsync(string id, KubernetesCredentials body, CancellationToken cancellationToken = default)
		{
			var response = await GetKubernetesCredentialsUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> DeleteKubernetesCredentialsAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetKubernetesCredentialsUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
