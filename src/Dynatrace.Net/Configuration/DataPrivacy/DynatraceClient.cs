using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Configuration.DataPrivacy.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetDataPrivacyUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/dataPrivacy");
		}

		public async Task<DataPrivacyAndSecurity> GetDataPrivacyConfigurationAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetDataPrivacyUrl()
				.GetJsonAsync<DataPrivacyAndSecurity>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateDataPrivacyConfigurationAsync(DataPrivacyAndSecurity body, CancellationToken cancellationToken = default)
		{
			var response = await GetDataPrivacyUrl()
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
