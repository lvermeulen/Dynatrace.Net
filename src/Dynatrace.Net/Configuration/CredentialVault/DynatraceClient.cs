using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Configuration.CredentialVault.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetCredentialVaultUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/credentials");
		}

		public async Task<CredentialsList> GetAllCredentialsAsync(CredentialTypes? type = null, CancellationToken cancellationToken = default)
		{
			var response = await GetCredentialVaultUrl()
				.GetJsonWithErrorCheckingAsync<CredentialsList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<CredentialsResponseElement> GetCredentialsAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetCredentialVaultUrl()
				.AppendPathSegment(id)
				.GetJsonWithErrorCheckingAsync<CredentialsResponseElement>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<CredentialsResponseElement> AddCredentialsAsync(Credentials body, CancellationToken cancellationToken = default)
		{
			var response = await GetCredentialVaultUrl()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<CredentialsResponseElement>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<CredentialsResponseElement> UpdateCredentialsAsync(string id, Credentials body, CancellationToken cancellationToken = default)
		{
			var response = await GetCredentialVaultUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<CredentialsResponseElement>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> DeleteCredentialsAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetCredentialVaultUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
