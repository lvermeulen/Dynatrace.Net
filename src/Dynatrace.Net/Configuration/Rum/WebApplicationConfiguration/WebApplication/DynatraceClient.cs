using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.Rum.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetWebApplicationConfigurationWebApplicationUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/applications/web");
		}

		public async Task<StubList> GetAllWebApplicationsAsync(CancellationToken cancellationToken = default)
		{
			var result = await GetWebApplicationConfigurationWebApplicationUrl()
				.GetJsonWithErrorCheckingAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<WebApplicationConfig> GetWebApplicationAsync(string id, CancellationToken cancellationToken = default)
		{
			var result = await GetWebApplicationConfigurationWebApplicationUrl()
				.AppendPathSegment(id)
				.GetJsonWithErrorCheckingAsync<WebApplicationConfig>(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<EntityShortRepresentation> CreateWebApplicationAsync(WebApplicationConfig body = null, CancellationToken cancellationToken = default)
		{
			var result = await GetWebApplicationConfigurationWebApplicationUrl()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return result;
		}

		public async Task<EntityShortRepresentation> UpdateWebApplicationAsync(string id, WebApplicationConfig body = null, CancellationToken cancellationToken = default)
		{
			var result = await GetWebApplicationConfigurationWebApplicationUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return result;
		}

		public async Task<bool> DeleteWebApplicationAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetWebApplicationConfigurationWebApplicationUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
