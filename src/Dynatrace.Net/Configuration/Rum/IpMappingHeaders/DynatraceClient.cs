using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Configuration.Rum.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetRumIpMappingHeadersUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/geographicRegions/ipDetectionHeaders");
		}

		public async Task<IpDetectionHeaders> GetRumIpMappingHeadersConfigurationAsync(CancellationToken cancellationToken = default)
		{
			var result = await GetRumIpMappingHeadersUrl()
				.GetJsonAsync<IpDetectionHeaders>(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<bool> PutRumIpMappingHeadersConfigurationAsync(IpDetectionHeaders body, CancellationToken cancellationToken = default)
		{
			var response = await GetRumIpMappingHeadersUrl()
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
