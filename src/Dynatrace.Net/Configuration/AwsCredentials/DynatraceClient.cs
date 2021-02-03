using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.AwsCredentials.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetAwsCredentialsUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/aws/credentials");
		}

		public async Task<StubList> GetAllAwsCredentialsAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetAwsCredentialsUrl()
				.GetJsonAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<AwsCredentialsConfig> GetAwsCredentialsAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetAwsCredentialsUrl()
				.AppendPathSegment(id)
				.GetJsonAsync<AwsCredentialsConfig>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> AddAwsCredentialsAsync(AwsCredentialsConfig body, CancellationToken cancellationToken = default)
		{
			var response = await GetAwsCredentialsUrl()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> UpdateAwsCredentialsAsync(string id, AwsCredentialsConfig body, CancellationToken cancellationToken = default)
		{
			var response = await GetAwsCredentialsUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> DeleteAwsCredentialsAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetAwsCredentialsUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
