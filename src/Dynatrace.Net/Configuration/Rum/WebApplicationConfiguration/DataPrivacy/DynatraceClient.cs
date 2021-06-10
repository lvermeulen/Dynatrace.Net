using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Configuration.Rum.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetWebApplicationConfigurationDataPrivacyUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/applications/web/dataPrivacy");
		}

		private IFlurlRequest GetWebApplicationConfigurationDataPrivacyUrl(string id)
		{
			return GetBaseUrl()
				.AppendPathSegment($"config/v1/applications/web/{id}/dataPrivacy");
		}

		public async Task<ApplicationDataPrivacyList> GetAllWebApplicationsDataPrivacyAsync(CancellationToken cancellationToken = default)
		{
			var result = await GetWebApplicationConfigurationDataPrivacyUrl()
				.GetJsonWithErrorCheckingAsync<ApplicationDataPrivacyList>(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<ApplicationDataPrivacy> GetWebApplicationDataPrivacyAsync(string id, CancellationToken cancellationToken = default)
		{
			var result = await GetWebApplicationConfigurationDataPrivacyUrl(id)
				.GetJsonWithErrorCheckingAsync<ApplicationDataPrivacy>(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<bool> UpdateWebApplicationDataPrivacyAsync(string id, ApplicationDataPrivacy body = null, CancellationToken cancellationToken = default)
		{
			var response = await GetWebApplicationConfigurationDataPrivacyUrl(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<ApplicationDataPrivacy> GetDefaultApplicationDataPrivacyAsync(CancellationToken cancellationToken = default)
		{
			var result = await GetWebApplicationConfigurationDataPrivacyUrl("default")
				.GetJsonWithErrorCheckingAsync<ApplicationDataPrivacy>(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<bool> UpdateDefaultApplicationDataPrivacyAsync(ApplicationDataPrivacy body = null, CancellationToken cancellationToken = default)
		{
			var response = await GetWebApplicationConfigurationDataPrivacyUrl("default")
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
