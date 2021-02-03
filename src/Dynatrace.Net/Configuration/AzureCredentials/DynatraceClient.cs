using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.AzureCredentials.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetAzureCredentialsUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/azure/credentials");
		}

		public async Task<StubList> GetAllAzureCredentialsAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetAzureCredentialsUrl()
				.GetJsonAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<AzureCredentials> GetAzureCredentialsAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetAzureCredentialsUrl()
				.AppendPathSegment(id)
				.GetJsonAsync<AzureCredentials>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> AddAzureCredentialsAsync(AzureCredentialsCreation body, CancellationToken cancellationToken = default)
		{
			var response = await GetAzureCredentialsUrl()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> UpdateAzureCredentialsAsync(string id, AzureCredentials body, CancellationToken cancellationToken = default)
		{
			var response = await GetAzureCredentialsUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> DeleteAzureCredentialsAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetAzureCredentialsUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
