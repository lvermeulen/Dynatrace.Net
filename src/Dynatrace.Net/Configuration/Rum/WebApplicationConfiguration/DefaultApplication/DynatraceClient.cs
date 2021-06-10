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
		private IFlurlRequest GetWebApplicationConfigurationDefaultApplicationUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/applications/web/default");
		}

		public async Task<WebApplicationConfig> GetDefaultApplicationAsync(CancellationToken cancellationToken = default)
		{
			var result = await GetWebApplicationConfigurationDefaultApplicationUrl()
				.GetJsonWithErrorCheckingAsync<WebApplicationConfig>(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<bool> UpdateDefaultApplicationAsync(string id, WebApplicationConfig body = null, CancellationToken cancellationToken = default)
		{
			var response = await GetWebApplicationConfigurationDefaultApplicationUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
