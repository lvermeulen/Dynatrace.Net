using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Configuration.AwsPrivateLink.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetAwsPrivateLinkUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/aws/privateLink");
		}

		private IFlurlRequest GetAwsPrivateLinkWhiteListedAccountsUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/aws/privateLink/whitelistedAccounts");
		}

		public async Task<AwsPrivateLinkConfig> GetAwsPrivateLinkConfigAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetAwsPrivateLinkUrl()
				.GetJsonAsync<AwsPrivateLinkConfig>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<AwsPrivateLinkConfig> UpdateAwsPrivateLinkConfigAsync(AwsPrivateLinkConfig body, CancellationToken cancellationToken = default)
		{
			var response = await GetAwsPrivateLinkUrl()
				.PutJsonAsync(body, cancellationToken)
				.ReceiveJson<AwsPrivateLinkConfig>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<WhitelistedAwsAccountList> GetAwsPrivateLinkWhiteListedAccountsAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetAwsPrivateLinkWhiteListedAccountsUrl()
				.GetJsonAsync<WhitelistedAwsAccountList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<WhitelistedAwsAccountList> AddAwsPrivateLinkWhiteListedAccountAsync(string id, WhitelistedAwsAccount body, CancellationToken cancellationToken = default)
		{
			var response = await GetAwsPrivateLinkWhiteListedAccountsUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ReceiveJson<WhitelistedAwsAccountList>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> DeleteAwsPrivateLinkWhiteListedAccountAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetAwsPrivateLinkWhiteListedAccountsUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
