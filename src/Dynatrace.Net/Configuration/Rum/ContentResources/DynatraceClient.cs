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
		private IFlurlRequest GetRumContentResourcesUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/contentResources");
		}

		public async Task<ContentResources> GetRumContentProvidersConfigurationAsync(CancellationToken cancellationToken = default)
		{
			var result = await GetRumContentResourcesUrl()
				.GetJsonWithErrorCheckingAsync<ContentResources>(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<bool> PutRumContentProvidersConfigurationAsync(ContentResources body, CancellationToken cancellationToken = default)
		{
			var response = await GetRumContentResourcesUrl()
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
