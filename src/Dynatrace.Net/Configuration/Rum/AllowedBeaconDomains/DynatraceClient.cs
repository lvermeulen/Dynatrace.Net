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
		private IFlurlRequest GetRumAllowedBeaconDomainsUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/allowedBeaconOriginsForCors");
		}

		public async Task<AllowedBeaconOrigins> GetRumAllowedBeaconDomainsConfigurationAsync(CancellationToken cancellationToken = default)
		{
			var result = await GetRumAllowedBeaconDomainsUrl()
				.GetJsonWithErrorCheckingAsync<AllowedBeaconOrigins>(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<bool> PutRumAllowedBeaconDomainsConfigurationAsync(AllowedBeaconOrigins body, CancellationToken cancellationToken = default)
		{
			var response = await GetRumAllowedBeaconDomainsUrl()
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
