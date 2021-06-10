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
		private IFlurlRequest GetRumIpAddressMappingUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/geographicRegions/ipAddressMappings");
		}

		public async Task<IpAddressMappings> GetRumIpAddressMappingConfigurationAsync(CancellationToken cancellationToken = default)
		{
			var result = await GetRumIpAddressMappingUrl()
				.GetJsonWithErrorCheckingAsync<IpAddressMappings>(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<bool> PutRumIpAddressMappingConfigurationAsync(IpAddressMappings body, CancellationToken cancellationToken = default)
		{
			var response = await GetRumIpAddressMappingUrl()
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
