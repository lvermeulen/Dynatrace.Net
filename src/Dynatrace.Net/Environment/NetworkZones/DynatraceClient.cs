using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Environment.NetworkZones.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetNetworkZonesUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("v2/networkZones");
		}

		private IFlurlRequest GetNetworkZoneSettingsUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("v2/networkZoneSettings");
		}

		public async Task<NetworkZoneList> GetNetworkZonesAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetNetworkZonesUrl()
				.GetJsonAsync<NetworkZoneList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<NetworkZone> GetNetworkZoneAsync(string networkZoneId, CancellationToken cancellationToken = default)
		{
			var response = await GetNetworkZonesUrl()
				.AppendPathSegment(networkZoneId)
				.GetJsonAsync<NetworkZone>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> EditNetworkZoneAsync(string networkZoneId, NetworkZone body, CancellationToken cancellationToken = default)
		{
			var response = await GetNetworkZonesUrl()
				.AppendPathSegment(networkZoneId)
				.PutJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> DeleteNetworkZoneAsync(string networkZoneId, CancellationToken cancellationToken = default)
		{
			var response = await GetNetworkZonesUrl()
				.AppendPathSegment(networkZoneId)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<NetworkZoneSettings> GetNetworkZoneSettingsAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetNetworkZoneSettingsUrl()
				.GetJsonAsync<NetworkZoneSettings>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateNetworkZoneSettingsAsync(NetworkZoneSettings body, CancellationToken cancellationToken = default)
		{
			var response = await GetNetworkZoneSettingsUrl()
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
